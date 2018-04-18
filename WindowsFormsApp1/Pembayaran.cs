using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Pembayaran
    {
        public string NoGiro
        {
            get;
        }
        public string TanggalGiro
        {
            get;set;
        }
        public string NamaBank
        {
            get; set;
        }
        public string NoRek
        {
            get; set;
        }
        public string JatuhTempo
        {
            get; set;
        }
        public int Amount
        {
            get;set;
        }
        public int Sisa
        {
            get;set;
        }
        public int KodeCustomer
        {
            get; set;
        }
        public string NamaCustomer
        {
            get;set;
        }
        public string NoFaktur
        {
            get; set;
        }
        public bool SudahCair
        {
            get; set;
        }
        public string Keterangan
        {
            get; set;
        }
        public string Extra
        {
            get; set;
        }

        public Pembayaran(string nogiro = "",
            string tanggalgiro = "",
            string namabank = "",
            string norek = "",
            string jatuhtempo = "",
            int amount = 0,
            int sisa = 0,
            int kodecustomer = 0,
            string namacustomer = "",
            string nofaktur = "",
            bool sudahcair = false,
            string keterangan = "",
            string extra = "")
        {
            NoGiro = nogiro;
            TanggalGiro = tanggalgiro;
            NamaBank = namabank;
            NoRek = norek;
            JatuhTempo = jatuhtempo;
            Amount = amount;
            Sisa = sisa;
            KodeCustomer = kodecustomer;
            NamaCustomer = namacustomer;
            NoFaktur = nofaktur;
            SudahCair = sudahcair;
            Keterangan = keterangan;
            Extra = extra;
        }

    }
}
