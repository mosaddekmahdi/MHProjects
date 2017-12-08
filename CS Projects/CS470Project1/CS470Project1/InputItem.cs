using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS470Project1
{
    public class InputItem
    {
        public List<int> Weights { get; set; }
        public List<int> Values { get; set; }
        public List<int> UpperBounds { get; set; }
        public List<int> IsFractional { get; set; }
        public int Capacity { get; set; }

        public InputItem()
        {
            this.Weights = new List<int>();
            this.Values = new List<int>();
            this.UpperBounds = new List<int>();
            this.IsFractional = new List<int>();
        }
    }
}
