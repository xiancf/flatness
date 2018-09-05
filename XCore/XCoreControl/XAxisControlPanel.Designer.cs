namespace XCore
{
    partial class XAxisControlPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAxisId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDiatance = new System.Windows.Forms.ComboBox();
            this.bnt_Back = new System.Windows.Forms.Button();
            this.bnt_Forward = new System.Windows.Forms.Button();
            this.bnt_Stop = new System.Windows.Forms.Button();
            this.tkb_Vel = new System.Windows.Forms.TrackBar();
            this.bnt_JOP_N = new System.Windows.Forms.Button();
            this.bnt_JOP_P = new System.Windows.Forms.Button();
            this.bnt_Home = new System.Windows.Forms.Button();
            this.ptb_SVON = new System.Windows.Forms.PictureBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.ptb_MEL = new System.Windows.Forms.PictureBox();
            this.ptb_ORG = new System.Windows.Forms.PictureBox();
            this.ptb_PEL = new System.Windows.Forms.PictureBox();
            this.ptb_ALM = new System.Windows.Forms.PictureBox();
            this.ptb_ASTP = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_Vel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_SVON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_MEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ORG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_PEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ALM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ASTP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12.07563F);
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "轴号";
            // 
            // cmbAxisId
            // 
            this.cmbAxisId.Font = new System.Drawing.Font("宋体", 12.07563F);
            this.cmbAxisId.FormattingEnabled = true;
            this.cmbAxisId.Location = new System.Drawing.Point(79, 11);
            this.cmbAxisId.Name = "cmbAxisId";
            this.cmbAxisId.Size = new System.Drawing.Size(112, 28);
            this.cmbAxisId.TabIndex = 1;
            this.cmbAxisId.SelectedIndexChanged += new System.EventHandler(this.cmbAxisId_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12.07563F);
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "位移";
            // 
            // cmbDiatance
            // 
            this.cmbDiatance.Font = new System.Drawing.Font("宋体", 12.07563F);
            this.cmbDiatance.FormattingEnabled = true;
            this.cmbDiatance.Location = new System.Drawing.Point(79, 47);
            this.cmbDiatance.Name = "cmbDiatance";
            this.cmbDiatance.Size = new System.Drawing.Size(112, 28);
            this.cmbDiatance.TabIndex = 1;
            this.cmbDiatance.SelectedIndexChanged += new System.EventHandler(this.cmbDiatance_SelectedIndexChanged);
            // 
            // bnt_Back
            // 
            this.bnt_Back.BackColor = System.Drawing.Color.LightGreen;
            this.bnt_Back.Font = new System.Drawing.Font("宋体", 30.10084F, System.Drawing.FontStyle.Bold);
            this.bnt_Back.Location = new System.Drawing.Point(243, 11);
            this.bnt_Back.Name = "bnt_Back";
            this.bnt_Back.Size = new System.Drawing.Size(79, 54);
            this.bnt_Back.TabIndex = 2;
            this.bnt_Back.Text = "-";
            this.bnt_Back.UseVisualStyleBackColor = false;
            this.bnt_Back.Click += new System.EventHandler(this.bnt_Back_Click);
            // 
            // bnt_Forward
            // 
            this.bnt_Forward.BackColor = System.Drawing.Color.LightGreen;
            this.bnt_Forward.Font = new System.Drawing.Font("宋体", 30.10084F, System.Drawing.FontStyle.Bold);
            this.bnt_Forward.Location = new System.Drawing.Point(335, 11);
            this.bnt_Forward.Name = "bnt_Forward";
            this.bnt_Forward.Size = new System.Drawing.Size(74, 54);
            this.bnt_Forward.TabIndex = 2;
            this.bnt_Forward.Text = "+";
            this.bnt_Forward.UseVisualStyleBackColor = false;
            this.bnt_Forward.Click += new System.EventHandler(this.bnt_Forward_Click);
            // 
            // bnt_Stop
            // 
            this.bnt_Stop.BackColor = System.Drawing.Color.LightGreen;
            this.bnt_Stop.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnt_Stop.Location = new System.Drawing.Point(429, 11);
            this.bnt_Stop.Name = "bnt_Stop";
            this.bnt_Stop.Size = new System.Drawing.Size(96, 64);
            this.bnt_Stop.TabIndex = 2;
            this.bnt_Stop.Text = "STOP";
            this.bnt_Stop.UseVisualStyleBackColor = false;
            this.bnt_Stop.Click += new System.EventHandler(this.bnt_Stop_Click);
            // 
            // tkb_Vel
            // 
            this.tkb_Vel.Location = new System.Drawing.Point(24, 87);
            this.tkb_Vel.Name = "tkb_Vel";
            this.tkb_Vel.Size = new System.Drawing.Size(163, 56);
            this.tkb_Vel.TabIndex = 3;
            this.tkb_Vel.Scroll += new System.EventHandler(this.tkb_Vel_Scroll);
            // 
            // bnt_JOP_N
            // 
            this.bnt_JOP_N.BackColor = System.Drawing.Color.LightGreen;
            this.bnt_JOP_N.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnt_JOP_N.Location = new System.Drawing.Point(243, 87);
            this.bnt_JOP_N.Name = "bnt_JOP_N";
            this.bnt_JOP_N.Size = new System.Drawing.Size(81, 57);
            this.bnt_JOP_N.TabIndex = 2;
            this.bnt_JOP_N.Text = "JOP-";
            this.bnt_JOP_N.UseVisualStyleBackColor = false;
            this.bnt_JOP_N.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bnt_JOP_N_MouseDown);
            // 
            // bnt_JOP_P
            // 
            this.bnt_JOP_P.BackColor = System.Drawing.Color.LightGreen;
            this.bnt_JOP_P.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnt_JOP_P.Location = new System.Drawing.Point(335, 87);
            this.bnt_JOP_P.Name = "bnt_JOP_P";
            this.bnt_JOP_P.Size = new System.Drawing.Size(74, 57);
            this.bnt_JOP_P.TabIndex = 2;
            this.bnt_JOP_P.Text = "JOP+";
            this.bnt_JOP_P.UseVisualStyleBackColor = false;
            this.bnt_JOP_P.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bnt_JOP_P_MouseDown);
            // 
            // bnt_Home
            // 
            this.bnt_Home.BackColor = System.Drawing.Color.LightGreen;
            this.bnt_Home.Font = new System.Drawing.Font("宋体", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnt_Home.Location = new System.Drawing.Point(424, 128);
            this.bnt_Home.Name = "bnt_Home";
            this.bnt_Home.Size = new System.Drawing.Size(101, 66);
            this.bnt_Home.TabIndex = 2;
            this.bnt_Home.Text = "回零";
            this.bnt_Home.UseVisualStyleBackColor = false;
            this.bnt_Home.Click += new System.EventHandler(this.bnt_Home_Click);
            // 
            // ptb_SVON
            // 
            this.ptb_SVON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_SVON.Location = new System.Drawing.Point(26, 166);
            this.ptb_SVON.Name = "ptb_SVON";
            this.ptb_SVON.Size = new System.Drawing.Size(45, 28);
            this.ptb_SVON.TabIndex = 4;
            this.ptb_SVON.TabStop = false;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("宋体", 12.70588F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSpeed.Location = new System.Drawing.Point(58, 123);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(82, 21);
            this.lblSpeed.TabIndex = 1;
            this.lblSpeed.Text = "label3";
            // 
            // ptb_MEL
            // 
            this.ptb_MEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_MEL.Location = new System.Drawing.Point(77, 166);
            this.ptb_MEL.Name = "ptb_MEL";
            this.ptb_MEL.Size = new System.Drawing.Size(45, 28);
            this.ptb_MEL.TabIndex = 4;
            this.ptb_MEL.TabStop = false;
            // 
            // ptb_ORG
            // 
            this.ptb_ORG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_ORG.Location = new System.Drawing.Point(128, 166);
            this.ptb_ORG.Name = "ptb_ORG";
            this.ptb_ORG.Size = new System.Drawing.Size(45, 28);
            this.ptb_ORG.TabIndex = 4;
            this.ptb_ORG.TabStop = false;
            // 
            // ptb_PEL
            // 
            this.ptb_PEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_PEL.Location = new System.Drawing.Point(179, 166);
            this.ptb_PEL.Name = "ptb_PEL";
            this.ptb_PEL.Size = new System.Drawing.Size(45, 28);
            this.ptb_PEL.TabIndex = 4;
            this.ptb_PEL.TabStop = false;
            // 
            // ptb_ALM
            // 
            this.ptb_ALM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_ALM.Location = new System.Drawing.Point(230, 166);
            this.ptb_ALM.Name = "ptb_ALM";
            this.ptb_ALM.Size = new System.Drawing.Size(45, 28);
            this.ptb_ALM.TabIndex = 4;
            this.ptb_ALM.TabStop = false;
            // 
            // ptb_ASTP
            // 
            this.ptb_ASTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_ASTP.Location = new System.Drawing.Point(281, 166);
            this.ptb_ASTP.Name = "ptb_ASTP";
            this.ptb_ASTP.Size = new System.Drawing.Size(45, 28);
            this.ptb_ASTP.TabIndex = 4;
            this.ptb_ASTP.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "SVON";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "MEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "ORG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "PEL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "ALM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "ASTP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "使能";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "负极限";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(134, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "原点";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(176, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "正极限 ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(234, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "报警";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "异常停止";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblSpeed);
            this.panel1.Controls.Add(this.tkb_Vel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cmbAxisId);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cmbDiatance);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bnt_Back);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.bnt_JOP_N);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bnt_Forward);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.bnt_JOP_P);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bnt_Stop);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.bnt_Home);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ptb_SVON);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ptb_PEL);
            this.panel1.Controls.Add(this.ptb_MEL);
            this.panel1.Controls.Add(this.ptb_ASTP);
            this.panel1.Controls.Add(this.ptb_ALM);
            this.panel1.Controls.Add(this.ptb_ORG);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 241);
            this.panel1.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 245);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(537, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // XAxisControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "XAxisControlPanel";
            this.Size = new System.Drawing.Size(537, 267);
            ((System.ComponentModel.ISupportInitialize)(this.tkb_Vel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_SVON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_MEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ORG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_PEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ALM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ASTP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAxisId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDiatance;
        private System.Windows.Forms.Button bnt_Back;
        private System.Windows.Forms.Button bnt_Forward;
        private System.Windows.Forms.Button bnt_Stop;
        private System.Windows.Forms.TrackBar tkb_Vel;
        private System.Windows.Forms.Button bnt_JOP_N;
        private System.Windows.Forms.Button bnt_JOP_P;
        private System.Windows.Forms.Button bnt_Home;
        private System.Windows.Forms.PictureBox ptb_SVON;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.PictureBox ptb_MEL;
        private System.Windows.Forms.PictureBox ptb_ORG;
        private System.Windows.Forms.PictureBox ptb_PEL;
        private System.Windows.Forms.PictureBox ptb_ALM;
        private System.Windows.Forms.PictureBox ptb_ASTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
