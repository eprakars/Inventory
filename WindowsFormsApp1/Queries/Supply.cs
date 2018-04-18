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
    class Supply : Base
    {
        internal static int GetCreditDay(SqlConnection conn, int id)
        {
            int ret = 7;
            SqlCommand com = new SqlCommand(QueryString.GetSupplierCreditDay, conn);
            com.Parameters.Add("@sid", Int).Value = id;
            try
            {
                ret = (int)com.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Silahkan Pilih Supplier");
            }
            return ret;
        }
        internal static List<Supplier> LoadSuppliers(DataTable data)
        {
            List<Supplier> list = new List<Supplier>();
            foreach (DataRow drCurrent in data.Rows)
            {
                list.Add(new Supplier(
                date: drCurrent["_jatuhTempo"] == null ? "" : Utilities.ConvertDateToString(drCurrent["_jatuhTempo"]),
                sid: int.Parse(drCurrent["_sid"].ToString()),
                creditDay: int.Parse(drCurrent["_creditDay"].ToString()),
                name: drCurrent["_name"].ToString(),
                phone: drCurrent["_phone"].ToString(),
                address: drCurrent["_address"].ToString(),
                city: drCurrent["_city"].ToString(),
                notes: drCurrent["_notes"].ToString()
                ));
            }
            return list;
        }

        internal static void InsertSupplier(SqlConnection conn)
        {

            if (f.SupplierNameTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nama Tidak Boleh Kosong");
                return;
            }

            SqlCommand com = new SqlCommand(QueryString.InsertSupplier, conn);
            com.Parameters.Add("@city", VarChar).Value = f.SupplierCityTextBox.Text.Trim();
            com.Parameters.Add("@name", VarChar).Value = f.SupplierNameTextBox.Text.Trim();
            com.Parameters.Add("@address", VarChar).Value = f.SupplierAddrTextBox.Text.Trim();
            com.Parameters.Add("phone", VarChar).Value = f.SupplierPhoneTextBox.Text.Trim();
            com.Parameters.Add("@notes", VarChar).Value = f.SupplierNotesTextBox.Text.Trim();
            com.Parameters.Add("@creditDay", Int).Value = Utilities.GetInt(f.SupplierCreditDayTextBox.Text.Trim());
            com.Parameters.Add("@extra", VarChar).Value = "";
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Insert new Supplier failed");
                    // throw Exception ?
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }

        internal static void UpdateSupplier(SqlConnection conn, int idx)
        {
            var name = f.SupplierNameTextBox.Text.Trim();
            var city = f.SupplierCityTextBox.Text.Trim();
            var addr = f.SupplierAddrTextBox.Text.Trim();
            var phone = f.SupplierPhoneTextBox.Text.Trim();
            var notes = f.SupplierNotesTextBox.Text.Trim();
            var credit = Utilities.GetInt(f.SupplierCreditDayTextBox.Text.Trim());
            var sid = Utilities.GetSupplierCode(f.SupplierCodeLabel.Text);

            if (name.Equals(""))
            {
                MessageBox.Show("Nama Tidak Boleh Kosong");
                return;
            }

            SqlCommand com = new SqlCommand(QueryString.UpdateSupplierInfo, conn);
            com.Parameters.Add("@city", VarChar).Value = city;
            com.Parameters.Add("@name", VarChar).Value = name;
            com.Parameters.Add("@addr", VarChar).Value = addr;
            com.Parameters.Add("@phone", VarChar).Value = phone;
            com.Parameters.Add("@notes", VarChar).Value = notes;
            com.Parameters.Add("@credit", Int).Value = credit;
            com.Parameters.Add("@sid", Int).Value = sid;
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Utilities.print("Update Supplier failed");
                    // throw Exception ?
                    return;
                }

                List<Supplier> list = f.supplierOLV.Objects.Cast<Supplier>().ToList();
                Supplier s = list[idx];
                s.Nama = name;
                s.Address = addr;
                s.CreditDay = credit;
                s.Keterangan = notes;
                s.Kota = city;
                s.Phone = phone;
                list[idx] = s;
                f.supplierOLV.RefreshObject(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }
        
    }
}
