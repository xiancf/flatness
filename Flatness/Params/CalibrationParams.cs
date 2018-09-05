using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Params
{
   public  class CalibrationParams
    {
        private int _白色同轴光源;
        private double[] _大理石头校验数据;

        [Category("光源亮度")]
        public int 白色同轴光源
        {
            get
            {
                return _白色同轴光源;
            }

            set
            {
                if (value <=0||value >3)
                {
                    MessageBox.Show("光源亮度范围 1-3", "参数不在有效范围！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _白色同轴光源 = value;
            }
        }
        [Category("校验数据")]
        public double[] 大理石头校验数据
        {
            get
            {
                return _大理石头校验数据;
            }

            set
            {
                _大理石头校验数据 = value;
            }
        }
    }
}
