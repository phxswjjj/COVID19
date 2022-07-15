using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VaccineKcg.Data;

namespace VaccineKcg
{
    class TraceJob : IJob
    {
        const string TargetUrl = "https://vaccine.kcg.gov.tw/api/Common/HealthCenters?town=";
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Run(() =>
            {
                var client = CreateClient();
                var resp = client.GetAsync(TargetUrl).Result;
                context.Result = resp.Content.ReadAsAsync<List<CenterInfo>>().Result; ;
            });
        }

        private HttpClient CreateClient()
        {
            var client = new HttpClient();
            client.Timeout = new TimeSpan(0, 1, 0);

            //解決亂碼問題
            client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
