using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Piutang
    {
        public string Nama
        {
            get; set;
        }
        public int NoFaktur
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
        public int KodeSales
        {
            get; set;
        }
        public string Kota
        {
            get; set;
        }
        public int TotalPiutang
        {
            get; set;
        }
        public Piutang(string nama = "", int nofaktur = 0, string date = "", string jatuhtempo = "", int kodesales = 0, string kota = "", int totalpiutang = 0)
        {
            Nama = nama;
            NoFaktur = nofaktur;
            Date = date;
            JatuhTempo = jatuhtempo;
            KodeSales = kodesales;
            Kota = kota;
            TotalPiutang = totalpiutang;
        }
    }
}
