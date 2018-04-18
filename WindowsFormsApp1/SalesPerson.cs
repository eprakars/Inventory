using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SalesPerson
    {
        public int KodeSales
        {
            get;
        }
        public string Nama
        {
            get; set;
        }
        public string Alamat
        {
            get; set;
        }
        public string Keterangan
        {
            get; set;
        }
        public string Kota
        {
            get; set;
        }
        public Int64 Profit
        {
            get; set;
        }
        public Int64 Omset
        {
            get; set;
        }
        public Int64 JumlahTagih
        {
            get; set;
        }
        public Int64 JumlahReturn
        {
            get; set;
        }
        public string KomImport
        {
            get; set;
        }
        public string KomLocal
        {
            get; set;
        }
        public string Phone
        {
            get; set;
        }
        public string Status
        {
            get; set;
        }
        public DateTime Date
        {
            get; set;
        }
        public int Discount
        {
            get; set;
        }


        public SalesPerson(DateTime date, int spid = -1, string status = "", string name = "", string phone = "", 
            string address = "", string city = "", string komImport = "", string komLocal = "", string notes = "")
        {
            KodeSales = spid;
            Status = status;
            Date = date;
            Nama = name;
            Phone = phone;
            Alamat = address;
            Kota = city;
            KomImport = komImport;
            KomLocal = komLocal;
            Keterangan = notes;
        }
        public SalesPerson(int spid = -1, string status = "",
             string name = "", string phone = "", string address = "", string city = "", string komImport = "", string komLocal = "", string notes = "") : this(DateTime.Now,
                 spid, status, name, phone, address, city, komImport, komLocal, notes)
        {

        }

        public SalesPerson(int spid = 0, string name = "")
        {
            KodeSales = spid;
            Nama = name;
        }
    }
}
