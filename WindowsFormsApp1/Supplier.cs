using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Supplier
    {
        public int KodeSupplier
        {
            get;
        }
        public string Nama
        {
            get; set;
        }
        public string Kota
        {
            get; set;
        }
        public int CreditDay
        {
            get; set;
        }
        public String JatuhTempo
        {
            get; set;
        }
        public string Keterangan
        {
            get; set;
        }
        public string Phone
        {
            get; set;
        }
        public string Address
        {
            get; set;
        }
        public string Extra
        {
            get; set;
        }

        public Supplier (string date = "", int sid = 0, int creditDay = 0, string name = "", string phone = "", string address = "", string city = "", string notes = "", string extra = "")
        {
            JatuhTempo = date;
            KodeSupplier = sid;
            CreditDay = creditDay;
            Nama = name;
            Phone = phone;
            Address = address;
            Kota = city;
            Keterangan = notes;
            Extra = extra;
        }

        public Supplier (int sid = 0, int creditDay = 0, string name = "", string phone = "", string address = "", string city = "", string notes = "", string extra = "") :
            this ("", sid, creditDay, name, city, notes, extra)
        {

        }

        public Supplier (int sid = 0, string name = "", int creditday = 0)
        {
            KodeSupplier = sid;
            Nama = name;
            CreditDay = creditday;
        }
    }
}
