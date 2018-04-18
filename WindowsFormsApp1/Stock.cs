using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Stock
    {
        public int Id
        {
            get;
        }
        public string Code
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Merk
        {
            get; set;
        }
        public string Color
        {
            get; set;
        }
        public string SizeId
        {
            get; set;
        }
        public string Notes
        {
            get; set;
        }
        public string Unit
        {
            get; set;
        }
        public int Quantity
        {
            get; set;
        }
        public int Colly
        {
            get; set;
        }
        public int Price
        {
            get; set;
        }
        public int SuggestedPrice
        {
            get; set;
        }
        public double Weight
        {
            get; set;
        }
        public string Dimensions
        {
            get; set;
        }
        public string Category
        {
            get; set;
        }
        public string DateList
        {
            get; set;
        }
        public bool Make
        {
            get; set;
        }
        public string Extra
        {
            get; set;
        }
        public string ImageName
        {
            get; set;
        }

        public Stock(int id = 0, string code = "", string name = "", string merk = "", string color = "", string sizeid = "", string notes = "", string unit = "", int quantity = 0,
            int colly = 0, int price = 0, int suggestedPrice = 0, double weight = 0, string dim = "", string category = "", string date = "", bool make = false, string imagename = "", string extra = "")
        {
            Id = id;
            Code = code;
            Name = name;
            Merk = merk;
            Color = color;
            SizeId = sizeid;
            Notes = notes;
            Unit = unit;
            Quantity = quantity;
            Colly = colly;
            Price = price;
            SuggestedPrice = suggestedPrice;
            Weight = weight;
            Dimensions = dim;
            Category = category;
            DateList = date;
            Make = make;
            ImageName = imagename;
            Extra = extra;
        }

        public Stock(string name = "", string imagename = "", int price = 0)
        {
            ImageName = imagename;
            Name = name;
            Price = price;
        }
    }
}
