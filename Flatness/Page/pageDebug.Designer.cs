namespace Page
{
    partial class pageDebug
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
            this.components = new System.ComponentModel.Container();
            this.其它 = new System.Windows.Forms.TabPage();
            this.输出信号 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrDo = new System.Windows.Forms.DataGridView();
            this.输入信号 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrDi = new System.Windows.Forms.DataGridView();
            this.支撑模块 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.夹持模块 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.测量模块 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.xAxisControlPanel = new XCore.XAxisControlPanel();
            this.tabControl_Debug = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.输出信号.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDo)).BeginInit();
            this.输入信号.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDi)).BeginInit();
            this.支撑模块.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.夹持模块.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.测量模块.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabControl_Debug.SuspendLayout();
            this.SuspendLayout();
            // 
            // 其它
            // 
            this.其它.BackColor = System.Drawing.Color.Transparent;
            this.其它.Location = new System.Drawing.Point(4, 25);
            this.其它.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.其它.Name = "其它";
            this.其它.Size = new System.Drawing.Size(1093, 513);
            this.其它.TabIndex = 5;
            this.其它.Text = "其它";
            // 
            // 输出信号
            // 
            this.输出信号.Controls.Add(this.groupBox2);
            this.输出信号.Location = new System.Drawing.Point(4, 25);
            this.输出信号.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.输出信号.Name = "输出信号";
            this.输出信号.Size = new System.Drawing.Size(1093, 513);
            this.输出信号.TabIndex = 4;
            this.输出信号.Text = "输出信号";
            this.输出信号.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrDo);
            this.groupBox2.Location = new System.Drawing.Point(-4, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1099, 515);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出信号";
            // 
            // dgrDo
            // 
            this.dgrDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDo.Location = new System.Drawing.Point(7, 21);
            this.dgrDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrDo.Name = "dgrDo";
            this.dgrDo.RowTemplate.Height = 27;
            this.dgrDo.Size = new System.Drawing.Size(1097, 488);
            this.dgrDo.TabIndex = 0;
            this.dgrDo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDo_CellClick);
            // 
            // 输入信号
            // 
            this.输入信号.Controls.Add(this.groupBox1);
            this.输入信号.Location = new System.Drawing.Point(4, 25);
            this.输入信号.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.输入信号.Name = "输入信号";
            this.输入信号.Size = new System.Drawing.Size(1093, 513);
            this.输入信号.TabIndex = 3;
            this.输入信号.Text = "输入信号";
            this.输入信号.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrDi);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9.07563F);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1088, 508);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入信号";
            // 
            // dgrDi
            // 
            this.dgrDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDi.Location = new System.Drawing.Point(4, 24);
            this.dgrDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrDi.Name = "dgrDi";
            this.dgrDi.RowTemplate.Height = 27;
            this.dgrDi.Size = new System.Drawing.Size(1084, 484);
            this.dgrDi.TabIndex = 0;
            // 
            // 支撑模块
            // 
            this.支撑模块.Controls.Add(this.tabControl3);
            this.支撑模块.Location = new System.Drawing.Point(4, 25);
            this.支撑模块.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.支撑模块.Name = "支撑模块";
            this.支撑模块.Size = new System.Drawing.Size(1093, 513);
            this.支撑模块.TabIndex = 2;
            this.支撑模块.Text = "支撑模块";
            this.支撑模块.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.Location = new System.Drawing.Point(3, 2);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1095, 508);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage9.Size = new System.Drawing.Size(1087, 479);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "支撑模块";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // 夹持模块
            // 
            this.夹持模块.Controls.Add(this.tabControl2);
            this.夹持模块.Location = new System.Drawing.Point(4, 25);
            this.夹持模块.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.夹持模块.Name = "夹持模块";
            this.夹持模块.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.夹持模块.Size = new System.Drawing.Size(1093, 513);
            this.夹持模块.TabIndex = 1;
            this.夹持模块.Text = "夹持模块";
            this.夹持模块.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(3, 2);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1095, 511);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage8.Size = new System.Drawing.Size(1087, 482);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "夹持模块";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // 测量模块
            // 
            this.测量模块.Controls.Add(this.tabControl1);
            this.测量模块.Location = new System.Drawing.Point(4, 25);
            this.测量模块.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.测量模块.Name = "测量模块";
            this.测量模块.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.测量模块.Size = new System.Drawing.Size(1093, 513);
            this.测量模块.TabIndex = 0;
            this.测量模块.Text = "测量模块";
            this.测量模块.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1091, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.xAxisControlPanel);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage7.Size = new System.Drawing.Size(1083, 485);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "测量模块";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // xAxisControlPanel
            // 
            this.xAxisControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xAxisControlPanel.Location = new System.Drawing.Point(537, 3);
            this.xAxisControlPanel.Name = "xAxisControlPanel";
            this.xAxisControlPanel.Size = new System.Drawing.Size(543, 287);
            this.xAxisControlPanel.TabIndex = 0;
            // 
            // tabControl_Debug
            // 
            this.tabControl_Debug.Controls.Add(this.测量模块);
            this.tabControl_Debug.Controls.Add(this.夹持模块);
            this.tabControl_Debug.Controls.Add(this.支撑模块);
            this.tabControl_Debug.Controls.Add(this.输入信号);
            this.tabControl_Debug.Controls.Add(this.输出信号);
            this.tabControl_Debug.Controls.Add(this.其它);
            this.tabControl_Debug.Location = new System.Drawing.Point(1, 12);
            this.tabControl_Debug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_Debug.Name = "tabControl_Debug";
            this.tabControl_Debug.SelectedIndex = 0;
            this.tabControl_Debug.Size = new System.Drawing.Size(1101, 542);
            this.tabControl_Debug.TabIndex = 0;
            this.tabControl_Debug.SelectedIndexChanged += new System.EventHandler(this.tabControl_Debug_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pageDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 545);
            this.Controls.Add(this.tabControl_Debug);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "pageDebug";
            this.Text = "pageDebug";
            this.Load += new System.EventHandler(this.pageDebug_Load);
            this.输出信号.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDo)).EndInit();
            this.输入信号.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDi)).EndInit();
            this.支撑模块.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.夹持模块.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.测量模块.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabControl_Debug.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage 其它;
        private System.Windows.Forms.TabPage 输出信号;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrDo;
        private System.Windows.Forms.TabPage 输入信号;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrDi;
        private System.Windows.Forms.TabPage 支撑模块;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage 夹持模块;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage 测量模块;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabControl tabControl_Debug;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private XCore.XAxisControlPanel xAxisControlPanel;
    }
}