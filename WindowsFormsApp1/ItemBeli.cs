using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ItemBeli
    {
        public int Id
        {
            get; set;
        }
        public string Date
        {
            get; set;
        }
        public int FakturId
        {
            get; set;
        }
        public int StockId
        {
            get; set;
        }

        public string NamaStock
        {
            get; set;
        }

        public int Price
        {
            get; set;
        }
        public string ImageName
        {
            get; set; 
        }
        public int Quantity
        {
            get; set;
        }
        public string Extra
        {
            get; set;
        }

        public ItemBeli (int id = 0, string date = "", int fakturId = 0, int stockId = 0, string namastock = "",int price = 0, string imagename = "", int quantity = 0, string extra = "")
        {
            Id = id;
            Date = date;
            FakturId = fakturId;
            NamaStock = namastock;
            StockId = stockId;
            Price = price;
            ImageName = imagename;
            Quantity = quantity;
            Extra = extra;
        }
    }
}
