using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCore
{
    class XConvert
    {
        public static bool BitEnable(int word,int bits) 
        {
            return (word & 1<<bits) != 0;
        }
        public static void SetBits(ref int word,int bits)      
        {
            if (BitEnable(word, bits))
            {
                word = (word & ~(1 << bits));

            }
            else
            {
                word = word | (1 << bits);
            }
        }
        public static int MM_PULS(double MM,double lead)     //根据距离mm换算脉冲数量
        {
            return Convert.ToInt32((MM * 10000) / lead);
        }
        public static double  PULS_MM(int PULS,double lead)         //根据脉冲数量换算距离
        {
            return PULS / 10000 * lead;
        }
    }
}
