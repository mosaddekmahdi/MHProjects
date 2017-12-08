using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS470Project1
{
    public class ResultItem
    {
        public double AmountTaken { get; set; }
        public int ItemId { get; set; }
        public double Weight { get; set; }
        public double Value { get; set; }
        public bool IsContinuous { get; set; }
        public int UpperBound { get; set; }
    }
}
