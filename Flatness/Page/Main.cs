using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flatness;
using Params;

namespace Page
{
    public enum PageName
    {
        pageProduct,
        pageSetting,
        pageCamera,
        pageAlarm,
        pageChart,
        pageInfo,
        pageLogin,
        pageEngineer,
        pageGRR
    }
    public delegate void ChangePage(string pageName);
    public partial class Main : Form
    {
        public static ChangePage change;
        public Dictionary<string, Label> labMap = new Dictionary<string, Label>();
        public Dictionary<string, Control> pageMap = new Dictionary<string, Control>();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            WelcomForm welcom = new Page.WelcomForm();
            welcom.ShowDialog();
            change = new ChangePage(pageChange);
            Global.BindParms();
            Global.BindCardAndAxis();
            Global.BindDi();
            Global.BindDo();
            Global.BindTask();
            Global.Initial();
            Global.LoadParams();

            labMap.Add(PageName.pageProduct.ToString(), lblProduct);
            labMap.Add(PageName.pageSetting.ToString(), lblSetting);
            labMap.Add(PageName.pageCamera.ToString(), lblCamera);
            labMap.Add(PageName.pageAlarm.ToString(), lblAlarm);
            labMap.Add(PageName.pageChart.ToString(), lblChart);
            labMap.Add(PageName.pageInfo.ToString(), lblInfo);
            labMap.Add(PageName.pageLogin.ToString(), lblLogin);

            pageMap.Add(PageName.pageProduct.ToString(), new pageProduct());
            pageMap.Add(PageName.pageSetting.ToString(), new pageSetting());
            pageMap.Add(PageName.pageCamera.ToString(), new pageCamera());
            pageMap.Add(PageName.pageAlarm.ToString(), new pageAlarm());
            pageMap.Add(PageName.pageChart.ToString(), new pageChart());
            pageMap.Add(PageName.pageInfo.ToString(), new pageInfo());
            pageMap.Add(PageName.pageLogin.ToString(), new pageLogin());
            pageMap.Add(PageName.pageEngineer.ToString(), new pageEngineer());
            pageMap.Add(PageName.pageGRR.ToString(), new pageGRR());
            panelPage.Controls.Add(pageMap[PageName.pageLogin.ToString()]);

        }
        private void pageChange(string pageName)
        {
            panelPage.Controls.Clear();
            panelPage.Controls.Add(pageMap[pageName]);
            foreach (var lab in labMap)
            {
                lab.Value.BackColor = Control.DefaultBackColor;
                if (lab.Key == pageName)
                {
                    lab.Value.BackColor = Color.Green;
                }
            }
        }
        private void pageChange_OnClick(object sender, EventArgs e)   //单击菜单时按钮变颜色变化及切换至对应界面-事件
        {
            string pageName = ((Label)sender).Tag.ToString();
            pageChange(pageName);

        }
        /// <summary>
        /// 关闭退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }


    }
}
