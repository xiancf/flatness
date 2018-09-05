using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace XCore
{
  public class XDevice
    {
        private Dictionary<int, XCard> cardMap = new Dictionary<int, XCard>();
        private Dictionary<int, XAxis> axisMap = new Dictionary<int, XAxis>();
        private Dictionary<int, XDo> doMap = new Dictionary<int, XDo>();
        private Dictionary<int, XDi> diMap = new Dictionary<int, XDi>();
        private Dictionary<int, XChannelValue> channelValueMap = new Dictionary<int, XChannelValue>();
        public Dictionary<int,XCard> CardMap { get { return cardMap; } }
        public Dictionary<int, XDi> DiMap { get { return diMap; } }
        public Dictionary<int,XDo> DoMap { get { return doMap; } }

        private static XDevice instance=new XDevice ();
        public static XDevice Instance { get { return instance; } }

        public void BindCard(int setCardId,int actCardId,XCommandCard commandCard,string name)
        {
            if (cardMap.ContainsKey(setCardId)==false )
            {
                XCard card = new XCore.XCard(actCardId, commandCard, name);
                cardMap.Add(setCardId, card);
            }
        }
        public void BindAxis(int setCardId,int setAxisId,int actAxisId,double lead,XAxisDirection dir, string name)
        {
            if (cardMap.ContainsKey(setCardId) == true)
            {
                if (axisMap.ContainsKey(setAxisId) == false)
                {
                    XAxis axis = new XCore.XAxis(cardMap [setCardId], actAxisId, lead, name);                 
                    axisMap.Add(setAxisId, axis);
                }
            }
        }
        public void BindDi(int setCardId,int setDiId,int actDiId, int channel, string name,string cardName)
        {
            if (diMap .ContainsKey(setDiId)==false )
            {
                XDi di = new XCore.XDi(cardMap[setCardId], actDiId, channel, name, cardName);
                
                diMap.Add(setDiId, di);
            }
        }
        public void BingDo(int setCardId,int setDoId,int actDoId,int channel,string name,string cardName)
        {
            if (doMap.ContainsKey(setDoId)==false)
            {
                XDo xdo = new XCore.XDo(cardMap[setCardId], actDoId, channel,name, cardName);
                doMap.Add(setDoId, xdo);
            }
        }
        public XAxis FindAxisById(int setAxisId)
        {
            return axisMap[setAxisId];
        }
    }
}
