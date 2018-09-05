using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flatness;

namespace Page
{
    public enum LoginType
    {       
        Production,
        Engreeing,
        Administrator,
        None,
    }
    public partial class pageLogin : UserControl
    {
        public static LoginType User = LoginType.None;
        public pageLogin()
        {
            InitializeComponent();
        }

        private void pageLogin_Load(object sender, EventArgs e)
        {
            cmbUserName.SelectedIndex = 0;
            picbWarrring.Visible = false;
            picbRigh.Visible = false;
            lblMessage.Text = "";
            lblLoginUser.Text = User.ToString();
            lblProductMode.Enabled = false;
            lblEngineerMode.Enabled = false;
            lblCPKMode.Enabled = false;
        }
        private void Mode_Click(object sender,EventArgs e)
        {          
            string mode=((Label)sender).Tag.ToString();
            Page.Main.change(mode);
            
        }
        private void bntLogin_Click(object sender, EventArgs e)
        {
            picbWarrring.Visible = false;
            picbRigh.Visible = false;
            if (cmbUserName.SelectedIndex < 0 || cmbUserName.Text=="")
            {
                //MessageBox.Show("请选择要登陆的用户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                picbWarrring.Visible = true;
                lblMessage.Text = "请选择要登陆的用户！";
                return;
            }
            string pwd = "";
            if (cmbUserName.SelectedIndex == 0)
            {
                pwd = Global.UserParm.操作员密码;
            }
            if (cmbUserName.SelectedIndex == 1)
            {
                pwd = Global.UserParm.工程师密码;
            }
            if (cmbUserName.SelectedIndex == 2)
            {
                pwd = Global.UserParm.管理员密码;
            }
            
            if (User==LoginType.None|| cmbUserName.SelectedIndex > (int)User)
            {
                if (txbPassWord.Text.Trim() != pwd)
                {
                    //MessageBox.Show("用户" + cmbUserName.Text + "密码不正确！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    picbWarrring.Visible = true;
                    lblMessage.Text = "用户" + cmbUserName.Text + "密码不正确！";
                    return;
                }               
            }
            // MessageBox.Show("用户" + cmbUserName.Text + "登陆成功！", "提示", MessageBoxButtons.OK);
            picbRigh.Visible = true;
            lblMessage.Text = "用户" + cmbUserName.Text + "登陆成功！";
            User = (LoginType)cmbUserName.SelectedIndex;
            lblLoginUser.Text =User.ToString();
            Mode();
           
        }
        private void Mode()
        {
            if (User ==LoginType.Production)
            {
                lblProductMode.Enabled = true;
                lblEngineerMode.Enabled = false;
                lblCPKMode.Enabled = false;
            }
            if (User ==LoginType.Engreeing)
            {
                lblProductMode.Enabled = true;
                lblEngineerMode.Enabled = true;
                lblCPKMode.Enabled = false;
            }
            if (User ==LoginType.Administrator)
            {
                lblProductMode.Enabled = true;
                lblEngineerMode.Enabled = true;
                lblCPKMode.Enabled = true;
            }
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            picbRigh.Visible = false;
            picbWarrring.Visible = false;
            lblMessage.Text = "";
        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {
            picbRigh.Visible = false;
            picbWarrring.Visible = false;
            lblMessage.Text = "";
        }
    }
}
