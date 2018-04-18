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
    class ItemJ : Base
    {
        public static List<ItemJual> LoadItemJual(SqlConnection conn, int fid)
        {
            List<ItemJual> list = new List<ItemJual>();
            SqlCommand com = new SqlCommand(QueryString.GetItemJual, conn);
            com.Parameters.Add("@fid", Int).Value = fid;
            SqlDataAdapter reader = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            reader.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ItemJual(
                    id: Utilities.GetInt(row[0].ToString())
                    , dateOut: row["_dateOut"] == null ? "" : Utilities.ConvertDateToString(row["_dateOut"])
                    , fid: Utilities.GetInt(row[2].ToString())
                    , sid: Utilities.GetInt(row[3].ToString())
                    , namastock: row["_name"].ToString()
                    , imagename: row["_imagename"].ToString()
                    , sellingprice: Utilities.GetInt(row["_sellingprice"].ToString())
                    , quantity: Utilities.GetInt(row["_quantity"].ToString())
                    , baseprice: Utilities.GetInt(row["_baseprice"].ToString())
                    , discount: Utilities.GetInt(row["_discount"].ToString())
                    , extra: row[7].ToString()));
            }
            return list;
        }

        // tot = old total
        public static void UpdateItemJual(SqlConnection conn, int idx)
        {
            var sellingprice = Utilities.GetInt(f.ItemJualHargaJualTextBox.Text);
            var quantity = Utilities.GetInt(f.ItemJualQtyTextBox.Text);
            var baseprice = Utilities.GetInt(f.ItemJualHargaPokokTextBox.Text, true);
            var discount = Utilities.GetInt(f.ItemJualDiscountTextBox.Text);
            SqlCommand command = new SqlCommand(QueryString.GetItemJualTotal, conn);
            SqlTransaction transaction = conn.BeginTransaction(IsolationLevel.Serializable);
            List<ItemJual> list = f.ItemJualOLV.Objects.Cast<ItemJual>().ToList();
            ItemJual item = list[idx];
            command.Parameters.Add("@id", Int).Value = item.Id;       // NEED ID LABEL HERE
            command.Transaction = transaction;
            var old = (int)command.ExecuteScalar();

            SqlCommand com = new SqlCommand(QueryString.GetItemJualQuantity, conn);
            com.Parameters.Add("@id", Int).Value = item.Id;
            com.Transaction = transaction;
            int pre = (int)com.ExecuteScalar();

            com.CommandText = QueryString.UpdateItemJual;
            com.Parameters.Add("@sellingprice", Int).Value = sellingprice;
            com.Parameters.Add("@quantity", Int).Value = quantity;
            com.Parameters.Add("@itemid", Int).Value = item.Id;
            com.Parameters.Add("@baseprice", Int).Value = baseprice;
            com.Parameters.Add("@discount", Int).Value = discount;
            com.Transaction = transaction;
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Utilities.print("Update ItemIndex({0}) failed", idx);
                    // throw Exception ?
                    return;
                }

                
                int q = Stocks.GetStockQuantity(conn, item.StockId, transaction);
                Utilities.print("pre({0}), q({1}), quantity({2})", pre, q, quantity);
                if (quantity > q + pre)
                {
                    // FAIL
                    transaction.Rollback();
                    return;
                }
                com.CommandText = QueryString.UpdateStockQuantity;
                com.Parameters.Add("@quantityStock", Int).Value = q + pre - quantity;
                com.Parameters.Add("@stockid", Int).Value = item.StockId;
                com.Transaction = transaction;
                rowsAffected = com.ExecuteNonQuery();

                if (rowsAffected != 1)
                {
                    Console.WriteLine("Update Stock Quantity failed");
                    // throw Exception ?
                }
                transaction.Commit();
                item.SellingPrice = sellingprice;
                item.Quantity = quantity;
                list[idx] = item;

                // update total faktur
                var total = sellingprice * quantity;
                var ppn = f.FakturJualPPNCheckBox.Checked;
                double oldT = Utilities.GetInt(f.FakturJualTotalJualTextBox.Text, true) / 100;
                double oldTax = Utilities.GetInt(f.FakturJualTotalPPNTextBox.Text, true) / 100;
                double oldTotal = Utilities.GetInt(f.FakturJualTotalAkhirTextBox.Text, true) / 100;
                oldT = ppn ? (oldT - old) / 1.1 : oldT - old;      // - oldItemTotal
                oldTax = ppn ? oldTax - old * .1 : 0;         // - oldItemPPN
                oldTotal = oldTotal - old;                      // - oldItemTotal ?
                oldT += ppn ? total / 1.1 : total;
                oldTax += ppn ? .1 * total : 0;
                oldTotal += total;
                f.FakturJualTotalAkhirTextBox.Text = string.Format(Utilities.FormatRupiah, oldTotal);
                f.FakturJualTotalJualTextBox.Text = string.Format(Utilities.FormatRupiah, oldT);
                f.FakturJualTotalPPNTextBox.Text = string.Format(Utilities.FormatRupiah, oldTax);
                item.SellingPrice = sellingprice;
                item.Quantity = quantity;
                item.Discount = discount;
                f.ItemJualOLV.RefreshObject(item);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (SqlException ex)
                {
                    if (transaction.Connection != null)
                    {
                        Console.WriteLine("An exception of type " + ex.GetType() +
                            " was encountered while attempting to roll back the transaction.");
                    }
                }
            }
        }

        public static void DeleteItemJual(SqlConnection conn, int idx)
        {
            SqlCommand com = new SqlCommand(QueryString.DeleteItemJual, conn);
            List<ItemJual> list = f.ItemJualOLV.Objects.Cast<ItemJual>().ToList();
            ItemJual item = list[idx];
            com.Parameters.Add("@itemid", Int).Value = item.Id;

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Delete ItemBeli failed");
                    // throw Exception ?
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }

        public static void InsertItemJual(SqlConnection conn)
        {
            var price = Utilities.GetInt(f.ItemJualHargaJualTextBox.Text);
            var quantity = Utilities.GetInt(f.ItemJualQtyTextBox.Text);
            var baseprice = Utilities.GetInt(f.ItemJualHargaPokokTextBox.Text, true);
            var date = Utilities.GetDateNow();
            var fid = Utilities.GetNoFaktur(f.FakturJualNoFakturTextBox.Text);
            var sid = Stocks.GetStockIdFromStockCode(conn, f.ItemJualStokIDComboBox.Text);
            var ppn = f.FakturJualPPNCheckBox.Checked;
            int oldQ = Stocks.GetStockQuantity(conn, sid);
            var discount = Utilities.GetInt(f.ItemJualDiscountTextBox.Text);

            SqlCommand com = new SqlCommand(QueryString.InsertItemJual, conn);
            SqlTransaction transaction = conn.BeginTransaction(IsolationLevel.Serializable);
            com.Transaction = transaction;
            com.Parameters.Add("@date", Date).Value = date;
            com.Parameters.Add("@fid", Int).Value = fid;
            com.Parameters.Add("@sid", Int).Value = sid;    // Get Id from Code
            com.Parameters.Add("@price", Int).Value = price;
            com.Parameters.Add("@quantity", Int).Value = quantity;
            com.Parameters.Add("@baseprice", Int).Value = baseprice;
            com.Parameters.Add("@extra", VarChar).Value = "";
            com.Parameters.Add("@del", Bit).Value = 0;
            com.Parameters.Add("@discount", Int).Value = discount;

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Insert ItemJual failed");
                    // throw Exception ?
                }
                Utilities.print("ItemJual inserted");
                if (quantity > oldQ)
                {
                    // FAIL
                    MessageBox.Show("Stok Tidak Mencukupi");
                    transaction.Rollback();
                    return;
                }

                com.CommandText = QueryString.UpdateStockQuantity;
                com.Parameters.Add("@quantityStock", Int).Value = oldQ - quantity;
                com.Parameters.Add("@stockid", Int).Value = sid;
                rowsAffected = com.ExecuteNonQuery();

                if (rowsAffected != 1)
                {
                    Console.WriteLine("Update Stock Quantity failed");
                    // throw Exception ?
                }
                transaction.Commit();
                var t = ppn ? price * quantity / 1.1 : price * quantity;
                var tax = ppn ? .1 * price * quantity : 0;
                var tt = t + tax;
                double total = Utilities.GetInt(f.FakturJualTotalJualTextBox.Text, true) / 100;
                double taxx = Utilities.GetInt(f.FakturJualTotalPPNTextBox.Text, true) / 100;
                tt += total + taxx;
                f.FakturJualTotalJualTextBox.Text = String.Format(Utilities.FormatRupiah, total + t);
                f.FakturJualTotalPPNTextBox.Text = String.Format(Utilities.FormatRupiah, tax + taxx);
                f.FakturJualTotalAkhirTextBox.Text = string.Format(Utilities.FormatRupiah, tt);

                // Add to itemjualolv ?
            }
            catch (Exception e)
            {
                Console.WriteLine("Error here:" + e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (SqlException ex)
                {
                    if (transaction.Connection != null)
                    {
                        Console.WriteLine("An exception of type " + ex.GetType() +
                            " was encountered while attempting to roll back the transaction.");
                    }
                }
            }
        }
    }
}
