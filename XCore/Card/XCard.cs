using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XCore
{
   public  class XCard
    {
        private int actCardId;
        private string name;
        private XCommandCard commandCard;
        private Dictionary<int, XAxis> axiss = new Dictionary<int, XAxis>();
        public XCard (int actCardId,XCommandCard commandCard,string name)
        {
            this.actCardId = actCardId;
            this.commandCard = commandCard;
            this.name = name;
        }
        public int Initial()
        {
            int ret = commandCard.Initial();
            if (ret<0)
            {
                MessageBox.Show("初始化失败！");
            }
            return ret;
        }
        public int LoadParams(string pXMLFile)
        {
            int ret = commandCard.LoadParam(pXMLFile);
            if (ret<0)
            {
                MessageBox.Show("加载配置文件失败");
            }
            return ret;
        }
        public int Close()
        {
            return  commandCard.Close();           
        }
        public int SetServo(int axisid,bool on)
        {
            return  commandCard.SetServo(actCardId,axisid, on);           
        }
        public int GetMotionSts(int axisId,ref int sts)
        {
            return commandCard.GetMotionSts(actCardId, axisId,ref sts);
        }
        public int GetMotionIoSts(int axisId,ref int sts)
        {
            return commandCard.GetMotionIoSts(actCardId, axisId, ref sts);
        }
        public int GetCommandPos(int axisId,ref int pos)
        {
            return commandCard.GetCommandPos(actCardId, axisId, ref pos);
        }
        public int GetMotionPos(int axisId,ref int pos)
        {
            return commandCard.GetCommandPos(actCardId, axisId, ref pos);
        }
        public int GetHome(int axisId)
        {
            return commandCard.SetHome(actCardId, axisId);
        }
        public int Stop(int axisId)
        {
            return commandCard.Stop(actCardId, axisId);
        }
        public int MoveRel(int axisId,int distance,int vel)
        {
            return commandCard.MoveRel(actCardId, axisId, distance, vel);
        }
        public int MoveAbs(int axisId,int postion,int vel)
        {
            return commandCard.MoveRel(actCardId, axisId,postion, vel);
        }
        public int SetMotionPos(int axisId,int pos)
        {
            return commandCard.SetMotionPos(actCardId, axisId, pos);
        }
        public int SetAccAndDec(int axisId,double lead,double  acc,double  dec)
        {
            return commandCard.SetAccAndDec(actCardId, axisId, lead, acc, dec);
        }
        public int GetDi(int channel,int index,ref int data)
        {
            return commandCard.GetDi(actCardId, channel,index, ref data);
        }
        public int GetDo(int channel,int index,ref int data)
        {
            return commandCard.GetDo(channel, actCardId, index, ref data);
        }
        public int SetDo(int channel,int index, ref int data)
        {
            return commandCard.SetDo(actCardId,channel,index,ref data);
        }
    }
}
