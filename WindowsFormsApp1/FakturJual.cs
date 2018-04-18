using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class FakturJual
    {
        public string Id
        {
            get; set;
        }
        public string Date
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
        public bool JualReturn
        {
            get; set;
        }
        public int Cid
        {
            get; set;
        }
        public string CustomerName
        {
            get; set;
        }
        public int KodeSales
        {
            get;set;
        }
        public string JatuhTempo
        {
            get; set;
        }
        public string LunasDate
        {
            get; set;
        }
        public string Extra
        {
            get; set;
        }
        public int Terbayar
        {
            get; set;
        }
        public FakturJual(string id = "", string date = "", bool ppn = false, bool cashCredit = false, bool jualReturn = false, int cid = 0, string customername = "",
            int spid = 0, string jatuhTempo = "", string lunasDate = "", string extra = "", int terbayar = 0)
        {
            Id = id;
            Date = date;
            Ppn = ppn;
            CashCredit = cashCredit;
            JualReturn = jualReturn;
            Cid = cid;
            CustomerName = customername;
            KodeSales = spid;
            JatuhTempo = jatuhTempo;
            LunasDate = lunasDate;
            Extra = extra;
        }
    }
}
