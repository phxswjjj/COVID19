
namespace VaccineKcg
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxSetting = new System.Windows.Forms.GroupBox();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbxSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSetting
            // 
            this.gbxSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSetting.Controls.Add(this.txtName);
            this.gbxSetting.Controls.Add(this.label2);
            this.gbxSetting.Controls.Add(this.numInterval);
            this.gbxSetting.Controls.Add(this.label1);
            this.gbxSetting.Location = new System.Drawing.Point(12, 12);
            this.gbxSetting.Name = "gbxSetting";
            this.gbxSetting.Size = new System.Drawing.Size(1309, 110);
            this.gbxSetting.TabIndex = 0;
            this.gbxSetting.TabStop = false;
            this.gbxSetting.Text = "設定";
            // 
            // numInterval
            // 
            this.numInterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numInterval.Location = new System.Drawing.Point(155, 29);
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(90, 30);
            this.numInterval.TabIndex = 1;
            this.numInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "更新頻率(min)：";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(12, 128);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(119, 45);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Start";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(137, 128);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1184, 379);
            this.treeView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "名稱(like)：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 30);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "莫德納";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 519);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.gbxSetting);
            this.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbxSetting.ResumeLayout(false);
            this.gbxSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSetting;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
    }
}

