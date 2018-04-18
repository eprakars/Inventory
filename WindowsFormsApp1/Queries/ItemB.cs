using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ItemB : Base
    {
        public static int GetStockQuantity(SqlConnection conn, int id)
        {
            int ret = -1;
            SqlCommand com = new SqlCommand(QueryString.GetStockQuantityFromItemBeli, conn);
            com.Parameters.Add("@sid", Int).Value = id;
            var res = com.ExecuteScalar().ToString();
            ret = Utilities.GetInt(res);
            return ret;
        }
        public static List<ItemBeli> LoadItemBelis(SqlConnection conn, int fid)
        {
            List<ItemBeli> list = new List<ItemBeli>();
            SqlCommand com = new SqlCommand(QueryString.GetItemBeli, conn);
            com.Parameters.Add("@fid", Int).Value = fid;
            SqlDataAdapter reader = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            reader.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ItemBeli(
                    id: Utilities.GetInt(row[0].ToString())
                    , date: row["_dateIn"] == null ? "" : Utilities.ConvertDateToString(row["_dateIn"])
                    , fakturId: Utilities.GetInt(row[2].ToString())
                    , stockId: Utilities.GetInt(row[3].ToString())
                    , namastock: row["_stockCode"].ToString()
                    , price: Utilities.GetInt(row[4].ToString())
                    , quantity: Utilities.GetInt(row[5].ToString())
                    , imagename: row["_imageName"].ToString()
                    , extra: row[6].ToString()));
            }
            return list;
        }

        // tot = old total
        public static void UpdateItemBeli(SqlConnection conn, int idx)
        {
            var price = Utilities.GetInt(f.ItemBeliHargaBeliTextBox.Text);
            var quantity = Utilities.GetInt(f.ItemBeliQtyTextBox.Text);
                
            SqlTransaction transaction = conn.BeginTransaction(IsolationLevel.Serializable);
            List<ItemBeli> list = f.ItemBeliOLV.Objects.Cast<ItemBeli>().ToList();
            ItemBeli item = list[idx];


            int id = item.StockId;
            int p = 0;
            int q = 0;
            int old = 0;
            int oPrice = 0;
            int stockQ = 0;
            SqlConnectionStringBuilder connectionToLocal = new SqlConnectionStringBuilder();
            connectionToLocal.ConnectionString = "Data Source=localhost;Initial Catalog=Vera;";
            connectionToLocal.UserID = "sa";
            connectionToLocal.Password = "productive2018";
            using (var connection = new SqlConnection(connectionToLocal.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(QueryString.GetItemBeliTotal, connection);
                command.Parameters.Add("@id", Int).Value = item.Id;       // NEED ID LABEL HERE
                var rec = command.ExecuteReader();

                if (rec.Read())
                {
                    p = rec.GetInt32(0);
                    q = rec.GetInt32(1);
                    old = p * q;
                }
                rec.Close();
                oPrice = Stocks.GetStockPrice(connection, id);
                stockQ = Stocks.GetStockQuantity(connection, id);
            }

            try
            {
                SqlCommand com = new SqlCommand(QueryString.UpdateItemBeli, conn);
                com.Transaction = transaction;
                com.Parameters.Add("@price", Int).Value = price;
                com.Parameters.Add("@quantity", Int).Value = quantity;
                com.Parameters.Add("@id", Int).Value = item.Id;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();

                com.CommandText = QueryString.UpdateStockQty;
                Utilities.print(oPrice + " " + stockQ + " " + old + " " + price + " " + quantity + " " + p + " " + q);
                com.Parameters.Add("@stockprice", BigInt).Value = ((oPrice * stockQ) - old + (price * quantity)) / (stockQ - q + quantity);
                com.Parameters.Add("@qty", Int).Value = stockQ - q + quantity;
                com.Parameters.Add("@stockid", Int).Value = id;
                rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Utilities.print("Update ItemIndex({0}) failed", idx);
                    // throw Exception ?
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
                    return;
                }
                transaction.Commit();
                item.Price = price;
                item.Quantity = quantity;
                list[idx] = item;

                // update total faktur
                var total = price * quantity;
                var ppn = f.FakturBeliPPNCheckBox.Checked;
                double oldT = Utilities.GetInt(f.FakturBeliTotalBeliTextBox.Text, true);
                double oldTax = Utilities.GetInt(f.FakturBeliTotalPPNTextBox.Text, true);
                double oldTotal = Utilities.GetInt(f.FakturBeliTotalAkhirTextBox.Text, true);
                oldT = ppn ? (oldT - old) / 1.1 : oldT - old;      // - oldItemTotal
                oldTax = ppn ? oldTax - old * .1: 0;         // - oldItemPPN
                oldTotal = oldTotal - old;                      // - oldItemTotal ?
                oldT += ppn ? total / 1.1 : total;
                oldTax += ppn ? .1 * total : 0;
                oldTotal += total;
                f.FakturBeliTotalAkhirTextBox.Text = string.Format(Utilities.FormatRupiah, oldTotal);
                f.FakturBeliTotalBeliTextBox.Text = string.Format(Utilities.FormatRupiah, oldT);
                f.FakturBeliTotalPPNTextBox.Text = string.Format(Utilities.FormatRupiah, oldTax);
                item.Price = price;
                item.Quantity = quantity;
                f.ItemBeliOLV.RefreshObject(item);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
                try
                {
                    transaction.Rollback();
                } catch (SqlException ex)
                {
                    if (transaction.Connection != null)
                    {
                        Console.WriteLine("An exception of type " + ex.GetType() +
                            " was encountered while attempting to roll back the transaction.");
                    }
                }
                return;
            }
        }

        public static void DeleteItemBeli(SqlConnection conn, int idx)
        {
            SqlCommand com = new SqlCommand(QueryString.DeleteItemBeli, conn);
            List<ItemBeli> list = f.ItemBeliOLV.Objects.Cast<ItemBeli>().ToList();
            ItemBeli item = list[idx];
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

        public static void InsertItemBeli(SqlConnection conn)
        {
            var price = Utilities.GetInt(f.ItemBeliHargaBeliTextBox.Text);
            var quantity = Utilities.GetInt(f.ItemBeliQtyTextBox.Text);
            var date = Utilities.GetDateNow();
            var fid = Utilities.GetNoFaktur(f.FakturBeliNoFakturTextBox.Text);
            var sid = Stocks.GetStockIdFromStockCode(conn, f.ItemBeliStokIDComboBox.Text);
            var ppn = f.FakturBeliPPNCheckBox.Checked;
            //Get Quantity Before
            SqlCommand getQtyCount = new SqlCommand(QueryString.GetStockQty, conn);
            getQtyCount.Parameters.Add("@id", Int).Value = sid;

            int QtyBefore = (int)getQtyCount.ExecuteScalar();


            //Get Harga Before
            SqlCommand getPriceBefore = new SqlCommand(QueryString.GetStockPrice, conn);
            getPriceBefore.Parameters.Add("@id", Int).Value = sid;

            int PriceBefore = (int)getPriceBefore.ExecuteScalar();

            // Transaction
            SqlTransaction transaction = conn.BeginTransaction(IsolationLevel.Serializable);
            SqlCommand com = new SqlCommand(QueryString.InsertItemBeli, conn);
            
            com.Parameters.Add("@date", Date).Value = date;
            com.Parameters.Add("@fid", Int).Value = fid;
            com.Parameters.Add("@sid", Int).Value = sid;    // Get Id from Code
            com.Parameters.Add("@price", Int).Value = price;
            com.Parameters.Add("@quantity", Int).Value = quantity;
            com.Parameters.Add("@extra", VarChar).Value = "";
            com.Parameters.Add("@del", Bit).Value = 0;
            com.Transaction = transaction;
           

            //Update Quantity Before + A new quantity 
            SqlCommand updateItemQty = new SqlCommand(QueryString.UpdateStockQty, conn);

            int NewQty = QtyBefore + quantity;
            
            Console.WriteLine(PriceBefore + " " + QtyBefore + " " + price + " " + quantity + " " + NewQty);


            updateItemQty.Parameters.Add("@stockprice", Int).Value = ((PriceBefore * QtyBefore) + (price * quantity)) / NewQty;
            updateItemQty.Parameters.Add("@qty", Int).Value = NewQty;
            updateItemQty.Parameters.Add("@stockid", Int).Value = sid;

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Insert ItemBeli failed");
                    // throw Exception ?
                }
                updateItemQty.Transaction = transaction;
                rowsAffected = updateItemQty.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Update Stock Qty failed");
                    // throw Exception ?
                }
                transaction.Commit();
                var t = ppn ? price * quantity / 1.1 : price * quantity;
                var tax = ppn ? .1 * price * quantity : 0;
                var tt = t + tax;
                double total = Utilities.GetInt(f.FakturBeliTotalBeliTextBox.Text, true);
                double taxx = Utilities.GetInt(f.FakturBeliTotalPPNTextBox.Text, true);
                tt +=  total + taxx;
                f.FakturBeliTotalBeliTextBox.Text = String.Format(Utilities.FormatRupiah, total + t);
                f.FakturBeliTotalPPNTextBox.Text = String.Format(Utilities.FormatRupiah, tax + taxx);
                f.FakturBeliTotalAkhirTextBox.Text = string.Format(Utilities.FormatRupiah, tt);

                // Add to itembeliolv ?
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
                try
                {
                    transaction.Rollback();
                } catch (SqlException ex)
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
