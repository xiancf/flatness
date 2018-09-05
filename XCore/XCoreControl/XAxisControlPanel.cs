using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCore.Properties;

namespace XCore

{
    public partial class XAxisControlPanel : UserControl
    {
        private int taskId ;
        private int m_AxisId;
        private XAxis m_Axis;
        private double m_Distance;
        private double m_Vel;
        private double m_Acc = 1000;

        public int TaskId
        {
            get { return taskId; }
            set
            {
                cmbAxisId.Items.Clear();
                foreach (var axis in XTaskManage.Instance.FindTaskById(taskId).AxisMap.Values)
                {
                    cmbAxisId.Items.Add(axis.Name);
                }
            }
        }
        public void AddAxisItem(string name)
        {
            cmbAxisId.Items.Add(name);
        }
        public double M_ACC
        {
            get { return m_Acc; }
            set { m_Acc = value; }
        }

        public XAxisControlPanel()
        {
            InitializeComponent();
            InitailDistance();
            InitailVel();
            InitailSts();
            //lblSpeed.BringToFront();
        }

        private void InitailDistance()
        {
            cmbDiatance.Items.Add(0.001);
            cmbDiatance.Items.Add(0.002);
            cmbDiatance.Items.Add(0.005);
            cmbDiatance.Items.Add(0.01);
            cmbDiatance.Items.Add(0.02);
            cmbDiatance.Items.Add(0.05);
            cmbDiatance.Items.Add(0.1);
            cmbDiatance.Items.Add(0.2);
            cmbDiatance.Items.Add(0.5);
            cmbDiatance.Items.Add(1);
            cmbDiatance.Items.Add(2);
            cmbDiatance.Items.Add(5);
            cmbDiatance.Items.Add(10);
            cmbDiatance.Items.Add(20);
            cmbDiatance.Items.Add(30);
            cmbDiatance.Items.Add(45);
            cmbDiatance.Items.Add(50);
            cmbDiatance.Items.Add(60);
            cmbDiatance.Items.Add(80);
            cmbDiatance.Items.Add(100);
            cmbDiatance.Items.Add(120);
            cmbDiatance.Items.Add(140);
            cmbDiatance.Items.Add(160);

        }
        private void InitailVel()
        {
            tkb_Vel.Maximum = 1;
            tkb_Vel.Maximum = 100;
            tkb_Vel.Value = 10;
            lblSpeed.Text = tkb_Vel.Value.ToString() + "mm/s";

        }
        private void InitailSts()  //初始化轴STS显示为fals,背景图片居中
        {
            ptb_SVON.BackgroundImage = XCore.Properties.Resources._lampGray20;
            ptb_MEL.BackgroundImage = XCore.Properties.Resources._lampGray20;
            ptb_ORG.BackgroundImage = XCore.Properties.Resources._lampGray20;
            ptb_PEL.BackgroundImage = XCore.Properties.Resources._lampGray20;
            ptb_ALM.BackgroundImage = XCore.Properties.Resources._lampGray20;
            ptb_ASTP.BackgroundImage = XCore.Properties.Resources._lampGray20;
            ptb_SVON.BackgroundImage = Resources._lampGreen20;
            ptb_SVON.BackgroundImageLayout = ImageLayout.Center;
            ptb_MEL.BackgroundImageLayout = ImageLayout.Center;
            ptb_ORG.BackgroundImageLayout = ImageLayout.Center;
            ptb_PEL.BackgroundImageLayout = ImageLayout.Center;
            ptb_ALM.BackgroundImageLayout = ImageLayout.Center;
            ptb_ASTP.BackgroundImageLayout = ImageLayout.Center;

        }
        private void tkb_Vel_Scroll(object sender, EventArgs e)
        {
            m_Vel = tkb_Vel.Value;
            lblSpeed.Text = tkb_Vel.Value.ToString() + "mm/s";
        }

        private void cmbAxisId_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var axis in XTaskManage.Instance.FindTaskById(taskId).AxisMap.Values)
            {
                
                m_Axis = axis;
            }
        }

        private void cmbDiatance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiatance.SelectedItem != null)
            {
                m_Distance = Convert.ToDouble(cmbDiatance.SelectedItem);
            }
        }

        private void bnt_Back_Click(object sender, EventArgs e)
        {
            if (cmbAxisId.Items.Count > 0)
            {
                if (XDevice.Instance.FindAxisById(m_AxisId).SetAccAndDec(m_Acc, m_Acc) != 0)  //如果SetAccAndDec不成功则返回
                {
                    return;
                }
                XDevice.Instance.FindAxisById(m_AxisId).MoveRel(-m_Distance, m_Vel);
            }

            //    if (cmbAxisId.SelectedItem == null)
            //    {
            //        MessageBox.Show("请先选择要操作的轴", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    if (cmbAxisId.SelectedItem == null)
            //    {
            //        MessageBox.Show("请先选择位移量", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    m_Axis.MoveRel(-m_Distance,m_Vel);
        }

        private void bnt_Forward_Click(object sender, EventArgs e)
        {
            MessageBox.Show("123");
            if (cmbAxisId.Items.Count > 0)
            {
                if (XDevice.Instance.FindAxisById(m_AxisId).SetAccAndDec(m_Acc, m_Acc) != 0)  //如果SetAccAndDec不成功则返回
                {
                    return;
                }
                XDevice.Instance.FindAxisById(m_AxisId).MoveRel(-m_Distance, m_Vel);
            }
            //if (cmbAxisId.SelectedItem==null)
            //{
            //    MessageBox.Show("请先选择要操作的轴","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    return;
            //}
            //if (cmbAxisId.SelectedItem==null)
            //{
            //    MessageBox.Show("请先选择位移量", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //m_Axis.MoveRel(m_Distance, m_Vel);
        }

        private void bnt_Stop_Click(object sender, EventArgs e)
        {
            // if (m_Axis.i)
        }

        private void bnt_Home_Click(object sender, EventArgs e)
        {

        }

        private void bnt_JOP_N_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void bnt_JOP_P_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
