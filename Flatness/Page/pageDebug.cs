using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCore;
using Flatness.Properties;
using ID;

namespace Page
{
    public partial class pageDebug : Form
    {
        public pageDebug()
        {
            InitializeComponent();
        }

        private string[] colHead = new string[] { "", "信号状态", "名称", "通道号", "通道组" };  //dgr列名
        private void pageDebug_Load(object sender, EventArgs e)
        {

            

        }

        private void timer1_Tick_1(object sender, EventArgs e)   //更新Di信号状态
        {

            for (int i = 0; i < XDevice.Instance.DiMap.Values.Count; i++)
            {
                XDevice.Instance.DiMap.Values.ToArray()[i].update();
                bool b = XDevice.Instance.DiMap.Values.ToArray()[i].M_STS;
                if (b)
                {
                    dgrDi.Rows[i].Cells[1].Value = Flatness.Properties.Resources._lampGreen20;
                    return;
                }
                dgrDi.Rows[i].Cells[1].Value = Flatness.Properties.Resources._lampGray20;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)      //更新DO信号状态
        {
            for (int i = 0; i < XDevice.Instance.DoMap.Values.Count; i++)
            {
                XDevice.Instance.DoMap.Values.ToArray()[i].Update();
                bool b = XDevice.Instance.DoMap.Values.ToArray()[i].M_STS;
                if (b)
                {
                    dgrDo.Rows[i].Cells[1].Value = Flatness.Properties.Resources._lampGreen20;
                    return;
                }
                dgrDo.Rows[i].Cells[1].Value = Flatness.Properties.Resources._lampGray20;

            }
        }

        private void tabControl_Debug_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = tabControl_Debug.SelectedTab.Text;

            switch (s)
            {
                case "测量模块":
                    //XAxis x1 = XDevice.Instance.FindAxisById((int)AxisId.测量X1);
                    //XAxis x2 = XDevice.Instance.FindAxisById((int)AxisId.测量Z1);
                    //xAxisControlPanel.AddAxisItem(AxisId.测量X1.ToString());
                    //xAxisControlPanel.AddAxisItem(AxisId.测量Z1.ToString());
                    xAxisControlPanel.TaskId = 0;
                    return;
                case "夹持模块":
                    
                    return;
                case "支撑模块":
                    return;
                case "输入信号":
                    {
                        dgrDi.Columns.Clear();
                        dgrDi.Columns.Add(new DataGridViewTextBoxColumn());
                        dgrDi.Columns.Add(new DataGridViewImageColumn());
                        dgrDi.Columns.Add(new DataGridViewTextBoxColumn());
                        dgrDi.Columns.Add(new DataGridViewTextBoxColumn());
                        dgrDi.Columns.Add(new DataGridViewTextBoxColumn());
                        dgrDi.Columns[0].Width = 50;
                        dgrDi.Columns[1].Width = 150;
                        dgrDi.Columns[2].Width = 200;
                        dgrDi.Columns[3].Width = 100;
                        dgrDi.Columns[4].Width = 100;
                        for (int i = 0; i < colHead.Length; i++)
                        {
                            dgrDi.Columns[i].HeaderText = colHead[i]; //绑定Di列名
                        }

                        for (int i = 0; i < XDevice.Instance.DiMap.Values.Count; i++)
                        {

                            dgrDi.Rows.Add();
                            dgrDi.Rows[i].Cells[0].Value = null;
                            dgrDi.Rows[i].Cells[1].Value = Flatness.Properties.Resources._lampGray20;
                            dgrDi.Rows[i].Cells[2].Value = XDevice.Instance.DiMap.Values.ToArray()[i].Name;
                            dgrDi.Rows[i].Cells[3].Value = XDevice.Instance.DiMap.Values.ToArray()[i].ActDiId - 7;
                            dgrDi.Rows[i].Cells[4].Value = XDevice.Instance.DiMap.Values.ToArray()[i].Channel;
                        }
                        timer1.Enabled = true;
                        return;
                    }
                case "输出信号":
                    {


                        dgrDo.Columns.Clear();
                        dgrDo.Columns.Add(new DataGridViewTextBoxColumn());
                        dgrDo.Columns.Add(new DataGridViewImageColumn());
                        dgrDo.Columns.Add(new DataGridViewTextBoxColumn());
                        dgrDo.Columns.Add(new DataGridViewTextBoxColumn());
                        dgrDo.Columns.Add(new DataGridViewTextBoxColumn());
                        dgrDo.Columns[0].Width = 50;
                        dgrDo.Columns[1].Width = 150;
                        dgrDo.Columns[2].Width = 200;
                        dgrDo.Columns[3].Width = 100;
                        dgrDo.Columns[4].Width = 100;
                        for (int i = 0; i < colHead.Length; i++)
                        {
                            dgrDo.Columns[i].HeaderText = colHead[i];   //绑定DO列名
                        }
                        for (int i = 0; i < XDevice.Instance.DoMap.Values.Count; i++)
                        {
                            dgrDo.Rows.Add();
                            dgrDo.Rows[i].Cells[0].Value = null;
                            dgrDo.Rows[i].Cells[1].Value = Flatness.Properties.Resources._lampGray20;
                            dgrDo.Rows[i].Cells[2].Value = XDevice.Instance.DoMap.Values.ToArray()[i].Name;
                            dgrDo.Rows[i].Cells[3].Value = XDevice.Instance.DoMap.Values.ToArray()[i].ActDoId - 7;
                            dgrDo.Rows[i].Cells[4].Value = XDevice.Instance.DoMap.Values.ToArray()[i].Channel;
                        }
                        timer2.Enabled = true;
                        return;
                    }

                case "其它":
                    return;
            }

        }
        private void dgrDo_CellClick(object sender, DataGridViewCellEventArgs e) //点击do切换输出信号状态
        {

            int cIndex = e.ColumnIndex;
            int rIndex = e.RowIndex;
            if (cIndex >= 0 && rIndex >= 0 && dgrDo.Columns[cIndex].HeaderText == "信号状态")
            {
                foreach (var v in XDevice.Instance.DoMap.Values)
                {
                    object doSelect = dgrDo.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value;
                    if (doSelect != null)
                    {
                        if (v.Name == doSelect.ToString())
                        {
                            v.Qufa();
                        }
                    }

                }
            }
        }


    }
}
