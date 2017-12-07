using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic
{
    class LimitValues
    {
        public LimitValues()
        {
            PulsUpper = 100;
            PulsLower = 50;
            DiaUpper = 110;
            DiaLower = 50;
            SysUpper = 180;
            SysLower = 100;
        }
        public double ZPAVolt { get; set; }
        public int PulsUpper { get; set; }
        public int PulsLower { get; set; }
        public int DiaUpper { get; set; }
        public int DiaLower { get; set; }
        public int SysUpper { get; set; }
        public int SysLower { get; set; }

        


    }
}
