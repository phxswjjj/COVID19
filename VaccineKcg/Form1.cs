using Quartz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccineKcg.Data;

namespace VaccineKcg
{
    public partial class Form1 : Form
    {
        private readonly IScheduler Scheduler;
        private readonly CancellationTokenSource MonitorCancelSource;
        const int MaxResultCount = 100;

        public Form1()
        {
            InitializeComponent();

            #region Init Scheduler
            var factory = new Quartz.Impl.StdSchedulerFactory();
            var sch = factory.GetScheduler().GetAwaiter().GetResult();
            this.Scheduler = sch;
            #endregion

            var monitorCancelSource = new CancellationTokenSource();
            CancellationToken ct = monitorCancelSource.Token;
            var monitor = Task.Run(() =>
            {
                while (!ct.IsCancellationRequested)
                {
                    if (sch.IsStarted && !sch.InStandbyMode)
                    {
                        foreach (var job in sch.GetCurrentlyExecutingJobs().Result)
                        {
                            while (job.Result == null)
                                Thread.Sleep(100);
                            var centers = job.Result as List<CenterInfo>;
                            centers.Sort(CenterInfo.Comparer);
                            treeView1.Invoke((MethodInvoker)(() =>
                            {
                                treeView1.Nodes.Clear();
                                var likeName = txtName.Text.Trim().ToUpper();
                                foreach (var center in centers)
                                {
                                    if (!string.IsNullOrEmpty(likeName) && !center.name.Contains(likeName))
                                        continue;
                                    var isAllFull = center.servicePeriods.Exists(s => !s.isFull);
                                    if (!isAllFull)
                                        treeView1.Nodes.Add($"{center.town}-{center.name}");
                                }
                            }));
                        }
                    }
                }
            }, monitorCancelSource.Token);
            this.MonitorCancelSource = monitorCancelSource;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var sch = this.Scheduler;

            btnExecute.Enabled = false;
            gbxSetting.Enabled = false;

            if (!sch.IsStarted || sch.InStandbyMode)
            {
                var intervalMinutes = (int)numInterval.Value;
                var job = JobBuilder.Create<TraceJob>()
                    .Build();
                var trigger = TriggerBuilder.Create()
                    .StartNow()
                    .WithSimpleSchedule(s => s.WithIntervalInMinutes(intervalMinutes).RepeatForever())
                    .Build();

                sch.ScheduleJob(job, trigger);
                sch.Start();

                btnExecute.Text = "Stop";
                btnExecute.Enabled = true;
            }
            else
            {
                btnExecute.Text = "Stopping";

                sch.Standby().Wait();

                var task = Task.Run(() =>
                {
                    while (sch.GetCurrentlyExecutingJobs().GetAwaiter().GetResult().Count > 0)
                        Thread.Sleep(100);

                    sch.Clear();

                    btnExecute.Invoke((MethodInvoker)(() =>
                    {
                        btnExecute.Text = "Start";
                        btnExecute.Enabled = true;
                        gbxSetting.Enabled = true;
                    }));
                });
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MonitorCancelSource.Cancel();
        }
    }
}
