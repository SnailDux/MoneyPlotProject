using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPlotProject
{
    public class Rates
    {
        public float EUR { set; get; }
        public float GBP { set; get; }
        public float PLN { set; get; }

    }
    public class Money
    {
        public string disclaimer { set; get; }
        public string license { set; get; }
        public int timestamp { set; get; }
        public string Base { set; get; }
        public Rates Rates { set; get; }

    }


}
