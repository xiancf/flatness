using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Params
{
    public  class MotionParams
    {
        private double _测量模块X1轴回零速度 ;
        private double _测量模块X1轴运行速度 ;
        private double _测量模块X1轴运行加速度 ;
        private double _测量模块Z1轴回零速度 ;
        private double _测量模块Z1轴运行速度 ;
        private double _测量模块Z1轴运行加速度 ;


        private double _夹持模块X2轴回零速度 ;
        private double _夹持模块X2轴运行速度 ;
        private double _夹持模块X2轴运行加速度 ;
        private double _夹持模块Z2轴回零速度 ;
        private double _夹持模块Z2轴运行速度 ;
        private double _夹持模块Z2轴运行加速度 ;
        private double _夹持模块Y3轴回零速度 ;
        private double _夹持模块Y3轴运行速度 ;
        private double _夹持模块Y3轴运行加速度 ;

        private double _支撑模块Y1轴回零速度 ;
        private double _支撑模块Y1轴运行速度 ;
        private double _支撑模块Y1轴运行加速度 ;
        private double _支撑模块Y2轴回零速度 ;
        private double _支撑模块Y2轴运行速度 ;
        private double _支撑模块Y2轴运行加速度 ;
        [Category("测量模块")]
        public double 测量模块X1轴回零速度
        {
            get
            {
                return _测量模块X1轴回零速度;
            }

            set
            {
                if (value <1||value>1000)
                {
                    MessageBox.Show("测量模块X1轴回零速度范围 1--1000", "参数不在有效范围！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _测量模块X1轴回零速度 = value;
            }
        }
        [Category("测量模块")]
        public double 测量模块X1轴运行速度
        {
            get
            {
                return _测量模块X1轴运行速度;
            }

            set
            {
                _测量模块X1轴运行速度 = value;
            }
        }
        [Category("测量模块")]
        public double 测量模块X1轴运行加速度
        {
            get
            {
                return _测量模块X1轴运行加速度;
            }

            set
            {
                _测量模块X1轴运行加速度 = value;
            }
        }
        [Category("测量模块")]
        public double 测量模块Z1轴回零速度
        {
            get
            {
                return _测量模块Z1轴回零速度;
            }

            set
            {
                _测量模块Z1轴回零速度 = value;
            }
        }
        [Category("测量模块")]
        public double 测量模块Z1轴运行速度
        {
            get
            {
                return _测量模块Z1轴运行速度;
            }

            set
            {
                _测量模块Z1轴运行速度 = value;
            }
        }
        [Category("测量模块")]
        public double 测量模块Z1轴运行加速度
        {
            get
            {
                return _测量模块Z1轴运行加速度;
            }

            set
            {
                _测量模块Z1轴运行加速度 = value;
            }
        }
        [Category("夹持模块")]
        public double 夹持模块X2轴回零速度
        {
            get
            {
                return _夹持模块X2轴回零速度;
            }

            set
            {
                _夹持模块X2轴回零速度 = value;
            }
        }
        [Category("夹持模块")]
        public double 夹持模块X2轴运行速度
        {
            get
            {
                return _夹持模块X2轴运行速度;
            }

            set
            {
                _夹持模块X2轴运行速度 = value;
            }
        }
        [Category("夹持模块")]
        public double 夹持模块X2轴运行加速度
        {
            get
            {
                return _夹持模块X2轴运行加速度;
            }

            set
            {
                _夹持模块X2轴运行加速度 = value;
            }
        }
        [Category("夹持模块")]
        public double 夹持模块Z2轴回零速度
        {
            get
            {
                return _夹持模块Z2轴回零速度;
            }

            set
            {
                _夹持模块Z2轴回零速度 = value;
            }
        }
        [Category("夹持模块")]
        public double 夹持模块Z2轴运行速度
        {
            get
            {
                return _夹持模块Z2轴运行速度;
            }

            set
            {
                _夹持模块Z2轴运行速度 = value;
            }
        }
        [Category("夹持模块")]
        public double 夹持模块Z2轴运行加速度
        {
            get
            {
                return _夹持模块Z2轴运行加速度;
            }

            set
            {
                _夹持模块Z2轴运行加速度 = value;
            }
        }
        [Category("夹持模块")]
        public double 夹持模块Y3轴回零速度
        {
            get
            {
                return _夹持模块Y3轴回零速度;
            }

            set
            {
                _夹持模块Y3轴回零速度 = value;
            }
        }
        [Category("夹持模块")]
        public double 夹持模块Y3轴运行速度
        {
            get
            {
                return _夹持模块Y3轴运行速度;
            }

            set
            {
                _夹持模块Y3轴运行速度 = value;
            }
        }
        [Category("夹持模块")]
        public double 夹持模块Y3轴运行加速度
        {
            get
            {
                return _夹持模块Y3轴运行加速度;
            }

            set
            {
                _夹持模块Y3轴运行加速度 = value;
            }
        }
        [Category("支撑模块")]
        public double 支撑模块Y1轴回零速度
        {
            get
            {
                return _支撑模块Y1轴回零速度;
            }

            set
            {
                _支撑模块Y1轴回零速度 = value;
            }
        }
        [Category("支撑模块")]
        public double 支撑模块Y1轴运行速度
        {
            get
            {
                return _支撑模块Y1轴运行速度;
            }

            set
            {
                _支撑模块Y1轴运行速度 = value;
            }
        }
        [Category("支撑模块")]
        public double 支撑模块Y1轴运行加速度
        {
            get
            {
                return _支撑模块Y1轴运行加速度;
            }

            set
            {
                _支撑模块Y1轴运行加速度 = value;
            }
        }
        [Category("支撑模块")]
        public double 支撑模块Y2轴回零速度
        {
            get
            {
                return _支撑模块Y2轴回零速度;
            }

            set
            {
                _支撑模块Y2轴回零速度 = value;
            }
        }
        [Category("支撑模块")]
        public double 支撑模块Y2轴运行速度
        {
            get
            {
                return _支撑模块Y2轴运行速度;
            }

            set
            {
                _支撑模块Y2轴运行速度 = value;
            }
        }
        [Category("支撑模块")]
        public double 支撑模块Y2轴运行加速度
        {
            get
            {
                return _支撑模块Y2轴运行加速度;
            }

            set
            {
                _支撑模块Y2轴运行加速度 = value;
            }
        }
    }
}
