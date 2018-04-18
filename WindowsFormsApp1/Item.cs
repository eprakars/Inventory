using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Item
    {
        public int IID
        {
            get;
        }
        public string Name
        {
            get; set;
        }
        public int Quantity
        {
            get; set;
        }
        public string Dimensions
        {
            get; set;
        }
        public double Weight
        {
            get; set;
        }
        public double PriceIn
        {
            get; set;
        }
        public double PriceOut
        {
            get; set;
        }

        public Item(int iid, string name = "", int quantity = 0, double weight = 0, double pricein = 0, double priceout = 0, string dim = "")
        {
            IID = iid;
            Name = name;
            Quantity = quantity;
            Weight = weight;
            PriceIn = pricein;
            PriceOut = priceout;
            Dimensions = dim;
        }
    }
}
