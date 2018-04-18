using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class FakturBeli
    {
        public string Id
        {
            get; set;
        }
        public string Date
        {
            get; set;
        }
        public string JatuhTempo
        {
            get; set;
        }
        public bool Ppn
        {
            get; set;
        }
        public bool CashCredit
        {
            get; set;
        }
        public bool BeliReturn
        {
            get; set;
        }
        public int SupplierId
        {
            get; set;
        }
        public string SupplierName
        {
            get; set;
        }
        public int Discount
        {
            get; set;
        }
        public string DatePajak
        {
            get; set;
        }
        public string NomorPajak
        {
            get; set;
        }
        public string Extra
        {
            get; set;
        }

        public FakturBeli(string id = "", string date = "", string jatuhTempo = "", bool ppn = false, bool cashCredit = false, bool beliReturn = false,
            int supplierId = 0, string suppliername = "", int discount = 0, string datePajak = "", string nomorPajak = "", string extra = "")
        {
            Id = id;
            Date = date;
            JatuhTempo = jatuhTempo;
            Ppn = ppn;
            CashCredit = cashCredit;
            BeliReturn = beliReturn;
            SupplierId = supplierId;
            SupplierName = suppliername;
            Discount = discount;
            DatePajak = datePajak;
            NomorPajak = nomorPajak;
            Extra = extra;
        }
    }
}
