using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Database Variable
        SqlConnectionStringBuilder connectionToLocal = new SqlConnectionStringBuilder();
        private string connectionString = "Data Source=localhost;Initial Catalog=Vera;";
        private SqlConnection connection;
        private SqlCommand command;
        //private string sql = null;
        public static Form1 _Form;
        int selectIdx, total, ROLE;
        string LoginPassword;
        int selectSecondaryIdx;

        //Format Rupiah
        private string FormatRupiah = "Rp. {0:N}"; // {0 : amount}
        CultureInfo culture = CultureInfo.CreateSpecificCulture("id-id");


        //List for Combobox
        List<SalesPerson> listSalesInCustomer = new List<SalesPerson>();
        List<Customer> listCustomerInFakturJual = new List<Customer>();
        List<Stock> listStokInItemJual = new List<Stock>();
        List<Supplier> listSupplierInFakturBeli = new List<Supplier>();
        List<Stock> listStokInItemBeli = new List<Stock>();
        List<Customer> listCustomerInPembayaran = new List<Customer>();

        ImageForm IF = new ImageForm();


        public Form1(int role, string password)
        {  
            ROLE = role;
            LoginPassword = password;
            InitializeComponent();
            _Form = this;
            RemoveTabFromRole();
            selectIdx = -1;
            selectSecondaryIdx = -1;
        }

        //Role Restriction
        private void RemoveTabFromRole()
        {
            if (ROLE == 1)
            {
                tabControl1.TabPages.Remove(tabPage9);
            }
            else if (ROLE == 2)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage9);
            }
            else if (ROLE == 3)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage7);
                tabControl1.TabPages.Remove(tabPage9);
            }

            if (ROLE > 0)
            {
                FakturJualDetailsGroupBox.Controls.Remove(FakturJualEditButton);
                FakturBeliDetailsGroupBox.Controls.Remove(FakturBeliEditButton);
                ItemJualDetailsGroupBox.Controls.Remove(ItemJualEditButton);
                ItemJualDetailsGroupBox.Controls.Remove(ItemJualDeleteButton);
                ItemBeliDetailsGroupBox.Controls.Remove(ItemBeliEditButton);
                ItemBeliDetailsGroupBox.Controls.Remove(ItemBeliDeleteButton);
                PembayaranDetailsGroupBox.Controls.Remove(PembayaranEditButton);
                CustGroupBox.Controls.Remove(CustEditButton);
                SalesGroupBox.Controls.Remove(SalesEditButton);
                SuppGroupBox.Controls.Remove(SuppEditButton);
                StokGroupBox.Controls.Remove(StokEditButton);
            }

        }

        private void connectDatabase()
        {
            // Init local database variable
            connectionToLocal.ConnectionString = connectionString;
            connectionToLocal.UserID = "sa";
            connectionToLocal.Password = "productive2018";
            Boolean connected = false;
            while (!connected)
            {
                connection = new SqlConnection(connectionToLocal.ConnectionString);
                try
                {
                    connection.Open();
                    connected = true;
                    Console.WriteLine("Connected to localhost!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Cannot open connection to localhost :" + ex.Message);
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            timer1.Enabled = true;
            timer1.Interval = 1000;
            //Connect Database
            connectDatabase();

            //GET FAKTUR JUAL BEFORE CHANGING TAB
            GetFakturJual();
            LoadComboBoxFakturJual();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IF.Hide();
            selectIdx = -1;
            selectSecondaryIdx = -1;

            //Change Tab need to press cancel button
            if (tabControl1.SelectedTab == tabPage1)
            {
                //Load Faktur Jual
                GetFakturJual();
                LoadComboBoxFakturJual();
                cancelButton(FakturJualNewButton, FakturJualEditButton, FakturJualCancelButton, FakturJualOLV, FakturJualDetailsGroupBox);
                cancelButton(ItemJualNewButton, ItemJualEditButton, ItemJualCancelButton, ItemJualOLV, ItemJualDetailsGroupBox);
                ItemJualDeleteButton.Enabled = true;
            } else if (tabControl1.SelectedTab == tabPage2)
            {
                //Load Faktur Beli
                GetFakturBeli();
                LoadComboBoxFakturBeli();
                cancelButton(FakturBeliNewButton, FakturBeliEditButton, FakturBeliCancelButton, FakturBeliOLV, FakturBeliDetailsGroupBox);
                cancelButton(ItemBeliNewButton, ItemBeliEditButton, ItemBeliCancelButton, ItemBeliOLV, ItemBeliDetailsGroupBox);
                ItemBeliDeleteButton.Enabled = true;
            } else if (tabControl1.SelectedTab == tabPage3)
            {
                //Load Customer
                GetCustomer();
                LoadComboBoxCustomer();
                cancelButton(CustNewButton, CustEditButton, CustCancelButton, customerOLV, CustGroupBox);
            } else if (tabControl1.SelectedTab == tabPage4)
            {
                //Load Supplier
                GetSuppliers();
                LoadComboBoxSupplier();
                cancelButton(SuppNewButton, SuppEditButton, SuppCancelButton, supplierOLV, SuppGroupBox);
            } else if (tabControl1.SelectedTab == tabPage5)
            {
                //Load Sales
                GetSalesPersons();
                cancelButton(SalesNewButton, SalesEditButton, SalesCancelButton, salesOLV, SalesGroupBox);
            } else if (tabControl1.SelectedTab == tabPage6)
            {
                IF.Show();
                //Load Stock
                GetStok();
                LoadComboBoxStok();
                cancelButton(StokNewButton, StokEditButton, StokCancelButton, stokOLV, StokGroupBox);
            } else if (tabControl1.SelectedTab == tabPage7)
            {
                //Load Pembayaran
                GetPembayaran();
                LoadComboBoxPembayaran();
                cancelButton(PembayaranNewButton, PembayaranEditButton, PembayaranCancelButton, PembayaranOLV, PembayaranDetailsGroupBox);
            } else if (tabControl1.SelectedTab == tabPage8)
            {
                //Load Piutang
                GetPiutang();
            } else if (tabControl1.SelectedTab == tabPage9)
            {
                //Load Laporan Pembukuan dan Graf
                LoadGrafikComboBox();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //Get tblauthour from sql
        private DataTable getDataTableFromSql(String sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter SDA = new SqlDataAdapter(sql, connection);
            SDA.FillSchema(ds, SchemaType.Source, "DataTable");
            SDA.Fill(ds, "DataTable");
            DataTable tblAuthors;
            tblAuthors = ds.Tables["DataTable"];
            return tblAuthors;
        }

        ///////////////////////////////////////////////////////////////////////////////
        ///                                                                         ///
        ///                         PEMBAYARAN TAB                                   ///
        ///                                                                         ///
        ///////////////////////////////////////////////////////////////////////////////

        private void GetPembayaran()
        {
            var Pembayaran = Payment.LoadPembayaran(getDataTableFromSql(QueryString.GetPembayaran));
            PembayaranOLV.SetObjects(Pembayaran);
        }

        private void LoadComboBoxPembayaran()
        {
            PembayaranSudahCairComboBox.Items.Clear();
            PembayaranSudahCairComboBox.BeginUpdate();
            PembayaranSudahCairComboBox.Items.Add("Y");
            PembayaranSudahCairComboBox.Items.Add("T");
            PembayaranSudahCairComboBox.EndUpdate();

            DataTable data = getDataTableFromSql(QueryString.GetCustomers);

            PembayaranNamaCustComboBox.Items.Clear();
            PembayaranNamaCustComboBox.BeginUpdate();
            foreach (DataRow drCurrent in data.Rows)
            {
                listCustomerInPembayaran.Add(new Customer(
                    cid: int.Parse(drCurrent["_cid"].ToString()),
                    nama: drCurrent["_name"].ToString())
                    );
                PembayaranNamaCustComboBox.Items.Add(drCurrent["_name"].ToString());
            }
            PembayaranNamaCustComboBox.EndUpdate();
        }

        private void PembayaranOLV_ItemSelectionChanged(object sender, EventArgs e)
        {
            selectIdx = PembayaranOLV.SelectedIndex;
            Pembayaran pb = (Pembayaran)PembayaranOLV.SelectedObject;
            PembayaranNoGiroTextBox.Text = pb.NoGiro;
            PembayaranTglGiroDatePicker.Value = DateTime.Parse(pb.TanggalGiro);
            PembayaranNamaBankTextBox.Text = pb.NamaBank;
            PembayaranNoRekTextBox.Text = pb.NoRek;
            PembayaranJthTempoDatePicker.Value = DateTime.Parse(pb.JatuhTempo);
            PembayaranNilaiTextBox.Text = String.Format(culture, FormatRupiah, pb.Amount);
            PembayaranKodeCustTextBox.Text = String.Format("K{0:0000}", pb.KodeCustomer);
            PembayaranNamaCustComboBox.Text = pb.NamaCustomer;
            PembayaranNoFakturComboBox1.Text = pb.NoFaktur;
            //PembayaranNoFakturComboBox1;
            //PembayaranNoFakturComboBox1;
            //PembayaranNoFakturComboBox1;
            
            // FIXME
            //META 
            TextBox tb1 = null;
            TextBox tb2 = null;
            TextBox tb3 = null;
            TextBox tb4 = null;
            tb1 = new TextBox();
            tb2 = new TextBox();
            tb3 = new TextBox();
            tb4 = new TextBox();
            tb1.Text = "test";
            tb2.Text = "test";
            tb3.Text = "test";
            tb4.Text = "test";
            tableLayoutPanel1.Controls.Add(tb1);
            tableLayoutPanel1.Controls.Add(tb2);
            tableLayoutPanel1.Controls.Add(tb3);
            tableLayoutPanel1.Controls.Add(tb4);
            tableLayoutPanel1.ColumnCount++;

        }

        private void PembayaranNamaCustComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PembayaranNoFakturComboBox1.SelectedIndex = -1;
            PembayaranNoFakturComboBox2.SelectedIndex = -1;
            PembayaranNoFakturComboBox3.SelectedIndex = -1;
            PembayaranNoFakturComboBox4.SelectedIndex = -1;
            foreach (Customer c in listCustomerInPembayaran)
            {
                if (c.Nama.Equals(PembayaranNamaCustComboBox.Text.ToString()))
                {
                    PembayaranKodeCustTextBox.Text = String.Format("K{0:0000}", c.KodeCustomer);
                    List<FakturJual> payment = Payment.LoadFakturJualFromCid(connection, c.KodeCustomer);
                    PembayaranNoFakturComboBox1.Items.Clear();
                    PembayaranNoFakturComboBox2.Items.Clear();
                    PembayaranNoFakturComboBox3.Items.Clear();
                    PembayaranNoFakturComboBox4.Items.Clear();
                    PembayaranNoFakturComboBox1.BeginUpdate();
                    PembayaranNoFakturComboBox2.BeginUpdate();
                    PembayaranNoFakturComboBox3.BeginUpdate();
                    PembayaranNoFakturComboBox4.BeginUpdate();
                    for (int a = 0; a < payment.Count(); a++)
                    {
                        PembayaranNoFakturComboBox1.Items.Add(payment[a].Id);
                        PembayaranNoFakturComboBox2.Items.Add(payment[a].Id);
                        PembayaranNoFakturComboBox3.Items.Add(payment[a].Id);
                        PembayaranNoFakturComboBox4.Items.Add(payment[a].Id);
                    }
                    PembayaranNoFakturComboBox1.EndUpdate();
                    PembayaranNoFakturComboBox2.EndUpdate();
                    PembayaranNoFakturComboBox3.EndUpdate();
                    PembayaranNoFakturComboBox4.EndUpdate();

                    //PembayaranNoFakturComboBox Fill with the oldest faktur
                }
            }
        }


        private void PembayaranNewButton_Click(object sender, EventArgs e)
        {
            addButton(PembayaranNewButton, PembayaranEditButton, PembayaranCancelButton, PembayaranOLV, PembayaranDetailsGroupBox);
        }

        private void PembayaraEditButton_Click(object sender, EventArgs e)
        {
            editButton(PembayaranNewButton, PembayaranEditButton, PembayaranCancelButton, PembayaranOLV, PembayaranDetailsGroupBox);
        }

        private void PembayaranCancelButton_Click(object sender, EventArgs e)
        {
            cancelButton(PembayaranNewButton, PembayaranEditButton, PembayaranCancelButton, PembayaranOLV, PembayaranDetailsGroupBox);
        }

        ///////////////////////////////////////////////////////////////////////////////
        ///                                                                         ///
        ///                         PIUTANG TAB                                     ///
        ///                                                                         ///
        ///////////////////////////////////////////////////////////////////////////////

        private void GetPiutang()
        {
            var Piutang = Piutangs.LoadPiutang(getDataTableFromSql(QueryString.GetPiutang));
            PiutangOLV.SetObjects(Piutang);
        }


        ///////////////////////////////////////////////////////////////////////////////
        ///                                                                         ///
        ///                         LAPORAN TAB                                     ///
        ///                                                                         ///
        ///////////////////////////////////////////////////////////////////////////////

        private void LoadGrafikComboBox()
        {
            GrafikComboBox.Items.Clear();
            GrafikComboBox.BeginUpdate();
            GrafikComboBox.Items.Add("Omset");
            GrafikComboBox.Items.Add("HPP");
            GrafikComboBox.Items.Add("Laba/Rugi");
            GrafikComboBox.Items.Add("Piutang");
            GrafikComboBox.Items.Add("Ekuilitas");
            GrafikComboBox.Items.Add("Kas");
            GrafikComboBox.EndUpdate();
        }

        private void GetGraph(string series, List<int> value)
        {
            foreach (var s in LaporanChart.Series)
            {
                s.Points.Clear();
            }
            for (int i = 1; i < 13; i++)
            {
                LaporanChart.Series[series].Points.AddXY(i + "", value[i - 1]);
            }
        }

        private void GrafikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            int range = 10000;
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                list.Add(rnd.Next(1, 100) * range);
            }

            GetGraph(GrafikComboBox.Text.ToString(), list);
        }


        /// ///////////////////////////////////////////////////////////////////////////
        ///                                                                         ///
        ///                         FAKTUR BELI TAB                                 ///
        ///                                                                         ///
        /// ///////////////////////////////////////////////////////////////////////////


        private void LoadComboBoxFakturBeli()
        {
            //Jual Return Combo box
            FakturBeliBeliReturnComboBox.Items.Clear();
            FakturBeliBeliReturnComboBox.BeginUpdate();
            FakturBeliBeliReturnComboBox.Items.Add("B");
            FakturBeliBeliReturnComboBox.Items.Add("R");
            FakturBeliBeliReturnComboBox.EndUpdate();

            //Cash Kredit Combo Box
            FakturBeliCashKreditComboBox.Items.Clear();
            FakturBeliCashKreditComboBox.BeginUpdate();
            FakturBeliCashKreditComboBox.Items.Add("C");
            FakturBeliCashKreditComboBox.Items.Add("K");
            FakturBeliCashKreditComboBox.EndUpdate();

            //Nama Supplier Combo box
            DataTable data = getDataTableFromSql(QueryString.GetSupplier);

            FakturBeliNamaSuppComboBox.Items.Clear();
            FakturBeliNamaSuppComboBox.BeginUpdate();
            foreach (DataRow drCurrent in data.Rows)
            {
                listSupplierInFakturBeli.Add(new Supplier(Utilities.GetInt(drCurrent["_sid"].ToString()),
                    drCurrent["_name"].ToString(),
                    Utilities.GetInt(drCurrent["_creditDay"].ToString())
                    ));
                FakturBeliNamaSuppComboBox.Items.Add(drCurrent["_name"].ToString());
            }
            FakturBeliNamaSuppComboBox.EndUpdate();

            //Stok ID Combo Box
            DataTable dataStok = getDataTableFromSql(QueryString.GetStocks);

            ItemBeliStokIDComboBox.Items.Clear();
            ItemBeliStokIDComboBox.BeginUpdate();
            foreach (DataRow drCurrent in dataStok.Rows)
            {
                listStokInItemBeli.Add(new Stock(drCurrent["_name"].ToString(),
                    drCurrent["_imageName"].ToString()
                    ));
                ItemBeliStokIDComboBox.Items.Add(drCurrent["_name"].ToString());
            }
            ItemBeliStokIDComboBox.EndUpdate();
        }

        private void GetFakturBeli()
        {
            var FakturBeli = FakturB.LoadFakturBeli(getDataTableFromSql(QueryString.GetFakturBeli));
            FakturBeliOLV.SetObjects(FakturBeli);
        }

        private void FakturBeliBeliReturnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FakturBeliBeliReturnComboBox.Text.ToString().Equals("B"))
            {
                FakturBeliNoFakturTextBox.Text = "B" + Utilities.GetNoFaktur(FakturBeliNoFakturTextBox.Text);
            }
            else
            {
                FakturBeliNoFakturTextBox.Text = "R" + Utilities.GetNoFaktur(FakturBeliNoFakturTextBox.Text);
            }
        }

        private void FakturBeliPPNCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int total = Utilities.GetInt(FakturBeliTotalBeliTextBox.Text, true);

            if (FakturBeliPPNCheckBox.Checked)
            {
                FakturBeliTotalPPNTextBox.Text = string.Format(FormatRupiah, 0.1 * total);
                FakturBeliTotalAkhirTextBox.Text = string.Format(FormatRupiah, total + (0.1 * total));
            }
            else
            {
                FakturBeliTotalPPNTextBox.Text = string.Format(FormatRupiah, 0);
                FakturBeliTotalAkhirTextBox.Text = string.Format(FormatRupiah, total);
            }
        }

        private void FakturBeliNamaSuppComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Supplier s in listSupplierInFakturBeli)
            {
                if (s.Nama.Equals(FakturBeliNamaSuppComboBox.Text.ToString()))
                {
                    FakturBeliKodeSuppTextBox.Text = String.Format("S{0:000}", s.KodeSupplier);
                    FakturBeliJatuhTempoTextBox.Text = Utilities.GetDateNow(s.CreditDay, FakturBeliTanggalTextBox.Text);
                }
            }
        }

        private void ItemBeliStokIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Stock st in listStokInItemBeli)
            {
                if (st.Name.Equals(ItemBeliStokIDComboBox.Text.ToString()))
                {
                    ItemBeliPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    try
                    {
                        ItemBeliPictureBox.Image = new Bitmap(st.ImageName);
                    }
                    catch
                    {
                    }

                }
            }
        }

        private FakturBeli fakturBeli;
        private void FakturBeliOLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectIdx = FakturBeliOLV.SelectedIndex;
            fakturBeli = (FakturBeli)FakturBeliOLV.SelectedObject;
            FakturBeliBeliReturnComboBox.Text = fakturBeli.BeliReturn ? "R" : "B";
            FakturBeliJatuhTempoTextBox.Text = fakturBeli.JatuhTempo;
            FakturBeliNamaSuppComboBox.Text = fakturBeli.SupplierName;
            FakturBeliKodeSuppTextBox.Text = String.Format("S{0:000}", fakturBeli.SupplierId);
            FakturBeliNoFakturTextBox.Text = fakturBeli.Id;
            FakturBeliNoPajakTextBox.Text = fakturBeli.NomorPajak.ToString();
            FakturBeliPPNCheckBox.Checked = fakturBeli.Ppn;
            FakturBeliCashKreditComboBox.Text = fakturBeli.CashCredit ? "K" : "C";
            FakturBeliTanggalPajakDatePicker.Value = DateTime.Parse(fakturBeli.DatePajak);
            FakturBeliTanggalTextBox.Text = fakturBeli.Date;

            GetItemBeli();
            selectSecondaryIdx = -1;
        }

        private void GetItemBeli()
        {
            // Load ItemBeli
            List<ItemBeli> list = ItemB.LoadItemBelis(connection, Utilities.GetNoFaktur(fakturBeli.Id.ToString()));
            int total = 0;
            FakturBeliJlhItemTextBox.Text = list.Count.ToString();
            foreach (var i in list)
            {
                total += i.Price * i.Quantity;
            }
            if (fakturBeli.Ppn == true)
            {
                FakturBeliTotalBeliTextBox.Text = string.Format(FormatRupiah, total);
                FakturBeliTotalPPNTextBox.Text = string.Format(FormatRupiah, 0.1 * total);
                FakturBeliTotalAkhirTextBox.Text = string.Format(FormatRupiah, total + (0.1 * total));
            } else
            {
                FakturBeliTotalBeliTextBox.Text = string.Format(FormatRupiah, total);
                FakturBeliTotalPPNTextBox.Text = string.Format(FormatRupiah, 0);
                FakturBeliTotalAkhirTextBox.Text = string.Format(FormatRupiah, total);
            }

            ItemBeliOLV.SetObjects(list);
        }


        private void ItemBeliOLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectSecondaryIdx = ItemBeliOLV.SelectedIndex;
            ItemBeli item = (ItemBeli)ItemBeliOLV.SelectedObject;
            ItemBeliStokIDComboBox.Text = item.NamaStock.ToString();
            ItemBeliHargaBeliTextBox.Text = item.Price.ToString();
            ItemBeliQtyTextBox.Text = item.Quantity.ToString();
            ItemBeliTanggalTextBox.Text = item.Date;
            try
            {
                ItemBeliPictureBox.Image = new Bitmap(item.ImageName);
            }
            catch
            {
                ItemBeliPictureBox.Image = null;
            }
            total = item.Price * item.Quantity;
        }


        private void FakturBeliNewButton_Click(object sender, EventArgs e)
        {
            addButton(FakturBeliNewButton, FakturBeliEditButton, FakturBeliCancelButton, FakturBeliOLV, FakturBeliDetailsGroupBox);
            ItemBeliDeleteButton.Enabled = false;
        }

        private void FakturBeliEditButton_Click(object sender, EventArgs e)
        {
            editButton(FakturBeliNewButton, FakturBeliEditButton, FakturBeliCancelButton, FakturBeliOLV, FakturBeliDetailsGroupBox);
            ItemBeliDeleteButton.Enabled = false;
        }

        private void FakturBeliCancelButton_Click(object sender, EventArgs e)
        {
            cancelButton(FakturBeliNewButton, FakturBeliEditButton, FakturBeliCancelButton, FakturBeliOLV, FakturBeliDetailsGroupBox);
            ItemBeliDeleteButton.Enabled = true;
        }

        private void ItemBeliNewButton_Click(object sender, EventArgs e)
        {
            addButton(ItemBeliNewButton, ItemBeliEditButton, ItemBeliCancelButton, ItemBeliOLV, ItemBeliDetailsGroupBox);
            ItemBeliDeleteButton.Enabled = false;
        }

        private void ItemBeliEditButton_Click(object sender, EventArgs e)
        {
            editButton(ItemBeliNewButton, ItemBeliEditButton, ItemBeliCancelButton, ItemBeliOLV, ItemBeliDetailsGroupBox);
            ItemBeliDeleteButton.Enabled = false;
        }

        private void ItemBeliCancelButton_Click(object sender, EventArgs e)
        {
            cancelButton(ItemBeliNewButton, ItemBeliEditButton, ItemBeliCancelButton, ItemBeliOLV, ItemBeliDetailsGroupBox);
            ItemBeliDeleteButton.Enabled = true;
        }

        private void ItemBeliDeleteButton_Click(object sender, EventArgs e)
        {
            deleteButton(ItemBeliDetailsGroupBox);
        }

        int hargaBeli = 0;
        int qtyBeli = 0;
        private void ItemBeliHargaBeliTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                hargaBeli = int.Parse(ItemBeliHargaBeliTextBox.Text);
            }
            catch
            {
            }
            ItemBeliTotalTextBox.Text = String.Format(culture, FormatRupiah, hargaBeli * qtyBeli);
        }

        private void ItemBeliQtyTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                qtyBeli = int.Parse(ItemBeliQtyTextBox.Text);
            }
            catch
            {
            }
            ItemBeliTotalTextBox.Text = String.Format(culture, FormatRupiah, hargaBeli * qtyBeli);
        }

        private void FakturBeliFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTextBox(sender, FakturBeliOLV);
        }

        /// ///////////////////////////////////////////////////////////////////////////
        ///                                                                         ///
        ///                         FAKTUR JUAL TAB                                 ///
        ///                                                                         ///
        /// ///////////////////////////////////////////////////////////////////////////

        private void LoadComboBoxFakturJual()
        {
            //Jual Return Combo box
            FakturJualJualReturnComboBox.Items.Clear();
            FakturJualJualReturnComboBox.BeginUpdate();
            FakturJualJualReturnComboBox.Items.Add("J");
            FakturJualJualReturnComboBox.Items.Add("R");
            FakturJualJualReturnComboBox.EndUpdate();

            //Cash Kredit Combo Box
            FakturJualCashKreditComboBox.Items.Clear();
            FakturJualCashKreditComboBox.BeginUpdate();
            FakturJualCashKreditComboBox.Items.Add("C");
            FakturJualCashKreditComboBox.Items.Add("K");
            FakturJualCashKreditComboBox.EndUpdate();

            //Nama Customer Combo box
            DataTable data = getDataTableFromSql(QueryString.GetCustomers);

            FakturJualNamaCustComboBox.Items.Clear();
            FakturJualNamaCustComboBox.BeginUpdate();
            foreach (DataRow drCurrent in data.Rows)
            {
                listCustomerInFakturJual.Add(new Customer(int.Parse(drCurrent["_cid"].ToString()),
                    drCurrent["_name"].ToString(),
                    int.Parse(drCurrent["_spid"].ToString()),
                    drCurrent["_salesname"].ToString(),
                    Utilities.GetInt(drCurrent["_lamakredit"].ToString())
                    ));
                FakturJualNamaCustComboBox.Items.Add(drCurrent["_name"].ToString());
            }
            FakturJualNamaCustComboBox.EndUpdate();

            //Stok ID Combo Box
            DataTable dataStok = getDataTableFromSql(QueryString.GetStocks);

            ItemJualStokIDComboBox.Items.Clear();
            ItemJualStokIDComboBox.BeginUpdate();
            foreach (DataRow drCurrent in dataStok.Rows)
            {
                listStokInItemJual.Add(new Stock(drCurrent["_name"].ToString(),
                    drCurrent["_ImageName"].ToString(),
                    Utilities.GetInt(drCurrent["_price"].ToString())
                    ));
                ItemJualStokIDComboBox.Items.Add(drCurrent["_name"].ToString());
            }
            ItemJualStokIDComboBox.EndUpdate();
        }

        private void GetFakturJual()
        {
            var FakturJual = FakturJ.LoadFakturJual(getDataTableFromSql(QueryString.GetFakturJuals));
            FakturJualOLV.SetObjects(FakturJual);
        }

        private void FakturJualCashKreditComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FakturJualCashKreditComboBox.Text.ToString().Equals("C"))
            {
                FakturJualTanggalLunasTextBox.Text = Utilities.GetDateNow();
            }
            else
            {
                FakturJualTanggalLunasTextBox.Text = "";
            }
        }

        private void FakturJualJualReturnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FakturJualJualReturnComboBox.Text.ToString().Equals("J"))
            {
                FakturJualNoFakturTextBox.Text = "J" + Utilities.GetNoFaktur(FakturJualNoFakturTextBox.Text);
            } else
            {
                FakturJualNoFakturTextBox.Text = "R" + Utilities.GetNoFaktur(FakturJualNoFakturTextBox.Text);
            }
        }

        private void FakturJualPPNCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int total = Utilities.GetInt(FakturJualTotalJualTextBox.Text, true);

            if (FakturJualPPNCheckBox.Checked)
            {
                FakturJualTotalPPNTextBox.Text = string.Format(FormatRupiah, 0.1 * total);
                FakturJualTotalAkhirTextBox.Text = string.Format(FormatRupiah, total + (0.1 * total));
            }
            else
            {
                FakturJualTotalPPNTextBox.Text = string.Format(FormatRupiah, 0);
                FakturJualTotalAkhirTextBox.Text = string.Format(FormatRupiah, total);
            }
        }

        private void FakturJualNamaCustComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Customer c in listCustomerInFakturJual)
            {
                if (c.Nama.Equals(FakturJualNamaCustComboBox.Text.ToString()))
                {
                    FakturJualKodeCustomerTextBox.Text = String.Format("K{0:0000}", c.KodeCustomer);
                    FakturJualKodeSalesTextBox.Text = String.Format("SL{0:000}", c.SalesID);
                    FakturJualNamaSalesTextBox.Text = String.Format("" + c.NamaSales);
                    FakturJualJthTempoTextBox.Text = Utilities.GetDateNow(c.LamaKredit, FakturJualTanggalTextBox.Text);
                }
            }
        }

        private void ItemJualStokIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Stock st in listStokInItemJual)
            {
                if (st.Name.Equals(ItemJualStokIDComboBox.Text.ToString()))
                {
                    ItemJualHargaPokokTextBox.Text = String.Format(culture, FormatRupiah, st.Price);
                    ItemJualPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    try
                    {
                        ItemJualPictureBox.Image = new Bitmap(st.ImageName);
                    }
                    catch
                    {
                        ItemJualPictureBox.Image = null;
                    }
                }
            }
        }

        private FakturJual fakturJual;
        private void FakturJualOLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectIdx = FakturJualOLV.SelectedIndex;
            fakturJual = (FakturJual)FakturJualOLV.SelectedObject;
            FakturJualJualReturnComboBox.Text = fakturJual.JualReturn ? "R" : "J";
            FakturJualJthTempoTextBox.Text = fakturJual.JatuhTempo;
            FakturJualNamaCustComboBox.Text = fakturJual.CustomerName;
            FakturJualKodeCustomerTextBox.Text = String.Format("K{0:0000}", fakturJual.Cid);
            FakturJualNoFakturTextBox.Text = fakturJual.JualReturn ? fakturJual.Id.ToString() : fakturJual.Id.ToString();
            FakturJualPPNCheckBox.Checked = fakturJual.Ppn;
            FakturJualCashKreditComboBox.Text = fakturJual.CashCredit ? "K" : "C";
            FakturJualTanggalTextBox.Text = fakturJual.Date;
            GetItemJual();
            selectSecondaryIdx = -1;
        }

        private void GetItemJual()
        {
            // Load ItemBeli
            List<ItemJual> list = ItemJ.LoadItemJual(connection, Utilities.GetNoFaktur(fakturJual.Id.ToString()));
            int total = 0;
            FakturJualJlhItemTextBox.Text = list.Count.ToString();
            foreach (var i in list)
            {
                total += i.SellingPrice * i.Quantity;
            }
            if (fakturJual.Ppn == true)
            {
                FakturJualTotalJualTextBox.Text = string.Format(FormatRupiah, total);
                FakturJualTotalPPNTextBox.Text = string.Format(FormatRupiah, 0.1 * total);
                FakturJualTotalAkhirTextBox.Text = string.Format(FormatRupiah, total + (0.1 * total));
            }
            else
            {
                FakturJualTotalJualTextBox.Text = string.Format(FormatRupiah, total);
                FakturJualTotalPPNTextBox.Text = string.Format(FormatRupiah, 0);
                FakturJualTotalAkhirTextBox.Text = string.Format(FormatRupiah, total);
            }
            ItemJualOLV.SetObjects(list);
        }

        private void ItemJualOLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectSecondaryIdx = ItemJualOLV.SelectedIndex;
            ItemJual item = (ItemJual)ItemJualOLV.SelectedObject;
            this.ItemJualStokIDComboBox.SelectedIndexChanged -= new EventHandler(ItemJualStokIDComboBox_SelectedIndexChanged);
            ItemJualHargaPokokTextBox.Text = String.Format(culture, FormatRupiah, item.BasePrice);
            ItemJualStokIDComboBox.Text = item.NamaStock.ToString();
            ItemJualHargaJualTextBox.Text = item.SellingPrice.ToString();
            ItemJualDiscountTextBox.Text = item.Discount.ToString();
            ItemJualTanggalTextBox.Text = item.DateOut;
            ItemJualQtyTextBox.Text = item.Quantity.ToString();
            try
            {
                ItemJualPictureBox.Image = new Bitmap(item.ImageName);
            }
            catch
            {
                ItemJualPictureBox.Image = null;
            }
        }

        private void FakturJualNewButton_Click(object sender, EventArgs e)
        {
            addButton(FakturJualNewButton, FakturJualEditButton, FakturJualCancelButton, FakturJualOLV, FakturJualDetailsGroupBox);
            ItemJualDeleteButton.Enabled = false;
        }

        private void FakturJualEditButton_Click(object sender, EventArgs e)
        {
            editButton(FakturJualNewButton, FakturJualEditButton, FakturJualCancelButton, FakturJualOLV, FakturJualDetailsGroupBox);
            ItemJualDeleteButton.Enabled = false;
        }

        private void FakturJualCancelButton_Click(object sender, EventArgs e)
        {
            cancelButton(FakturJualNewButton, FakturJualEditButton, FakturJualCancelButton, FakturJualOLV, FakturJualDetailsGroupBox);
            ItemJualDeleteButton.Enabled = true;
        }

        private void ItemJualNewButton_Click(object sender, EventArgs e)
        {
            addButton(ItemJualNewButton, ItemJualEditButton, ItemJualCancelButton, ItemJualOLV, ItemJualDetailsGroupBox);
            ItemJualDeleteButton.Enabled = false;
        }

        private void ItemJualEditButton_Click(object sender, EventArgs e)
        {
            editButton(ItemJualNewButton, ItemJualEditButton, ItemJualCancelButton, ItemJualOLV, ItemJualDetailsGroupBox);
            ItemJualDeleteButton.Enabled = false;
        }

        private void ItemJualCancelButton_Click(object sender, EventArgs e)
        {
            cancelButton(ItemJualNewButton, ItemJualEditButton, ItemJualCancelButton, ItemJualOLV, ItemJualDetailsGroupBox);
            ItemJualDeleteButton.Enabled = true;
        }

        private void ItemJualDeleteButton_Click(object sender, EventArgs e)
        {
            deleteButton(ItemJualDetailsGroupBox);
        }

        int hargaJual = 0;
        int qtyJual = 0;
        int discountJual = 0;
        private void ItemJualHargaJualTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hargaJual = int.Parse(ItemJualHargaJualTextBox.Text);
            }
            catch
            {
            }
            if(ItemJualHargaPokokTextBox.Text.Length == 0)
            {
                ItemJualProfitTextBox.Text = String.Format(culture, FormatRupiah, 0);
            }
            else
            {
                ItemJualProfitTextBox.Text = String.Format(culture, FormatRupiah, (hargaJual - Utilities.GetInt(ItemJualHargaPokokTextBox.Text, true) - discountJual) * qtyJual);
            }
            
        }

        private void ItemJualQtyTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                qtyJual = int.Parse(ItemJualQtyTextBox.Text);
            }
            catch
            {
            }
            if (ItemJualHargaPokokTextBox.Text.Length == 0)
            {
                ItemJualProfitTextBox.Text = String.Format(culture, FormatRupiah, 0);
            }
            else
            {
                ItemJualProfitTextBox.Text = String.Format(culture, FormatRupiah, (hargaJual - Utilities.GetInt(ItemJualHargaPokokTextBox.Text, true) - discountJual) * qtyJual);
            }
        }

        private void ItemJualDiscountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                discountJual = int.Parse(ItemJualDiscountTextBox.Text);
            }
            catch
            {
            }
            if (ItemJualHargaPokokTextBox.Text.Length == 0)
            {
                ItemJualProfitTextBox.Text = String.Format(culture, FormatRupiah, 0);
            }
            else
            {
                ItemJualProfitTextBox.Text = String.Format(culture, FormatRupiah, (hargaJual - Utilities.GetInt(ItemJualHargaPokokTextBox.Text, true) - discountJual) * qtyJual);
            }
        }

        private void FakturJualFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTextBox(sender, FakturJualOLV);
        }


        /// ///////////////////////////////////////////////////////////////////////////
        ///                                                                         ///
        ///                         STOK TAB                                        ///
        ///                                                                         ///
        /// ///////////////////////////////////////////////////////////////////////////

        private void stokOLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectIdx = stokOLV.SelectedIndex;
            Stock s = (Stock)stokOLV.SelectedObject;
            StokNameTextBox.Text = s.Name;
            StokNotesTextBox.Text = s.Notes;
            StokQuantityTextBox.Text = s.Quantity.ToString();
            StokUnitTextBox.Text = s.Unit;
            StokSizeTextBox.Text = s.SizeId;
            StokIDTextBox.Text = s.Code;
            StokCollyTextBox.Text = s.Colly.ToString();
            StokColorTextBox.Text = s.Color;
            StokWeightTextBox.Text = s.Weight.ToString();
            StokKategoriTextBox.Text = s.Category;
            StokDimensionsTextBox.Text = s.Dimensions;
            StokHargaPokokTextBox.Text = String.Format(FormatRupiah, s.Price);
            StokHargaListTextBox.Text = String.Format(FormatRupiah, s.SuggestedPrice);
            StockIDLabel.Text = s.Id.ToString();
            StokMerkTextBox.Text = s.Merk;
            StokBuatanTextBox.Text = s.Make ? "Lokal" : "Import";
            StockDateListDateTextBox.Text = s.DateList;
            StokPhotoTextBox.Text = s.ImageName;
            IF.setImage(s.ImageName);
            StockDateInDateTextBox.Text = Stocks.GetTanggalMasukFromStockId(connection, s.Id);



        }
        private void GetStok()
        {
            var stocks = Stocks.LoadStocks(getDataTableFromSql(QueryString.GetStocks));
            stokOLV.SetObjects(stocks);
        }

        private void LoadComboBoxStok()
        {
            StokBuatanTextBox.Items.Clear();
            StokBuatanTextBox.BeginUpdate();
            StokBuatanTextBox.Items.Add("Import");
            StokBuatanTextBox.Items.Add("Lokal");
            StokBuatanTextBox.EndUpdate();
        }

        private void StokNewButton_Click(object sender, EventArgs e)
        {
            addButton(StokNewButton, StokEditButton, StokCancelButton, stokOLV, StokGroupBox);
        }

        private void StokEditButton_Click(object sender, EventArgs e)
        {
            editButton(StokNewButton, StokEditButton, StokCancelButton, stokOLV, StokGroupBox);
        }

        private void StokCancelButton_Click(object sender, EventArgs e)
        {
            cancelButton(StokNewButton, StokEditButton, StokCancelButton, stokOLV, StokGroupBox);
        }

        private void StokFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTextBox(sender, stokOLV);
        }

        private void StokBrowseButton_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                StokPhotoTextBox.Text = file;
                IF.setImage(file);
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
        }


        /// ///////////////////////////////////////////////////////////////////////////
        ///                                                                         ///
        ///                         SUPPLIER TAB                                    ///
        ///                                                                         ///
        /// ///////////////////////////////////////////////////////////////////////////
        
        private void GetSuppliers()
        {
            var suppliers = Supply.LoadSuppliers(getDataTableFromSql(QueryString.GetSupplier));
            supplierOLV.SetObjects(suppliers);
        }

        private void LoadComboBoxSupplier()
        {
            //ListBox Customer Lama Kredit
            ComboBoxCreditDay(SupplierCreditDayTextBox);
        }

        private void supplierOLV_ItemSelectionChanged(object sender, EventArgs e)
        {
            selectIdx = supplierOLV.SelectedIndex;
            Utilities.print("SUPPLIER SELECT IDX :" + selectIdx);
            Supplier supplier = (Supplier)supplierOLV.SelectedObject;
            int id = supplier.KodeSupplier;
            
            SupplierNameTextBox.Text = supplier.Nama;
            SupplierCodeLabel.Text = String.Format("Kode Supplier : S{0:000}", id);
            SupplierPhoneTextBox.Text = supplier.Phone;
            SupplierCityTextBox.Text = supplier.Kota;
            SupplierAddrTextBox.Text = supplier.Address;
            SupplierCreditDayTextBox.Text = supplier.CreditDay.ToString();
            SupplierJatuhTempoTextBox.Text = supplier.JatuhTempo.ToString();
            SupplierNotesTextBox.Text = supplier.Keterangan;
        }

        private void SuppButton1_Click(object sender, EventArgs e)
        {
            addButton(SuppNewButton, SuppEditButton, SuppCancelButton, supplierOLV, SuppGroupBox);
        }

        private void SuppButton2_Click(object sender, EventArgs e)
        {
            editButton(SuppNewButton, SuppEditButton, SuppCancelButton, supplierOLV, SuppGroupBox);
        }

        private void SuppButton3_Click(object sender, EventArgs e)
        {
            cancelButton(SuppNewButton, SuppEditButton, SuppCancelButton, supplierOLV, SuppGroupBox);
        }

        private void SupplierFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTextBox(sender, supplierOLV);
        }

        /// ///////////////////////////////////////////////////////////////////////////
        ///                                                                         ///
        ///                         SALES TAB                                       ///
        ///                                                                         ///
        /// ///////////////////////////////////////////////////////////////////////////

        private void GetSalesPersons()
        {
            var salesPersons = Sales.LoadSalesPerson(getDataTableFromSql(QueryString.GetSalesPersons));
            salesOLV.SetObjects(salesPersons);
        }

        private void salesOLV_ItemSelectionChanged(object sender, EventArgs e)
        {
            selectIdx = salesOLV.SelectedIndex;
            Utilities.print("SALES SELECT IDX :" + selectIdx);
            SalesPerson salesPerson = (SalesPerson)salesOLV.SelectedObject;
            SalesCodeLabel.Text = String.Format("Kode Sales : SL{0:000}", salesPerson.KodeSales);
            SalesNameTextBox.Text = salesPerson.Nama;
            SalesPhoneTextBox.Text = salesPerson.Phone;
            SalesCityTextBox.Text = salesPerson.Kota;
            SalesAddrTextBox.Text = salesPerson.Alamat;
            SalesTagihTextBox.Text = String.Format(culture, FormatRupiah, salesPerson.JumlahTagih);
            SalesReturnTextBox.Text = String.Format(culture, FormatRupiah, salesPerson.JumlahReturn);
            SalesDiscountTextBox.Text = salesPerson.Discount.ToString();
            SalesProfitTextBox.Text = String.Format(culture, FormatRupiah, salesPerson.Profit);
            SalesNotesTextBox.Text = salesPerson.Keterangan;
            SalesDateTimePicker.Value = salesPerson.Date;
            var dict = Sales.GetOmset(connection, salesPerson.KodeSales);

            SalesOmsetImportTextBox.Text = String.Format(culture, FormatRupiah, dict.ContainsKey(0) ? dict[0] : 0);
            SalesOmsetLocalTextBox.Text = String.Format(culture, FormatRupiah, dict.ContainsKey(1) ? dict[1] : 0);

            SalesProfitTextBox.Text = String.Format(culture, FormatRupiah, Sales.GetProfit(connection, salesPerson.KodeSales));



            if (salesPerson.KomImport.Equals(""))
            {
                SalesImportATextBox.Text = "";
                SalesImportBTextBox.Text = "";
                SalesImportCTextBox.Text = "";
                SalesImportDTextBox.Text = "";
                SalesImportETextBox.Text = "";
            }else
            {
                var import = salesPerson.KomImport.Split(':');
                SalesImportATextBox.Text = import[0];
                SalesImportBTextBox.Text = import[1];
                SalesImportCTextBox.Text = import[2];
                SalesImportDTextBox.Text = import[3];
                SalesImportETextBox.Text = import[4];
            }

            if (salesPerson.KomLocal.Equals(""))
            {
                SalesLocalATextBox.Text = "";
                SalesLocalBTextBox.Text = "";
                SalesLocalCTextBox.Text = "";
                SalesLocalDTextBox.Text = "";
                SalesLocalETextBox.Text = "";
            } else
            {
                var Local = salesPerson.KomLocal.Split(':');
                SalesLocalATextBox.Text = Local[0];
                SalesLocalBTextBox.Text = Local[1];
                SalesLocalCTextBox.Text = Local[2];
                SalesLocalDTextBox.Text = Local[3];
                SalesLocalETextBox.Text = Local[4];
            }


        }

        private void SalesButton1_Click(object sender, EventArgs e)
        {
            addButton(SalesNewButton, SalesEditButton, SalesCancelButton, salesOLV, SalesGroupBox);
        }

        private void SalesButton2_Click(object sender, EventArgs e)
        {
            editButton(SalesNewButton, SalesEditButton, SalesCancelButton, salesOLV, SalesGroupBox);
        }

        private void SalesButton3_Click(object sender, EventArgs e)
        {
            cancelButton(SalesNewButton, SalesEditButton, SalesCancelButton, salesOLV, SalesGroupBox);
        }

        private void SalesFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTextBox(sender, salesOLV);
        }

        /// ///////////////////////////////////////////////////////////////////////////
        ///                                                                         ///
        ///                         CUSTOMER TAB                                    ///
        ///                                                                         ///
        /// ///////////////////////////////////////////////////////////////////////////

        private void GetCustomer()
        {
            var customer = Customers.LoadCustomer(getDataTableFromSql(QueryString.GetCustomers));
            customerOLV.SetObjects(customer);
        }

        private void LoadComboBoxCustomer()
        {
            //ListBox Customer Lama Kredit
            ComboBoxCreditDay(CustLamaKreditTextBox);

            //Listbox Customer Nama Sales
            DataTable data = getDataTableFromSql(QueryString.GetSalesPersons);

            CustSalesNameTextBox.Items.Clear();
            CustSalesNameTextBox.BeginUpdate();
            foreach (DataRow drCurrent in data.Rows)
            {
                listSalesInCustomer.Add(new SalesPerson(int.Parse(drCurrent["_spid"].ToString()), drCurrent["_salesname"].ToString()));
                CustSalesNameTextBox.Items.Add(drCurrent["_salesname"].ToString());
            }
            CustSalesNameTextBox.EndUpdate();
        }

        private void customerOLV_ItemSelectionChanged(object sender, EventArgs e)
        {
            selectIdx = customerOLV.SelectedIndex;
            Utilities.print("CUSTOMER SELECT IDX :" + selectIdx);
            Customer customer = (Customer)customerOLV.SelectedObject;
            int id = customer.KodeCustomer;
            if (!customer.Recent)
            {
                var dict = Customers.LoadCustomer3Months(connection, id);
                foreach (var key in dict.Keys)
                {
                    switch (key)
                    {
                        case 1:
                            customer.SJ1 = dict[key];
                            break;
                        case 2:
                            customer.SJ2 = dict[key];
                            break;
                        case 3:
                            customer.SJ3 = dict[key];
                            break;
                        case 4:
                            customer.R1 = dict[key];
                            break;
                        case 5:
                            customer.R2 = dict[key];
                            break;
                        case 6:
                            customer.R3 = dict[key];
                            break;
                    }
                    Utilities.print("LOAD CUSTOMER DEATILS (Key:Value)==> " + key + ":" + dict[key]);
                }
                dict = Customers.LoadCustomerPiutang(connection, id);
                customer.Piutang = dict.ContainsKey(0) ? dict[0] : 0;
                customer.TotalReturn = dict.ContainsKey(1) ? dict[1] : 0;
                //customer.Recent = true;
                customerOLV.RefreshObject(customer);
            }
            CustCodeLabel.Text = String.Format("Kode Customer : K{0:0000}", id);
            CustNameTextBox.Text = customer.Nama;
            CustPhoneTextBox.Text = customer.TelpFax;
            CustCityTextBox.Text = customer.Kota;
            CustAddr1TextBox.Text = customer.Alamat1;
            CustAddr2TextBox.Text = customer.Alamat2;
            CustNpwpNumTextBox.Text = String.Format("{0:00'.'000'.'000'.'0-000.000}", customer.NoNPWP);
            CustNpwpNameTextBox.Text = customer.NamaNPWP;
            CustNpwpAddrTextBox.Text = customer.AlamatNPWP;
            CustLamaKreditTextBox.Text = customer.LamaKredit.ToString();
            CustPiutangTextBox.Text = String.Format(culture, FormatRupiah, customer.Piutang);
            
            CustJatuhTempoTextBox.Text = Customers.GetCustomerJatuhTempo(connection, customer.KodeCustomer);
            CustJ1TextBox.Text = String.Format(culture, FormatRupiah, customer.SJ1);
            CustR1TextBox.Text = String.Format(culture, FormatRupiah, customer.R1);
            CustJ2TextBox.Text = String.Format(culture, FormatRupiah, customer.SJ2);
            CustR2TextBox.Text = String.Format(culture, FormatRupiah, customer.R2);
            CustJ3TextBox.Text = String.Format(culture, FormatRupiah, customer.SJ3);
            CustTotalReturnTextBox.Text = String.Format(culture, FormatRupiah, customer.TotalReturn);
            CustNotesTextBox.Text = customer.Keterangan;
            CustSalesNameTextBox.Text = customer.NamaSales;
            CustSalesNumLabel.Text = String.Format("SL{0:000}", customer.SalesID);
            CustMarketCheckBox.Checked = customer.Marketibility;
        }

        private void CustButton1_Click(object sender, EventArgs e)
        {
            addButton(CustNewButton, CustEditButton, CustCancelButton, customerOLV, CustGroupBox);
        }

        private void CustButton2_Click(object sender, EventArgs e)
        {
            editButton(CustNewButton, CustEditButton, CustCancelButton, customerOLV, CustGroupBox);
        }

        private void CustButton3_Click(object sender, EventArgs e)
        {
            cancelButton(CustNewButton, CustEditButton, CustCancelButton, customerOLV, CustGroupBox);
        }

        private void NoSalesCustLabel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
            
           // Console.WriteLine(String.Format(culture, "Rp. {0:0,0.00}", 123456789));
        }

        private void CustSalesNameTextBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // Change Kode Sales here!!
            foreach (SalesPerson sp in listSalesInCustomer)
            {
                if (sp.Nama.Equals(CustSalesNameTextBox.Text.ToString()))
                {
                    CustSalesNumLabel.Text = String.Format("SL{0:000}", sp.KodeSales);
                }
            }

        }

        private void CustomerFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTextBox(sender, customerOLV);
        }

        /// ///////////////////////////////////////////////////////////////////////////
        ///                                                                         ///
        ///                         UTILITIES                                       ///
        ///                                                                         ///
        /// ///////////////////////////////////////////////////////////////////////////

        //Baru Button in Every Tab
        private void addButton(Button baru, Button edit, Button cancel, BrightIdeasSoftware.ObjectListView OLV, GroupBox groupbox)
        {
            int customerCount= 0;
            int salesCount = 0;
            int supplierCount = 0;
            int fakturBeliCount = 0;
            int fakturJualCount = 0;


            if (groupbox == CustGroupBox)
            {
                command = new SqlCommand(QueryString.CountCustomer, connection);
                customerCount = (int)command.ExecuteScalar() + 1;
            } else if (groupbox == SalesGroupBox)
            {
                command = new SqlCommand(QueryString.CountSales, connection);
                salesCount = (int)command.ExecuteScalar() + 1;
            }else if(groupbox == SuppGroupBox)
            {
                command = new SqlCommand(QueryString.CountSupplier, connection);
                supplierCount = (int)command.ExecuteScalar() + 1;
            } else if (groupbox == FakturBeliDetailsGroupBox)
            {
                command = new SqlCommand(QueryString.countFakturBeliInMonth, connection);
                fakturBeliCount = (int)command.ExecuteScalar() + 1;
            } else if (groupbox == ItemBeliDetailsGroupBox && selectIdx == -1)
            {
                MessageBox.Show("Pilih No Faktur yang ingin ditambahkan");
                return;
            } else if (groupbox == FakturJualDetailsGroupBox)
            {
                command = new SqlCommand(QueryString.countFakturJualInMonth, connection);
                fakturJualCount = (int)command.ExecuteScalar() + 1;
            } else if (groupbox == ItemJualDetailsGroupBox && selectIdx == -1)
            {
                MessageBox.Show("Pilih No Faktur yang ingin ditambahkan");
                return;
            }

            if (baru.Text.Equals("Baru"))
            {
                cancel.Enabled = true;
                edit.Enabled = false;
                OLV.Enabled = false;
                foreach (Control x in groupbox.Controls)
                {
                    if (x is TextBox || x is ComboBox || x is DateTimePicker)
                    {
                        x.Enabled = true;
                        x.Text = "";
                    }

                }
                baru.Text = "Tambah";
                if (groupbox == CustGroupBox)
                {
                    CustCodeLabel.Text = String.Format("Kode Customer : K{0:0000}", customerCount);
                } else if (groupbox == SalesGroupBox)
                {
                    SalesCodeLabel.Text = String.Format("Kode Sales : SL{0:000}", salesCount);
                } else if (groupbox == SuppGroupBox)
                {
                    SupplierCodeLabel.Text = String.Format("Kode Supplier : S{0:000}", supplierCount);
                } else if (groupbox == StokGroupBox)
                {
                    //Enable browse button
                    StokBrowseButton.Enabled = true;
                    StockDateListDateTextBox.Text = Utilities.GetDateNow();
                } else if (groupbox == FakturBeliDetailsGroupBox)
                {
                    FakturBeliNoFakturTextBox.Text = String.Format("B{0}", Utilities.SetNoFaktur(fakturBeliCount));
                    FakturBeliTanggalTextBox.Text = Utilities.GetDateNow();
                    FakturBeliBeliReturnComboBox.SelectedIndex = -1;
                    FakturBeliCashKreditComboBox.SelectedIndex = -1;
                    ItemBeliNewButton.Enabled = false;
                    ItemBeliEditButton.Enabled = false;
                    ItemBeliOLV.Enabled = false;
                } else if (groupbox == ItemBeliDetailsGroupBox)
                {
                    FakturBeliNewButton.Enabled = false;
                    FakturBeliEditButton.Enabled = false;
                    FakturBeliOLV.Enabled = false;
                } else if (groupbox == FakturJualDetailsGroupBox)
                {
                    FakturJualNoFakturTextBox.Text = String.Format("J{0}", Utilities.SetNoFaktur(fakturJualCount));
                    FakturJualTanggalTextBox.Text = Utilities.GetDateNow();
                    FakturJualJualReturnComboBox.SelectedIndex = -1;
                    FakturJualCashKreditComboBox.SelectedIndex = -1;
                    ItemJualNewButton.Enabled = false;
                    ItemJualEditButton.Enabled = false;
                    ItemJualOLV.Enabled = false;
                } else if (groupbox == ItemJualDetailsGroupBox)
                {
                    this.ItemJualStokIDComboBox.SelectedIndexChanged += new EventHandler(ItemJualStokIDComboBox_SelectedIndexChanged);
                    FakturJualNewButton.Enabled = false;
                    FakturJualEditButton.Enabled = false;
                    FakturJualOLV.Enabled = false;
                    hargaJual = 0;
                    qtyJual = 0;
                    discountJual = 0;
                }
            }
            else // else if OK insert to Database
            {

                if (groupbox == CustGroupBox)
                {
                    Customers.insertCustomer(connection);
                    GetCustomer();
                } else if (groupbox == SalesGroupBox)
                {
                    Sales.InsertSalesPerson(connection);
                    GetSalesPersons();
                } else if (groupbox == SuppGroupBox)
                {
                    Supply.InsertSupplier(connection);
                    GetSuppliers();
                } else if (groupbox == StokGroupBox)
                {
                    //Disable browse button
                    StokBrowseButton.Enabled = false;
                    Stocks.InsertStock(connection);
                    GetStok();
                } else if (groupbox == ItemBeliDetailsGroupBox)
                {
                    ItemB.InsertItemBeli(connection);
                    FakturBeliOLV.Enabled = true;
                    FakturBeliNewButton.Enabled = true;
                    FakturBeliEditButton.Enabled = true;
                    GetItemBeli();

                } else if (groupbox == FakturBeliDetailsGroupBox)
                {
                    FakturB.InsertFakturBeli(connection);
                    GetFakturBeli();
                    ItemBeliOLV.Enabled = true;
                    ItemBeliNewButton.Enabled = true ;
                    ItemBeliEditButton.Enabled = true;

                } else if (groupbox == ItemJualDetailsGroupBox)
                {
                    ItemJ.InsertItemJual(connection);
                    FakturJualOLV.Enabled = true;
                    FakturJualNewButton.Enabled = true;
                    FakturJualEditButton.Enabled = true;
                    GetItemJual();

                } else if (groupbox == FakturJualDetailsGroupBox)
                {
                    FakturJ.InsertFakturJual(connection);
                    GetFakturJual();
                    ItemJualOLV.Enabled = true;
                    ItemJualNewButton.Enabled = true;
                    ItemJualEditButton.Enabled = true;
                } else if (groupbox == PembayaranDetailsGroupBox)
                {
                    Payment.InsertPembayaran(connection);
                    GetPembayaran();
                }

                cancel.Enabled = false;
                edit.Enabled = true;
                OLV.Enabled = true;
                EnableTextBox(false, groupbox);
                baru.Text = "Baru";
            }
        }

        //Cancel Button in Every Tab
        private void cancelButton(Button baru, Button edit, Button cancel, BrightIdeasSoftware.ObjectListView OLV, GroupBox groupbox)
        {
            baru.Enabled = true;
            cancel.Enabled = false;
            edit.Enabled = true;
            OLV.Enabled = true;
            EnableTextBox(false, groupbox);
            baru.Text = "Baru";
            edit.Text = "Edit";

            if (groupbox == FakturBeliDetailsGroupBox)
            {
                ItemBeliOLV.Enabled = true;
                ItemBeliNewButton.Enabled = true;
                ItemBeliEditButton.Enabled = true;
            } else if (groupbox == ItemBeliDetailsGroupBox)
            {
                FakturBeliOLV.Enabled = true;
                FakturBeliNewButton.Enabled = true;
                FakturBeliEditButton.Enabled = true;
            } else if (groupbox == FakturJualDetailsGroupBox)
            {
                ItemJualOLV.Enabled = true;
                ItemJualNewButton.Enabled = true;
                ItemJualEditButton.Enabled = true;
            } else if (groupbox == ItemJualDetailsGroupBox)
            {
                FakturJualOLV.Enabled = true;
                FakturJualNewButton.Enabled = true;
                FakturJualEditButton.Enabled = true;
            }

        }

        //Edit Button in Every Tab
        private void editButton(Button baru, Button edit, Button cancel, BrightIdeasSoftware.ObjectListView OLV, GroupBox groupbox)
        {
            //Edit
            if (edit.Text == "Edit")
            {
                Utilities.print("SELECTED INDEX TO EDIT :" + selectIdx);
                if (selectIdx == -1)
                {
                    MessageBox.Show("No row selected to edit, please select a row to edit");
                    return;
                }

                if(groupbox == StokGroupBox)
                {
                    //Enable browse button
                    StokBrowseButton.Enabled = true;
                }
                else if (groupbox == FakturBeliDetailsGroupBox)
                {
                    ItemBeliOLV.Enabled = false;
                    ItemBeliNewButton.Enabled = false;
                    ItemBeliEditButton.Enabled = false;
                }
                else if (groupbox == ItemBeliDetailsGroupBox)
                {

                    if(selectSecondaryIdx == -1)
                    {
                        MessageBox.Show("No row selected to edit, please select a row to edit");
                        return;
                    }

                    FakturBeliOLV.Enabled = false;
                    FakturBeliNewButton.Enabled = false;
                    FakturBeliEditButton.Enabled = false;
                }
                else if (groupbox == FakturJualDetailsGroupBox)
                {
                    ItemJualOLV.Enabled = false;
                    ItemJualNewButton.Enabled = false;
                    ItemJualEditButton.Enabled = false;
                }
                else if (groupbox == ItemJualDetailsGroupBox)
                {

                    if (selectSecondaryIdx == -1)
                    {
                        MessageBox.Show("No row selected to edit, please select a row to edit");
                        return;
                    }
                    this.ItemJualStokIDComboBox.SelectedIndexChanged += new EventHandler(ItemJualStokIDComboBox_SelectedIndexChanged);
                    FakturJualOLV.Enabled = false;
                    FakturJualNewButton.Enabled = false;
                    FakturJualEditButton.Enabled = false;
                }

                baru.Enabled = false;
                cancel.Enabled = true;
                edit.Enabled = true;
                edit.Text = "Ok";
                EnableTextBox(true, groupbox);
                OLV.Enabled = false;
            }
            else // else if OK update Database
            {
                baru.Enabled = true;
                cancel.Enabled = false;
                edit.Enabled = true;
                edit.Text = "Edit";
                EnableTextBox(false, groupbox);
                OLV.Enabled = true;
                if (groupbox == CustGroupBox)
                {
                    Customers.UpdateCustomer(connection, selectIdx);
                } else if (groupbox == SuppGroupBox)
                {
                    Supply.UpdateSupplier(connection, selectIdx);
                } else if (groupbox == SalesGroupBox)
                {
                    Sales.UpdateSalesPersonInfo(connection, selectIdx);
                } else if (groupbox == StokGroupBox)
                {
                    //Disable browse button
                    StokBrowseButton.Enabled = false;
                    Stocks.UpdateStockInfo(connection, selectIdx);
                } else if (groupbox == ItemBeliDetailsGroupBox)
                {
                    ItemB.UpdateItemBeli(connection, selectSecondaryIdx);
                    FakturBeliOLV.Enabled = true;
                    FakturBeliNewButton.Enabled = true;
                    FakturBeliEditButton.Enabled = true;
                } else if (groupbox == FakturBeliDetailsGroupBox)
                {
                    FakturB.UpdateFakturBeli(connection, selectIdx);
                    ItemBeliOLV.Enabled = true;
                    ItemBeliNewButton.Enabled = true;
                    ItemBeliEditButton.Enabled = true;
                } else if (groupbox == ItemJualDetailsGroupBox)
                {
                    ItemJ.UpdateItemJual(connection, selectSecondaryIdx);
                    FakturJualOLV.Enabled = true;
                    FakturJualNewButton.Enabled = true;
                    FakturJualEditButton.Enabled = true;
                } else if (groupbox == FakturJualDetailsGroupBox)
                {
                    FakturJ.UpdateFakturJual(connection, selectIdx);
                    ItemJualOLV.Enabled = true;
                    FakturJualNewButton.Enabled = true;
                    FakturJualEditButton.Enabled = true;
                }
                selectSecondaryIdx = -1;
            }
        }

        private void deleteButton(GroupBox groupbox)
        {
            if (selectSecondaryIdx == -1)
            {
                MessageBox.Show("No row selected, please select a row to delete");
                return;
            }

            if(groupbox == ItemJualDetailsGroupBox)
            {
                DialogResult dialogResult = MessageBox.Show("Apakah Anda Yakin", "Hapus?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ItemJ.DeleteItemJual(connection, selectSecondaryIdx);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
                GetItemJual();
            }
            else if (groupbox == ItemBeliDetailsGroupBox)
            {
                DialogResult dialogResult = MessageBox.Show("Apakah Anda Yakin", "Hapus?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ItemB.DeleteItemBeli(connection, selectSecondaryIdx);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
                GetItemBeli();
            }
        }

        //Enable Textbox and combobox in every tab
        private void EnableTextBox(bool boo, GroupBox groupbox)
        {
            foreach (Control x in groupbox.Controls)
            {
                if (x is TextBox || x is ComboBox || x is DateTimePicker)
                {
                    x.Enabled = boo;
                }
            }
        }

        //ListBox for Credit Day 7, 14, 21, 30, 60, 90
        private void ComboBoxCreditDay(ComboBox combobox)
        {
            combobox.Items.Clear();
            //ListBox Customer Lama Kredit
            combobox.BeginUpdate();
            combobox.Items.Add("7");
            combobox.Items.Add("14");
            combobox.Items.Add("21");
            combobox.Items.Add("30");
            combobox.Items.Add("60");
            combobox.Items.Add("90");
            combobox.EndUpdate();
        }

        //Filter Textbox
        private void FilterTextBox(object sender, BrightIdeasSoftware.ObjectListView olv)
        {
            BrightIdeasSoftware.TextMatchFilter filter = BrightIdeasSoftware.TextMatchFilter.Contains(olv, ((TextBox)sender).Text);
            olv.ModelFilter = filter;
            olv.DefaultRenderer = new BrightIdeasSoftware.HighlightTextRenderer(filter);
        }

        //Ubah Tanggal
        private void ubahTanggalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UbahTanggal UB = new UbahTanggal();
            if (UB.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Tanggal Berubah");
            }
            else
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ubah Password
        private void ubahPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UbahPassword up = new UbahPassword(LoginPassword);
            bool cond = true;
            do
            {
                if (up.ShowDialog() == DialogResult.Cancel)
                {
                    cond = false;
                }
                else
                {
                    cond = !up.Success;
                    LoginPassword = up.GetPassword();
                }
                    
            } while (cond);
        }

        //Tambah Password
        private void tambahPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ROLE > 0)
            {
                MessageBox.Show("Not Authorized!");
                return;
            }
            TambahPassword TB = new TambahPassword();

            if (TB.ShowDialog() == DialogResult.OK)
            {
                string password = TB.GetPassword();
                int role = TB.GetRole();

                if (password.Equals("") || password.Length <= 6 || role == -1)
                {
                    MessageBox.Show("Password dan Role Tidak Boleh Kosong dan harus lebih dari 6 karakter");
                    return;
                }

                //Insert To Database
                try
                {
                    Account.InsertAccount(connection, password, role);
                    MessageBox.Show("Password Created");
                }
                catch
                {
                    Console.WriteLine("ERROR");
                }
                
            }
            else
            {

            }
        }

    }
}
