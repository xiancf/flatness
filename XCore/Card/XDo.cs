using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCore
{
   public  class XDo
    {
        private XCard card;
        private int actDoId;
        private string name;

        private bool m_sts;
        private int channel;
        private string cardName;

        private Object obj = new object();
        public int ActDoId { get { return actDoId; } }
        public string Name { get { return name; } }
        public bool M_STS
        {
            
            get
            {
                lock (obj)
                {
                    return m_sts;
                }
            }
            set
            {
                m_sts = value;
            }
        }
        
        public void Qufa()       //取反
        {
            lock(obj)
            {
                int data = 0;
                GetDo(ref data);
                XConvert.SetBits(ref data, actDoId);
                card.SetDo(channel, actDoId, ref data);
            }
        }
        public int  GetDo(ref int data)
        {
            return card.GetDo(channel, actDoId, ref data);
        }
        public void SetDo(bool b)
        {

        }
        public void Update()
        {
            lock(obj)
            {
                int data = 0;
                int ret = GetDo(ref data);
                m_sts = XConvert.BitEnable(data, actDoId);
            }
            
        }
        //public 
       
        public int Channel { get { return channel; } }
        public XDo(XCard card,int actDoId,int channel,string name,string cardName)
        {
            this.card = card;
            this.actDoId = actDoId;
            this.name = name;
            this.channel = channel;
            this.cardName = cardName;
        }
    }
}
