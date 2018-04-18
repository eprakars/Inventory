using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    class Customers : Base
    {
        internal static string GetCustomerJatuhTempo(SqlConnection conn, int id = 0)
        {
            StringBuilder res = new StringBuilder();
            SqlCommand com = new SqlCommand(QueryString.FakturJualJatuhTempoFromCustomer, conn);
            com.Parameters.Add("@customerid", VarChar).Value = id;
            res.Append(com.ExecuteScalar().ToString());
            return res.ToString();
        }
        public static string GetCustomerNameFromId(SqlConnection conn, int id = 0)
        {
            StringBuilder res = new StringBuilder();
            SqlCommand com = new SqlCommand(QueryString.GetCustomerNameFromId, conn);
            com.Parameters.Add("@cid", VarChar).Value = id;
            res.Append(com.ExecuteScalar().ToString());
            return res.ToString();
        }

        public static Dictionary<int, long> LoadCustomerPiutang(SqlConnection conn, int cid)
        {
            Dictionary<int, long> dictionary = new Dictionary<int, long>();
            SqlCommand com = new SqlCommand(QueryString.GetTotalPiutangOrderByJual, conn);
            com.Parameters.Add("@cid", Int).Value = cid;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                bool jual = bool.Parse(row["Jual"].ToString());
                long val = Utilities.GetBigInt(row["Total"].ToString());
                Utilities.print("{0} and {1}", jual, val);
                dictionary.Add(jual ? 1 : 0, val);
            }
            return dictionary;
        }
        public static Dictionary<int, Int64> LoadCustomer3Months(SqlConnection conn, int cid)
        {
            Utilities.print("PRINT 3 MONTHS!");
            Dictionary<int, long> dictionary = new Dictionary<int, long>();
            SqlCommand com = new SqlCommand(QueryString.GetFakturLast3MonthsGroupByMonth, conn);
            com.Parameters.Add("@d", Date).Value = System.DateTime.Now;
            com.Parameters.Add("@cid", Int).Value = cid;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            // 1, 2, 3 : J
            // 4, 5, 6 : R
            long piutang = 0;
            long ret = 0;
            foreach (DataRow row in dt.Rows)
            {
                int jual = row["Jual"].ToString().Equals(false.ToString()) ? 0 : 1;
                int sss = Utilities.GetInt(row["BulanMinus"].ToString()) + 1;
                long val = Utilities.GetBigInt(row["Total"].ToString());
                if (jual == 0)
                    piutang += val;
                else
                    ret += val;
                dictionary.Add(jual * 3 + sss, val);
            }
            return dictionary;
        }
        public static List<Customer> LoadCustomer(DataTable data)
        {
            var listCustomer = new List<Customer>();
            string cid = "";
            foreach (DataRow drCurrent in data.Rows)
            {
                cid = String.Format("K{0:0000}", int.Parse(drCurrent["_cid"].ToString()));
                int id = int.Parse(drCurrent["_cid"].ToString());
                listCustomer.Add(new Customer(
                    cid : id,
                    name : drCurrent["_name"].ToString(),
                    namasales : drCurrent["_salesname"].ToString(),
                    salesid : int.Parse(drCurrent["_spid"].ToString()),
                    city : drCurrent["_city"].ToString(),
                    alamat1 : drCurrent["_address1"].ToString(),
                    alamat2 : drCurrent["_address2"].ToString(),
                    telpfax : drCurrent["_phone"].ToString(),
                    keterangan : drCurrent["_notes"].ToString(),
                    lamakredit : int.Parse(drCurrent["_lamakredit"].ToString()),
                    marketibility : bool.Parse(drCurrent["_marketibility"].ToString()),
                    nonpwp : Int64.Parse(drCurrent["_nonpwp"].ToString()),
                    namanpwp : drCurrent["_namanpwp"].ToString(),
                    alamatnpwp : drCurrent["_addressnpwp"].ToString()
                    ));
            }
            return listCustomer;
        }

        public static void UpdateCustomer(SqlConnection conn, int idx)
         {
            var name = f.CustNameTextBox.Text.Trim();
            var salesName = f.CustSalesNameTextBox.Text.Trim();
            var addr1 = f.CustAddr1TextBox.Text.Trim();
            var addr2 = f.CustAddr2TextBox.Text.Trim();
            var lamaK = Utilities.GetInt(f.CustLamaKreditTextBox.Text.Trim());
            var salesId = Utilities.GetSalesCode(f.CustSalesNumLabel.Text.Trim(), false);
            var city = f.CustCityTextBox.Text.Trim();
            var phone = f.CustPhoneTextBox.Text.Trim();
            var notes = f.CustNotesTextBox.Text.Trim();
            var npwpnum = Utilities.GetBigInt(f.getNPWPNumTextBox().Trim());
            var npwpaddr = f.getNPWPAddrTextBox().Trim();
            var npwpname = f.getNPWPNameTextBox().Trim();
            var market = f.CustMarketCheckBox.Checked;
            var cid = Utilities.GetCustomerCode(f.CustCodeLabel.Text);
            Utilities.print("salesID :" + salesId);

            SqlCommand com = new SqlCommand(QueryString.UpdateCustomerInfo, conn);
            com.Parameters.Add("@cid", Int).Value = cid;
            com.Parameters.Add("@lamaKredit", Int).Value = lamaK;
            com.Parameters.Add("@name", VarChar).Value = name;
            com.Parameters.Add("@salesId", Int).Value = salesId;
            com.Parameters.Add("@city", VarChar).Value = city;
            com.Parameters.Add("@addr1", VarChar).Value = addr1;
            com.Parameters.Add("@addr2", VarChar).Value = addr2;
            com.Parameters.Add("@phone", VarChar).Value = phone;
            com.Parameters.Add("@notes", VarChar).Value = notes;
            com.Parameters.Add("@npwpNum", BigInt).Value = npwpnum;
            com.Parameters.Add("@npwpName", VarChar).Value = npwpname;
            com.Parameters.Add("@npwpAddr", VarChar).Value = npwpaddr;
            com.Parameters.Add("@market", Bit).Value = market;

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Utilities.print("Update Customer({0}) failed", cid);
                    // throw Exception ?
                    return;
                }
                List<Customer> list = f.customerOLV.Objects.Cast<Customer>().ToList();
                Customer c = list[idx];
                c.Alamat1 = addr1;
                c.Alamat2 = addr2;
                c.AlamatNPWP = npwpaddr;
                c.Keterangan = notes;
                c.Kota = city;
                c.LamaKredit = lamaK;
                c.Marketibility = market;
                c.Nama = name;
                c.NamaNPWP = npwpname;
                c.NamaSales = salesName;
                c.NoNPWP = npwpnum;
                c.SalesID = salesId;
                c.TelpFax = phone;
                list[idx] = c;
                f.customerOLV.RefreshObject(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
                return;
            }
         }

        public static void insertCustomer(SqlConnection conn)
        {
            var name = f.CustNameTextBox.Text.Trim();
            var salesName = f.CustSalesNameTextBox.Text.Trim();
            var addr1 = f.CustAddr1TextBox.Text.Trim();
            var addr2 = f.CustAddr2TextBox.Text.Trim();
            var lamaK = Utilities.GetInt(f.CustLamaKreditTextBox.Text.Trim());
            var salesId = Utilities.GetSalesCode(f.CustSalesNumLabel.Text.Trim(), false);
            var city = f.CustCityTextBox.Text.Trim();
            var phone = f.CustPhoneTextBox.Text.Trim();
            var notes = f.CustNotesTextBox.Text.Trim();
            var npwpnum = Utilities.GetBigInt(f.getNPWPNumTextBox().Trim());
            var npwpaddr = f.getNPWPAddrTextBox().Trim();
            var npwpname = f.getNPWPNameTextBox().Trim();
            var market = f.CustMarketCheckBox.Checked;
            Utilities.print("salesID :" + salesId);

            if (name.Equals(""))
            {
                MessageBox.Show("Nama Tidak Boleh Kosong");
                return;
            }

            if (salesName.Equals(""))
            {
                MessageBox.Show("Sales Tidak Boleh Kosong");
                return;
            }


            SqlCommand com = new SqlCommand(QueryString.InsertCustomers, conn);
            com.Parameters.Add("@lamaKredit", Int).Value = lamaK;
            com.Parameters.Add("@name", VarChar).Value = name;
            com.Parameters.Add("@salesId", Int).Value = salesId;
            com.Parameters.Add("@city", VarChar).Value = city;
            com.Parameters.Add("@addr1", VarChar).Value = addr1;
            com.Parameters.Add("@addr2", VarChar).Value = addr2;
            com.Parameters.Add("@phone", VarChar).Value = phone;
            com.Parameters.Add("@notes", VarChar).Value = notes;
            com.Parameters.Add("@npwpNum", BigInt).Value = npwpnum;
            com.Parameters.Add("@npwpName", VarChar).Value = npwpname;
            com.Parameters.Add("@npwpAddr", VarChar).Value = npwpaddr;
            com.Parameters.Add("@market", Bit).Value = market;

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Insert Customer failed");
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
