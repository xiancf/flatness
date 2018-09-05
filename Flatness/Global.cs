using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ID;
using XCore;
using Params;
using Task;

namespace Flatness
{
   public  class Global
    {
        public static string ParamsPath = Application.StartupPath + "\\Parms\\";
        public static string UserParmsPath = ParamsPath + "UserParms.xml";
        public static string MontionParmsPath = ParamsPath + "MontionParms.xml";
        public static string CalibrationParmsPath = ParamsPath + "Calibration.xml";
        //public static string Params204 = ParamsPath + "param.xml";
        public static string Params204 =@"D:\param.xml";
        public static UserParams UserParm = new UserParams();
        public static MotionParams MotionParam = new MotionParams();
        public static CalibrationParams CalibrationParam = new CalibrationParams();
        public static void BindParms()
        {        
            ParmsFactory.Load<UserParams>(UserParmsPath,ref UserParm);
            ParmsFactory.Load<MotionParams>(MontionParmsPath, ref MotionParam);
            ParmsFactory.Load<CalibrationParams>(CalibrationParmsPath, ref CalibrationParam);
        }
        public static void BindCardAndAxis()
        {
            XDevice.Instance.BindCard((int)CardId.AMP208C1, 0, new XCommandCard208C(), "卡1");
            XDevice.Instance.BindAxis((int)CardId.AMP208C1, (int)AxisId.测量X1, 0, 20, XAxisDirection.left_Right, AxisId.测量X1.ToString());
            XDevice.Instance.BindAxis((int)CardId.AMP208C1, (int)AxisId.测量Z1, 1, 20, XAxisDirection.left_Right, AxisId.测量Z1.ToString());
            XDevice.Instance.BindAxis((int)CardId.AMP208C1, (int)AxisId.夹持模组X2, 2, 20, XAxisDirection.left_Right, AxisId.夹持模组X2.ToString());
            XDevice.Instance.BindAxis((int)CardId.AMP208C1, (int)AxisId.夹持模组Z2, 3, 20, XAxisDirection.left_Right, AxisId.夹持模组Z2.ToString());
            XDevice.Instance.BindAxis((int)CardId.AMP208C1, (int)AxisId.夹持模组Y3, 4, 20, XAxisDirection.left_Right, AxisId.夹持模组Y3.ToString());
            XDevice.Instance.BindAxis((int)CardId.AMP208C1, (int)AxisId.支撑机构Y1, 5, 20, XAxisDirection.left_Right, AxisId.支撑机构Y1.ToString());
            XDevice.Instance.BindAxis((int)CardId.AMP208C1, (int)AxisId.支撑机构Y2, 6, 20, XAxisDirection.left_Right, AxisId.支撑机构Y2.ToString());

        }
        public static void BindDi()
        {
            XDevice.Instance.BindDi((int)CardId.AMP208C1, (int)DiId.产品检测光纤,8,0, DiId.产品检测光纤.ToString(), CardId.AMP208C1.ToString());
            XDevice.Instance.BindDi((int)CardId.AMP208C1, (int)DiId.右启动按钮, 9, 0, DiId.右启动按钮.ToString(), CardId.AMP208C1.ToString());
            XDevice.Instance.BindDi((int)CardId.AMP208C1, (int)DiId.复位按钮, 10, 0, DiId.复位按钮.ToString(), CardId.AMP208C1.ToString());
            XDevice.Instance.BindDi((int)CardId.AMP208C1, (int)DiId.安全光幕, 11, 0, DiId.安全光幕.ToString(), CardId.AMP208C1.ToString());
            XDevice.Instance.BindDi((int)CardId.AMP208C1, (int)DiId.左启动按钮, 12, 0, DiId.左启动按钮.ToString(), CardId.AMP208C1.ToString());
        }
        public static void BindDo()
        {
            XDevice.Instance.BingDo((int)CardId.AMP208C1, (int)DoId.气缸, 8, 0, DoId.气缸.ToString(), CardId.AMP208C1.ToString());
            XDevice.Instance.BingDo((int)CardId.AMP208C1, (int)DoId.红灯, 9, 0, DoId.红灯.ToString(), CardId.AMP208C1.ToString());
            XDevice.Instance.BingDo((int)CardId.AMP208C1, (int)DoId.绿灯, 10, 0, DoId.绿灯.ToString(), CardId.AMP208C1.ToString());
            XDevice.Instance.BingDo((int)CardId.AMP208C1, (int)DoId.蜂鸣器, 11, 0, DoId.蜂鸣器.ToString(), CardId.AMP208C1.ToString());
            XDevice.Instance.BingDo((int)CardId.AMP208C1, (int)DoId.黄灯, 12, 0, DoId.黄灯.ToString(), CardId.AMP208C1.ToString());
        }
        public static void BindTask()
        {
            XTaskManage.Instance.BindTask((int)TaskId.任务0_测量模块, new 测量模块(), TaskId.任务0_测量模块.ToString());
            XTaskManage.Instance.BindTask((int)TaskId.任务1_支撑模块, new 测量模块(), TaskId.任务1_支撑模块.ToString());
            XTaskManage.Instance.BindTask((int)TaskId.任务2_夹持模块, new 测量模块(), TaskId.任务2_夹持模块.ToString());
            XTaskManage.Instance.FindTaskById((int)TaskId.任务0_测量模块).RegisterAxis((int)AxisId.测量X1);
            XTaskManage.Instance.FindTaskById((int)TaskId.任务0_测量模块).RegisterAxis((int)AxisId.测量Z1);
            XTaskManage.Instance.FindTaskById((int)TaskId.任务1_支撑模块).RegisterAxis((int)AxisId.支撑机构Y1);
            XTaskManage.Instance.FindTaskById((int)TaskId.任务1_支撑模块).RegisterAxis((int)AxisId.支撑机构Y2);
            XTaskManage.Instance.FindTaskById((int)TaskId.任务2_夹持模块).RegisterAxis((int)AxisId.夹持模组X2);
            XTaskManage.Instance.FindTaskById((int)TaskId.任务2_夹持模块).RegisterAxis((int)AxisId.夹持模组Y3);
            XTaskManage.Instance.FindTaskById((int)TaskId.任务2_夹持模块).RegisterAxis((int)AxisId.夹持模组Z2);


        }
        public static void Initial()
        {
           foreach(XCard  v in XDevice.Instance.CardMap.Values)
            {
                int ret=v.Initial();
            }
        }
        public static void LoadParams()
        {
            foreach (XCard v in XDevice.Instance.CardMap.Values)
            {
                int ret = v.LoadParams(Params204);
            }
        }
    }
}
