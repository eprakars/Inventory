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
    class Stocks : Base
    {

        public static int GetStockQuantity(SqlConnection conn, int id, SqlTransaction t = null)
        {
            int ret = -1;
            SqlCommand com = new SqlCommand(QueryString.GetStockQty, conn);
            com.Parameters.Add("@id", Int).Value = id;
            if (t != null)
                com.Transaction = t;
            var res = com.ExecuteScalar().ToString();
            ret = Utilities.GetInt(res);
            return ret;
        }

        public static int GetStockPrice(SqlConnection conn, int id, SqlTransaction t = null)
        {
            int ret = -1;
            SqlCommand com = new SqlCommand(QueryString.GetStockPrice, conn);
            com.Parameters.Add("@id", Int).Value = id;
            if (t != null)
                com.Transaction = t;
            var res = com.ExecuteScalar().ToString();
            ret = Utilities.GetInt(res);
            return ret;
        }
        public static int GetStockIdFromStockCode(SqlConnection conn, string nama = "")
        {
            int res = 0;
            SqlCommand com = new SqlCommand(QueryString.GetStockIdFromStockCode, conn);
            com.Parameters.Add("@name", VarChar).Value = nama;
            res = Utilities.GetInt(com.ExecuteScalar().ToString());
            return res;
        }

        public static string GetTanggalMasukFromStockId(SqlConnection conn, int id)
        {
            string ret = "";
            SqlCommand com = new SqlCommand(QueryString.GetDateInFromStockid, conn);
            com.Parameters.Add("@id", Int).Value = id;
            var res = com.ExecuteScalar().ToString();
            ret = Utilities.ChangeDateFormatToDDDMMMDDyyyy(res);
            return ret;
        }

        public static List<Stock> LoadStocks(DataTable data)
        {
            var listStock = new List<Stock>();
            foreach (DataRow drCurrent in data.Rows)
            {
               
                listStock.Add(new Stock(
                id: Utilities.GetInt(drCurrent["_id"].ToString())
                , code: drCurrent["_stockCode"].ToString()
                , name: drCurrent["_name"].ToString()
                , merk: drCurrent["_merk"].ToString()
                , color: drCurrent["_color"].ToString()
                , sizeid: drCurrent["_sizeid"].ToString()
                , notes: drCurrent["_notes"].ToString()
                , dim: drCurrent["_dimensions"].ToString()
                , category: drCurrent["_category"].ToString()
                , date: Utilities.ConvertDateToString(drCurrent["_datelist"])
                , imagename: drCurrent["_imageName"].ToString()
                , unit: drCurrent["_unit"].ToString()
                , quantity: Utilities.GetInt(drCurrent["_quantity"].ToString())
                , colly: Utilities.GetInt(drCurrent["_colly"].ToString())
                , price: Utilities.GetInt(drCurrent["_price"].ToString())
                , suggestedPrice: Utilities.GetInt(drCurrent["_suggestedPrice"].ToString())
                , weight: double.Parse(drCurrent["_weight"].ToString())
                , make: bool.Parse(drCurrent["_make"].ToString())
                ));
            }
            return listStock;
        }

        public static void InsertStock(SqlConnection conn)
        {
            var code = f.StokIDTextBox.Text.Trim();
            var name = f.StokNameTextBox.Text.Trim();
            var merk = f.StokMerkTextBox.Text.Trim();
            var color = f.StokColorTextBox.Text.Trim();
            var dim = f.StokDimensionsTextBox.Text.Trim();
            var unit = f.StokUnitTextBox.Text.Trim();
            double weight;
            double.TryParse(f.StokWeightTextBox.Text.Trim(), out weight);
            var size = f.StokSizeTextBox.Text.Trim();
            var colly = Utilities.GetInt(f.StokCollyTextBox.Text.Trim());
            var make = f.StokBuatanTextBox.SelectedIndex; // 0 = import, 1 = local
            var category = f.StokKategoriTextBox.Text.Trim();
            var date = System.DateTime.Now.ToString("yyyy-MM-dd");
            var notes = f.StokNotesTextBox.Text.Trim();
            var price = Utilities.GetInt(f.StokHargaPokokTextBox.Text.Trim());
            var suggest = Utilities.GetInt(f.StokHargaListTextBox.Text.Trim());
            var path = f.StokPhotoTextBox.Text;
            if (name.Length < 1)
            {
                MessageBox.Show("Nama Tidak Boleh Kosong");
                return;
            }

            SqlCommand com = new SqlCommand(QueryString.InsertStock, conn);
            com.Parameters.Add("@name", VarChar).Value = name;
            com.Parameters.Add("@code", VarChar).Value = code;
            com.Parameters.Add("@merk", VarChar).Value = merk;
            com.Parameters.Add("@color", VarChar).Value = color;
            com.Parameters.Add("@notes", VarChar).Value = notes;
            com.Parameters.Add("@date", Date).Value = date;
            com.Parameters.Add("@dim", VarChar).Value = dim;
            com.Parameters.Add("@unit", VarChar).Value = unit;
            com.Parameters.Add("@colly", Int).Value = colly;
            com.Parameters.Add("@price", Int).Value = price;
            com.Parameters.Add("@suggested", Int).Value = suggest;
            com.Parameters.Add("@weight", Decimal).Value = weight;
            com.Parameters.Add("@size", VarChar).Value = size;
            com.Parameters.Add("@make", Bit).Value = make;
            com.Parameters.Add("@category", VarChar).Value = category;
            com.Parameters.Add("@imageName", VarChar).Value = path;
            com.Parameters.Add("@extra", VarChar).Value = "";

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Insert new Stock failed");
                    // throw Exception ?
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error {0}:{1}", e.Number, e.Message);
                // Duplicate key
                if (e.Number == 2601 || e.Number == 2627)
                {
                    MessageBox.Show("Kode Stok/Nama telah terdaftar");
                }
            }
        }

        public static void UpdateStockInfo(SqlConnection conn, int idx)
        {
            var code = f.StokIDTextBox.Text.Trim();
            var name = f.StokNameTextBox.Text.Trim();
            var merk = f.StokMerkTextBox.Text.Trim();
            var color = f.StokColorTextBox.Text.Trim();
            var dim = f.StokDimensionsTextBox.Text.Trim();
            var unit = f.StokUnitTextBox.Text.Trim();
            double weight;
            double.TryParse(f.StokWeightTextBox.Text.Trim(), out weight);
            var size = f.StokSizeTextBox.Text.Trim();
            var colly = Utilities.GetInt(f.StokCollyTextBox.Text.Trim());
            var make = f.StokBuatanTextBox.SelectedIndex; // 0 = import, 1 = local
            var category = f.StokKategoriTextBox.Text.Trim();
            var date = f.StockDateListDateTextBox.Text.Trim();
            var notes = f.StokNotesTextBox.Text.Trim();
            var suggest = Utilities.GetInt(f.StokHargaListTextBox.Text.Trim());
            var id = Utilities.GetInt(f.StockIDLabel.Text.Trim());
            var path = f.StokPhotoTextBox.Text;

            if (name.Length < 1)
            {
                MessageBox.Show("Nama Tidak Boleh Kosong");
                return;
            }

            SqlCommand com = new SqlCommand(QueryString.UpdateStockInfo, conn);
            com.Parameters.Add("@name", VarChar).Value = name;
            com.Parameters.Add("@code", VarChar).Value = code;
            com.Parameters.Add("@merk", VarChar).Value = merk;
            com.Parameters.Add("@color", VarChar).Value = color;
            com.Parameters.Add("@notes", VarChar).Value = notes;
            com.Parameters.Add("@date", Date).Value = date;
            com.Parameters.Add("@dim", VarChar).Value = dim;
            com.Parameters.Add("@unit", VarChar).Value = unit;
            com.Parameters.Add("@colly", Int).Value = colly;
            com.Parameters.Add("@suggested", Int).Value = suggest;
            com.Parameters.Add("@weight", Decimal).Value = weight;
            com.Parameters.Add("@size", VarChar).Value = size;
            com.Parameters.Add("@make", Bit).Value = make;
            com.Parameters.Add("@category", VarChar).Value = category;
            com.Parameters.Add("@id", Int).Value = id;
            com.Parameters.Add("@imageName", VarChar).Value = path;

            //try to update db
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Update Stock info failed");
                    // throw Exception ?
                    return;
                }
                List<Stock> list = f.stokOLV.Objects.Cast<Stock>().ToList();
                Stock sp = list[idx];
                sp.Code = code;
                sp.Name = name;
                sp.Make = make == 1;
                sp.Merk = merk;
                sp.Color = color;
                sp.SizeId = size;
                sp.Notes = notes;
                sp.Unit = unit;
                sp.Colly = colly;
                sp.SuggestedPrice = suggest;
                sp.Weight = weight;
                sp.Dimensions = dim;
                sp.Category = category;
                sp.DateList = date;
                sp.ImageName = path;

                list[idx] = sp;
                f.stokOLV.RefreshObject(sp);
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error {0}:{1}", e.Number, e.Message);
                // Duplicate key
                if (e.Number == 2601 || e.Number == 2627)
                {
                    MessageBox.Show("Kode stok udah ada, masukin kode lain");
                }
            }
            }
    }
}
