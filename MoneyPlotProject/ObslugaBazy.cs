using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MoneyPlotProject
{
    public class ModifiedMoney
    {
        public int ID { set; get; }
        public int timestamp { set; get; }
        public int sampleYear { set; get; }
        public string BASE { set; get; }
        public float EUR { set; get; }
        public float GBP { set; get; }
        public float PLN { set; get; }

    }
    public class MoneyDB : DbContext
    {
        public virtual DbSet<ModifiedMoney> MoneyTbl { get; set; }
    }
}
