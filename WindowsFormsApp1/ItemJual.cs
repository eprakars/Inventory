using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ItemJual
    {
        public int Id
        {
            get; set;
        }
        public string DateOut
        {
            get; set;
        }
        public int FakturJualId
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
        public string ImageName
        {
            get; set;
        }
        public int Quantity
        {
            get; set;
        }
        public int SellingPrice
        {
            get; set;
        }
        public int BasePrice
        {
            get; set;
        }
        public string Extra
        {
            get; set;
        }
        public int Discount
        {
            get; set; 
        }
        public ItemJual(int id = 0, string dateOut = "", int fid = 0, int sid = 0, string namastock = "", string imagename = "", int quantity = 0, int sellingprice = 0, int baseprice = 0, string extra = "", int discount = 0)
        {
            Id = id;
            DateOut = dateOut;
            FakturJualId = fid;
            StockId = sid;
            NamaStock = namastock;
            ImageName = imagename;
            Quantity = quantity;
            SellingPrice = sellingprice;
            BasePrice = baseprice;
            Extra = extra;
            Discount = discount;
        }
    }
}
