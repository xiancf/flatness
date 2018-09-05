using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCore
{
    public class XAxis
    {
        private XCard card;
        private int actAxisId;            //轴Id
        private double lead;              //轴导乘
        private string name;              //轴名字
        private XAxisDirection direction; //轴运动模式
        private int axisMotionSts;        //轴的运动状态，如加速度
        private int axisMotionIoSts;         //轴IO信号状态，如限位信号
        private int axisCommandPos;       //轴发送脉冲数量
        private int axisMotionPos;        //轴实际行走脉冲数量 
        private bool isHomeOk;

        public XAxis(XCard card, int actAxisid, double lead, string name)
        {
            this.card = card;
            this.actAxisId = actAxisid;
            this.lead = lead;
            this.name = name;
        }
        public int SetId { set; get; }
        public int TaskId { set; get; }
        public int GetActAxisId { get { return actAxisId; } }
        public string Name { get { return name; } }
        public double  CommandPos                                     
        {
            get
            {
                lock(this)
                {
                    return XConvert.PULS_MM(axisCommandPos, lead);
                }
            }
        }                      
        public bool IsHomeOk { get { return isHomeOk; } }
        public bool IsPEL
        {
            get
            {
                lock (this)
                {
                   return   XConvert.BitEnable(axisMotionIoSts, XAPS_Define.MIO_PEL);
                }
            }
        }
        public bool IsMEL
        {
            get
            {
                lock (this)
                {
                    return XConvert.BitEnable(axisMotionIoSts, XAPS_Define.MIO_MEL);
                }
            }
        }
        public bool IsORG
        {
            get
            {
                lock(this)
                {
                    return XConvert.BitEnable(axisMotionIoSts, XAPS_Define.MIO_ORG);
                }
            }
        }
        public bool IsALM
        {
            get
            {
                lock (this)
                {
                    return XConvert.BitEnable(axisMotionIoSts, XAPS_Define.MIO_ALM);
                }
            }
        }
        public bool IsEMG
        {
            get
            {
                lock (this)
                {
                    return XConvert.BitEnable(axisMotionIoSts, XAPS_Define.MIO_EMG);
                }
            }
        }
        public bool IsSVON
        {
            get
            {
                lock (this)
                {
                    return XConvert.BitEnable(axisMotionIoSts, XAPS_Define.MIO_SVON);
                }
            }
        }

        public bool IsASTP
        {
            get
            {
                lock(this)
                {
                    return XConvert.BitEnable(axisMotionSts, XAPS_Define.MTS_ASTP);
                }
            }
        }
        public bool IsHMV
        {
            get
            {
                lock (this)
                {
                    return XConvert.BitEnable(axisMotionSts, XAPS_Define.MTS_HMV);
                }
            }
        }
        public bool IsMDN
        {
            get
            {
                lock (this)
                {
                    return XConvert.BitEnable(axisMotionSts, XAPS_Define.MTS_MDN);
                }
            }
        }
        public int GoHome()
        {
                return card.GetHome(actAxisId);
        }
        public int Stop()
        {
                return card.Stop(actAxisId);
        }
        public int SetServo(bool on)
        {
            return card.SetServo(actAxisId, on);
        }
        public int Update()
        {
            lock (this)
            {

                card.GetMotionSts(actAxisId, ref axisMotionSts);
                card.GetMotionIoSts(actAxisId, ref axisMotionIoSts);
                card.GetCommandPos(actAxisId, ref axisCommandPos);
                card.GetMotionPos(actAxisId, ref axisMotionPos);
                return 0;
            }
        }
        public int MoveRel(double  distance,double  vel)
        {
           return  card.MoveRel(actAxisId, XConvert.MM_PULS(distance,lead), XConvert .MM_PULS (vel,lead));
        }
        public int MoveAbs(int postion,int vel)
        {
            return card.MoveAbs(actAxisId, XConvert.MM_PULS(postion, lead), XConvert.MM_PULS(vel, lead));
        }
        public int SetMotionPos(int pos)
        {
            return card.SetMotionPos(actAxisId, pos);
        }
        public int SetAccAndDec(double  acc,double  dec)
        {
            return card.SetAccAndDec(actAxisId, lead, acc, dec);
        }
    }
    public enum XAxisDirection
    {
        left_Right,
        Front_Back,
        Back_Front,
        UP_Down,
        Rotate,
        Rotate_antiClock,
        Right_Left,
    }
}
