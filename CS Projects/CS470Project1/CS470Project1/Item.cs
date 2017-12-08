using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS470Project1
{
    public class Item
    {
        public int Weight { get; set; }
        public int Value { get; set; }
        public int UpperBound { get; set; }
        public int Id { get; set; }
        public double Ratio { get; set; }

        public Item(int weight, int value)
        {
            this.Weight = weight;
            this.Value = value;
            this.Ratio = this.Value / (double)this.Weight;
        }
    }
}
