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
using Params;

namespace Page
{
    public partial class pageSetting : UserControl
    {
        public pageSetting()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 绑定对象到propertGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageSetting_Load(object sender, EventArgs e)
        {
            propertyGrid_MotionParams.SelectedObject = Global.MotionParam;
            propertyGrid_Calibration.SelectedObject = Global.CalibrationParam;
        }
        /// <summary>
        /// 保存参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntSaveParams_Click(object sender, EventArgs e)
        {
            ParmsFactory.SaveParams<MotionParams>(Global.MontionParmsPath, Global.MotionParam);
            ParmsFactory.SaveParams<CalibrationParams>(Global.CalibrationParmsPath,Global.CalibrationParam);
        }
    }
}
