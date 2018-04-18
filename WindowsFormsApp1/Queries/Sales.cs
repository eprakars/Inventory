using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Sales : Base
    {
        public static Dictionary<int, long> GetOmset(SqlConnection conn, int spid = 0)
        {
            Dictionary<int, long> dictionary = new Dictionary<int, long>();
            SqlCommand com = new SqlCommand(QueryString.GetOmsetOrderByMake, conn);
            com.Parameters.Add("@spid", VarChar).Value = spid;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                bool make = bool.Parse(row["_make"].ToString());
                long val = Utilities.GetBigInt(row["_totalOmset"].ToString());
                Utilities.print("{0} and {1}", make, val);
                dictionary.Add(make ? 1 : 0, val);
            }
            return dictionary;

        }

        public static int GetProfit(SqlConnection conn, int spid = 0)
        {
            int res = -1;
            SqlCommand com = new SqlCommand(QueryString.GetProfit, conn);
            com.Parameters.Add("@spid", VarChar).Value = spid;
            res = (int)com.ExecuteScalar();
            return res;
        }

        public static List<SalesPerson> LoadSalesPerson(DataTable data)
        {
            var listSalesPerson = new List<SalesPerson>();
            foreach (DataRow drCurrent in data.Rows)
            {
                    listSalesPerson.Add(new SalesPerson(
                    date : drCurrent["_dateIn"].ToString().Length == 0 ? System.DateTime.Now : System.DateTime.Parse(drCurrent["_dateIn"].ToString()),
                    spid : int.Parse(drCurrent["_spid"].ToString()),
                    status : drCurrent["_extra"].ToString(),
                    name : drCurrent["_salesname"].ToString(),
                    phone : drCurrent["_phone"].ToString(),
                    address : drCurrent["_address"].ToString(),
                    city : drCurrent["_city"].ToString(),
                    komImport : drCurrent["_komImport"].ToString(),
                    komLocal : drCurrent["_komLocal"].ToString(),
                    notes : drCurrent["_notes"].ToString()
                    ));
            }
            return listSalesPerson;
        }

        public static void InsertSalesPerson(SqlConnection conn)
        {
            var salesName = f.SalesNameTextBox.Text.Trim();
            var address = f.SalesAddrTextBox.Text.Trim();
            var city = f.SalesCityTextBox.Text.Trim();
            var phone = f.SalesPhoneTextBox.Text.Trim();
            var notes = f.SalesNotesTextBox.Text.Trim();
            var dateIn = f.SalesDateTimePicker.Text;
            StringBuilder sb = new StringBuilder();
            double val;
            double.TryParse(f.SalesImportATextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesImportBTextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesImportCTextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesImportDTextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesImportETextBox.Text.Trim(), out val);
            sb.Append(val);
            var komImport = sb.ToString();
            sb.Clear();
            double.TryParse(f.SalesLocalATextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesLocalBTextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesLocalCTextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesLocalDTextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesLocalETextBox.Text.Trim(), out val);
            sb.Append(val);
            var komLocal = sb.ToString();
            var spid = Utilities.GetSalesCode(f.SalesCodeLabel.Text, true);

            if (salesName.Equals(""))
            {
                MessageBox.Show("Nama Tidak Boleh Kosong");
                return;
            }

            SqlCommand com = new SqlCommand(QueryString.InsertSalesPerson, conn);
            com.Parameters.Add("@salesName", VarChar).Value = salesName;
            com.Parameters.Add("@address", VarChar).Value = address;
            com.Parameters.Add("@city", VarChar).Value = city;
            com.Parameters.Add("@phone", VarChar).Value = phone;
            com.Parameters.Add("@notes", VarChar).Value = notes;
            com.Parameters.Add("@dateIn", Date).Value = dateIn;
            com.Parameters.Add("@komImport", VarChar).Value = komImport;
            com.Parameters.Add("@komLocal", VarChar).Value = komLocal;
            com.Parameters.Add("@spid", Int).Value = spid;
            com.Parameters.Add("@komTarget", BigInt).Value = 0;
            com.Parameters.Add("@extra", VarChar).Value = "";

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Insert new SalesPerson failed");
                    // throw Exception ?
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }

        public static void UpdateSalesPersonInfo(SqlConnection conn, int idx)
        {
            var salesName = f.SalesNameTextBox.Text.Trim();
            var address = f.SalesAddrTextBox.Text.Trim();
            var city = f.SalesCityTextBox.Text.Trim();
            var phone = f.SalesPhoneTextBox.Text.Trim();
            var notes = f.SalesNotesTextBox.Text.Trim();
            var dateIn = f.SalesDateTimePicker.Text;
            StringBuilder sb = new StringBuilder();
            double val;
            double.TryParse(f.SalesImportATextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesImportBTextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesImportCTextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesImportDTextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesImportETextBox.Text.Trim(), out val);
            sb.Append(val);
            var komImport = sb.ToString();
            sb.Clear();
            double.TryParse(f.SalesLocalATextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesLocalBTextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesLocalCTextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesLocalDTextBox.Text.Trim(), out val);
            sb.Append(val + ":");
            double.TryParse(f.SalesLocalETextBox.Text.Trim(), out val);
            sb.Append(val);
            var komLocal = sb.ToString();
            //var komTarget = Utilities.GetBigInt(f.salestarget)
            var spid = Utilities.GetSalesCode(f.SalesCodeLabel.Text, true);

            SqlCommand com = new SqlCommand(QueryString.UpdateSalesPersonInfo, conn);
            com.Parameters.Add("@salesName", VarChar).Value = salesName;
            com.Parameters.Add("@address", VarChar).Value = address;
            com.Parameters.Add("@city", VarChar).Value = city;
            com.Parameters.Add("@phone", VarChar).Value = phone;
            com.Parameters.Add("@notes", VarChar).Value = notes;
            com.Parameters.Add("@dateIn", Date).Value = dateIn;
            com.Parameters.Add("@komImport", VarChar).Value = komImport;
            com.Parameters.Add("@komLocal", VarChar).Value = komLocal;
            com.Parameters.Add("@spid", Int).Value = spid;

            // try to update db
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Utilities.print("Update SalesPerson({0}) info failed", spid);
                    // throw Exception ?
                    return;
                }
                List<SalesPerson> list = f.salesOLV.Objects.Cast<SalesPerson>().ToList();
                SalesPerson sp = list[idx];
                sp.Alamat = address;
                sp.Date = System.DateTime.Parse(dateIn);
                sp.Keterangan = notes;
                sp.KomImport = komImport;
                sp.KomLocal = komLocal;
                sp.Kota = city;
                sp.Nama = salesName;
                sp.Phone = phone;
                list[idx] = sp;
                f.salesOLV.RefreshObject(sp);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
                return;
            }
        }
    }
}
