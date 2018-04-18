using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class FakturJ : Base
    {
        public static List<FakturJual> LoadFakturJual(DataTable data)
        {
            List<FakturJual> list = new List<FakturJual>();
            foreach (DataRow drCurrent in data.Rows)
            {
                list.Add(new FakturJual(
                id: Utilities.ParseBoolean(drCurrent["_jualReturn"].ToString()) ? "R" + drCurrent["_idJual"].ToString() : "J" + drCurrent["_idJual"].ToString()
                , jatuhTempo: drCurrent["_jatuhTempo"] == null ? "" : Utilities.ConvertDateToString(drCurrent["_jatuhTempo"])
                , ppn: Utilities.ParseBoolean(drCurrent["_ppn"].ToString())
                , cashCredit: Utilities.ParseBoolean(drCurrent["_cashCredit"].ToString())
                , jualReturn: Utilities.ParseBoolean(drCurrent["_jualReturn"].ToString())
                , cid: Utilities.GetInt(drCurrent["_cid"].ToString())
                , customername: drCurrent["_name"].ToString()
                , spid: Utilities.GetInt(drCurrent["_spid"].ToString())
                , lunasDate: drCurrent["_tanggalLunas"] == null ? "" : Utilities.ConvertDateToString(drCurrent["_tanggalLunas"])
                , extra: drCurrent["_extra"].ToString()
                , date: drCurrent["_date"] == null ? "" : Utilities.ConvertDateToString(drCurrent["_date"])
                ));
            }
            return list;
        }

        public static void UpdateFakturJual(SqlConnection conn, int idx)
        {
            var Id = Utilities.GetNoFaktur(f.FakturJualNoFakturTextBox.Text);     // Parse Code here
            var jatuhTempo = Utilities.ChangeDateFormatToyyyyMMdd(f.FakturJualJthTempoTextBox.Text);
            var ppn = f.FakturJualPPNCheckBox.Checked ? 1 : 0;
            var cashCredit = f.FakturJualCashKreditComboBox.SelectedIndex;
            var jualReturn = f.FakturJualJualReturnComboBox.SelectedIndex;
            var cid = Utilities.GetCustomerCode(f.FakturJualKodeCustomerTextBox.Text);
            var LunasDate = Utilities.ChangeDateFormatToyyyyMMdd(f.FakturJualTanggalLunasTextBox.Text);
            var extra = "";
            SqlCommand com = new SqlCommand(QueryString.UpdateFakturJual, conn);
            com.Parameters.Add("@jatuhTempo", Date).Value = jatuhTempo;
            com.Parameters.Add("@ppn", Bit).Value = ppn;
            com.Parameters.Add("@cashCredit", Bit).Value = cashCredit;
            com.Parameters.Add("@jualReturn", Bit).Value = jualReturn;
            com.Parameters.Add("@cid", Int).Value = cid;
            com.Parameters.Add("@extra", VarChar).Value = extra;
            com.Parameters.Add("@id", Int).Value = Id;
            if (LunasDate.Length == 0)
            {
                com.Parameters.Add("@lunasDate", Date).Value = DBNull.Value;
            }
            else
            {
                com.Parameters.Add("@lunasDate", Date).Value = LunasDate;
            }

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Update FakturJual failed");
                    // throw Exception ?
                    return;
                }
                List<FakturJual> list = f.FakturJualOLV.Objects.Cast<FakturJual>().ToList();
                FakturJual fj = list[idx];
                fj.CashCredit = cashCredit == 1;
                fj.JualReturn = jualReturn == 1;
                fj.Extra = extra;
                fj.JatuhTempo = Utilities.ChangeDateFormatToDDDMMMDDyyyy(jatuhTempo);
                fj.Ppn = ppn == 1;
                fj.Id = jualReturn == 1 ? "R" + Id : "J" + Id;

                fj.CustomerName = Customers.GetCustomerNameFromId(conn, cid);
                f.FakturJualOLV.RefreshObject(fj);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }
        public static void InsertFakturJual(SqlConnection conn)
        {
            var date = Utilities.GetDateNow();
            var jatuhTempo = Utilities.ChangeDateFormatToyyyyMMdd(f.FakturJualJthTempoTextBox.Text);
            var ppn = f.FakturJualPPNCheckBox.Checked ? 1 : 0;
            var cashCredit = f.FakturJualCashKreditComboBox.SelectedIndex;
            var jualReturn = f.FakturJualJualReturnComboBox.SelectedIndex;
            var cid = Utilities.GetCustomerCode(f.FakturJualKodeCustomerTextBox.Text);
            var Id = Utilities.GetNoFaktur(f.FakturJualNoFakturTextBox.Text);
            var LunasDate = Utilities.ChangeDateFormatToyyyyMMdd(f.FakturJualTanggalLunasTextBox.Text);

            var extra = "";
            
            SqlCommand com = new SqlCommand(QueryString.InsertFakturJual, conn);
            //SqlTransaction transaction = conn.BeginTransaction(IsolationLevel.Serializable);
            com.Parameters.Add("@id", Int).Value = Id;
            com.Parameters.Add("@date", Date).Value = date;
            com.Parameters.Add("@jatuhTempo", Date).Value = jatuhTempo;
            com.Parameters.Add("@ppn", Bit).Value = ppn;
            com.Parameters.Add("@cashCredit", Bit).Value = cashCredit;
            com.Parameters.Add("@jualReturn", Bit).Value = jualReturn;
            com.Parameters.Add("@cid", Int).Value = cid;

            if (LunasDate.Length == 0)
            {
                com.Parameters.Add("@lunasDate", Date).Value = DBNull.Value;
            }
            else
            {
                com.Parameters.Add("@lunasDate", Date).Value = LunasDate;
            }
            
            com.Parameters.Add("@extra", VarChar).Value = extra;

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Insert new FakturJual failed");
                    // throw Exception ?
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }
    }
}
