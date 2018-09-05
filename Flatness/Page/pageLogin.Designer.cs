namespace Page
{
    partial class pageLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pageLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.picbRigh = new System.Windows.Forms.PictureBox();
            this.picbWarrring = new System.Windows.Forms.PictureBox();
            this.bntLogin = new System.Windows.Forms.Button();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductMode = new System.Windows.Forms.Label();
            this.lblEngineerMode = new System.Windows.Forms.Label();
            this.lblCPKMode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbRigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbWarrring)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.picbRigh);
            this.panel1.Controls.Add(this.picbWarrring);
            this.panel1.Controls.Add(this.bntLogin);
            this.panel1.Controls.Add(this.txbPassWord);
            this.panel1.Controls.Add(this.cmbUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 291);
            this.panel1.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("宋体", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMessage.Location = new System.Drawing.Point(150, 199);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(68, 17);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "label3";
            // 
            // picbRigh
            // 
            this.picbRigh.Image = ((System.Drawing.Image)(resources.GetObject("picbRigh.Image")));
            this.picbRigh.Location = new System.Drawing.Point(113, 192);
            this.picbRigh.Name = "picbRigh";
            this.picbRigh.Size = new System.Drawing.Size(30, 30);
            this.picbRigh.TabIndex = 4;
            this.picbRigh.TabStop = false;
            // 
            // picbWarrring
            // 
            this.picbWarrring.Image = global::Flatness.Properties.Resources._alarmH1;
            this.picbWarrring.Location = new System.Drawing.Point(113, 192);
            this.picbWarrring.Name = "picbWarrring";
            this.picbWarrring.Size = new System.Drawing.Size(30, 30);
            this.picbWarrring.TabIndex = 4;
            this.picbWarrring.TabStop = false;
            // 
            // bntLogin
            // 
            this.bntLogin.Font = new System.Drawing.Font("宋体", 16.07563F);
            this.bntLogin.Location = new System.Drawing.Point(113, 232);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(102, 42);
            this.bntLogin.TabIndex = 3;
            this.bntLogin.Text = "Login";
            this.bntLogin.UseVisualStyleBackColor = true;
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // txbPassWord
            // 
            this.txbPassWord.Font = new System.Drawing.Font("宋体", 15.73109F, System.Drawing.FontStyle.Bold);
            this.txbPassWord.Location = new System.Drawing.Point(113, 149);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(234, 37);
            this.txbPassWord.TabIndex = 2;
            this.txbPassWord.TextChanged += new System.EventHandler(this.txbPassWord_TextChanged);
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.DropDownWidth = 180;
            this.cmbUserName.Font = new System.Drawing.Font("宋体", 15.73109F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Items.AddRange(new object[] {
            "Production",
            "Engineer",
            "Administrator"});
            this.cmbUserName.Location = new System.Drawing.Point(113, 57);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(234, 34);
            this.cmbUserName.TabIndex = 1;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18.07563F);
            this.label2.Location = new System.Drawing.Point(108, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "PassWord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18.07563F);
            this.label1.Location = new System.Drawing.Point(108, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblLoginUser);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(921, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 385);
            this.panel2.TabIndex = 1;
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Font = new System.Drawing.Font("宋体", 21.78151F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLoginUser.Location = new System.Drawing.Point(106, 29);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(126, 36);
            this.lblLoginUser.TabIndex = 1;
            this.lblLoginUser.Text = "用户名";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Image = global::Flatness.Properties.Resources.user;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 91);
            this.label3.TabIndex = 0;
            // 
            // lblProductMode
            // 
            this.lblProductMode.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductMode.Font = new System.Drawing.Font("宋体", 36.30252F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProductMode.Location = new System.Drawing.Point(307, 99);
            this.lblProductMode.Name = "lblProductMode";
            this.lblProductMode.Size = new System.Drawing.Size(344, 86);
            this.lblProductMode.TabIndex = 2;
            this.lblProductMode.Tag = "pageProduct";
            this.lblProductMode.Text = "Product";
            this.lblProductMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductMode.Click += new System.EventHandler(this.Mode_Click);
            // 
            // lblEngineerMode
            // 
            this.lblEngineerMode.BackColor = System.Drawing.SystemColors.Control;
            this.lblEngineerMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEngineerMode.Font = new System.Drawing.Font("宋体", 36.30252F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEngineerMode.Location = new System.Drawing.Point(307, 254);
            this.lblEngineerMode.Name = "lblEngineerMode";
            this.lblEngineerMode.Size = new System.Drawing.Size(344, 86);
            this.lblEngineerMode.TabIndex = 2;
            this.lblEngineerMode.Tag = "pageEngineer";
            this.lblEngineerMode.Text = "Engineer";
            this.lblEngineerMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEngineerMode.Click += new System.EventHandler(this.Mode_Click);
            // 
            // lblCPKMode
            // 
            this.lblCPKMode.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPKMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCPKMode.Font = new System.Drawing.Font("宋体", 36.30252F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCPKMode.Location = new System.Drawing.Point(307, 400);
            this.lblCPKMode.Name = "lblCPKMode";
            this.lblCPKMode.Size = new System.Drawing.Size(344, 86);
            this.lblCPKMode.TabIndex = 2;
            this.lblCPKMode.Tag = "pageGRR";
            this.lblCPKMode.Text = "CPK/GRR";
            this.lblCPKMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCPKMode.Click += new System.EventHandler(this.Mode_Click);
            // 
            // pageLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblCPKMode);
            this.Controls.Add(this.lblEngineerMode);
            this.Controls.Add(this.lblProductMode);
            this.Controls.Add(this.panel2);
            this.Name = "pageLogin";
            this.Size = new System.Drawing.Size(1365, 810);
            this.Load += new System.EventHandler(this.pageLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbRigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbWarrring)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntLogin;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picbWarrring;
        private System.Windows.Forms.PictureBox picbRigh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProductMode;
        private System.Windows.Forms.Label lblEngineerMode;
        private System.Windows.Forms.Label lblCPKMode;
    }
}
