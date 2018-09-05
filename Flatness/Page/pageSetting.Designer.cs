namespace Page
{
    partial class pageSetting
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propertyGrid_Calibration = new System.Windows.Forms.PropertyGrid();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.propertyGrid_MotionParams = new System.Windows.Forms.PropertyGrid();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.propertyGrid_Option = new System.Windows.Forms.PropertyGrid();
            this.bntSaveParams = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.propertyGrid_Calibration);
            this.groupBox1.Location = new System.Drawing.Point(454, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 810);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "标定参数";
            // 
            // propertyGrid_Calibration
            // 
            this.propertyGrid_Calibration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid_Calibration.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid_Calibration.Location = new System.Drawing.Point(3, 21);
            this.propertyGrid_Calibration.Name = "propertyGrid_Calibration";
            this.propertyGrid_Calibration.Size = new System.Drawing.Size(407, 786);
            this.propertyGrid_Calibration.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.propertyGrid_MotionParams);
            this.groupBox3.Location = new System.Drawing.Point(-1, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 810);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "运动参数";
            // 
            // propertyGrid_MotionParams
            // 
            this.propertyGrid_MotionParams.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid_MotionParams.Location = new System.Drawing.Point(3, 21);
            this.propertyGrid_MotionParams.Name = "propertyGrid_MotionParams";
            this.propertyGrid_MotionParams.Size = new System.Drawing.Size(407, 779);
            this.propertyGrid_MotionParams.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.propertyGrid_Option);
            this.groupBox4.Location = new System.Drawing.Point(914, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 363);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "选项";
            // 
            // propertyGrid_Option
            // 
            this.propertyGrid_Option.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid_Option.Location = new System.Drawing.Point(3, 21);
            this.propertyGrid_Option.Name = "propertyGrid_Option";
            this.propertyGrid_Option.Size = new System.Drawing.Size(410, 334);
            this.propertyGrid_Option.TabIndex = 2;
            // 
            // bntSaveParams
            // 
            this.bntSaveParams.Font = new System.Drawing.Font("宋体", 19.07563F);
            this.bntSaveParams.Location = new System.Drawing.Point(1039, 696);
            this.bntSaveParams.Name = "bntSaveParams";
            this.bntSaveParams.Size = new System.Drawing.Size(195, 78);
            this.bntSaveParams.TabIndex = 3;
            this.bntSaveParams.Text = "保存更改";
            this.bntSaveParams.UseVisualStyleBackColor = true;
            this.bntSaveParams.Click += new System.EventHandler(this.bntSaveParams_Click);
            // 
            // pageSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.bntSaveParams);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "pageSetting";
            this.Size = new System.Drawing.Size(1363, 808);
            this.Load += new System.EventHandler(this.pageSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PropertyGrid propertyGrid_Calibration;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PropertyGrid propertyGrid_MotionParams;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PropertyGrid propertyGrid_Option;
        private System.Windows.Forms.Button bntSaveParams;
    }
}
