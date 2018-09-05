using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS_Define_W32;

namespace XCore
{
    public abstract class XCommandCard
    {
        public virtual int Initial() { return -1; }
        public virtual int Close() { return -1; }
        public virtual int LoadParam(string pXMLFile) { return -1; }
        public virtual int SetServo(int cardId, int axisId, bool on) { return -1; }
        public virtual int GetMotionSts(int cardId, int axisId, ref int sts) { return -1; }
        public virtual int GetMotionIoSts(int cardId, int axisId, ref int sts) { return -1; }
        public virtual int GetCommandPos(int cardId, int axisId, ref int pos) { return -1; }
        public virtual int GetMotionPos(int cardId, int axisId, ref int pos) { return -1; }
        public virtual int SetHome(int cardId, int axisId) { return -1; }
        public virtual int Stop(int cardId, int axisId) { return -1; }
        public virtual int MoveAbs(int cardId, int axisId, int position, int vel) { return -1; }
        public virtual int MoveRel(int cardId, int axisId, int distance, int vel) { return -1; }
        public virtual int SetMotionPos(int cardId, int axisId, int pos) { return -1; }
        public virtual int SetAccAndDec(int cardId, int axisId, double lead, double acc, double dec) { return -1; }
        public virtual int GetDi(int cardId,int channel,int index,ref int data) { return -1; }
        public virtual int GetDo(int cardId,int channel,int index,ref int data) { return -1; }
        public virtual int SetDo(int cardId, int channel,int index, ref int data) { return -1; }
    }
}
