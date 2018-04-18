using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Customer
    {
        public int KodeCustomer
        {
            get;
        }
        public string Nama
        {
            get; set;
        }
        public string NamaSales
        {
            get; set;
        }
        public int SalesID
        {
            get; set;
        }
        public string Kota
        {
            get; set;
        }
        public string Alamat1
        {
            get; set;
        }
        public string Alamat2
        {
            get; set;
        }
        public string TelpFax
        {
            get; set;
        }
        public string Keterangan
        {
            get; set;
        }
        public int LamaKredit
        {
            get; set;
        }
        public bool Marketibility
        {
            get; set;
        }
        public string JatuhTempo
        {
            get; set;
        }
        public Int64 NoNPWP
        {
            get; set;
        }
        public string NamaNPWP
        {
            get; set;
        }
        public string AlamatNPWP
        {
            get; set;
        }
        public Int64 SJ1
        {
            get; set;
        }
        public Int64 SJ2
        {
            get; set;
        }
        public Int64 SJ3
        {
            get; set;
        }
        public Int64 R1
        {
            get; set;
        }
        public Int64 R2
        {
            get; set;
        }
        public Int64 R3
        {
            get; set;
        }
        public Int64 Piutang
        {
            get; set;
        }
        public Int64 TotalReturn
        {
            get; set;
        }
        public bool Recent
        {
            get; set;
        }


        public Customer(
            int cid = 0,
            string name = "",
            string namasales = "",
            int salesid = 0,
            string city = "",
            string alamat1 = "",
            string alamat2 = "",
            string telpfax = "",
            string keterangan = "",
            int lamakredit = 0,
            bool marketibility = false,
            string jatuhtempo = "",
            Int64 nonpwp = 0,
            string namanpwp = "",
            string alamatnpwp = "",
            Int64 sj1 = 0,
            Int64 sj2 = 0,
            Int64 sj3 = 0,
            Int64 r1 = 0,
            Int64 r2 = 0,
            Int64 r3 = 0,
            Int64 piutang = 0,
            Int64 totalreturn = 0,
            bool recent = false)
        {
            KodeCustomer = cid;
            Nama = name;
            NamaSales = namasales;
            SalesID = salesid;
            Kota = city;
            Alamat1 = alamat1;
            Alamat2 = alamat2;
            TelpFax = telpfax;
            Keterangan = keterangan;
            LamaKredit = lamakredit;
            Marketibility = marketibility;
            JatuhTempo = jatuhtempo;
            NoNPWP = nonpwp;
            NamaNPWP = namanpwp;
            AlamatNPWP = alamatnpwp;
            SJ1 = sj1;
            SJ2 = sj2;
            SJ3 = sj3;
            R1 = r1;
            R2 = r2;
            R3 = r3;
            Piutang = piutang;
            TotalReturn = totalreturn;
            Recent = recent;
        }

        public Customer(int cid = 0, string nama = "", int spid = 0, string namasales = "", int lamakredit = 0)
        {
            KodeCustomer = cid;
            Nama = nama;
            NamaSales = namasales;
            SalesID = spid;
            LamaKredit = lamakredit;
        }

    }
}
