using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Payment : Base
    {
        public static void UpdatePembayaran(SqlConnection conn, int idx)
        {
            var Id = Utilities.GetNoFaktur(f.FakturBeliNoFakturTextBox.Text);     // Parse Code here
            SqlCommand com = new SqlCommand(QueryString.UpdateFakturBeli, conn);
            //com.Parameters.Add("@jatuhTempo", Date).Value = jatuhTempo;
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
                fb.Id = fb.Id = "R" + Id;
                f.FakturBeliOLV.RefreshObject(fb);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }

        public static void InsertPembayaran(SqlConnection conn)
        {
            var noGiro = f.PembayaranNoGiroTextBox.Text.Trim();
            var tanggalGiro = f.PembayaranTglGiroDatePicker.Text;
            var namaBank = f.PembayaranNamaBankTextBox.Text.Trim();
            var noRek = f.PembayaranNoRekTextBox.Text.Trim();
            var jthTempo = f.PembayaranJthTempoDatePicker.Text;
            var amount = Utilities.GetInt(f.PembayaranNilaiTextBox.Text.Trim());
            //var sisa = Utilities.GetInt(f.)
            //var discount = Utilities.GetInt(f.pembayarandis)
            var cid = Utilities.GetCustomerCode(f.PembayaranKodeCustTextBox.Text);
            var noFaktur = f.PembayaranNoFakturComboBox1.Text.Trim() + ":" +
                           f.PembayaranNoFakturComboBox2.Text.Trim() + ":" +
                           f.PembayaranNoFakturComboBox3.Text.Trim() + ":" +
                           f.PembayaranNoFakturComboBox4.Text.Trim();
            var sudahCair = f.PembayaranSudahCairComboBox.Text == "Y" ? 1 : 0 ;
            var keterangan = f.PembayaranKeteranganTextBox.Text.Trim();
            var extra = "";

            SqlCommand com = new SqlCommand(QueryString.InsertPembayaran, conn);
            com.Parameters.Add("@nogiro", VarChar).Value = noGiro;
            com.Parameters.Add("@dategiro", Date).Value = tanggalGiro;
            com.Parameters.Add("@namabank", VarChar).Value = namaBank;
            com.Parameters.Add("@norek", VarChar).Value = noRek;
            com.Parameters.Add("@jatuhtempo", Date).Value = jthTempo;
            com.Parameters.Add("@amount", Int).Value = amount;
            com.Parameters.Add("@sisa", Int).Value = 0;
            com.Parameters.Add("@cid", Int).Value = cid;
            com.Parameters.Add("@nofaktur", VarChar).Value = noFaktur;
            com.Parameters.Add("@sudahcair", Bit).Value = sudahCair;
            com.Parameters.Add("@keterangan", VarChar).Value = keterangan;
            com.Parameters.Add("@extra", VarChar).Value = extra;

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Insert new Pembayaran failed");
                    // throw Exception ?
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }
        public static List<Pembayaran> LoadPembayaran(DataTable data)
        {
            List<Pembayaran> list = new List<Pembayaran>();

            foreach (DataRow drCurrent in data.Rows)
            {
                list.Add(new Pembayaran(
                nogiro: drCurrent["_nogiro"].ToString()
                , tanggalgiro: Utilities.ChangeDateFormatToDDDMMMDDyyyy(drCurrent["_dategiro"].ToString())
                , namabank: drCurrent["_namaBank"].ToString()
                , norek: drCurrent["_norek"].ToString()
                , jatuhtempo: drCurrent["_jatuhTempo"].ToString()
                , amount: Utilities.GetInt(drCurrent["_amount"].ToString())
                , sisa: Utilities.GetInt(drCurrent["_sisa"].ToString())
                , kodecustomer: Utilities.GetInt(drCurrent["_cid"].ToString())
                , namacustomer: drCurrent["_name"].ToString()
                , nofaktur: drCurrent["_nofaktur"].ToString()
                , sudahcair: Utilities.ParseBoolean(drCurrent["_sudahCair"].ToString())
                , keterangan: drCurrent["_keterangan"].ToString()
                , extra: drCurrent["_extra"].ToString()
                ));
            }
            return list;
        }

        public static List<FakturJual> LoadFakturJualFromCid(SqlConnection conn, int cid)
        {
            List<FakturJual> list = new List<FakturJual>();

            SqlCommand com = new SqlCommand(QueryString.GetFakturJualFromCid, conn);
            com.Parameters.Add("@customerid", Int).Value = cid;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new FakturJual(
                    id: row["_idjual"].ToString()));
            }
            return list;
        }

    }
}
