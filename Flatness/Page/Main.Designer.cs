namespace Page
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProduct = new System.Windows.Forms.Label();
            this.panelPage = new System.Windows.Forms.Panel();
            this.lblSetting = new System.Windows.Forms.Label();
            this.lblCamera = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.lblChart = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblStop = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.SystemColors.Control;
            this.lblProduct.Image = global::Flatness.Properties.Resources.home;
            this.lblProduct.Location = new System.Drawing.Point(3, 5);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(89, 84);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Tag = "pageProduct";
            this.lblProduct.Click += new System.EventHandler(this.pageChange_OnClick);
            // 
            // panelPage
            // 
            this.panelPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPage.Location = new System.Drawing.Point(0, 100);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(1365, 810);
            this.panelPage.TabIndex = 1;
            // 
            // lblSetting
            // 
            this.lblSetting.BackColor = System.Drawing.SystemColors.Control;
            this.lblSetting.Image = global::Flatness.Properties.Resources.setting;
            this.lblSetting.Location = new System.Drawing.Point(98, 5);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(89, 84);
            this.lblSetting.TabIndex = 0;
            this.lblSetting.Tag = "pageSetting";
            this.lblSetting.Click += new System.EventHandler(this.pageChange_OnClick);
            // 
            // lblCamera
            // 
            this.lblCamera.BackColor = System.Drawing.SystemColors.Control;
            this.lblCamera.Image = global::Flatness.Properties.Resources.OpenImage;
            this.lblCamera.Location = new System.Drawing.Point(193, 5);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(89, 84);
            this.lblCamera.TabIndex = 0;
            this.lblCamera.Tag = "pageCamera";
            this.lblCamera.Click += new System.EventHandler(this.pageChange_OnClick);
            // 
            // lblAlarm
            // 
            this.lblAlarm.BackColor = System.Drawing.SystemColors.Control;
            this.lblAlarm.Image = global::Flatness.Properties.Resources.alarm;
            this.lblAlarm.Location = new System.Drawing.Point(288, 5);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(89, 84);
            this.lblAlarm.TabIndex = 0;
            this.lblAlarm.Tag = "pageAlarm";
            this.lblAlarm.Click += new System.EventHandler(this.pageChange_OnClick);
            // 
            // lblChart
            // 
            this.lblChart.BackColor = System.Drawing.SystemColors.Control;
            this.lblChart.Image = global::Flatness.Properties.Resources.chart;
            this.lblChart.Location = new System.Drawing.Point(383, 5);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(89, 84);
            this.lblChart.TabIndex = 0;
            this.lblChart.Tag = "pageChart";
            this.lblChart.Click += new System.EventHandler(this.pageChange_OnClick);
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.SystemColors.Control;
            this.lblLogin.Image = global::Flatness.Properties.Resources.user;
            this.lblLogin.Location = new System.Drawing.Point(1178, 5);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(89, 84);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Tag = "pageLogin";
            this.lblLogin.Click += new System.EventHandler(this.pageChange_OnClick);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.SystemColors.Control;
            this.lblExit.Image = global::Flatness.Properties.Resources.close;
            this.lblExit.Location = new System.Drawing.Point(1273, 5);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(89, 84);
            this.lblExit.TabIndex = 0;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblPause
            // 
            this.lblPause.BackColor = System.Drawing.SystemColors.Control;
            this.lblPause.Image = global::Flatness.Properties.Resources.pause;
            this.lblPause.Location = new System.Drawing.Point(955, 5);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(89, 84);
            this.lblPause.TabIndex = 0;
            // 
            // lblStop
            // 
            this.lblStop.BackColor = System.Drawing.SystemColors.Control;
            this.lblStop.Image = global::Flatness.Properties.Resources.stop;
            this.lblStop.Location = new System.Drawing.Point(1050, 5);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(89, 84);
            this.lblStop.TabIndex = 0;
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.SystemColors.Control;
            this.lblStart.Image = global::Flatness.Properties.Resources.start;
            this.lblStart.Location = new System.Drawing.Point(860, 5);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(89, 84);
            this.lblStart.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Font = new System.Drawing.Font("宋体", 26.01681F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.Location = new System.Drawing.Point(533, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(271, 84);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Tag = "pageInfo";
            this.lblInfo.Text = "Flatness";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Click += new System.EventHandler(this.pageChange_OnClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1365, 900);
            this.ControlBox = false;
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblChart);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.lblProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel panelPage;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblChart;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblInfo;
    }
}