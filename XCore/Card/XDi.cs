using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCore
{
    public class XDi
    {
        private XCard card;
        private int actDiId;
        private string name;
        private bool m_sts;
        private int channel;
        private string cardName;
        private Object obj = new Object();
        public int ActDiId { get { return actDiId; } }
        public string Name { get { return name; } }
        public int Channel { get { return channel; } }
        public bool M_STS { get { return m_sts; } }
        
        public XDi(XCard card,int actDiId,int channel,string name,string cardName)
        {
            this.card = card;
            this.actDiId = actDiId;
            this.channel = channel;
            this.name = name;
            this.cardName = cardName;
        }
        public void update()
        {
            lock(obj)
            {
                int data = 0;
                card.GetDi(channel, actDiId, ref data);
                m_sts = XConvert.BitEnable(data, actDiId);
            }
        }
        public int GetDi(ref int data)
        {
            return card.GetDi(channel,actDiId, ref data);
        }
        //public int Update()
        //{
        //    int sts = 0;
        //    int ret = GetDi(ref sts);
        //    if ()
            

        //}
    }
}
