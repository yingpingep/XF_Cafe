using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF_CafeNomad.Model
{
    public class CafeShop
    {
        public string id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public double wifi { get; set; }
        public double seat { get; set; }
        public double quiet { get; set; }
        public double tasty { get; set; }
        public double cheap { get; set; }
        public double music { get; set; }
        public string url { get; set; }
        public string address { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string limited_time { get; set; }
        public string socket { get; set; }
        public string standing_desk { get; set; }
        public string mrt { get; set; }
        public string open_time { get; set; }
    }
}
