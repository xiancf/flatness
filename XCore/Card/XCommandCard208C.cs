using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using XCore;
using APS168_W32;
using APS_Define_W32;

namespace XCore
{
    public class XCommandCard208C : XCommandCard
    {

        Object obj = new Object();
        public override int Initial()
        {
            lock (obj)
            {
                int boardId = 0;
                int mode = 0;
                int ret = APS168.APS_initial(ref boardId, mode);
                if (ret != 0)
                {
                    return ret;
                }
                return boardId;
            }
        }
        public override int Close()
        {
            lock (obj)
            {
                return APS168.APS_close();
            }
        }
        public override int LoadParam(string pXMLFile)
        {
            lock (obj)
            {

               if(!File.Exists(pXMLFile))
                {
                    return -1;
                }

                int ret = APS168.APS_load_param_from_file(pXMLFile);
                return ret;
            }
        }
        public override int SetServo(int cardid, int axisId, bool on)
        {
            if (on)
            {
                return APS168.APS_set_servo_on(axisId, 1);
            }
            return APS168.APS_set_servo_on(axisId, 0);
        }
        public override int GetMotionIoSts(int cardId, int axisId, ref int sts)
        {
            int _sts, _rSts;
            _sts = APS168.APS_motion_io_status(axisId);
            _rSts = 0;
            if(XConvert.BitEnable(_sts,XAPS_Define.MIO_ALM ))
            {
                XConvert.SetBits(ref _rSts, XAPS_Define.MIO_ALM);
            }
            if (XConvert .BitEnable (_sts,XAPS_Define.MIO_EMG))
            {
                XConvert.SetBits(ref _rSts, XAPS_Define.MIO_MEL);
            }
            if (XConvert.BitEnable(_sts ,XAPS_Define.MIO_ORG))
            {
                XConvert.SetBits(ref _rSts, XAPS_Define.MIO_ORG);
            }
            if (XConvert.BitEnable(_sts, XAPS_Define.MIO_PEL))
            {
                XConvert.SetBits(ref _rSts, XAPS_Define.MIO_PEL);
            }
            if (XConvert.BitEnable(_sts, XAPS_Define.MIO_SVON))
            {
                XConvert.SetBits(ref _rSts, XAPS_Define.MIO_SVON);
            }
            sts = _rSts;
            return 0;
        }
        public override int GetMotionSts(int cardId, int axisId, ref int sts)
        {
            int _sts, _rSts;
            _sts = APS168.APS_motion_status(axisId);
            _rSts = 0;
            if (XConvert.BitEnable(_sts,XAPS_Define.MTS_ASTP))
            {
                XConvert.SetBits(ref _rSts, XAPS_Define.MTS_ASTP);
            }
            if (XConvert.BitEnable(_sts, XAPS_Define.MTS_HMV)) 
            {
                XConvert.SetBits(ref _rSts, XAPS_Define.MTS_HMV);
            }
            if (XConvert.BitEnable(_sts,XAPS_Define.MTS_MDN))
            {
                XConvert.SetBits(ref _rSts, XAPS_Define.MTS_MDN);
            }
            sts = _rSts;
            return 0;
        }
        public override int GetCommandPos(int cardId, int axisId, ref int pos)
        {
            return APS168.APS_get_command(axisId, ref pos);
        }
        public override int GetMotionPos(int cardId, int axisId, ref int pos)
        {
            return APS168.APS_get_position(axisId, ref pos);
        }
        public override int SetHome(int cardId, int axisId)
        {
            return APS168.APS_home_move(axisId);
        }
        public override int Stop(int cardId, int axisId)
        {
            return APS168.APS_stop_move(axisId);
        }
        public override int MoveRel(int cardId, int axisId, int distance, int vel)
        {
            return APS168.APS_relative_move(axisId, distance, vel);
        }
        public override int MoveAbs(int cardId, int axisId, int pos, int vel)
        {
            return APS168.APS_absolute_move(axisId, pos, vel);
        }
        public override int SetMotionPos(int cardId, int axisId, int pos)
        {
            return APS168.APS_set_position(axisId, pos);
        }
        public override int SetAccAndDec(int cardId, int axisId,double lead, double  acc, double  dec)
        {
            int ret = 0;
            ret = APS168.APS_set_axis_param_f(cardId, (int)APS_Define.PRA_ACC, XConvert.MM_PULS(acc, lead));
            if (ret!=0)
            {
                return ret;
            }
            return APS168.APS_set_axis_param_f(cardId, (int)APS_Define.PRA_DEC, XConvert.MM_PULS(dec, lead));
        }
        public override int GetDi(int cardId, int channel, int index,ref int data)
        {
            lock(obj)
            {
                return APS168.APS_read_d_input(cardId, channel, ref data);
            }
        }
        public override int GetDo(int cardId, int channel, int index, ref int data)
        {
            lock (obj)
            {
                return APS168.APS_read_d_output(cardId, channel, ref data);
            }
        }
        public override int SetDo(int cardId, int channel,int index, ref int data)
        {
            lock(obj)
            {
                return APS168.APS_write_d_output(cardId, channel, data);
            }
        }
    }
}
