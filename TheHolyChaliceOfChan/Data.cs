using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHolyChaliceOfChan
{
    public class Data
    {
        public string CurPair { get; set; }
        public int OrderMode { get; set; }
        public string OrderModeText { get { return OrderMode == 2 ? "Buy" : "Sell"; }  }
        public double Lot { get; set; }
        public double Price { get; set; }
        public double StopLoss { get; set; }
        public double TakeProfit { get; set; }
        public bool DoOrder { get; set; }
        public int Expiration { get; set; }
    }
}
