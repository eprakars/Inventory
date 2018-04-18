using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class FakturB : Base
    {
        public static void UpdateFakturBeli(SqlConnection conn, int idx)
        {
            var Id = Utilities.GetNoFaktur(f.FakturBeliNoFakturTextBox.Text);     // Parse Code here
            var jatuhTempo = Utilities.GetDateNow();
            var ppn = f.FakturBeliPPNCheckBox.Checked ? 1 : 0;
            var cashCredit = f.FakturBeliCashKreditComboBox.SelectedIndex;
            var beliReturn = f.FakturBeliBeliReturnComboBox.SelectedIndex;
            var sid = Utilities.GetSupplierCode(f.FakturBeliKodeSuppTextBox.Text);
            var discount = 0;   // ?
            var nomorPajak = f.FakturBeliNoPajakTextBox.Text;
            var datePajak = Utilities.ChangeDateFormatToyyyyMMdd(f.FakturBeliTanggalPajakDatePicker.Value.ToString());
            var extra = "";
            SqlCommand com = new SqlCommand(QueryString.UpdateFakturBeli, conn);
            //com.Parameters.Add("@jatuhTempo", Date).Value = jatuhTempo;
            com.Parameters.Add("@ppn", Bit).Value = ppn;
            com.Parameters.Add("@cashCredit", Bit).Value = cashCredit;
            com.Parameters.Add("@beliReturn", Bit).Value = beliReturn;
            com.Parameters.Add("@sid", Int).Value = sid;
            com.Parameters.Add("@discount", Int).Value = discount;
            com.Parameters.Add("@nomorPajak", VarChar).Value = nomorPajak;
            com.Parameters.Add("@datePajak", Date).Value = datePajak;
            com.Parameters.Add("@extra", VarChar).Value = extra;
            com.Parameters.Add("@id", Int).Value = Id;

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Update FakturBeli failed");
                    // throw Exception ?
                    return;
                }
                List<FakturBeli> list = f.FakturBeliOLV.Objects.Cast<FakturBeli>().ToList();
                FakturBeli fb = list[idx];
                fb.Id = fb.Id = beliReturn == 1 ? "R" + Id : "B" + Id;
                fb.CashCredit = cashCredit == 1;
                fb.BeliReturn = beliReturn == 1;
                fb.DatePajak = datePajak;
                fb.Discount = discount;
                fb.Extra = extra;
                //fb.JatuhTempo = jatuhTempo;
                fb.NomorPajak = nomorPajak;
                fb.Ppn = ppn == 1;
                fb.SupplierId = sid;
                f.FakturBeliOLV.RefreshObject(fb);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }

        public static void InsertFakturBeli(SqlConnection conn)
        {
            var date = Utilities.GetDateNow();
            var sid = Utilities.GetSupplierCode(f.FakturBeliKodeSuppTextBox.Text);
            var jatuhTempo = System.DateTime.Now.AddDays(Supply.GetCreditDay(conn, sid));
            var ppn = f.FakturBeliPPNCheckBox.Checked ? 1 : 0;
            var cashCredit = f.FakturBeliCashKreditComboBox.SelectedIndex;
            var beliReturn = f.FakturBeliBeliReturnComboBox.SelectedIndex;
            var discount = 0;   // ?
            var nomorPajak = f.FakturBeliNoPajakTextBox.Text;
            var datePajak = Utilities.ChangeDateFormatToyyyyMMdd(f.FakturBeliTanggalPajakDatePicker.Value.ToString());
            var extra = "";
            var Id = Utilities.GetNoFaktur(f.FakturBeliNoFakturTextBox.Text);
            SqlCommand com = new SqlCommand(QueryString.InsertFakturBeli, conn);
            com.Parameters.Add("@id", Int).Value = Id;
            com.Parameters.Add("@date", Date).Value = date;
            com.Parameters.Add("@jatuhTempo", Date).Value = jatuhTempo;
            com.Parameters.Add("@ppn", Bit).Value = ppn;
            com.Parameters.Add("@cashCredit", Bit).Value = cashCredit;
            com.Parameters.Add("@beliReturn", Bit).Value = beliReturn;
            com.Parameters.Add("@sid", Int).Value = sid;
            com.Parameters.Add("@discount", Int).Value = discount;
            com.Parameters.Add("@nomorPajak", VarChar).Value = nomorPajak;
            com.Parameters.Add("@datePajak", Date).Value = datePajak;
            com.Parameters.Add("@extra", VarChar).Value = extra;

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Insert new FakturBeli failed");
                    // throw Exception ?
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }
        public static List<FakturBeli> LoadFakturBeli(DataTable data)
        {
            List<FakturBeli> list = new List<FakturBeli>();
            foreach (DataRow drCurrent in data.Rows)
            {

                list.Add(new FakturBeli(
                id: Utilities.ParseBoolean(drCurrent["_beliReturn"].ToString()) ? "R" + drCurrent["_idBeli"].ToString() : "B" + drCurrent["_idBeli"].ToString()
                , jatuhTempo: drCurrent["_jatuhTempo"] == null ? "" : Utilities.ConvertDateToString(drCurrent["_jatuhTempo"])
                , ppn: Utilities.ParseBoolean(drCurrent["_ppn"].ToString())
                , cashCredit: Utilities.ParseBoolean(drCurrent["_cashCredit"].ToString())
                , beliReturn: Utilities.ParseBoolean(drCurrent["_beliReturn"].ToString())
                , suppliername: drCurrent["_name"].ToString()
                , supplierId: Utilities.GetInt(drCurrent["_sid"].ToString())
                , discount: Utilities.GetInt(drCurrent["_discount"].ToString())
                , datePajak: drCurrent["_datePajak"] == null ? "" : Utilities.ConvertDateToString(drCurrent["_datePajak"])
                , nomorPajak: drCurrent["_noPajak"].ToString()
                , extra: drCurrent["_extra"].ToString()
                , date: drCurrent["_date"] == null ? "" : Utilities.ConvertDateToString(drCurrent["_date"])
                ));
            }
            return list;
        }
    }
}
