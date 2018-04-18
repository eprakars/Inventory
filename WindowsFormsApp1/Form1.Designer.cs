using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle1 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle2 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle3 = new BrightIdeasSoftware.HeaderStateStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.olvHdr = new BrightIdeasSoftware.HeaderFormatStyle();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahTanggalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PembayaranDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PembayaranNilaiTextBox = new System.Windows.Forms.TextBox();
            this.PembayaranNilaiLabel = new System.Windows.Forms.Label();
            this.PembayaranKeteranganTextBox = new System.Windows.Forms.TextBox();
            this.PembayaranSudahCairComboBox = new System.Windows.Forms.ComboBox();
            this.PembayaranNoFakturComboBox4 = new System.Windows.Forms.ComboBox();
            this.PembayaranNoFakturComboBox3 = new System.Windows.Forms.ComboBox();
            this.PembayaranNoFakturComboBox2 = new System.Windows.Forms.ComboBox();
            this.PembayaranNoFakturComboBox1 = new System.Windows.Forms.ComboBox();
            this.PembayaranNamaCustLabel = new System.Windows.Forms.Label();
            this.PembayaranNamaCustComboBox = new System.Windows.Forms.ComboBox();
            this.PembayaranJthTempoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PembayaranTglGiroDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PembayaranKodeCustTextBox = new System.Windows.Forms.TextBox();
            this.PembayaranNoRekTextBox = new System.Windows.Forms.TextBox();
            this.PembayaranNamaBankTextBox = new System.Windows.Forms.TextBox();
            this.PembayaranKeteranganLabel = new System.Windows.Forms.Label();
            this.PembayaranSudahCairLabel = new System.Windows.Forms.Label();
            this.PembayaranSisaLabel = new System.Windows.Forms.Label();
            this.PembayaranBayarLabel = new System.Windows.Forms.Label();
            this.PembayaranTotalFakturLabel = new System.Windows.Forms.Label();
            this.PembayaranNoFakturLabel = new System.Windows.Forms.Label();
            this.PembayaranKodeCustLabel = new System.Windows.Forms.Label();
            this.PembayaranJthTempoLabel = new System.Windows.Forms.Label();
            this.PembayaranNoRekLabel = new System.Windows.Forms.Label();
            this.PembayaranCancelButton = new System.Windows.Forms.Button();
            this.PembayaranEditButton = new System.Windows.Forms.Button();
            this.PembayaranNewButton = new System.Windows.Forms.Button();
            this.PembayaranNoGiroTextBox = new System.Windows.Forms.TextBox();
            this.PembayaranTglGiroLabel = new System.Windows.Forms.Label();
            this.PembayaranNamaBankLabel = new System.Windows.Forms.Label();
            this.PembayaranNoGiroLabel = new System.Windows.Forms.Label();
            this.PembayaranOLV = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn45 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn46 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn47 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn48 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.StokFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.StokFilterTextBox = new System.Windows.Forms.TextBox();
            this.StokGroupBox = new System.Windows.Forms.GroupBox();
            this.StokPhotoTextBox = new System.Windows.Forms.TextBox();
            this.StokPhotoLabel = new System.Windows.Forms.Label();
            this.StokBrowseButton = new System.Windows.Forms.Button();
            this.StockIDLabel = new System.Windows.Forms.Label();
            this.StokBuatanTextBox = new System.Windows.Forms.ComboBox();
            this.StokCancelButton = new System.Windows.Forms.Button();
            this.StokEditButton = new System.Windows.Forms.Button();
            this.StokNewButton = new System.Windows.Forms.Button();
            this.StokIDTextBox = new System.Windows.Forms.TextBox();
            this.StokHargaListTextBox = new System.Windows.Forms.TextBox();
            this.StokHargaPokokTextBox = new System.Windows.Forms.TextBox();
            this.StokHargaListLabel = new System.Windows.Forms.Label();
            this.StokHargaPokokLabel = new System.Windows.Forms.Label();
            this.StokSaldoAkhirTextBox = new System.Windows.Forms.TextBox();
            this.StokSaldoAwalTextBox = new System.Windows.Forms.TextBox();
            this.StokKategoriTextBox = new System.Windows.Forms.TextBox();
            this.StokKategoriLabel = new System.Windows.Forms.Label();
            this.StolBuatanLabel = new System.Windows.Forms.Label();
            this.StockEndLabel = new System.Windows.Forms.Label();
            this.StockInitialLabel = new System.Windows.Forms.Label();
            this.StockDateInDateTextBox = new System.Windows.Forms.TextBox();
            this.StokDateInLabel = new System.Windows.Forms.Label();
            this.StokDimensionsTextBox = new System.Windows.Forms.TextBox();
            this.StokWeightTextBox = new System.Windows.Forms.TextBox();
            this.StokCollyTextBox = new System.Windows.Forms.TextBox();
            this.StokDimensionsLabel = new System.Windows.Forms.Label();
            this.StokWeightLabel = new System.Windows.Forms.Label();
            this.StokCollyLabel = new System.Windows.Forms.Label();
            this.StockDateListDateTextBox = new System.Windows.Forms.TextBox();
            this.StokDateListLabel = new System.Windows.Forms.Label();
            this.StokColorTextBox = new System.Windows.Forms.TextBox();
            this.StokNameTextBox = new System.Windows.Forms.TextBox();
            this.StokNotesTextBox = new System.Windows.Forms.TextBox();
            this.StokSizeTextBox = new System.Windows.Forms.TextBox();
            this.StokUnitTextBox = new System.Windows.Forms.TextBox();
            this.StokQuantityTextBox = new System.Windows.Forms.TextBox();
            this.StokMerkTextBox = new System.Windows.Forms.TextBox();
            this.StokSizeLabel = new System.Windows.Forms.Label();
            this.StokMerkLabel = new System.Windows.Forms.Label();
            this.StokQuantityLabel = new System.Windows.Forms.Label();
            this.StokNotesLabel = new System.Windows.Forms.Label();
            this.StokUnitLabel = new System.Windows.Forms.Label();
            this.StokColorLabel = new System.Windows.Forms.Label();
            this.StokCodeLabel = new System.Windows.Forms.Label();
            this.StokNameLabel = new System.Windows.Forms.Label();
            this.stokOLV = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn13 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn14 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn15 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn17 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn18 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.SalesFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.SalesFilterTextBox = new System.Windows.Forms.TextBox();
            this.SalesGroupBox = new System.Windows.Forms.GroupBox();
            this.KomisiImportALabel = new System.Windows.Forms.Label();
            this.KomisiLokalELabel = new System.Windows.Forms.Label();
            this.KomisiLokalDLabel = new System.Windows.Forms.Label();
            this.KomisiLokalCLabel = new System.Windows.Forms.Label();
            this.KomisiLokalBLabel = new System.Windows.Forms.Label();
            this.KomisiLokalALabel = new System.Windows.Forms.Label();
            this.KomisiImportELabel = new System.Windows.Forms.Label();
            this.KomisiImportDLabel = new System.Windows.Forms.Label();
            this.KomisiImportBLabel = new System.Windows.Forms.Label();
            this.KomisiImportCLabel = new System.Windows.Forms.Label();
            this.SalesLocalETagihTextBox = new System.Windows.Forms.TextBox();
            this.SalesLocalDTagihTextBox = new System.Windows.Forms.TextBox();
            this.SalesLocalCTagihTextBox = new System.Windows.Forms.TextBox();
            this.SalesLocalBTagihTextBox = new System.Windows.Forms.TextBox();
            this.SalesLocalATagihTextBox = new System.Windows.Forms.TextBox();
            this.SalesImportETagihTextBox = new System.Windows.Forms.TextBox();
            this.SalesImportDTagihTextBox = new System.Windows.Forms.TextBox();
            this.SalesImportCTagihTextBox = new System.Windows.Forms.TextBox();
            this.SalesImportBTagihTextBox = new System.Windows.Forms.TextBox();
            this.SalesImportATagihTextBox = new System.Windows.Forms.TextBox();
            this.SalesLocalETextBox = new System.Windows.Forms.TextBox();
            this.SalesLocalDTextBox = new System.Windows.Forms.TextBox();
            this.SalesLocalCTextBox = new System.Windows.Forms.TextBox();
            this.SalesLocalBTextBox = new System.Windows.Forms.TextBox();
            this.SalesLocalATextBox = new System.Windows.Forms.TextBox();
            this.SalesImportETextBox = new System.Windows.Forms.TextBox();
            this.SalesImportDTextBox = new System.Windows.Forms.TextBox();
            this.SalesImportCTextBox = new System.Windows.Forms.TextBox();
            this.SalesImportBTextBox = new System.Windows.Forms.TextBox();
            this.SalesImportATextBox = new System.Windows.Forms.TextBox();
            this.SalesCancelButton = new System.Windows.Forms.Button();
            this.SalesEditButton = new System.Windows.Forms.Button();
            this.SalesNewButton = new System.Windows.Forms.Button();
            this.SalesTagihLocalLabel = new System.Windows.Forms.Label();
            this.SalesTagihImportLabel = new System.Windows.Forms.Label();
            this.SalesOmsetLocalTextBox = new System.Windows.Forms.TextBox();
            this.SalesOmsetLocalLabel = new System.Windows.Forms.Label();
            this.SalesKomisiLocalLabel = new System.Windows.Forms.Label();
            this.SalesKomisiImportLabel = new System.Windows.Forms.Label();
            this.SalesProfitTextBox = new System.Windows.Forms.TextBox();
            this.SalesDiscountTextBox = new System.Windows.Forms.TextBox();
            this.SalesReturnTextBox = new System.Windows.Forms.TextBox();
            this.SalesProfitLabel = new System.Windows.Forms.Label();
            this.SalesDiscountLabel = new System.Windows.Forms.Label();
            this.SalesReturnLabel = new System.Windows.Forms.Label();
            this.SalesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SalesDateInLabel = new System.Windows.Forms.Label();
            this.SalesCityTextBox = new System.Windows.Forms.TextBox();
            this.SalesNameTextBox = new System.Windows.Forms.TextBox();
            this.SalesNotesTextBox = new System.Windows.Forms.TextBox();
            this.SalesTagihTextBox = new System.Windows.Forms.TextBox();
            this.SalesOmsetImportTextBox = new System.Windows.Forms.TextBox();
            this.SalesAddrTextBox = new System.Windows.Forms.TextBox();
            this.SalesPhoneTextBox = new System.Windows.Forms.TextBox();
            this.SalesTagihLabel = new System.Windows.Forms.Label();
            this.SalesPhoneLabel = new System.Windows.Forms.Label();
            this.SalesAddrLabel = new System.Windows.Forms.Label();
            this.SalesNotesLabel = new System.Windows.Forms.Label();
            this.SalesOmsetImportLabel = new System.Windows.Forms.Label();
            this.SalesCityLabel = new System.Windows.Forms.Label();
            this.SalesCodeLabel = new System.Windows.Forms.Label();
            this.SalesNameLabel = new System.Windows.Forms.Label();
            this.salesOLV = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.SupplierFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.SupplierFilterTextBox = new System.Windows.Forms.TextBox();
            this.SuppGroupBox = new System.Windows.Forms.GroupBox();
            this.SupplierCreditDayTextBox = new System.Windows.Forms.ComboBox();
            this.SuppCancelButton = new System.Windows.Forms.Button();
            this.SuppEditButton = new System.Windows.Forms.Button();
            this.SuppNewButton = new System.Windows.Forms.Button();
            this.SupplierJatuhTempoTextBox = new System.Windows.Forms.TextBox();
            this.SupplierJatuhTempoLabel = new System.Windows.Forms.Label();
            this.SupplierCreditDayLabel = new System.Windows.Forms.Label();
            this.SupplierCityTextBox = new System.Windows.Forms.TextBox();
            this.SupplierNameTextBox = new System.Windows.Forms.TextBox();
            this.SupplierNotesTextBox = new System.Windows.Forms.TextBox();
            this.SupplierAddrTextBox = new System.Windows.Forms.TextBox();
            this.SupplierPhoneTextBox = new System.Windows.Forms.TextBox();
            this.SupplierPhoneLabel = new System.Windows.Forms.Label();
            this.SupplierAddrLabel = new System.Windows.Forms.Label();
            this.SupplierNotesLabel = new System.Windows.Forms.Label();
            this.SupplierCityLabel = new System.Windows.Forms.Label();
            this.SupplierCodeLabel = new System.Windows.Forms.Label();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.supplierOLV = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn19 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn20 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn21 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn22 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn23 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn24 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CustomerFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerFilterTextBox = new System.Windows.Forms.TextBox();
            this.CustGroupBox = new System.Windows.Forms.GroupBox();
            this.CustSalesNameTextBox = new System.Windows.Forms.ComboBox();
            this.CustLamaKreditTextBox = new System.Windows.Forms.ComboBox();
            this.CustSalesNumLabel = new System.Windows.Forms.Label();
            this.CustEditButton = new System.Windows.Forms.Button();
            this.CustCancelButton = new System.Windows.Forms.Button();
            this.CustTotalReturnTextBox = new System.Windows.Forms.TextBox();
            this.CustR2TextBox = new System.Windows.Forms.TextBox();
            this.CustR1TextBox = new System.Windows.Forms.TextBox();
            this.CustCityTextBox = new System.Windows.Forms.TextBox();
            this.CustTotalReturnLabel = new System.Windows.Forms.Label();
            this.CustSR2Label = new System.Windows.Forms.Label();
            this.CustSR1Label = new System.Windows.Forms.Label();
            this.CustJ3TextBox = new System.Windows.Forms.TextBox();
            this.CustJ2TextBox = new System.Windows.Forms.TextBox();
            this.CustJ1TextBox = new System.Windows.Forms.TextBox();
            this.CustSJ3Label = new System.Windows.Forms.Label();
            this.CustSJ2Label = new System.Windows.Forms.Label();
            this.CustSJ1Label = new System.Windows.Forms.Label();
            this.CustNewButton = new System.Windows.Forms.Button();
            this.CustNameTextBox = new System.Windows.Forms.TextBox();
            this.CustMarketCheckBox = new System.Windows.Forms.CheckBox();
            this.CustNpwpAddrTextBox = new wmgCMS.WaterMarkTextBox();
            this.CustNpwpNameTextBox = new wmgCMS.WaterMarkTextBox();
            this.CustNotesTextBox = new System.Windows.Forms.TextBox();
            this.CustJatuhTempoTextBox = new System.Windows.Forms.TextBox();
            this.CustPiutangTextBox = new System.Windows.Forms.TextBox();
            this.CustAddr2TextBox = new System.Windows.Forms.TextBox();
            this.CustAddr1TextBox = new System.Windows.Forms.TextBox();
            this.CustPhoneTextBox = new System.Windows.Forms.TextBox();
            this.CustNpwpNumTextBox = new wmgCMS.WaterMarkTextBox();
            this.CustLamaKreditLabel = new System.Windows.Forms.Label();
            this.CustJatuhTempoLabel = new System.Windows.Forms.Label();
            this.CustNpwpLabel = new System.Windows.Forms.Label();
            this.CustSalesCodeLabel = new System.Windows.Forms.Label();
            this.TelpCustLabel = new System.Windows.Forms.Label();
            this.CustAddr2Label = new System.Windows.Forms.Label();
            this.CustAddr1Label = new System.Windows.Forms.Label();
            this.CustNotesLabel = new System.Windows.Forms.Label();
            this.CustPiutangLabel = new System.Windows.Forms.Label();
            this.CustCityLabel = new System.Windows.Forms.Label();
            this.CustSalesNameLabel = new System.Windows.Forms.Label();
            this.CustCodeLabel = new System.Windows.Forms.Label();
            this.CustNameLabel = new System.Windows.Forms.Label();
            this.customerOLV = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ItemBeliOLV = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn36 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn37 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn38 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FakturBeliOLV = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn32 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn33 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn34 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn35 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ItemBeliDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemBeliDeleteButton = new System.Windows.Forms.Button();
            this.ItemBeliTanggalTextBox = new System.Windows.Forms.TextBox();
            this.ItemBeliTotalLabel = new System.Windows.Forms.Label();
            this.ItemBeliTotalTextBox = new System.Windows.Forms.TextBox();
            this.ItemBeliQtyTextBox = new System.Windows.Forms.TextBox();
            this.ItemBeliHargaBeliTextBox = new System.Windows.Forms.TextBox();
            this.ItemBeliStokIDComboBox = new System.Windows.Forms.ComboBox();
            this.ItemBeliEditButton = new System.Windows.Forms.Button();
            this.ItemBeliCancelButton = new System.Windows.Forms.Button();
            this.ItemBeliNewButton = new System.Windows.Forms.Button();
            this.ItemBeliPictureBox = new System.Windows.Forms.PictureBox();
            this.ItemBeliTanggalLabel = new System.Windows.Forms.Label();
            this.ItemBeliQtyLabel = new System.Windows.Forms.Label();
            this.ItemBeliHargaBeliLabel = new System.Windows.Forms.Label();
            this.ItemBeliStokIDLabel = new System.Windows.Forms.Label();
            this.FakturBeliDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.FakturBeliTanggalTextBox = new System.Windows.Forms.TextBox();
            this.FakturBeliTanggalPajakDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FakturBeliJlhItemTextBox = new System.Windows.Forms.TextBox();
            this.FakturBeliTanggalPajakLabel = new System.Windows.Forms.Label();
            this.FakturBeliNoPajakTextBox = new System.Windows.Forms.TextBox();
            this.FakturBeliNoPajakLabel = new System.Windows.Forms.Label();
            this.FakturBeliNoFakturTextBox = new System.Windows.Forms.TextBox();
            this.FakturBeliKodeSuppTextBox = new System.Windows.Forms.TextBox();
            this.FakturBeliJatuhTempoTextBox = new System.Windows.Forms.TextBox();
            this.FakturBeliTotalBeliTextBox = new System.Windows.Forms.TextBox();
            this.FakturBeliTotalPPNTextBox = new System.Windows.Forms.TextBox();
            this.FakturBeliTotalAkhirTextBox = new System.Windows.Forms.TextBox();
            this.FakturBeliCashKreditComboBox = new System.Windows.Forms.ComboBox();
            this.FakturBeliNamaSuppComboBox = new System.Windows.Forms.ComboBox();
            this.FakturBeliBeliReturnComboBox = new System.Windows.Forms.ComboBox();
            this.FakturBeliCancelButton = new System.Windows.Forms.Button();
            this.FakturBeliEditButton = new System.Windows.Forms.Button();
            this.FakturBeliNewButton = new System.Windows.Forms.Button();
            this.FakturBeliTotalPPNLabel = new System.Windows.Forms.Label();
            this.FakturBeliPPNCheckBox = new System.Windows.Forms.CheckBox();
            this.FakturBeliTotalBeliLabel = new System.Windows.Forms.Label();
            this.FakturBeliTanggalLabel = new System.Windows.Forms.Label();
            this.FakturBeliTotalAkhirLabel = new System.Windows.Forms.Label();
            this.FakturBeliCashKreditLabel = new System.Windows.Forms.Label();
            this.FakturBeliJatuhTempoLabel = new System.Windows.Forms.Label();
            this.FakturBeliNamaSuppLabel = new System.Windows.Forms.Label();
            this.FakturBeliKodeSuppLabel = new System.Windows.Forms.Label();
            this.FakturBeliBeliReturnLabel = new System.Windows.Forms.Label();
            this.FakturBeliJlhItemLabel = new System.Windows.Forms.Label();
            this.FakturBeliNoFakturLabel = new System.Windows.Forms.Label();
            this.FakturBeliFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.FakturBeliFilterTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FakturJualFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.FakturJualFilterTextBox = new System.Windows.Forms.TextBox();
            this.ItemJualDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemJualDiscountTextBox = new System.Windows.Forms.TextBox();
            this.ItemJualDiscountLabel = new System.Windows.Forms.Label();
            this.ItemJualDeleteButton = new System.Windows.Forms.Button();
            this.ItemJualHargaPokokTextBox = new System.Windows.Forms.TextBox();
            this.ItemJualTanggalTextBox = new System.Windows.Forms.TextBox();
            this.ItemJualProfitTextBox = new System.Windows.Forms.TextBox();
            this.ItemJualQtyTextBox = new System.Windows.Forms.TextBox();
            this.ItemJualHargaJualTextBox = new System.Windows.Forms.TextBox();
            this.ItemJualStokIDComboBox = new System.Windows.Forms.ComboBox();
            this.ItemJualEditButton = new System.Windows.Forms.Button();
            this.ItemJualCancelButton = new System.Windows.Forms.Button();
            this.ItemJualNewButton = new System.Windows.Forms.Button();
            this.ItemJualPictureBox = new System.Windows.Forms.PictureBox();
            this.ItemJualTanggalLabel = new System.Windows.Forms.Label();
            this.ItemJualQtyLabel = new System.Windows.Forms.Label();
            this.ItemJualHargaPokokLabel = new System.Windows.Forms.Label();
            this.ItemJualProfitLabel = new System.Windows.Forms.Label();
            this.ItemJualHargaJualLabel = new System.Windows.Forms.Label();
            this.ItemJualStokIDLabel = new System.Windows.Forms.Label();
            this.FakturJualDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.FakturJualTanggalTextBox = new System.Windows.Forms.TextBox();
            this.FakturJualJlhItemTextBox = new System.Windows.Forms.TextBox();
            this.FakturJualTanggalLunasTextBox = new System.Windows.Forms.TextBox();
            this.FakturJualTanggalLunasLabel = new System.Windows.Forms.Label();
            this.FakturJualNoFakturTextBox = new System.Windows.Forms.TextBox();
            this.FakturJualKodeCustomerTextBox = new System.Windows.Forms.TextBox();
            this.FakturJualKodeSalesTextBox = new System.Windows.Forms.TextBox();
            this.FakturJualNamaSalesTextBox = new System.Windows.Forms.TextBox();
            this.FakturJualJthTempoTextBox = new System.Windows.Forms.TextBox();
            this.FakturJualTotalJualTextBox = new System.Windows.Forms.TextBox();
            this.FakturJualTotalPPNTextBox = new System.Windows.Forms.TextBox();
            this.FakturJualTotalAkhirTextBox = new System.Windows.Forms.TextBox();
            this.FakturJualCashKreditComboBox = new System.Windows.Forms.ComboBox();
            this.FakturJualNamaCustComboBox = new System.Windows.Forms.ComboBox();
            this.FakturJualJualReturnComboBox = new System.Windows.Forms.ComboBox();
            this.FakturJualCancelButton = new System.Windows.Forms.Button();
            this.FakturJualEditButton = new System.Windows.Forms.Button();
            this.FakturJualNewButton = new System.Windows.Forms.Button();
            this.FakturJualTotalPPNLabel = new System.Windows.Forms.Label();
            this.FakturJualPPNCheckBox = new System.Windows.Forms.CheckBox();
            this.FakturJualTotalJualLabel = new System.Windows.Forms.Label();
            this.FakturJualTanggalabel = new System.Windows.Forms.Label();
            this.FakturJualTotalAkhirLabel = new System.Windows.Forms.Label();
            this.FakturJualNamaSalesLabel = new System.Windows.Forms.Label();
            this.FakturJualCashKreditLabel = new System.Windows.Forms.Label();
            this.FakturJualKodeSalesLabel = new System.Windows.Forms.Label();
            this.FakturJualJthTempoLabel = new System.Windows.Forms.Label();
            this.FakturJualNamaCustLabel = new System.Windows.Forms.Label();
            this.FakturJualKodeCustomerLabel = new System.Windows.Forms.Label();
            this.FakturJualJualReturnLabel = new System.Windows.Forms.Label();
            this.FakturJualJlhItemLabel = new System.Windows.Forms.Label();
            this.FakturJualNoFakturLabel = new System.Windows.Forms.Label();
            this.ItemJualOLV = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn29 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn30 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn31 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FakturJualOLV = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn25 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn26 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn27 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn28 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.PiutangOLV = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn39 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn40 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn41 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn42 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn43 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn44 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn49 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GrafikComboBox = new System.Windows.Forms.ComboBox();
            this.LaporanChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FakturJualPrintButton = new System.Windows.Forms.Button();
            this.FakturBeliPrintButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PembayaranDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PembayaranOLV)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.StokFilterGroupBox.SuspendLayout();
            this.StokGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokOLV)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SalesFilterGroupBox.SuspendLayout();
            this.SalesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesOLV)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SupplierFilterGroupBox.SuspendLayout();
            this.SuppGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierOLV)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.CustomerFilterGroupBox.SuspendLayout();
            this.CustGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerOLV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBeliOLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FakturBeliOLV)).BeginInit();
            this.ItemBeliDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBeliPictureBox)).BeginInit();
            this.FakturBeliDetailsGroupBox.SuspendLayout();
            this.FakturBeliFilterGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.FakturJualFilterGroupBox.SuspendLayout();
            this.ItemJualDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemJualPictureBox)).BeginInit();
            this.FakturJualDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemJualOLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FakturJualOLV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PiutangOLV)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaporanChart)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TimeLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(1387, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(112, 23);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "Time";
            // 
            // olvHdr
            // 
            headerStateStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.olvHdr.Hot = headerStateStyle1;
            headerStateStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            headerStateStyle2.ForeColor = System.Drawing.Color.Black;
            this.olvHdr.Normal = headerStateStyle2;
            headerStateStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.olvHdr.Pressed = headerStateStyle3;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ubahTanggalToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // ubahTanggalToolStripMenuItem
            // 
            this.ubahTanggalToolStripMenuItem.Name = "ubahTanggalToolStripMenuItem";
            this.ubahTanggalToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ubahTanggalToolStripMenuItem.Text = "Ubah Tanggal";
            this.ubahTanggalToolStripMenuItem.Click += new System.EventHandler(this.ubahTanggalToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ubahPasswordToolStripMenuItem,
            this.tambahPasswordToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // ubahPasswordToolStripMenuItem
            // 
            this.ubahPasswordToolStripMenuItem.Name = "ubahPasswordToolStripMenuItem";
            this.ubahPasswordToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ubahPasswordToolStripMenuItem.Text = "Ubah Password";
            this.ubahPasswordToolStripMenuItem.Click += new System.EventHandler(this.ubahPasswordToolStripMenuItem_Click);
            // 
            // tambahPasswordToolStripMenuItem
            // 
            this.tambahPasswordToolStripMenuItem.Name = "tambahPasswordToolStripMenuItem";
            this.tambahPasswordToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.tambahPasswordToolStripMenuItem.Text = "Tambah Password";
            this.tambahPasswordToolStripMenuItem.Click += new System.EventHandler(this.tambahPasswordToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.userToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1343, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // callToolStripMenuItem
            // 
            this.callToolStripMenuItem.Name = "callToolStripMenuItem";
            this.callToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.callToolStripMenuItem.Text = "Call: 081361192417";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox2);
            this.tabPage7.Controls.Add(this.PembayaranDetailsGroupBox);
            this.tabPage7.Controls.Add(this.PembayaranOLV);
            this.tabPage7.Location = new System.Drawing.Point(4, 26);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1338, 629);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Pembayaran";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(463, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 59);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 14;
            // 
            // PembayaranDetailsGroupBox
            // 
            this.PembayaranDetailsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNilaiTextBox);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNilaiLabel);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranKeteranganTextBox);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranSudahCairComboBox);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNoFakturComboBox4);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNoFakturComboBox3);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNoFakturComboBox2);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNoFakturComboBox1);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNamaCustLabel);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNamaCustComboBox);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranJthTempoDatePicker);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranTglGiroDatePicker);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranKodeCustTextBox);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNoRekTextBox);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNamaBankTextBox);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranKeteranganLabel);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranSudahCairLabel);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranSisaLabel);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranBayarLabel);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranTotalFakturLabel);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNoFakturLabel);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranKodeCustLabel);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranJthTempoLabel);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNoRekLabel);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranCancelButton);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranEditButton);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNewButton);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNoGiroTextBox);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranTglGiroLabel);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNamaBankLabel);
            this.PembayaranDetailsGroupBox.Controls.Add(this.PembayaranNoGiroLabel);
            this.PembayaranDetailsGroupBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranDetailsGroupBox.Location = new System.Drawing.Point(582, 6);
            this.PembayaranDetailsGroupBox.Name = "PembayaranDetailsGroupBox";
            this.PembayaranDetailsGroupBox.Size = new System.Drawing.Size(745, 620);
            this.PembayaranDetailsGroupBox.TabIndex = 8;
            this.PembayaranDetailsGroupBox.TabStop = false;
            this.PembayaranDetailsGroupBox.Text = "Detail";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(99, 279);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 156);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // PembayaranNilaiTextBox
            // 
            this.PembayaranNilaiTextBox.Enabled = false;
            this.PembayaranNilaiTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNilaiTextBox.Location = new System.Drawing.Point(109, 177);
            this.PembayaranNilaiTextBox.Name = "PembayaranNilaiTextBox";
            this.PembayaranNilaiTextBox.Size = new System.Drawing.Size(138, 26);
            this.PembayaranNilaiTextBox.TabIndex = 6;
            // 
            // PembayaranNilaiLabel
            // 
            this.PembayaranNilaiLabel.AutoSize = true;
            this.PembayaranNilaiLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNilaiLabel.Location = new System.Drawing.Point(8, 180);
            this.PembayaranNilaiLabel.Name = "PembayaranNilaiLabel";
            this.PembayaranNilaiLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PembayaranNilaiLabel.Size = new System.Drawing.Size(70, 19);
            this.PembayaranNilaiLabel.TabIndex = 77;
            this.PembayaranNilaiLabel.Text = "Nilai Rp : ";
            this.PembayaranNilaiLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PembayaranKeteranganTextBox
            // 
            this.PembayaranKeteranganTextBox.Enabled = false;
            this.PembayaranKeteranganTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranKeteranganTextBox.Location = new System.Drawing.Point(115, 476);
            this.PembayaranKeteranganTextBox.Name = "PembayaranKeteranganTextBox";
            this.PembayaranKeteranganTextBox.Size = new System.Drawing.Size(292, 26);
            this.PembayaranKeteranganTextBox.TabIndex = 13;
            // 
            // PembayaranSudahCairComboBox
            // 
            this.PembayaranSudahCairComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PembayaranSudahCairComboBox.Enabled = false;
            this.PembayaranSudahCairComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PembayaranSudahCairComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranSudahCairComboBox.FormattingEnabled = true;
            this.PembayaranSudahCairComboBox.Location = new System.Drawing.Point(115, 441);
            this.PembayaranSudahCairComboBox.Name = "PembayaranSudahCairComboBox";
            this.PembayaranSudahCairComboBox.Size = new System.Drawing.Size(48, 27);
            this.PembayaranSudahCairComboBox.TabIndex = 12;
            // 
            // PembayaranNoFakturComboBox4
            // 
            this.PembayaranNoFakturComboBox4.Enabled = false;
            this.PembayaranNoFakturComboBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNoFakturComboBox4.FormattingEnabled = true;
            this.PembayaranNoFakturComboBox4.Location = new System.Drawing.Point(577, 282);
            this.PembayaranNoFakturComboBox4.Name = "PembayaranNoFakturComboBox4";
            this.PembayaranNoFakturComboBox4.Size = new System.Drawing.Size(138, 27);
            this.PembayaranNoFakturComboBox4.TabIndex = 11;
            // 
            // PembayaranNoFakturComboBox3
            // 
            this.PembayaranNoFakturComboBox3.Enabled = false;
            this.PembayaranNoFakturComboBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNoFakturComboBox3.FormattingEnabled = true;
            this.PembayaranNoFakturComboBox3.Location = new System.Drawing.Point(422, 282);
            this.PembayaranNoFakturComboBox3.Name = "PembayaranNoFakturComboBox3";
            this.PembayaranNoFakturComboBox3.Size = new System.Drawing.Size(138, 27);
            this.PembayaranNoFakturComboBox3.TabIndex = 10;
            // 
            // PembayaranNoFakturComboBox2
            // 
            this.PembayaranNoFakturComboBox2.Enabled = false;
            this.PembayaranNoFakturComboBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNoFakturComboBox2.FormattingEnabled = true;
            this.PembayaranNoFakturComboBox2.Location = new System.Drawing.Point(269, 282);
            this.PembayaranNoFakturComboBox2.Name = "PembayaranNoFakturComboBox2";
            this.PembayaranNoFakturComboBox2.Size = new System.Drawing.Size(138, 27);
            this.PembayaranNoFakturComboBox2.TabIndex = 9;
            // 
            // PembayaranNoFakturComboBox1
            // 
            this.PembayaranNoFakturComboBox1.Enabled = false;
            this.PembayaranNoFakturComboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNoFakturComboBox1.FormattingEnabled = true;
            this.PembayaranNoFakturComboBox1.Location = new System.Drawing.Point(115, 282);
            this.PembayaranNoFakturComboBox1.Name = "PembayaranNoFakturComboBox1";
            this.PembayaranNoFakturComboBox1.Size = new System.Drawing.Size(138, 27);
            this.PembayaranNoFakturComboBox1.TabIndex = 8;
            // 
            // PembayaranNamaCustLabel
            // 
            this.PembayaranNamaCustLabel.AutoSize = true;
            this.PembayaranNamaCustLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNamaCustLabel.Location = new System.Drawing.Point(8, 215);
            this.PembayaranNamaCustLabel.Name = "PembayaranNamaCustLabel";
            this.PembayaranNamaCustLabel.Size = new System.Drawing.Size(120, 19);
            this.PembayaranNamaCustLabel.TabIndex = 60;
            this.PembayaranNamaCustLabel.Text = "Nama Customer : ";
            // 
            // PembayaranNamaCustComboBox
            // 
            this.PembayaranNamaCustComboBox.Enabled = false;
            this.PembayaranNamaCustComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNamaCustComboBox.FormattingEnabled = true;
            this.PembayaranNamaCustComboBox.Location = new System.Drawing.Point(134, 212);
            this.PembayaranNamaCustComboBox.Name = "PembayaranNamaCustComboBox";
            this.PembayaranNamaCustComboBox.Size = new System.Drawing.Size(138, 27);
            this.PembayaranNamaCustComboBox.TabIndex = 7;
            this.PembayaranNamaCustComboBox.SelectedIndexChanged += new System.EventHandler(this.PembayaranNamaCustComboBox_SelectedIndexChanged);
            // 
            // PembayaranJthTempoDatePicker
            // 
            this.PembayaranJthTempoDatePicker.Enabled = false;
            this.PembayaranJthTempoDatePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranJthTempoDatePicker.Location = new System.Drawing.Point(109, 142);
            this.PembayaranJthTempoDatePicker.Name = "PembayaranJthTempoDatePicker";
            this.PembayaranJthTempoDatePicker.Size = new System.Drawing.Size(253, 26);
            this.PembayaranJthTempoDatePicker.TabIndex = 5;
            // 
            // PembayaranTglGiroDatePicker
            // 
            this.PembayaranTglGiroDatePicker.Enabled = false;
            this.PembayaranTglGiroDatePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranTglGiroDatePicker.Location = new System.Drawing.Point(471, 37);
            this.PembayaranTglGiroDatePicker.Name = "PembayaranTglGiroDatePicker";
            this.PembayaranTglGiroDatePicker.Size = new System.Drawing.Size(253, 26);
            this.PembayaranTglGiroDatePicker.TabIndex = 2;
            // 
            // PembayaranKodeCustTextBox
            // 
            this.PembayaranKodeCustTextBox.Enabled = false;
            this.PembayaranKodeCustTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranKodeCustTextBox.Location = new System.Drawing.Point(134, 247);
            this.PembayaranKodeCustTextBox.Name = "PembayaranKodeCustTextBox";
            this.PembayaranKodeCustTextBox.ReadOnly = true;
            this.PembayaranKodeCustTextBox.Size = new System.Drawing.Size(138, 26);
            this.PembayaranKodeCustTextBox.TabIndex = 53;
            // 
            // PembayaranNoRekTextBox
            // 
            this.PembayaranNoRekTextBox.Enabled = false;
            this.PembayaranNoRekTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNoRekTextBox.Location = new System.Drawing.Point(109, 107);
            this.PembayaranNoRekTextBox.Name = "PembayaranNoRekTextBox";
            this.PembayaranNoRekTextBox.Size = new System.Drawing.Size(138, 26);
            this.PembayaranNoRekTextBox.TabIndex = 4;
            // 
            // PembayaranNamaBankTextBox
            // 
            this.PembayaranNamaBankTextBox.Enabled = false;
            this.PembayaranNamaBankTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNamaBankTextBox.Location = new System.Drawing.Point(109, 72);
            this.PembayaranNamaBankTextBox.Name = "PembayaranNamaBankTextBox";
            this.PembayaranNamaBankTextBox.Size = new System.Drawing.Size(138, 26);
            this.PembayaranNamaBankTextBox.TabIndex = 3;
            // 
            // PembayaranKeteranganLabel
            // 
            this.PembayaranKeteranganLabel.AutoSize = true;
            this.PembayaranKeteranganLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranKeteranganLabel.Location = new System.Drawing.Point(8, 479);
            this.PembayaranKeteranganLabel.Name = "PembayaranKeteranganLabel";
            this.PembayaranKeteranganLabel.Size = new System.Drawing.Size(90, 19);
            this.PembayaranKeteranganLabel.TabIndex = 50;
            this.PembayaranKeteranganLabel.Text = "Keterangan : ";
            // 
            // PembayaranSudahCairLabel
            // 
            this.PembayaranSudahCairLabel.AutoSize = true;
            this.PembayaranSudahCairLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranSudahCairLabel.Location = new System.Drawing.Point(8, 444);
            this.PembayaranSudahCairLabel.Name = "PembayaranSudahCairLabel";
            this.PembayaranSudahCairLabel.Size = new System.Drawing.Size(88, 19);
            this.PembayaranSudahCairLabel.TabIndex = 48;
            this.PembayaranSudahCairLabel.Text = "Sudah Cair : ";
            // 
            // PembayaranSisaLabel
            // 
            this.PembayaranSisaLabel.AutoSize = true;
            this.PembayaranSisaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranSisaLabel.Location = new System.Drawing.Point(8, 390);
            this.PembayaranSisaLabel.Name = "PembayaranSisaLabel";
            this.PembayaranSisaLabel.Size = new System.Drawing.Size(45, 19);
            this.PembayaranSisaLabel.TabIndex = 47;
            this.PembayaranSisaLabel.Text = "Sisa : ";
            // 
            // PembayaranBayarLabel
            // 
            this.PembayaranBayarLabel.AutoSize = true;
            this.PembayaranBayarLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranBayarLabel.Location = new System.Drawing.Point(8, 355);
            this.PembayaranBayarLabel.Name = "PembayaranBayarLabel";
            this.PembayaranBayarLabel.Size = new System.Drawing.Size(56, 19);
            this.PembayaranBayarLabel.TabIndex = 46;
            this.PembayaranBayarLabel.Text = "Bayar : ";
            // 
            // PembayaranTotalFakturLabel
            // 
            this.PembayaranTotalFakturLabel.AutoSize = true;
            this.PembayaranTotalFakturLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranTotalFakturLabel.Location = new System.Drawing.Point(8, 320);
            this.PembayaranTotalFakturLabel.Name = "PembayaranTotalFakturLabel";
            this.PembayaranTotalFakturLabel.Size = new System.Drawing.Size(94, 19);
            this.PembayaranTotalFakturLabel.TabIndex = 45;
            this.PembayaranTotalFakturLabel.Text = "Total Faktur : ";
            // 
            // PembayaranNoFakturLabel
            // 
            this.PembayaranNoFakturLabel.AutoSize = true;
            this.PembayaranNoFakturLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNoFakturLabel.Location = new System.Drawing.Point(8, 285);
            this.PembayaranNoFakturLabel.Name = "PembayaranNoFakturLabel";
            this.PembayaranNoFakturLabel.Size = new System.Drawing.Size(84, 19);
            this.PembayaranNoFakturLabel.TabIndex = 44;
            this.PembayaranNoFakturLabel.Text = "No Faktur : ";
            // 
            // PembayaranKodeCustLabel
            // 
            this.PembayaranKodeCustLabel.AutoSize = true;
            this.PembayaranKodeCustLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranKodeCustLabel.Location = new System.Drawing.Point(8, 250);
            this.PembayaranKodeCustLabel.Name = "PembayaranKodeCustLabel";
            this.PembayaranKodeCustLabel.Size = new System.Drawing.Size(118, 19);
            this.PembayaranKodeCustLabel.TabIndex = 43;
            this.PembayaranKodeCustLabel.Text = "Kode Customer : ";
            // 
            // PembayaranJthTempoLabel
            // 
            this.PembayaranJthTempoLabel.AutoSize = true;
            this.PembayaranJthTempoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranJthTempoLabel.Location = new System.Drawing.Point(8, 145);
            this.PembayaranJthTempoLabel.Name = "PembayaranJthTempoLabel";
            this.PembayaranJthTempoLabel.Size = new System.Drawing.Size(97, 19);
            this.PembayaranJthTempoLabel.TabIndex = 42;
            this.PembayaranJthTempoLabel.Text = "Jatuh Tempo : ";
            // 
            // PembayaranNoRekLabel
            // 
            this.PembayaranNoRekLabel.AutoSize = true;
            this.PembayaranNoRekLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNoRekLabel.Location = new System.Drawing.Point(8, 110);
            this.PembayaranNoRekLabel.Name = "PembayaranNoRekLabel";
            this.PembayaranNoRekLabel.Size = new System.Drawing.Size(96, 19);
            this.PembayaranNoRekLabel.TabIndex = 41;
            this.PembayaranNoRekLabel.Text = "NoRekening : ";
            // 
            // PembayaranCancelButton
            // 
            this.PembayaranCancelButton.Enabled = false;
            this.PembayaranCancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranCancelButton.Location = new System.Drawing.Point(99, 566);
            this.PembayaranCancelButton.Name = "PembayaranCancelButton";
            this.PembayaranCancelButton.Size = new System.Drawing.Size(75, 35);
            this.PembayaranCancelButton.TabIndex = 40;
            this.PembayaranCancelButton.Text = "Cancel";
            this.PembayaranCancelButton.UseVisualStyleBackColor = true;
            this.PembayaranCancelButton.Click += new System.EventHandler(this.PembayaranCancelButton_Click);
            // 
            // PembayaranEditButton
            // 
            this.PembayaranEditButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranEditButton.Location = new System.Drawing.Point(178, 566);
            this.PembayaranEditButton.Name = "PembayaranEditButton";
            this.PembayaranEditButton.Size = new System.Drawing.Size(75, 35);
            this.PembayaranEditButton.TabIndex = 39;
            this.PembayaranEditButton.Text = "Edit";
            this.PembayaranEditButton.UseVisualStyleBackColor = true;
            this.PembayaranEditButton.Click += new System.EventHandler(this.PembayaraEditButton_Click);
            // 
            // PembayaranNewButton
            // 
            this.PembayaranNewButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNewButton.Location = new System.Drawing.Point(18, 566);
            this.PembayaranNewButton.Name = "PembayaranNewButton";
            this.PembayaranNewButton.Size = new System.Drawing.Size(75, 35);
            this.PembayaranNewButton.TabIndex = 15;
            this.PembayaranNewButton.Text = "Baru";
            this.PembayaranNewButton.UseVisualStyleBackColor = true;
            this.PembayaranNewButton.Click += new System.EventHandler(this.PembayaranNewButton_Click);
            // 
            // PembayaranNoGiroTextBox
            // 
            this.PembayaranNoGiroTextBox.Enabled = false;
            this.PembayaranNoGiroTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNoGiroTextBox.Location = new System.Drawing.Point(109, 37);
            this.PembayaranNoGiroTextBox.Name = "PembayaranNoGiroTextBox";
            this.PembayaranNoGiroTextBox.Size = new System.Drawing.Size(183, 26);
            this.PembayaranNoGiroTextBox.TabIndex = 1;
            // 
            // PembayaranTglGiroLabel
            // 
            this.PembayaranTglGiroLabel.AutoSize = true;
            this.PembayaranTglGiroLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranTglGiroLabel.Location = new System.Drawing.Point(395, 40);
            this.PembayaranTglGiroLabel.Name = "PembayaranTglGiroLabel";
            this.PembayaranTglGiroLabel.Size = new System.Drawing.Size(70, 19);
            this.PembayaranTglGiroLabel.TabIndex = 0;
            this.PembayaranTglGiroLabel.Text = "Tgl Giro : ";
            // 
            // PembayaranNamaBankLabel
            // 
            this.PembayaranNamaBankLabel.AutoSize = true;
            this.PembayaranNamaBankLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNamaBankLabel.Location = new System.Drawing.Point(8, 75);
            this.PembayaranNamaBankLabel.Name = "PembayaranNamaBankLabel";
            this.PembayaranNamaBankLabel.Size = new System.Drawing.Size(89, 19);
            this.PembayaranNamaBankLabel.TabIndex = 0;
            this.PembayaranNamaBankLabel.Text = "NamaBank : ";
            // 
            // PembayaranNoGiroLabel
            // 
            this.PembayaranNoGiroLabel.AutoSize = true;
            this.PembayaranNoGiroLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranNoGiroLabel.Location = new System.Drawing.Point(8, 40);
            this.PembayaranNoGiroLabel.Name = "PembayaranNoGiroLabel";
            this.PembayaranNoGiroLabel.Size = new System.Drawing.Size(79, 19);
            this.PembayaranNoGiroLabel.TabIndex = 0;
            this.PembayaranNoGiroLabel.Text = "No. Giro  : ";
            // 
            // PembayaranOLV
            // 
            this.PembayaranOLV.AllColumns.Add(this.olvColumn45);
            this.PembayaranOLV.AllColumns.Add(this.olvColumn46);
            this.PembayaranOLV.AllColumns.Add(this.olvColumn47);
            this.PembayaranOLV.AllColumns.Add(this.olvColumn48);
            this.PembayaranOLV.AllowDrop = true;
            this.PembayaranOLV.AlternateRowBackColor = System.Drawing.Color.LemonChiffon;
            this.PembayaranOLV.CellEditUseWholeCell = false;
            this.PembayaranOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn45,
            this.olvColumn46,
            this.olvColumn47,
            this.olvColumn48});
            this.PembayaranOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.PembayaranOLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembayaranOLV.FullRowSelect = true;
            this.PembayaranOLV.HeaderFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.PembayaranOLV.HeaderFormatStyle = this.olvHdr;
            this.PembayaranOLV.Location = new System.Drawing.Point(6, 72);
            this.PembayaranOLV.Name = "PembayaranOLV";
            this.PembayaranOLV.ShowGroups = false;
            this.PembayaranOLV.Size = new System.Drawing.Size(570, 554);
            this.PembayaranOLV.TabIndex = 2;
            this.PembayaranOLV.UseAlternatingBackColors = true;
            this.PembayaranOLV.UseCompatibleStateImageBehavior = false;
            this.PembayaranOLV.UseFilterIndicator = true;
            this.PembayaranOLV.UseFiltering = true;
            this.PembayaranOLV.View = System.Windows.Forms.View.Details;
            this.PembayaranOLV.VirtualMode = true;
            this.PembayaranOLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.PembayaranOLV_ItemSelectionChanged);
            // 
            // olvColumn45
            // 
            this.olvColumn45.AspectName = "NoGiro";
            this.olvColumn45.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn45.Text = "No Giro";
            this.olvColumn45.UseInitialLetterForGroup = true;
            this.olvColumn45.Width = 154;
            // 
            // olvColumn46
            // 
            this.olvColumn46.AspectName = "NamaCustomer";
            this.olvColumn46.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn46.Text = "Nama Customer";
            this.olvColumn46.UseInitialLetterForGroup = true;
            this.olvColumn46.Width = 220;
            // 
            // olvColumn47
            // 
            this.olvColumn47.AspectName = "Sisa";
            this.olvColumn47.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn47.Text = "Sisa";
            this.olvColumn47.UseInitialLetterForGroup = true;
            this.olvColumn47.Width = 70;
            // 
            // olvColumn48
            // 
            this.olvColumn48.AspectName = "JatuhTempo";
            this.olvColumn48.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn48.Text = "Jatuh Tempo";
            this.olvColumn48.UseInitialLetterForGroup = true;
            this.olvColumn48.Width = 110;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.StokFilterGroupBox);
            this.tabPage6.Controls.Add(this.StokGroupBox);
            this.tabPage6.Controls.Add(this.stokOLV);
            this.tabPage6.Location = new System.Drawing.Point(4, 26);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1338, 629);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Stok";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // StokFilterGroupBox
            // 
            this.StokFilterGroupBox.Controls.Add(this.StokFilterTextBox);
            this.StokFilterGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokFilterGroupBox.Location = new System.Drawing.Point(739, 7);
            this.StokFilterGroupBox.Name = "StokFilterGroupBox";
            this.StokFilterGroupBox.Size = new System.Drawing.Size(113, 59);
            this.StokFilterGroupBox.TabIndex = 8;
            this.StokFilterGroupBox.TabStop = false;
            this.StokFilterGroupBox.Text = "Filter";
            // 
            // StokFilterTextBox
            // 
            this.StokFilterTextBox.Location = new System.Drawing.Point(6, 25);
            this.StokFilterTextBox.Name = "StokFilterTextBox";
            this.StokFilterTextBox.Size = new System.Drawing.Size(100, 26);
            this.StokFilterTextBox.TabIndex = 0;
            this.StokFilterTextBox.TextChanged += new System.EventHandler(this.StokFilterTextBox_TextChanged);
            // 
            // StokGroupBox
            // 
            this.StokGroupBox.Controls.Add(this.StokPhotoTextBox);
            this.StokGroupBox.Controls.Add(this.StokPhotoLabel);
            this.StokGroupBox.Controls.Add(this.StokBrowseButton);
            this.StokGroupBox.Controls.Add(this.StockIDLabel);
            this.StokGroupBox.Controls.Add(this.StokBuatanTextBox);
            this.StokGroupBox.Controls.Add(this.StokCancelButton);
            this.StokGroupBox.Controls.Add(this.StokEditButton);
            this.StokGroupBox.Controls.Add(this.StokNewButton);
            this.StokGroupBox.Controls.Add(this.StokIDTextBox);
            this.StokGroupBox.Controls.Add(this.StokHargaListTextBox);
            this.StokGroupBox.Controls.Add(this.StokHargaPokokTextBox);
            this.StokGroupBox.Controls.Add(this.StokHargaListLabel);
            this.StokGroupBox.Controls.Add(this.StokHargaPokokLabel);
            this.StokGroupBox.Controls.Add(this.StokSaldoAkhirTextBox);
            this.StokGroupBox.Controls.Add(this.StokSaldoAwalTextBox);
            this.StokGroupBox.Controls.Add(this.StokKategoriTextBox);
            this.StokGroupBox.Controls.Add(this.StokKategoriLabel);
            this.StokGroupBox.Controls.Add(this.StolBuatanLabel);
            this.StokGroupBox.Controls.Add(this.StockEndLabel);
            this.StokGroupBox.Controls.Add(this.StockInitialLabel);
            this.StokGroupBox.Controls.Add(this.StockDateInDateTextBox);
            this.StokGroupBox.Controls.Add(this.StokDateInLabel);
            this.StokGroupBox.Controls.Add(this.StokDimensionsTextBox);
            this.StokGroupBox.Controls.Add(this.StokWeightTextBox);
            this.StokGroupBox.Controls.Add(this.StokCollyTextBox);
            this.StokGroupBox.Controls.Add(this.StokDimensionsLabel);
            this.StokGroupBox.Controls.Add(this.StokWeightLabel);
            this.StokGroupBox.Controls.Add(this.StokCollyLabel);
            this.StokGroupBox.Controls.Add(this.StockDateListDateTextBox);
            this.StokGroupBox.Controls.Add(this.StokDateListLabel);
            this.StokGroupBox.Controls.Add(this.StokColorTextBox);
            this.StokGroupBox.Controls.Add(this.StokNameTextBox);
            this.StokGroupBox.Controls.Add(this.StokNotesTextBox);
            this.StokGroupBox.Controls.Add(this.StokSizeTextBox);
            this.StokGroupBox.Controls.Add(this.StokUnitTextBox);
            this.StokGroupBox.Controls.Add(this.StokQuantityTextBox);
            this.StokGroupBox.Controls.Add(this.StokMerkTextBox);
            this.StokGroupBox.Controls.Add(this.StokSizeLabel);
            this.StokGroupBox.Controls.Add(this.StokMerkLabel);
            this.StokGroupBox.Controls.Add(this.StokQuantityLabel);
            this.StokGroupBox.Controls.Add(this.StokNotesLabel);
            this.StokGroupBox.Controls.Add(this.StokUnitLabel);
            this.StokGroupBox.Controls.Add(this.StokColorLabel);
            this.StokGroupBox.Controls.Add(this.StokCodeLabel);
            this.StokGroupBox.Controls.Add(this.StokNameLabel);
            this.StokGroupBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokGroupBox.Location = new System.Drawing.Point(858, 6);
            this.StokGroupBox.Name = "StokGroupBox";
            this.StokGroupBox.Size = new System.Drawing.Size(472, 620);
            this.StokGroupBox.TabIndex = 7;
            this.StokGroupBox.TabStop = false;
            this.StokGroupBox.Text = "Detail";
            // 
            // StokPhotoTextBox
            // 
            this.StokPhotoTextBox.Enabled = false;
            this.StokPhotoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokPhotoTextBox.Location = new System.Drawing.Point(98, 466);
            this.StokPhotoTextBox.Name = "StokPhotoTextBox";
            this.StokPhotoTextBox.ReadOnly = true;
            this.StokPhotoTextBox.Size = new System.Drawing.Size(369, 26);
            this.StokPhotoTextBox.TabIndex = 44;
            // 
            // StokPhotoLabel
            // 
            this.StokPhotoLabel.AutoSize = true;
            this.StokPhotoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokPhotoLabel.Location = new System.Drawing.Point(14, 470);
            this.StokPhotoLabel.Name = "StokPhotoLabel";
            this.StokPhotoLabel.Size = new System.Drawing.Size(52, 19);
            this.StokPhotoLabel.TabIndex = 43;
            this.StokPhotoLabel.Text = "Photo :";
            // 
            // StokBrowseButton
            // 
            this.StokBrowseButton.Enabled = false;
            this.StokBrowseButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokBrowseButton.Location = new System.Drawing.Point(98, 498);
            this.StokBrowseButton.Name = "StokBrowseButton";
            this.StokBrowseButton.Size = new System.Drawing.Size(84, 29);
            this.StokBrowseButton.TabIndex = 14;
            this.StokBrowseButton.Text = "Browse...";
            this.StokBrowseButton.UseVisualStyleBackColor = true;
            this.StokBrowseButton.Click += new System.EventHandler(this.StokBrowseButton_Click);
            // 
            // StockIDLabel
            // 
            this.StockIDLabel.AutoSize = true;
            this.StockIDLabel.Location = new System.Drawing.Point(348, 522);
            this.StockIDLabel.Name = "StockIDLabel";
            this.StockIDLabel.Size = new System.Drawing.Size(42, 23);
            this.StockIDLabel.TabIndex = 41;
            this.StockIDLabel.Text = "_ID";
            // 
            // StokBuatanTextBox
            // 
            this.StokBuatanTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StokBuatanTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StokBuatanTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokBuatanTextBox.FormattingEnabled = true;
            this.StokBuatanTextBox.Location = new System.Drawing.Point(98, 230);
            this.StokBuatanTextBox.Name = "StokBuatanTextBox";
            this.StokBuatanTextBox.Size = new System.Drawing.Size(138, 27);
            this.StokBuatanTextBox.TabIndex = 10;
            // 
            // StokCancelButton
            // 
            this.StokCancelButton.Enabled = false;
            this.StokCancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokCancelButton.Location = new System.Drawing.Point(99, 566);
            this.StokCancelButton.Name = "StokCancelButton";
            this.StokCancelButton.Size = new System.Drawing.Size(75, 35);
            this.StokCancelButton.TabIndex = 40;
            this.StokCancelButton.Text = "Cancel";
            this.StokCancelButton.UseVisualStyleBackColor = true;
            this.StokCancelButton.Click += new System.EventHandler(this.StokCancelButton_Click);
            // 
            // StokEditButton
            // 
            this.StokEditButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokEditButton.Location = new System.Drawing.Point(180, 566);
            this.StokEditButton.Name = "StokEditButton";
            this.StokEditButton.Size = new System.Drawing.Size(75, 35);
            this.StokEditButton.TabIndex = 39;
            this.StokEditButton.Text = "Edit";
            this.StokEditButton.UseVisualStyleBackColor = true;
            this.StokEditButton.Click += new System.EventHandler(this.StokEditButton_Click);
            // 
            // StokNewButton
            // 
            this.StokNewButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokNewButton.Location = new System.Drawing.Point(18, 566);
            this.StokNewButton.Name = "StokNewButton";
            this.StokNewButton.Size = new System.Drawing.Size(75, 35);
            this.StokNewButton.TabIndex = 15;
            this.StokNewButton.Text = "Baru";
            this.StokNewButton.UseVisualStyleBackColor = true;
            this.StokNewButton.Click += new System.EventHandler(this.StokNewButton_Click);
            // 
            // StokIDTextBox
            // 
            this.StokIDTextBox.Enabled = false;
            this.StokIDTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokIDTextBox.Location = new System.Drawing.Point(329, 38);
            this.StokIDTextBox.Name = "StokIDTextBox";
            this.StokIDTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokIDTextBox.TabIndex = 2;
            // 
            // StokHargaListTextBox
            // 
            this.StokHargaListTextBox.Enabled = false;
            this.StokHargaListTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokHargaListTextBox.Location = new System.Drawing.Point(329, 311);
            this.StokHargaListTextBox.Name = "StokHargaListTextBox";
            this.StokHargaListTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokHargaListTextBox.TabIndex = 12;
            this.StokHargaListTextBox.TabStop = false;
            // 
            // StokHargaPokokTextBox
            // 
            this.StokHargaPokokTextBox.Enabled = false;
            this.StokHargaPokokTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokHargaPokokTextBox.Location = new System.Drawing.Point(98, 311);
            this.StokHargaPokokTextBox.Name = "StokHargaPokokTextBox";
            this.StokHargaPokokTextBox.ReadOnly = true;
            this.StokHargaPokokTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokHargaPokokTextBox.TabIndex = 35;
            this.StokHargaPokokTextBox.TabStop = false;
            // 
            // StokHargaListLabel
            // 
            this.StokHargaListLabel.AutoSize = true;
            this.StokHargaListLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokHargaListLabel.Location = new System.Drawing.Point(242, 314);
            this.StokHargaListLabel.Name = "StokHargaListLabel";
            this.StokHargaListLabel.Size = new System.Drawing.Size(65, 19);
            this.StokHargaListLabel.TabIndex = 34;
            this.StokHargaListLabel.Text = "Hrg List :";
            // 
            // StokHargaPokokLabel
            // 
            this.StokHargaPokokLabel.AutoSize = true;
            this.StokHargaPokokLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokHargaPokokLabel.Location = new System.Drawing.Point(14, 314);
            this.StokHargaPokokLabel.Name = "StokHargaPokokLabel";
            this.StokHargaPokokLabel.Size = new System.Drawing.Size(84, 19);
            this.StokHargaPokokLabel.TabIndex = 33;
            this.StokHargaPokokLabel.Text = "Hrg Pokok :";
            // 
            // StokSaldoAkhirTextBox
            // 
            this.StokSaldoAkhirTextBox.Enabled = false;
            this.StokSaldoAkhirTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokSaldoAkhirTextBox.Location = new System.Drawing.Point(329, 272);
            this.StokSaldoAkhirTextBox.Name = "StokSaldoAkhirTextBox";
            this.StokSaldoAkhirTextBox.ReadOnly = true;
            this.StokSaldoAkhirTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokSaldoAkhirTextBox.TabIndex = 32;
            this.StokSaldoAkhirTextBox.TabStop = false;
            // 
            // StokSaldoAwalTextBox
            // 
            this.StokSaldoAwalTextBox.Enabled = false;
            this.StokSaldoAwalTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokSaldoAwalTextBox.Location = new System.Drawing.Point(98, 272);
            this.StokSaldoAwalTextBox.Name = "StokSaldoAwalTextBox";
            this.StokSaldoAwalTextBox.ReadOnly = true;
            this.StokSaldoAwalTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokSaldoAwalTextBox.TabIndex = 31;
            this.StokSaldoAwalTextBox.TabStop = false;
            // 
            // StokKategoriTextBox
            // 
            this.StokKategoriTextBox.Enabled = false;
            this.StokKategoriTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokKategoriTextBox.Location = new System.Drawing.Point(329, 233);
            this.StokKategoriTextBox.Name = "StokKategoriTextBox";
            this.StokKategoriTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokKategoriTextBox.TabIndex = 11;
            // 
            // StokKategoriLabel
            // 
            this.StokKategoriLabel.AutoSize = true;
            this.StokKategoriLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokKategoriLabel.Location = new System.Drawing.Point(242, 236);
            this.StokKategoriLabel.Name = "StokKategoriLabel";
            this.StokKategoriLabel.Size = new System.Drawing.Size(73, 19);
            this.StokKategoriLabel.TabIndex = 28;
            this.StokKategoriLabel.Text = "Kategori : ";
            // 
            // StolBuatanLabel
            // 
            this.StolBuatanLabel.AutoSize = true;
            this.StolBuatanLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StolBuatanLabel.Location = new System.Drawing.Point(14, 236);
            this.StolBuatanLabel.Name = "StolBuatanLabel";
            this.StolBuatanLabel.Size = new System.Drawing.Size(62, 19);
            this.StolBuatanLabel.TabIndex = 27;
            this.StolBuatanLabel.Text = "Buatan : ";
            // 
            // StockEndLabel
            // 
            this.StockEndLabel.AutoSize = true;
            this.StockEndLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockEndLabel.Location = new System.Drawing.Point(242, 275);
            this.StockEndLabel.Name = "StockEndLabel";
            this.StockEndLabel.Size = new System.Drawing.Size(88, 19);
            this.StockEndLabel.TabIndex = 26;
            this.StockEndLabel.Text = "Saldo Akhir :";
            // 
            // StockInitialLabel
            // 
            this.StockInitialLabel.AutoSize = true;
            this.StockInitialLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInitialLabel.Location = new System.Drawing.Point(14, 275);
            this.StockInitialLabel.Name = "StockInitialLabel";
            this.StockInitialLabel.Size = new System.Drawing.Size(85, 19);
            this.StockInitialLabel.TabIndex = 25;
            this.StockInitialLabel.Text = "Saldo Awal :";
            // 
            // StockDateInDateTextBox
            // 
            this.StockDateInDateTextBox.Enabled = false;
            this.StockDateInDateTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockDateInDateTextBox.Location = new System.Drawing.Point(119, 389);
            this.StockDateInDateTextBox.Name = "StockDateInDateTextBox";
            this.StockDateInDateTextBox.ReadOnly = true;
            this.StockDateInDateTextBox.Size = new System.Drawing.Size(172, 26);
            this.StockDateInDateTextBox.TabIndex = 24;
            this.StockDateInDateTextBox.TabStop = false;
            // 
            // StokDateInLabel
            // 
            this.StokDateInLabel.AutoSize = true;
            this.StokDateInLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokDateInLabel.Location = new System.Drawing.Point(14, 392);
            this.StokDateInLabel.Name = "StokDateInLabel";
            this.StokDateInLabel.Size = new System.Drawing.Size(108, 19);
            this.StokDateInLabel.TabIndex = 23;
            this.StokDateInLabel.Text = "Tanggal Masuk :";
            // 
            // StokDimensionsTextBox
            // 
            this.StokDimensionsTextBox.Enabled = false;
            this.StokDimensionsTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokDimensionsTextBox.Location = new System.Drawing.Point(329, 116);
            this.StokDimensionsTextBox.Name = "StokDimensionsTextBox";
            this.StokDimensionsTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokDimensionsTextBox.TabIndex = 5;
            // 
            // StokWeightTextBox
            // 
            this.StokWeightTextBox.Enabled = false;
            this.StokWeightTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokWeightTextBox.Location = new System.Drawing.Point(329, 158);
            this.StokWeightTextBox.Name = "StokWeightTextBox";
            this.StokWeightTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokWeightTextBox.TabIndex = 7;
            // 
            // StokCollyTextBox
            // 
            this.StokCollyTextBox.Enabled = false;
            this.StokCollyTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokCollyTextBox.Location = new System.Drawing.Point(329, 197);
            this.StokCollyTextBox.Name = "StokCollyTextBox";
            this.StokCollyTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokCollyTextBox.TabIndex = 9;
            // 
            // StokDimensionsLabel
            // 
            this.StokDimensionsLabel.AutoSize = true;
            this.StokDimensionsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokDimensionsLabel.Location = new System.Drawing.Point(242, 119);
            this.StokDimensionsLabel.Name = "StokDimensionsLabel";
            this.StokDimensionsLabel.Size = new System.Drawing.Size(70, 19);
            this.StokDimensionsLabel.TabIndex = 19;
            this.StokDimensionsLabel.Text = "Kubikasi :";
            // 
            // StokWeightLabel
            // 
            this.StokWeightLabel.AutoSize = true;
            this.StokWeightLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokWeightLabel.Location = new System.Drawing.Point(242, 158);
            this.StokWeightLabel.Name = "StokWeightLabel";
            this.StokWeightLabel.Size = new System.Drawing.Size(49, 19);
            this.StokWeightLabel.TabIndex = 18;
            this.StokWeightLabel.Text = "Berat :";
            // 
            // StokCollyLabel
            // 
            this.StokCollyLabel.AutoSize = true;
            this.StokCollyLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokCollyLabel.Location = new System.Drawing.Point(242, 197);
            this.StokCollyLabel.Name = "StokCollyLabel";
            this.StokCollyLabel.Size = new System.Drawing.Size(61, 19);
            this.StokCollyLabel.TabIndex = 17;
            this.StokCollyLabel.Text = "Krt/Set :";
            // 
            // StockDateListDateTextBox
            // 
            this.StockDateListDateTextBox.Enabled = false;
            this.StockDateListDateTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockDateListDateTextBox.Location = new System.Drawing.Point(119, 347);
            this.StockDateListDateTextBox.Name = "StockDateListDateTextBox";
            this.StockDateListDateTextBox.ReadOnly = true;
            this.StockDateListDateTextBox.Size = new System.Drawing.Size(172, 26);
            this.StockDateListDateTextBox.TabIndex = 16;
            this.StockDateListDateTextBox.TabStop = false;
            // 
            // StokDateListLabel
            // 
            this.StokDateListLabel.AutoSize = true;
            this.StokDateListLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokDateListLabel.Location = new System.Drawing.Point(14, 353);
            this.StokDateListLabel.Name = "StokDateListLabel";
            this.StokDateListLabel.Size = new System.Drawing.Size(88, 19);
            this.StokDateListLabel.TabIndex = 15;
            this.StokDateListLabel.Text = "Tanggal List :";
            // 
            // StokColorTextBox
            // 
            this.StokColorTextBox.Enabled = false;
            this.StokColorTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokColorTextBox.Location = new System.Drawing.Point(329, 77);
            this.StokColorTextBox.Name = "StokColorTextBox";
            this.StokColorTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokColorTextBox.TabIndex = 4;
            // 
            // StokNameTextBox
            // 
            this.StokNameTextBox.Enabled = false;
            this.StokNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokNameTextBox.Location = new System.Drawing.Point(98, 38);
            this.StokNameTextBox.Name = "StokNameTextBox";
            this.StokNameTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokNameTextBox.TabIndex = 1;
            // 
            // StokNotesTextBox
            // 
            this.StokNotesTextBox.Enabled = false;
            this.StokNotesTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokNotesTextBox.Location = new System.Drawing.Point(98, 428);
            this.StokNotesTextBox.Name = "StokNotesTextBox";
            this.StokNotesTextBox.Size = new System.Drawing.Size(369, 26);
            this.StokNotesTextBox.TabIndex = 13;
            // 
            // StokSizeTextBox
            // 
            this.StokSizeTextBox.Enabled = false;
            this.StokSizeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokSizeTextBox.Location = new System.Drawing.Point(98, 194);
            this.StokSizeTextBox.Name = "StokSizeTextBox";
            this.StokSizeTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokSizeTextBox.TabIndex = 8;
            // 
            // StokUnitTextBox
            // 
            this.StokUnitTextBox.Enabled = false;
            this.StokUnitTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokUnitTextBox.Location = new System.Drawing.Point(98, 155);
            this.StokUnitTextBox.Name = "StokUnitTextBox";
            this.StokUnitTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokUnitTextBox.TabIndex = 6;
            // 
            // StokQuantityTextBox
            // 
            this.StokQuantityTextBox.Enabled = false;
            this.StokQuantityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokQuantityTextBox.Location = new System.Drawing.Point(98, 116);
            this.StokQuantityTextBox.Name = "StokQuantityTextBox";
            this.StokQuantityTextBox.ReadOnly = true;
            this.StokQuantityTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokQuantityTextBox.TabIndex = 3;
            this.StokQuantityTextBox.TabStop = false;
            // 
            // StokMerkTextBox
            // 
            this.StokMerkTextBox.Enabled = false;
            this.StokMerkTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokMerkTextBox.Location = new System.Drawing.Point(98, 77);
            this.StokMerkTextBox.Name = "StokMerkTextBox";
            this.StokMerkTextBox.Size = new System.Drawing.Size(138, 26);
            this.StokMerkTextBox.TabIndex = 3;
            // 
            // StokSizeLabel
            // 
            this.StokSizeLabel.AutoSize = true;
            this.StokSizeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokSizeLabel.Location = new System.Drawing.Point(14, 197);
            this.StokSizeLabel.Name = "StokSizeLabel";
            this.StokSizeLabel.Size = new System.Drawing.Size(61, 19);
            this.StokSizeLabel.TabIndex = 0;
            this.StokSizeLabel.Text = "Ukuran :";
            // 
            // StokMerkLabel
            // 
            this.StokMerkLabel.AutoSize = true;
            this.StokMerkLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokMerkLabel.Location = new System.Drawing.Point(14, 80);
            this.StokMerkLabel.Name = "StokMerkLabel";
            this.StokMerkLabel.Size = new System.Drawing.Size(57, 19);
            this.StokMerkLabel.TabIndex = 0;
            this.StokMerkLabel.Text = "Merek :";
            // 
            // StokQuantityLabel
            // 
            this.StokQuantityLabel.AutoSize = true;
            this.StokQuantityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokQuantityLabel.Location = new System.Drawing.Point(14, 119);
            this.StokQuantityLabel.Name = "StokQuantityLabel";
            this.StokQuantityLabel.Size = new System.Drawing.Size(39, 19);
            this.StokQuantityLabel.TabIndex = 0;
            this.StokQuantityLabel.Text = "Qty :";
            // 
            // StokNotesLabel
            // 
            this.StokNotesLabel.AutoSize = true;
            this.StokNotesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokNotesLabel.Location = new System.Drawing.Point(14, 431);
            this.StokNotesLabel.Name = "StokNotesLabel";
            this.StokNotesLabel.Size = new System.Drawing.Size(86, 19);
            this.StokNotesLabel.TabIndex = 0;
            this.StokNotesLabel.Text = "Keterangan :";
            // 
            // StokUnitLabel
            // 
            this.StokUnitLabel.AutoSize = true;
            this.StokUnitLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokUnitLabel.Location = new System.Drawing.Point(14, 158);
            this.StokUnitLabel.Name = "StokUnitLabel";
            this.StokUnitLabel.Size = new System.Drawing.Size(57, 19);
            this.StokUnitLabel.TabIndex = 0;
            this.StokUnitLabel.Text = "Satuan :";
            // 
            // StokColorLabel
            // 
            this.StokColorLabel.AutoSize = true;
            this.StokColorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokColorLabel.Location = new System.Drawing.Point(242, 80);
            this.StokColorLabel.Name = "StokColorLabel";
            this.StokColorLabel.Size = new System.Drawing.Size(56, 19);
            this.StokColorLabel.TabIndex = 3;
            this.StokColorLabel.Text = "Warna :";
            // 
            // StokCodeLabel
            // 
            this.StokCodeLabel.AutoSize = true;
            this.StokCodeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokCodeLabel.Location = new System.Drawing.Point(242, 41);
            this.StokCodeLabel.Name = "StokCodeLabel";
            this.StokCodeLabel.Size = new System.Drawing.Size(91, 19);
            this.StokCodeLabel.TabIndex = 0;
            this.StokCodeLabel.Text = "Kode Stock :";
            // 
            // StokNameLabel
            // 
            this.StokNameLabel.AutoSize = true;
            this.StokNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokNameLabel.Location = new System.Drawing.Point(14, 41);
            this.StokNameLabel.Name = "StokNameLabel";
            this.StokNameLabel.Size = new System.Drawing.Size(57, 19);
            this.StokNameLabel.TabIndex = 0;
            this.StokNameLabel.Text = "Nama : ";
            // 
            // stokOLV
            // 
            this.stokOLV.AllColumns.Add(this.olvColumn13);
            this.stokOLV.AllColumns.Add(this.olvColumn14);
            this.stokOLV.AllColumns.Add(this.olvColumn15);
            this.stokOLV.AllColumns.Add(this.olvColumn16);
            this.stokOLV.AllColumns.Add(this.olvColumn17);
            this.stokOLV.AllColumns.Add(this.olvColumn18);
            this.stokOLV.AllowDrop = true;
            this.stokOLV.AlternateRowBackColor = System.Drawing.Color.LemonChiffon;
            this.stokOLV.CellEditUseWholeCell = false;
            this.stokOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn13,
            this.olvColumn14,
            this.olvColumn15,
            this.olvColumn16,
            this.olvColumn17,
            this.olvColumn18});
            this.stokOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.stokOLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokOLV.FullRowSelect = true;
            this.stokOLV.HeaderFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.stokOLV.HeaderFormatStyle = this.olvHdr;
            this.stokOLV.Location = new System.Drawing.Point(6, 72);
            this.stokOLV.Name = "stokOLV";
            this.stokOLV.ShowGroups = false;
            this.stokOLV.Size = new System.Drawing.Size(846, 554);
            this.stokOLV.TabIndex = 1;
            this.stokOLV.UseAlternatingBackColors = true;
            this.stokOLV.UseCompatibleStateImageBehavior = false;
            this.stokOLV.UseFilterIndicator = true;
            this.stokOLV.UseFiltering = true;
            this.stokOLV.View = System.Windows.Forms.View.Details;
            this.stokOLV.VirtualMode = true;
            this.stokOLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.stokOLV_ItemSelectionChanged);
            // 
            // olvColumn13
            // 
            this.olvColumn13.AspectName = "Name";
            this.olvColumn13.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn13.Text = "Nama";
            this.olvColumn13.UseInitialLetterForGroup = true;
            this.olvColumn13.Width = 157;
            // 
            // olvColumn14
            // 
            this.olvColumn14.AspectName = "Code";
            this.olvColumn14.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn14.Text = "Stok ID";
            this.olvColumn14.UseInitialLetterForGroup = true;
            this.olvColumn14.Width = 220;
            // 
            // olvColumn15
            // 
            this.olvColumn15.AspectName = "Merk";
            this.olvColumn15.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn15.Text = "Merek";
            this.olvColumn15.UseInitialLetterForGroup = true;
            this.olvColumn15.Width = 70;
            // 
            // olvColumn16
            // 
            this.olvColumn16.AspectName = "Color";
            this.olvColumn16.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn16.Text = "Warna";
            this.olvColumn16.UseInitialLetterForGroup = true;
            this.olvColumn16.Width = 120;
            // 
            // olvColumn17
            // 
            this.olvColumn17.AspectName = "Quantity";
            this.olvColumn17.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn17.Text = "Qty";
            this.olvColumn17.UseInitialLetterForGroup = true;
            this.olvColumn17.Width = 70;
            // 
            // olvColumn18
            // 
            this.olvColumn18.AspectName = "DateList";
            this.olvColumn18.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn18.Text = "Tanggal Masuk";
            this.olvColumn18.UseInitialLetterForGroup = true;
            this.olvColumn18.Width = 200;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.SalesFilterGroupBox);
            this.tabPage5.Controls.Add(this.SalesGroupBox);
            this.tabPage5.Controls.Add(this.salesOLV);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1338, 629);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Daftar Sales";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // SalesFilterGroupBox
            // 
            this.SalesFilterGroupBox.Controls.Add(this.SalesFilterTextBox);
            this.SalesFilterGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesFilterGroupBox.Location = new System.Drawing.Point(739, 7);
            this.SalesFilterGroupBox.Name = "SalesFilterGroupBox";
            this.SalesFilterGroupBox.Size = new System.Drawing.Size(113, 59);
            this.SalesFilterGroupBox.TabIndex = 8;
            this.SalesFilterGroupBox.TabStop = false;
            this.SalesFilterGroupBox.Text = "Filter";
            // 
            // SalesFilterTextBox
            // 
            this.SalesFilterTextBox.Location = new System.Drawing.Point(6, 25);
            this.SalesFilterTextBox.Name = "SalesFilterTextBox";
            this.SalesFilterTextBox.Size = new System.Drawing.Size(100, 26);
            this.SalesFilterTextBox.TabIndex = 0;
            this.SalesFilterTextBox.TextChanged += new System.EventHandler(this.SalesFilterTextBox_TextChanged);
            // 
            // SalesGroupBox
            // 
            this.SalesGroupBox.Controls.Add(this.KomisiImportALabel);
            this.SalesGroupBox.Controls.Add(this.KomisiLokalELabel);
            this.SalesGroupBox.Controls.Add(this.KomisiLokalDLabel);
            this.SalesGroupBox.Controls.Add(this.KomisiLokalCLabel);
            this.SalesGroupBox.Controls.Add(this.KomisiLokalBLabel);
            this.SalesGroupBox.Controls.Add(this.KomisiLokalALabel);
            this.SalesGroupBox.Controls.Add(this.KomisiImportELabel);
            this.SalesGroupBox.Controls.Add(this.KomisiImportDLabel);
            this.SalesGroupBox.Controls.Add(this.KomisiImportBLabel);
            this.SalesGroupBox.Controls.Add(this.KomisiImportCLabel);
            this.SalesGroupBox.Controls.Add(this.SalesLocalETagihTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesLocalDTagihTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesLocalCTagihTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesLocalBTagihTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesLocalATagihTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesImportETagihTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesImportDTagihTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesImportCTagihTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesImportBTagihTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesImportATagihTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesLocalETextBox);
            this.SalesGroupBox.Controls.Add(this.SalesLocalDTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesLocalCTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesLocalBTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesLocalATextBox);
            this.SalesGroupBox.Controls.Add(this.SalesImportETextBox);
            this.SalesGroupBox.Controls.Add(this.SalesImportDTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesImportCTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesImportBTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesImportATextBox);
            this.SalesGroupBox.Controls.Add(this.SalesCancelButton);
            this.SalesGroupBox.Controls.Add(this.SalesEditButton);
            this.SalesGroupBox.Controls.Add(this.SalesNewButton);
            this.SalesGroupBox.Controls.Add(this.SalesTagihLocalLabel);
            this.SalesGroupBox.Controls.Add(this.SalesTagihImportLabel);
            this.SalesGroupBox.Controls.Add(this.SalesOmsetLocalTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesOmsetLocalLabel);
            this.SalesGroupBox.Controls.Add(this.SalesKomisiLocalLabel);
            this.SalesGroupBox.Controls.Add(this.SalesKomisiImportLabel);
            this.SalesGroupBox.Controls.Add(this.SalesProfitTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesDiscountTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesReturnTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesProfitLabel);
            this.SalesGroupBox.Controls.Add(this.SalesDiscountLabel);
            this.SalesGroupBox.Controls.Add(this.SalesReturnLabel);
            this.SalesGroupBox.Controls.Add(this.SalesDateTimePicker);
            this.SalesGroupBox.Controls.Add(this.SalesDateInLabel);
            this.SalesGroupBox.Controls.Add(this.SalesCityTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesNameTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesNotesTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesTagihTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesOmsetImportTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesAddrTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesPhoneTextBox);
            this.SalesGroupBox.Controls.Add(this.SalesTagihLabel);
            this.SalesGroupBox.Controls.Add(this.SalesPhoneLabel);
            this.SalesGroupBox.Controls.Add(this.SalesAddrLabel);
            this.SalesGroupBox.Controls.Add(this.SalesNotesLabel);
            this.SalesGroupBox.Controls.Add(this.SalesOmsetImportLabel);
            this.SalesGroupBox.Controls.Add(this.SalesCityLabel);
            this.SalesGroupBox.Controls.Add(this.SalesCodeLabel);
            this.SalesGroupBox.Controls.Add(this.SalesNameLabel);
            this.SalesGroupBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesGroupBox.Location = new System.Drawing.Point(858, 6);
            this.SalesGroupBox.Name = "SalesGroupBox";
            this.SalesGroupBox.Size = new System.Drawing.Size(472, 620);
            this.SalesGroupBox.TabIndex = 0;
            this.SalesGroupBox.TabStop = false;
            this.SalesGroupBox.Text = "Detail";
            // 
            // KomisiImportALabel
            // 
            this.KomisiImportALabel.AutoSize = true;
            this.KomisiImportALabel.Location = new System.Drawing.Point(22, 381);
            this.KomisiImportALabel.Name = "KomisiImportALabel";
            this.KomisiImportALabel.Size = new System.Drawing.Size(34, 23);
            this.KomisiImportALabel.TabIndex = 61;
            this.KomisiImportALabel.Text = "A :";
            // 
            // KomisiLokalELabel
            // 
            this.KomisiLokalELabel.AutoSize = true;
            this.KomisiLokalELabel.Location = new System.Drawing.Point(249, 509);
            this.KomisiLokalELabel.Name = "KomisiLokalELabel";
            this.KomisiLokalELabel.Size = new System.Drawing.Size(34, 23);
            this.KomisiLokalELabel.TabIndex = 60;
            this.KomisiLokalELabel.Text = "E :";
            // 
            // KomisiLokalDLabel
            // 
            this.KomisiLokalDLabel.AutoSize = true;
            this.KomisiLokalDLabel.Location = new System.Drawing.Point(249, 477);
            this.KomisiLokalDLabel.Name = "KomisiLokalDLabel";
            this.KomisiLokalDLabel.Size = new System.Drawing.Size(36, 23);
            this.KomisiLokalDLabel.TabIndex = 59;
            this.KomisiLokalDLabel.Text = "D :";
            // 
            // KomisiLokalCLabel
            // 
            this.KomisiLokalCLabel.AutoSize = true;
            this.KomisiLokalCLabel.Location = new System.Drawing.Point(249, 445);
            this.KomisiLokalCLabel.Name = "KomisiLokalCLabel";
            this.KomisiLokalCLabel.Size = new System.Drawing.Size(35, 23);
            this.KomisiLokalCLabel.TabIndex = 58;
            this.KomisiLokalCLabel.Text = "C :";
            // 
            // KomisiLokalBLabel
            // 
            this.KomisiLokalBLabel.AutoSize = true;
            this.KomisiLokalBLabel.Location = new System.Drawing.Point(249, 413);
            this.KomisiLokalBLabel.Name = "KomisiLokalBLabel";
            this.KomisiLokalBLabel.Size = new System.Drawing.Size(35, 23);
            this.KomisiLokalBLabel.TabIndex = 57;
            this.KomisiLokalBLabel.Text = "B :";
            // 
            // KomisiLokalALabel
            // 
            this.KomisiLokalALabel.AutoSize = true;
            this.KomisiLokalALabel.Location = new System.Drawing.Point(249, 384);
            this.KomisiLokalALabel.Name = "KomisiLokalALabel";
            this.KomisiLokalALabel.Size = new System.Drawing.Size(34, 23);
            this.KomisiLokalALabel.TabIndex = 56;
            this.KomisiLokalALabel.Text = "A :";
            // 
            // KomisiImportELabel
            // 
            this.KomisiImportELabel.AutoSize = true;
            this.KomisiImportELabel.Location = new System.Drawing.Point(22, 509);
            this.KomisiImportELabel.Name = "KomisiImportELabel";
            this.KomisiImportELabel.Size = new System.Drawing.Size(34, 23);
            this.KomisiImportELabel.TabIndex = 55;
            this.KomisiImportELabel.Text = "E :";
            // 
            // KomisiImportDLabel
            // 
            this.KomisiImportDLabel.AutoSize = true;
            this.KomisiImportDLabel.Location = new System.Drawing.Point(22, 477);
            this.KomisiImportDLabel.Name = "KomisiImportDLabel";
            this.KomisiImportDLabel.Size = new System.Drawing.Size(36, 23);
            this.KomisiImportDLabel.TabIndex = 54;
            this.KomisiImportDLabel.Text = "D :";
            // 
            // KomisiImportBLabel
            // 
            this.KomisiImportBLabel.AutoSize = true;
            this.KomisiImportBLabel.Location = new System.Drawing.Point(22, 413);
            this.KomisiImportBLabel.Name = "KomisiImportBLabel";
            this.KomisiImportBLabel.Size = new System.Drawing.Size(35, 23);
            this.KomisiImportBLabel.TabIndex = 53;
            this.KomisiImportBLabel.Text = "B :";
            // 
            // KomisiImportCLabel
            // 
            this.KomisiImportCLabel.AutoSize = true;
            this.KomisiImportCLabel.Location = new System.Drawing.Point(22, 445);
            this.KomisiImportCLabel.Name = "KomisiImportCLabel";
            this.KomisiImportCLabel.Size = new System.Drawing.Size(35, 23);
            this.KomisiImportCLabel.TabIndex = 52;
            this.KomisiImportCLabel.Text = "C :";
            // 
            // SalesLocalETagihTextBox
            // 
            this.SalesLocalETagihTextBox.Enabled = false;
            this.SalesLocalETagihTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLocalETagihTextBox.Location = new System.Drawing.Point(348, 509);
            this.SalesLocalETagihTextBox.Name = "SalesLocalETagihTextBox";
            this.SalesLocalETagihTextBox.ReadOnly = true;
            this.SalesLocalETagihTextBox.Size = new System.Drawing.Size(108, 26);
            this.SalesLocalETagihTextBox.TabIndex = 51;
            this.SalesLocalETagihTextBox.TabStop = false;
            // 
            // SalesLocalDTagihTextBox
            // 
            this.SalesLocalDTagihTextBox.Enabled = false;
            this.SalesLocalDTagihTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLocalDTagihTextBox.Location = new System.Drawing.Point(348, 477);
            this.SalesLocalDTagihTextBox.Name = "SalesLocalDTagihTextBox";
            this.SalesLocalDTagihTextBox.ReadOnly = true;
            this.SalesLocalDTagihTextBox.Size = new System.Drawing.Size(108, 26);
            this.SalesLocalDTagihTextBox.TabIndex = 50;
            this.SalesLocalDTagihTextBox.TabStop = false;
            // 
            // SalesLocalCTagihTextBox
            // 
            this.SalesLocalCTagihTextBox.Enabled = false;
            this.SalesLocalCTagihTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLocalCTagihTextBox.Location = new System.Drawing.Point(348, 445);
            this.SalesLocalCTagihTextBox.Name = "SalesLocalCTagihTextBox";
            this.SalesLocalCTagihTextBox.ReadOnly = true;
            this.SalesLocalCTagihTextBox.Size = new System.Drawing.Size(108, 26);
            this.SalesLocalCTagihTextBox.TabIndex = 49;
            this.SalesLocalCTagihTextBox.TabStop = false;
            // 
            // SalesLocalBTagihTextBox
            // 
            this.SalesLocalBTagihTextBox.Enabled = false;
            this.SalesLocalBTagihTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLocalBTagihTextBox.Location = new System.Drawing.Point(348, 413);
            this.SalesLocalBTagihTextBox.Name = "SalesLocalBTagihTextBox";
            this.SalesLocalBTagihTextBox.ReadOnly = true;
            this.SalesLocalBTagihTextBox.Size = new System.Drawing.Size(108, 26);
            this.SalesLocalBTagihTextBox.TabIndex = 48;
            this.SalesLocalBTagihTextBox.TabStop = false;
            // 
            // SalesLocalATagihTextBox
            // 
            this.SalesLocalATagihTextBox.Enabled = false;
            this.SalesLocalATagihTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLocalATagihTextBox.Location = new System.Drawing.Point(348, 381);
            this.SalesLocalATagihTextBox.Name = "SalesLocalATagihTextBox";
            this.SalesLocalATagihTextBox.ReadOnly = true;
            this.SalesLocalATagihTextBox.Size = new System.Drawing.Size(108, 26);
            this.SalesLocalATagihTextBox.TabIndex = 47;
            this.SalesLocalATagihTextBox.TabStop = false;
            // 
            // SalesImportETagihTextBox
            // 
            this.SalesImportETagihTextBox.Enabled = false;
            this.SalesImportETagihTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesImportETagihTextBox.Location = new System.Drawing.Point(128, 509);
            this.SalesImportETagihTextBox.Name = "SalesImportETagihTextBox";
            this.SalesImportETagihTextBox.ReadOnly = true;
            this.SalesImportETagihTextBox.Size = new System.Drawing.Size(108, 26);
            this.SalesImportETagihTextBox.TabIndex = 46;
            this.SalesImportETagihTextBox.TabStop = false;
            // 
            // SalesImportDTagihTextBox
            // 
            this.SalesImportDTagihTextBox.Enabled = false;
            this.SalesImportDTagihTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesImportDTagihTextBox.Location = new System.Drawing.Point(128, 477);
            this.SalesImportDTagihTextBox.Name = "SalesImportDTagihTextBox";
            this.SalesImportDTagihTextBox.ReadOnly = true;
            this.SalesImportDTagihTextBox.Size = new System.Drawing.Size(108, 26);
            this.SalesImportDTagihTextBox.TabIndex = 45;
            this.SalesImportDTagihTextBox.TabStop = false;
            // 
            // SalesImportCTagihTextBox
            // 
            this.SalesImportCTagihTextBox.Enabled = false;
            this.SalesImportCTagihTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesImportCTagihTextBox.Location = new System.Drawing.Point(128, 445);
            this.SalesImportCTagihTextBox.Name = "SalesImportCTagihTextBox";
            this.SalesImportCTagihTextBox.ReadOnly = true;
            this.SalesImportCTagihTextBox.Size = new System.Drawing.Size(108, 26);
            this.SalesImportCTagihTextBox.TabIndex = 44;
            this.SalesImportCTagihTextBox.TabStop = false;
            // 
            // SalesImportBTagihTextBox
            // 
            this.SalesImportBTagihTextBox.Enabled = false;
            this.SalesImportBTagihTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesImportBTagihTextBox.Location = new System.Drawing.Point(128, 413);
            this.SalesImportBTagihTextBox.Name = "SalesImportBTagihTextBox";
            this.SalesImportBTagihTextBox.ReadOnly = true;
            this.SalesImportBTagihTextBox.Size = new System.Drawing.Size(108, 26);
            this.SalesImportBTagihTextBox.TabIndex = 43;
            this.SalesImportBTagihTextBox.TabStop = false;
            // 
            // SalesImportATagihTextBox
            // 
            this.SalesImportATagihTextBox.Enabled = false;
            this.SalesImportATagihTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesImportATagihTextBox.Location = new System.Drawing.Point(128, 381);
            this.SalesImportATagihTextBox.Name = "SalesImportATagihTextBox";
            this.SalesImportATagihTextBox.ReadOnly = true;
            this.SalesImportATagihTextBox.Size = new System.Drawing.Size(108, 26);
            this.SalesImportATagihTextBox.TabIndex = 42;
            this.SalesImportATagihTextBox.TabStop = false;
            // 
            // SalesLocalETextBox
            // 
            this.SalesLocalETextBox.Enabled = false;
            this.SalesLocalETextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLocalETextBox.Location = new System.Drawing.Point(286, 509);
            this.SalesLocalETextBox.Name = "SalesLocalETextBox";
            this.SalesLocalETextBox.Size = new System.Drawing.Size(50, 26);
            this.SalesLocalETextBox.TabIndex = 16;
            // 
            // SalesLocalDTextBox
            // 
            this.SalesLocalDTextBox.Enabled = false;
            this.SalesLocalDTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLocalDTextBox.Location = new System.Drawing.Point(286, 477);
            this.SalesLocalDTextBox.Name = "SalesLocalDTextBox";
            this.SalesLocalDTextBox.Size = new System.Drawing.Size(50, 26);
            this.SalesLocalDTextBox.TabIndex = 15;
            // 
            // SalesLocalCTextBox
            // 
            this.SalesLocalCTextBox.Enabled = false;
            this.SalesLocalCTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLocalCTextBox.Location = new System.Drawing.Point(286, 445);
            this.SalesLocalCTextBox.Name = "SalesLocalCTextBox";
            this.SalesLocalCTextBox.Size = new System.Drawing.Size(50, 26);
            this.SalesLocalCTextBox.TabIndex = 14;
            // 
            // SalesLocalBTextBox
            // 
            this.SalesLocalBTextBox.Enabled = false;
            this.SalesLocalBTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLocalBTextBox.Location = new System.Drawing.Point(286, 413);
            this.SalesLocalBTextBox.Name = "SalesLocalBTextBox";
            this.SalesLocalBTextBox.Size = new System.Drawing.Size(50, 26);
            this.SalesLocalBTextBox.TabIndex = 13;
            // 
            // SalesLocalATextBox
            // 
            this.SalesLocalATextBox.Enabled = false;
            this.SalesLocalATextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLocalATextBox.Location = new System.Drawing.Point(286, 381);
            this.SalesLocalATextBox.Name = "SalesLocalATextBox";
            this.SalesLocalATextBox.Size = new System.Drawing.Size(50, 26);
            this.SalesLocalATextBox.TabIndex = 12;
            // 
            // SalesImportETextBox
            // 
            this.SalesImportETextBox.Enabled = false;
            this.SalesImportETextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesImportETextBox.Location = new System.Drawing.Point(62, 509);
            this.SalesImportETextBox.Name = "SalesImportETextBox";
            this.SalesImportETextBox.Size = new System.Drawing.Size(50, 26);
            this.SalesImportETextBox.TabIndex = 11;
            // 
            // SalesImportDTextBox
            // 
            this.SalesImportDTextBox.Enabled = false;
            this.SalesImportDTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesImportDTextBox.Location = new System.Drawing.Point(62, 477);
            this.SalesImportDTextBox.Name = "SalesImportDTextBox";
            this.SalesImportDTextBox.Size = new System.Drawing.Size(50, 26);
            this.SalesImportDTextBox.TabIndex = 10;
            // 
            // SalesImportCTextBox
            // 
            this.SalesImportCTextBox.Enabled = false;
            this.SalesImportCTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesImportCTextBox.Location = new System.Drawing.Point(62, 445);
            this.SalesImportCTextBox.Name = "SalesImportCTextBox";
            this.SalesImportCTextBox.Size = new System.Drawing.Size(50, 26);
            this.SalesImportCTextBox.TabIndex = 9;
            // 
            // SalesImportBTextBox
            // 
            this.SalesImportBTextBox.Enabled = false;
            this.SalesImportBTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesImportBTextBox.Location = new System.Drawing.Point(62, 413);
            this.SalesImportBTextBox.Name = "SalesImportBTextBox";
            this.SalesImportBTextBox.Size = new System.Drawing.Size(50, 26);
            this.SalesImportBTextBox.TabIndex = 8;
            // 
            // SalesImportATextBox
            // 
            this.SalesImportATextBox.Enabled = false;
            this.SalesImportATextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesImportATextBox.Location = new System.Drawing.Point(62, 381);
            this.SalesImportATextBox.Name = "SalesImportATextBox";
            this.SalesImportATextBox.Size = new System.Drawing.Size(50, 26);
            this.SalesImportATextBox.TabIndex = 7;
            // 
            // SalesCancelButton
            // 
            this.SalesCancelButton.Enabled = false;
            this.SalesCancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesCancelButton.Location = new System.Drawing.Point(99, 566);
            this.SalesCancelButton.Name = "SalesCancelButton";
            this.SalesCancelButton.Size = new System.Drawing.Size(75, 35);
            this.SalesCancelButton.TabIndex = 31;
            this.SalesCancelButton.Text = "Cancel";
            this.SalesCancelButton.UseVisualStyleBackColor = true;
            this.SalesCancelButton.Click += new System.EventHandler(this.SalesButton3_Click);
            // 
            // SalesEditButton
            // 
            this.SalesEditButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesEditButton.Location = new System.Drawing.Point(180, 566);
            this.SalesEditButton.Name = "SalesEditButton";
            this.SalesEditButton.Size = new System.Drawing.Size(75, 35);
            this.SalesEditButton.TabIndex = 30;
            this.SalesEditButton.Text = "Edit";
            this.SalesEditButton.UseVisualStyleBackColor = true;
            this.SalesEditButton.Click += new System.EventHandler(this.SalesButton2_Click);
            // 
            // SalesNewButton
            // 
            this.SalesNewButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesNewButton.Location = new System.Drawing.Point(18, 566);
            this.SalesNewButton.Name = "SalesNewButton";
            this.SalesNewButton.Size = new System.Drawing.Size(75, 35);
            this.SalesNewButton.TabIndex = 17;
            this.SalesNewButton.Text = "Baru";
            this.SalesNewButton.UseVisualStyleBackColor = true;
            this.SalesNewButton.Click += new System.EventHandler(this.SalesButton1_Click);
            // 
            // SalesTagihLocalLabel
            // 
            this.SalesTagihLocalLabel.AutoSize = true;
            this.SalesTagihLocalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTagihLocalLabel.Location = new System.Drawing.Point(344, 359);
            this.SalesTagihLocalLabel.Name = "SalesTagihLocalLabel";
            this.SalesTagihLocalLabel.Size = new System.Drawing.Size(80, 19);
            this.SalesTagihLocalLabel.TabIndex = 28;
            this.SalesTagihLocalLabel.Text = "Tagih Lokal";
            // 
            // SalesTagihImportLabel
            // 
            this.SalesTagihImportLabel.AutoSize = true;
            this.SalesTagihImportLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTagihImportLabel.Location = new System.Drawing.Point(137, 359);
            this.SalesTagihImportLabel.Name = "SalesTagihImportLabel";
            this.SalesTagihImportLabel.Size = new System.Drawing.Size(86, 19);
            this.SalesTagihImportLabel.TabIndex = 27;
            this.SalesTagihImportLabel.Text = "Tagih Import";
            // 
            // SalesOmsetLocalTextBox
            // 
            this.SalesOmsetLocalTextBox.Enabled = false;
            this.SalesOmsetLocalTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesOmsetLocalTextBox.Location = new System.Drawing.Point(316, 194);
            this.SalesOmsetLocalTextBox.Name = "SalesOmsetLocalTextBox";
            this.SalesOmsetLocalTextBox.ReadOnly = true;
            this.SalesOmsetLocalTextBox.Size = new System.Drawing.Size(138, 26);
            this.SalesOmsetLocalTextBox.TabIndex = 26;
            this.SalesOmsetLocalTextBox.TabStop = false;
            // 
            // SalesOmsetLocalLabel
            // 
            this.SalesOmsetLocalLabel.AutoSize = true;
            this.SalesOmsetLocalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesOmsetLocalLabel.Location = new System.Drawing.Point(241, 197);
            this.SalesOmsetLocalLabel.Name = "SalesOmsetLocalLabel";
            this.SalesOmsetLocalLabel.Size = new System.Drawing.Size(75, 19);
            this.SalesOmsetLocalLabel.TabIndex = 25;
            this.SalesOmsetLocalLabel.Text = "Omset(L) :";
            // 
            // SalesKomisiLocalLabel
            // 
            this.SalesKomisiLocalLabel.AutoSize = true;
            this.SalesKomisiLocalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesKomisiLocalLabel.Location = new System.Drawing.Point(241, 359);
            this.SalesKomisiLocalLabel.Name = "SalesKomisiLocalLabel";
            this.SalesKomisiLocalLabel.Size = new System.Drawing.Size(95, 19);
            this.SalesKomisiLocalLabel.TabIndex = 24;
            this.SalesKomisiLocalLabel.Text = "Komisi Lokal ";
            // 
            // SalesKomisiImportLabel
            // 
            this.SalesKomisiImportLabel.AutoSize = true;
            this.SalesKomisiImportLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesKomisiImportLabel.Location = new System.Drawing.Point(15, 359);
            this.SalesKomisiImportLabel.Name = "SalesKomisiImportLabel";
            this.SalesKomisiImportLabel.Size = new System.Drawing.Size(97, 19);
            this.SalesKomisiImportLabel.TabIndex = 23;
            this.SalesKomisiImportLabel.Text = "Komisi Import";
            // 
            // SalesProfitTextBox
            // 
            this.SalesProfitTextBox.Enabled = false;
            this.SalesProfitTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesProfitTextBox.Location = new System.Drawing.Point(85, 269);
            this.SalesProfitTextBox.Name = "SalesProfitTextBox";
            this.SalesProfitTextBox.ReadOnly = true;
            this.SalesProfitTextBox.Size = new System.Drawing.Size(138, 26);
            this.SalesProfitTextBox.TabIndex = 22;
            this.SalesProfitTextBox.TabStop = false;
            // 
            // SalesDiscountTextBox
            // 
            this.SalesDiscountTextBox.Enabled = false;
            this.SalesDiscountTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDiscountTextBox.Location = new System.Drawing.Point(316, 269);
            this.SalesDiscountTextBox.Name = "SalesDiscountTextBox";
            this.SalesDiscountTextBox.ReadOnly = true;
            this.SalesDiscountTextBox.Size = new System.Drawing.Size(138, 26);
            this.SalesDiscountTextBox.TabIndex = 21;
            this.SalesDiscountTextBox.TabStop = false;
            // 
            // SalesReturnTextBox
            // 
            this.SalesReturnTextBox.Enabled = false;
            this.SalesReturnTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReturnTextBox.Location = new System.Drawing.Point(316, 233);
            this.SalesReturnTextBox.Name = "SalesReturnTextBox";
            this.SalesReturnTextBox.ReadOnly = true;
            this.SalesReturnTextBox.Size = new System.Drawing.Size(138, 26);
            this.SalesReturnTextBox.TabIndex = 20;
            this.SalesReturnTextBox.TabStop = false;
            // 
            // SalesProfitLabel
            // 
            this.SalesProfitLabel.AutoSize = true;
            this.SalesProfitLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesProfitLabel.Location = new System.Drawing.Point(14, 275);
            this.SalesProfitLabel.Name = "SalesProfitLabel";
            this.SalesProfitLabel.Size = new System.Drawing.Size(49, 19);
            this.SalesProfitLabel.TabIndex = 19;
            this.SalesProfitLabel.Text = "Profit :";
            // 
            // SalesDiscountLabel
            // 
            this.SalesDiscountLabel.AutoSize = true;
            this.SalesDiscountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDiscountLabel.Location = new System.Drawing.Point(241, 272);
            this.SalesDiscountLabel.Name = "SalesDiscountLabel";
            this.SalesDiscountLabel.Size = new System.Drawing.Size(69, 19);
            this.SalesDiscountLabel.TabIndex = 18;
            this.SalesDiscountLabel.Text = "Discount :";
            // 
            // SalesReturnLabel
            // 
            this.SalesReturnLabel.AutoSize = true;
            this.SalesReturnLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReturnLabel.Location = new System.Drawing.Point(241, 236);
            this.SalesReturnLabel.Name = "SalesReturnLabel";
            this.SalesReturnLabel.Size = new System.Drawing.Size(69, 19);
            this.SalesReturnLabel.TabIndex = 17;
            this.SalesReturnLabel.Text = "Jlh Retur :";
            // 
            // SalesDateTimePicker
            // 
            this.SalesDateTimePicker.Enabled = false;
            this.SalesDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDateTimePicker.Location = new System.Drawing.Point(85, 155);
            this.SalesDateTimePicker.Name = "SalesDateTimePicker";
            this.SalesDateTimePicker.Size = new System.Drawing.Size(253, 26);
            this.SalesDateTimePicker.TabIndex = 5;
            // 
            // SalesDateInLabel
            // 
            this.SalesDateInLabel.AutoSize = true;
            this.SalesDateInLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDateInLabel.Location = new System.Drawing.Point(14, 158);
            this.SalesDateInLabel.Name = "SalesDateInLabel";
            this.SalesDateInLabel.Size = new System.Drawing.Size(74, 19);
            this.SalesDateInLabel.TabIndex = 15;
            this.SalesDateInLabel.Text = "T. Masuk :";
            // 
            // SalesCityTextBox
            // 
            this.SalesCityTextBox.Enabled = false;
            this.SalesCityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesCityTextBox.Location = new System.Drawing.Point(316, 77);
            this.SalesCityTextBox.Name = "SalesCityTextBox";
            this.SalesCityTextBox.Size = new System.Drawing.Size(138, 26);
            this.SalesCityTextBox.TabIndex = 3;
            // 
            // SalesNameTextBox
            // 
            this.SalesNameTextBox.Enabled = false;
            this.SalesNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesNameTextBox.Location = new System.Drawing.Point(85, 38);
            this.SalesNameTextBox.Name = "SalesNameTextBox";
            this.SalesNameTextBox.Size = new System.Drawing.Size(138, 26);
            this.SalesNameTextBox.TabIndex = 1;
            // 
            // SalesNotesTextBox
            // 
            this.SalesNotesTextBox.Enabled = false;
            this.SalesNotesTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesNotesTextBox.Location = new System.Drawing.Point(106, 314);
            this.SalesNotesTextBox.Name = "SalesNotesTextBox";
            this.SalesNotesTextBox.Size = new System.Drawing.Size(348, 26);
            this.SalesNotesTextBox.TabIndex = 6;
            // 
            // SalesTagihTextBox
            // 
            this.SalesTagihTextBox.Enabled = false;
            this.SalesTagihTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTagihTextBox.Location = new System.Drawing.Point(85, 233);
            this.SalesTagihTextBox.Name = "SalesTagihTextBox";
            this.SalesTagihTextBox.ReadOnly = true;
            this.SalesTagihTextBox.Size = new System.Drawing.Size(138, 26);
            this.SalesTagihTextBox.TabIndex = 0;
            this.SalesTagihTextBox.TabStop = false;
            // 
            // SalesOmsetImportTextBox
            // 
            this.SalesOmsetImportTextBox.Enabled = false;
            this.SalesOmsetImportTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesOmsetImportTextBox.Location = new System.Drawing.Point(85, 194);
            this.SalesOmsetImportTextBox.Name = "SalesOmsetImportTextBox";
            this.SalesOmsetImportTextBox.ReadOnly = true;
            this.SalesOmsetImportTextBox.Size = new System.Drawing.Size(138, 26);
            this.SalesOmsetImportTextBox.TabIndex = 0;
            this.SalesOmsetImportTextBox.TabStop = false;
            // 
            // SalesAddrTextBox
            // 
            this.SalesAddrTextBox.Enabled = false;
            this.SalesAddrTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesAddrTextBox.Location = new System.Drawing.Point(85, 116);
            this.SalesAddrTextBox.Name = "SalesAddrTextBox";
            this.SalesAddrTextBox.Size = new System.Drawing.Size(369, 26);
            this.SalesAddrTextBox.TabIndex = 4;
            // 
            // SalesPhoneTextBox
            // 
            this.SalesPhoneTextBox.Enabled = false;
            this.SalesPhoneTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesPhoneTextBox.Location = new System.Drawing.Point(85, 77);
            this.SalesPhoneTextBox.Name = "SalesPhoneTextBox";
            this.SalesPhoneTextBox.Size = new System.Drawing.Size(138, 26);
            this.SalesPhoneTextBox.TabIndex = 2;
            // 
            // SalesTagihLabel
            // 
            this.SalesTagihLabel.AutoSize = true;
            this.SalesTagihLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTagihLabel.Location = new System.Drawing.Point(14, 236);
            this.SalesTagihLabel.Name = "SalesTagihLabel";
            this.SalesTagihLabel.Size = new System.Drawing.Size(68, 19);
            this.SalesTagihLabel.TabIndex = 0;
            this.SalesTagihLabel.Text = "Jlh Tagih :";
            // 
            // SalesPhoneLabel
            // 
            this.SalesPhoneLabel.AutoSize = true;
            this.SalesPhoneLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesPhoneLabel.Location = new System.Drawing.Point(14, 80);
            this.SalesPhoneLabel.Name = "SalesPhoneLabel";
            this.SalesPhoneLabel.Size = new System.Drawing.Size(69, 19);
            this.SalesPhoneLabel.TabIndex = 0;
            this.SalesPhoneLabel.Text = "Telp/Fax :";
            // 
            // SalesAddrLabel
            // 
            this.SalesAddrLabel.AutoSize = true;
            this.SalesAddrLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesAddrLabel.Location = new System.Drawing.Point(14, 119);
            this.SalesAddrLabel.Name = "SalesAddrLabel";
            this.SalesAddrLabel.Size = new System.Drawing.Size(67, 19);
            this.SalesAddrLabel.TabIndex = 0;
            this.SalesAddrLabel.Text = "Alamat1 :";
            // 
            // SalesNotesLabel
            // 
            this.SalesNotesLabel.AutoSize = true;
            this.SalesNotesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesNotesLabel.Location = new System.Drawing.Point(14, 314);
            this.SalesNotesLabel.Name = "SalesNotesLabel";
            this.SalesNotesLabel.Size = new System.Drawing.Size(86, 19);
            this.SalesNotesLabel.TabIndex = 0;
            this.SalesNotesLabel.Text = "Keterangan :";
            // 
            // SalesOmsetImportLabel
            // 
            this.SalesOmsetImportLabel.AutoSize = true;
            this.SalesOmsetImportLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesOmsetImportLabel.Location = new System.Drawing.Point(15, 197);
            this.SalesOmsetImportLabel.Name = "SalesOmsetImportLabel";
            this.SalesOmsetImportLabel.Size = new System.Drawing.Size(71, 19);
            this.SalesOmsetImportLabel.TabIndex = 0;
            this.SalesOmsetImportLabel.Text = "Omset(I) :";
            // 
            // SalesCityLabel
            // 
            this.SalesCityLabel.AutoSize = true;
            this.SalesCityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesCityLabel.Location = new System.Drawing.Point(251, 80);
            this.SalesCityLabel.Name = "SalesCityLabel";
            this.SalesCityLabel.Size = new System.Drawing.Size(47, 19);
            this.SalesCityLabel.TabIndex = 3;
            this.SalesCityLabel.Text = "Kota :";
            // 
            // SalesCodeLabel
            // 
            this.SalesCodeLabel.AutoSize = true;
            this.SalesCodeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesCodeLabel.Location = new System.Drawing.Point(251, 41);
            this.SalesCodeLabel.Name = "SalesCodeLabel";
            this.SalesCodeLabel.Size = new System.Drawing.Size(87, 19);
            this.SalesCodeLabel.TabIndex = 0;
            this.SalesCodeLabel.Text = "Kode Sales :";
            // 
            // SalesNameLabel
            // 
            this.SalesNameLabel.AutoSize = true;
            this.SalesNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesNameLabel.Location = new System.Drawing.Point(14, 41);
            this.SalesNameLabel.Name = "SalesNameLabel";
            this.SalesNameLabel.Size = new System.Drawing.Size(57, 19);
            this.SalesNameLabel.TabIndex = 0;
            this.SalesNameLabel.Text = "Nama : ";
            // 
            // salesOLV
            // 
            this.salesOLV.AllColumns.Add(this.olvColumn7);
            this.salesOLV.AllColumns.Add(this.olvColumn8);
            this.salesOLV.AllColumns.Add(this.olvColumn9);
            this.salesOLV.AllColumns.Add(this.olvColumn10);
            this.salesOLV.AllColumns.Add(this.olvColumn11);
            this.salesOLV.AllColumns.Add(this.olvColumn12);
            this.salesOLV.AllowDrop = true;
            this.salesOLV.AlternateRowBackColor = System.Drawing.Color.LemonChiffon;
            this.salesOLV.CellEditUseWholeCell = false;
            this.salesOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn7,
            this.olvColumn8,
            this.olvColumn9,
            this.olvColumn10,
            this.olvColumn11,
            this.olvColumn12});
            this.salesOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.salesOLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOLV.FullRowSelect = true;
            this.salesOLV.HeaderFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.salesOLV.HeaderFormatStyle = this.olvHdr;
            this.salesOLV.Location = new System.Drawing.Point(6, 72);
            this.salesOLV.Name = "salesOLV";
            this.salesOLV.ShowGroups = false;
            this.salesOLV.Size = new System.Drawing.Size(846, 554);
            this.salesOLV.TabIndex = 0;
            this.salesOLV.UseAlternatingBackColors = true;
            this.salesOLV.UseCompatibleStateImageBehavior = false;
            this.salesOLV.UseFilterIndicator = true;
            this.salesOLV.UseFiltering = true;
            this.salesOLV.View = System.Windows.Forms.View.Details;
            this.salesOLV.VirtualMode = true;
            this.salesOLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.salesOLV_ItemSelectionChanged);
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "Nama";
            this.olvColumn7.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn7.Text = "Nama";
            this.olvColumn7.UseInitialLetterForGroup = true;
            this.olvColumn7.Width = 157;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "KodeSales";
            this.olvColumn8.AspectToStringFormat = "SL{0:000}";
            this.olvColumn8.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn8.Text = "Kode Sales";
            this.olvColumn8.UseInitialLetterForGroup = true;
            this.olvColumn8.Width = 99;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "Kota";
            this.olvColumn9.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn9.Text = "Kota";
            this.olvColumn9.UseInitialLetterForGroup = true;
            this.olvColumn9.Width = 118;
            // 
            // olvColumn10
            // 
            this.olvColumn10.AspectName = "Omset";
            this.olvColumn10.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn10.Text = "Omset";
            this.olvColumn10.UseInitialLetterForGroup = true;
            this.olvColumn10.Width = 161;
            // 
            // olvColumn11
            // 
            this.olvColumn11.AspectName = "Profit";
            this.olvColumn11.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn11.Text = "Profit";
            this.olvColumn11.UseInitialLetterForGroup = true;
            this.olvColumn11.Width = 140;
            // 
            // olvColumn12
            // 
            this.olvColumn12.AspectName = "JumlahTagih";
            this.olvColumn12.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn12.Text = "Jumlah Tagih";
            this.olvColumn12.UseInitialLetterForGroup = true;
            this.olvColumn12.Width = 165;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.SupplierFilterGroupBox);
            this.tabPage4.Controls.Add(this.SuppGroupBox);
            this.tabPage4.Controls.Add(this.supplierOLV);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1338, 629);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Daftar Supplier";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // SupplierFilterGroupBox
            // 
            this.SupplierFilterGroupBox.Controls.Add(this.SupplierFilterTextBox);
            this.SupplierFilterGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierFilterGroupBox.Location = new System.Drawing.Point(739, 7);
            this.SupplierFilterGroupBox.Name = "SupplierFilterGroupBox";
            this.SupplierFilterGroupBox.Size = new System.Drawing.Size(113, 59);
            this.SupplierFilterGroupBox.TabIndex = 7;
            this.SupplierFilterGroupBox.TabStop = false;
            this.SupplierFilterGroupBox.Text = "Filter";
            // 
            // SupplierFilterTextBox
            // 
            this.SupplierFilterTextBox.Location = new System.Drawing.Point(6, 25);
            this.SupplierFilterTextBox.Name = "SupplierFilterTextBox";
            this.SupplierFilterTextBox.Size = new System.Drawing.Size(100, 26);
            this.SupplierFilterTextBox.TabIndex = 0;
            this.SupplierFilterTextBox.TextChanged += new System.EventHandler(this.SupplierFilterTextBox_TextChanged);
            // 
            // SuppGroupBox
            // 
            this.SuppGroupBox.Controls.Add(this.SupplierCreditDayTextBox);
            this.SuppGroupBox.Controls.Add(this.SuppCancelButton);
            this.SuppGroupBox.Controls.Add(this.SuppEditButton);
            this.SuppGroupBox.Controls.Add(this.SuppNewButton);
            this.SuppGroupBox.Controls.Add(this.SupplierJatuhTempoTextBox);
            this.SuppGroupBox.Controls.Add(this.SupplierJatuhTempoLabel);
            this.SuppGroupBox.Controls.Add(this.SupplierCreditDayLabel);
            this.SuppGroupBox.Controls.Add(this.SupplierCityTextBox);
            this.SuppGroupBox.Controls.Add(this.SupplierNameTextBox);
            this.SuppGroupBox.Controls.Add(this.SupplierNotesTextBox);
            this.SuppGroupBox.Controls.Add(this.SupplierAddrTextBox);
            this.SuppGroupBox.Controls.Add(this.SupplierPhoneTextBox);
            this.SuppGroupBox.Controls.Add(this.SupplierPhoneLabel);
            this.SuppGroupBox.Controls.Add(this.SupplierAddrLabel);
            this.SuppGroupBox.Controls.Add(this.SupplierNotesLabel);
            this.SuppGroupBox.Controls.Add(this.SupplierCityLabel);
            this.SuppGroupBox.Controls.Add(this.SupplierCodeLabel);
            this.SuppGroupBox.Controls.Add(this.SupplierNameLabel);
            this.SuppGroupBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppGroupBox.Location = new System.Drawing.Point(858, 6);
            this.SuppGroupBox.Name = "SuppGroupBox";
            this.SuppGroupBox.Size = new System.Drawing.Size(472, 620);
            this.SuppGroupBox.TabIndex = 0;
            this.SuppGroupBox.TabStop = false;
            this.SuppGroupBox.Text = "Detail";
            // 
            // SupplierCreditDayTextBox
            // 
            this.SupplierCreditDayTextBox.Enabled = false;
            this.SupplierCreditDayTextBox.FormattingEnabled = true;
            this.SupplierCreditDayTextBox.Location = new System.Drawing.Point(337, 152);
            this.SupplierCreditDayTextBox.Name = "SupplierCreditDayTextBox";
            this.SupplierCreditDayTextBox.Size = new System.Drawing.Size(57, 31);
            this.SupplierCreditDayTextBox.TabIndex = 5;
            // 
            // SuppCancelButton
            // 
            this.SuppCancelButton.Enabled = false;
            this.SuppCancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppCancelButton.Location = new System.Drawing.Point(99, 566);
            this.SuppCancelButton.Name = "SuppCancelButton";
            this.SuppCancelButton.Size = new System.Drawing.Size(75, 35);
            this.SuppCancelButton.TabIndex = 26;
            this.SuppCancelButton.Text = "Cancel";
            this.SuppCancelButton.UseVisualStyleBackColor = true;
            this.SuppCancelButton.Click += new System.EventHandler(this.SuppButton3_Click);
            // 
            // SuppEditButton
            // 
            this.SuppEditButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppEditButton.Location = new System.Drawing.Point(180, 566);
            this.SuppEditButton.Name = "SuppEditButton";
            this.SuppEditButton.Size = new System.Drawing.Size(75, 35);
            this.SuppEditButton.TabIndex = 25;
            this.SuppEditButton.Text = "Edit";
            this.SuppEditButton.UseVisualStyleBackColor = true;
            this.SuppEditButton.Click += new System.EventHandler(this.SuppButton2_Click);
            // 
            // SuppNewButton
            // 
            this.SuppNewButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppNewButton.Location = new System.Drawing.Point(18, 566);
            this.SuppNewButton.Name = "SuppNewButton";
            this.SuppNewButton.Size = new System.Drawing.Size(75, 35);
            this.SuppNewButton.TabIndex = 7;
            this.SuppNewButton.Text = "Baru";
            this.SuppNewButton.UseVisualStyleBackColor = true;
            this.SuppNewButton.Click += new System.EventHandler(this.SuppButton1_Click);
            // 
            // SupplierJatuhTempoTextBox
            // 
            this.SupplierJatuhTempoTextBox.Enabled = false;
            this.SupplierJatuhTempoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierJatuhTempoTextBox.Location = new System.Drawing.Point(104, 155);
            this.SupplierJatuhTempoTextBox.Name = "SupplierJatuhTempoTextBox";
            this.SupplierJatuhTempoTextBox.ReadOnly = true;
            this.SupplierJatuhTempoTextBox.Size = new System.Drawing.Size(119, 26);
            this.SupplierJatuhTempoTextBox.TabIndex = 20;
            this.SupplierJatuhTempoTextBox.TabStop = false;
            // 
            // SupplierJatuhTempoLabel
            // 
            this.SupplierJatuhTempoLabel.AutoSize = true;
            this.SupplierJatuhTempoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierJatuhTempoLabel.Location = new System.Drawing.Point(14, 158);
            this.SupplierJatuhTempoLabel.Name = "SupplierJatuhTempoLabel";
            this.SupplierJatuhTempoLabel.Size = new System.Drawing.Size(93, 19);
            this.SupplierJatuhTempoLabel.TabIndex = 16;
            this.SupplierJatuhTempoLabel.Text = "Jatuh Tempo :";
            // 
            // SupplierCreditDayLabel
            // 
            this.SupplierCreditDayLabel.AutoSize = true;
            this.SupplierCreditDayLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierCreditDayLabel.Location = new System.Drawing.Point(248, 158);
            this.SupplierCreditDayLabel.Name = "SupplierCreditDayLabel";
            this.SupplierCreditDayLabel.Size = new System.Drawing.Size(83, 19);
            this.SupplierCreditDayLabel.TabIndex = 15;
            this.SupplierCreditDayLabel.Text = "Credit Day :";
            // 
            // SupplierCityTextBox
            // 
            this.SupplierCityTextBox.Enabled = false;
            this.SupplierCityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierCityTextBox.Location = new System.Drawing.Point(301, 77);
            this.SupplierCityTextBox.Name = "SupplierCityTextBox";
            this.SupplierCityTextBox.Size = new System.Drawing.Size(164, 26);
            this.SupplierCityTextBox.TabIndex = 3;
            // 
            // SupplierNameTextBox
            // 
            this.SupplierNameTextBox.Enabled = false;
            this.SupplierNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNameTextBox.Location = new System.Drawing.Point(85, 38);
            this.SupplierNameTextBox.Name = "SupplierNameTextBox";
            this.SupplierNameTextBox.Size = new System.Drawing.Size(138, 26);
            this.SupplierNameTextBox.TabIndex = 1;
            // 
            // SupplierNotesTextBox
            // 
            this.SupplierNotesTextBox.Enabled = false;
            this.SupplierNotesTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNotesTextBox.Location = new System.Drawing.Point(104, 194);
            this.SupplierNotesTextBox.Name = "SupplierNotesTextBox";
            this.SupplierNotesTextBox.Size = new System.Drawing.Size(348, 26);
            this.SupplierNotesTextBox.TabIndex = 6;
            // 
            // SupplierAddrTextBox
            // 
            this.SupplierAddrTextBox.Enabled = false;
            this.SupplierAddrTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierAddrTextBox.Location = new System.Drawing.Point(85, 116);
            this.SupplierAddrTextBox.Name = "SupplierAddrTextBox";
            this.SupplierAddrTextBox.Size = new System.Drawing.Size(380, 26);
            this.SupplierAddrTextBox.TabIndex = 4;
            // 
            // SupplierPhoneTextBox
            // 
            this.SupplierPhoneTextBox.Enabled = false;
            this.SupplierPhoneTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierPhoneTextBox.Location = new System.Drawing.Point(85, 77);
            this.SupplierPhoneTextBox.Name = "SupplierPhoneTextBox";
            this.SupplierPhoneTextBox.Size = new System.Drawing.Size(138, 26);
            this.SupplierPhoneTextBox.TabIndex = 2;
            // 
            // SupplierPhoneLabel
            // 
            this.SupplierPhoneLabel.AutoSize = true;
            this.SupplierPhoneLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierPhoneLabel.Location = new System.Drawing.Point(14, 80);
            this.SupplierPhoneLabel.Name = "SupplierPhoneLabel";
            this.SupplierPhoneLabel.Size = new System.Drawing.Size(69, 19);
            this.SupplierPhoneLabel.TabIndex = 0;
            this.SupplierPhoneLabel.Text = "Telp/Fax :";
            // 
            // SupplierAddrLabel
            // 
            this.SupplierAddrLabel.AutoSize = true;
            this.SupplierAddrLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierAddrLabel.Location = new System.Drawing.Point(14, 119);
            this.SupplierAddrLabel.Name = "SupplierAddrLabel";
            this.SupplierAddrLabel.Size = new System.Drawing.Size(59, 19);
            this.SupplierAddrLabel.TabIndex = 0;
            this.SupplierAddrLabel.Text = "Alamat :";
            // 
            // SupplierNotesLabel
            // 
            this.SupplierNotesLabel.AutoSize = true;
            this.SupplierNotesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNotesLabel.Location = new System.Drawing.Point(14, 197);
            this.SupplierNotesLabel.Name = "SupplierNotesLabel";
            this.SupplierNotesLabel.Size = new System.Drawing.Size(86, 19);
            this.SupplierNotesLabel.TabIndex = 0;
            this.SupplierNotesLabel.Text = "Keterangan :";
            // 
            // SupplierCityLabel
            // 
            this.SupplierCityLabel.AutoSize = true;
            this.SupplierCityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierCityLabel.Location = new System.Drawing.Point(248, 80);
            this.SupplierCityLabel.Name = "SupplierCityLabel";
            this.SupplierCityLabel.Size = new System.Drawing.Size(47, 19);
            this.SupplierCityLabel.TabIndex = 3;
            this.SupplierCityLabel.Text = "Kota :";
            // 
            // SupplierCodeLabel
            // 
            this.SupplierCodeLabel.AutoSize = true;
            this.SupplierCodeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierCodeLabel.Location = new System.Drawing.Point(248, 41);
            this.SupplierCodeLabel.Name = "SupplierCodeLabel";
            this.SupplierCodeLabel.Size = new System.Drawing.Size(105, 19);
            this.SupplierCodeLabel.TabIndex = 0;
            this.SupplierCodeLabel.Text = "Kode Supplier :";
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNameLabel.Location = new System.Drawing.Point(14, 41);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(57, 19);
            this.SupplierNameLabel.TabIndex = 0;
            this.SupplierNameLabel.Text = "Nama : ";
            // 
            // supplierOLV
            // 
            this.supplierOLV.AllColumns.Add(this.olvColumn19);
            this.supplierOLV.AllColumns.Add(this.olvColumn20);
            this.supplierOLV.AllColumns.Add(this.olvColumn21);
            this.supplierOLV.AllColumns.Add(this.olvColumn22);
            this.supplierOLV.AllColumns.Add(this.olvColumn23);
            this.supplierOLV.AllColumns.Add(this.olvColumn24);
            this.supplierOLV.AlternateRowBackColor = System.Drawing.Color.LemonChiffon;
            this.supplierOLV.CellEditUseWholeCell = false;
            this.supplierOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn19,
            this.olvColumn20,
            this.olvColumn21,
            this.olvColumn22,
            this.olvColumn23,
            this.olvColumn24});
            this.supplierOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.supplierOLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierOLV.FullRowSelect = true;
            this.supplierOLV.HeaderFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.supplierOLV.HeaderFormatStyle = this.olvHdr;
            this.supplierOLV.Location = new System.Drawing.Point(6, 72);
            this.supplierOLV.Name = "supplierOLV";
            this.supplierOLV.ShowGroups = false;
            this.supplierOLV.Size = new System.Drawing.Size(846, 554);
            this.supplierOLV.TabIndex = 1;
            this.supplierOLV.UseAlternatingBackColors = true;
            this.supplierOLV.UseCompatibleStateImageBehavior = false;
            this.supplierOLV.UseFilterIndicator = true;
            this.supplierOLV.UseFiltering = true;
            this.supplierOLV.View = System.Windows.Forms.View.Details;
            this.supplierOLV.VirtualMode = true;
            this.supplierOLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.supplierOLV_ItemSelectionChanged);
            // 
            // olvColumn19
            // 
            this.olvColumn19.AspectName = "Nama";
            this.olvColumn19.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn19.Text = "Nama";
            this.olvColumn19.UseInitialLetterForGroup = true;
            this.olvColumn19.Width = 140;
            // 
            // olvColumn20
            // 
            this.olvColumn20.AspectName = "KodeSupplier";
            this.olvColumn20.AspectToStringFormat = "S{0:000}";
            this.olvColumn20.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn20.Text = "Kode Supplier";
            this.olvColumn20.UseInitialLetterForGroup = true;
            this.olvColumn20.Width = 102;
            // 
            // olvColumn21
            // 
            this.olvColumn21.AspectName = "Kota";
            this.olvColumn21.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn21.Text = "Kota";
            this.olvColumn21.UseInitialLetterForGroup = true;
            this.olvColumn21.Width = 120;
            // 
            // olvColumn22
            // 
            this.olvColumn22.AspectName = "CreditDay";
            this.olvColumn22.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn22.Text = "Credit Day";
            this.olvColumn22.UseInitialLetterForGroup = true;
            this.olvColumn22.Width = 91;
            // 
            // olvColumn23
            // 
            this.olvColumn23.AspectName = "JatuhTempo";
            this.olvColumn23.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn23.Text = "Jatuh Tempo";
            this.olvColumn23.UseInitialLetterForGroup = true;
            this.olvColumn23.Width = 120;
            // 
            // olvColumn24
            // 
            this.olvColumn24.AspectName = "Keterangan";
            this.olvColumn24.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn24.Text = "Keterangan";
            this.olvColumn24.UseInitialLetterForGroup = true;
            this.olvColumn24.Width = 267;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CustomerFilterGroupBox);
            this.tabPage3.Controls.Add(this.CustGroupBox);
            this.tabPage3.Controls.Add(this.customerOLV);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1338, 629);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Daftar Customer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CustomerFilterGroupBox
            // 
            this.CustomerFilterGroupBox.Controls.Add(this.CustomerFilterTextBox);
            this.CustomerFilterGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFilterGroupBox.Location = new System.Drawing.Point(739, 7);
            this.CustomerFilterGroupBox.Name = "CustomerFilterGroupBox";
            this.CustomerFilterGroupBox.Size = new System.Drawing.Size(113, 59);
            this.CustomerFilterGroupBox.TabIndex = 6;
            this.CustomerFilterGroupBox.TabStop = false;
            this.CustomerFilterGroupBox.Text = "Filter";
            // 
            // CustomerFilterTextBox
            // 
            this.CustomerFilterTextBox.Location = new System.Drawing.Point(6, 25);
            this.CustomerFilterTextBox.Name = "CustomerFilterTextBox";
            this.CustomerFilterTextBox.Size = new System.Drawing.Size(100, 26);
            this.CustomerFilterTextBox.TabIndex = 0;
            this.CustomerFilterTextBox.TextChanged += new System.EventHandler(this.CustomerFilterTextBox_TextChanged);
            // 
            // CustGroupBox
            // 
            this.CustGroupBox.Controls.Add(this.CustSalesNameTextBox);
            this.CustGroupBox.Controls.Add(this.CustLamaKreditTextBox);
            this.CustGroupBox.Controls.Add(this.CustSalesNumLabel);
            this.CustGroupBox.Controls.Add(this.CustEditButton);
            this.CustGroupBox.Controls.Add(this.CustCancelButton);
            this.CustGroupBox.Controls.Add(this.CustTotalReturnTextBox);
            this.CustGroupBox.Controls.Add(this.CustR2TextBox);
            this.CustGroupBox.Controls.Add(this.CustR1TextBox);
            this.CustGroupBox.Controls.Add(this.CustCityTextBox);
            this.CustGroupBox.Controls.Add(this.CustTotalReturnLabel);
            this.CustGroupBox.Controls.Add(this.CustSR2Label);
            this.CustGroupBox.Controls.Add(this.CustSR1Label);
            this.CustGroupBox.Controls.Add(this.CustJ3TextBox);
            this.CustGroupBox.Controls.Add(this.CustJ2TextBox);
            this.CustGroupBox.Controls.Add(this.CustJ1TextBox);
            this.CustGroupBox.Controls.Add(this.CustSJ3Label);
            this.CustGroupBox.Controls.Add(this.CustSJ2Label);
            this.CustGroupBox.Controls.Add(this.CustSJ1Label);
            this.CustGroupBox.Controls.Add(this.CustNewButton);
            this.CustGroupBox.Controls.Add(this.CustNameTextBox);
            this.CustGroupBox.Controls.Add(this.CustMarketCheckBox);
            this.CustGroupBox.Controls.Add(this.CustNpwpAddrTextBox);
            this.CustGroupBox.Controls.Add(this.CustNpwpNameTextBox);
            this.CustGroupBox.Controls.Add(this.CustNotesTextBox);
            this.CustGroupBox.Controls.Add(this.CustJatuhTempoTextBox);
            this.CustGroupBox.Controls.Add(this.CustPiutangTextBox);
            this.CustGroupBox.Controls.Add(this.CustAddr2TextBox);
            this.CustGroupBox.Controls.Add(this.CustAddr1TextBox);
            this.CustGroupBox.Controls.Add(this.CustPhoneTextBox);
            this.CustGroupBox.Controls.Add(this.CustNpwpNumTextBox);
            this.CustGroupBox.Controls.Add(this.CustLamaKreditLabel);
            this.CustGroupBox.Controls.Add(this.CustJatuhTempoLabel);
            this.CustGroupBox.Controls.Add(this.CustNpwpLabel);
            this.CustGroupBox.Controls.Add(this.CustSalesCodeLabel);
            this.CustGroupBox.Controls.Add(this.TelpCustLabel);
            this.CustGroupBox.Controls.Add(this.CustAddr2Label);
            this.CustGroupBox.Controls.Add(this.CustAddr1Label);
            this.CustGroupBox.Controls.Add(this.CustNotesLabel);
            this.CustGroupBox.Controls.Add(this.CustPiutangLabel);
            this.CustGroupBox.Controls.Add(this.CustCityLabel);
            this.CustGroupBox.Controls.Add(this.CustSalesNameLabel);
            this.CustGroupBox.Controls.Add(this.CustCodeLabel);
            this.CustGroupBox.Controls.Add(this.CustNameLabel);
            this.CustGroupBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustGroupBox.Location = new System.Drawing.Point(858, 6);
            this.CustGroupBox.Name = "CustGroupBox";
            this.CustGroupBox.Size = new System.Drawing.Size(472, 620);
            this.CustGroupBox.TabIndex = 5;
            this.CustGroupBox.TabStop = false;
            this.CustGroupBox.Text = "Detail";
            // 
            // CustSalesNameTextBox
            // 
            this.CustSalesNameTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustSalesNameTextBox.Enabled = false;
            this.CustSalesNameTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CustSalesNameTextBox.Location = new System.Drawing.Point(106, 503);
            this.CustSalesNameTextBox.Name = "CustSalesNameTextBox";
            this.CustSalesNameTextBox.Size = new System.Drawing.Size(121, 31);
            this.CustSalesNameTextBox.TabIndex = 12;
            this.CustSalesNameTextBox.SelectedValueChanged += new System.EventHandler(this.CustSalesNameTextBox_SelectedValueChanged);
            // 
            // CustLamaKreditTextBox
            // 
            this.CustLamaKreditTextBox.Enabled = false;
            this.CustLamaKreditTextBox.FormattingEnabled = true;
            this.CustLamaKreditTextBox.Location = new System.Drawing.Point(404, 230);
            this.CustLamaKreditTextBox.Name = "CustLamaKreditTextBox";
            this.CustLamaKreditTextBox.Size = new System.Drawing.Size(61, 31);
            this.CustLamaKreditTextBox.TabIndex = 9;
            // 
            // CustSalesNumLabel
            // 
            this.CustSalesNumLabel.AutoSize = true;
            this.CustSalesNumLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustSalesNumLabel.Location = new System.Drawing.Point(341, 509);
            this.CustSalesNumLabel.Name = "CustSalesNumLabel";
            this.CustSalesNumLabel.Size = new System.Drawing.Size(0, 19);
            this.CustSalesNumLabel.TabIndex = 25;
            this.CustSalesNumLabel.Click += new System.EventHandler(this.NoSalesCustLabel_Click);
            // 
            // CustEditButton
            // 
            this.CustEditButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustEditButton.Location = new System.Drawing.Point(180, 566);
            this.CustEditButton.Name = "CustEditButton";
            this.CustEditButton.Size = new System.Drawing.Size(75, 35);
            this.CustEditButton.TabIndex = 24;
            this.CustEditButton.Text = "Edit";
            this.CustEditButton.UseVisualStyleBackColor = true;
            this.CustEditButton.Click += new System.EventHandler(this.CustButton2_Click);
            // 
            // CustCancelButton
            // 
            this.CustCancelButton.Enabled = false;
            this.CustCancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustCancelButton.Location = new System.Drawing.Point(99, 566);
            this.CustCancelButton.Name = "CustCancelButton";
            this.CustCancelButton.Size = new System.Drawing.Size(75, 35);
            this.CustCancelButton.TabIndex = 23;
            this.CustCancelButton.Text = "Cancel";
            this.CustCancelButton.UseVisualStyleBackColor = true;
            this.CustCancelButton.Click += new System.EventHandler(this.CustButton3_Click);
            // 
            // CustTotalReturnTextBox
            // 
            this.CustTotalReturnTextBox.Enabled = false;
            this.CustTotalReturnTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustTotalReturnTextBox.Location = new System.Drawing.Point(337, 311);
            this.CustTotalReturnTextBox.Name = "CustTotalReturnTextBox";
            this.CustTotalReturnTextBox.ReadOnly = true;
            this.CustTotalReturnTextBox.Size = new System.Drawing.Size(128, 26);
            this.CustTotalReturnTextBox.TabIndex = 0;
            this.CustTotalReturnTextBox.TabStop = false;
            // 
            // CustR2TextBox
            // 
            this.CustR2TextBox.Enabled = false;
            this.CustR2TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustR2TextBox.Location = new System.Drawing.Point(337, 389);
            this.CustR2TextBox.Name = "CustR2TextBox";
            this.CustR2TextBox.ReadOnly = true;
            this.CustR2TextBox.Size = new System.Drawing.Size(128, 26);
            this.CustR2TextBox.TabIndex = 0;
            this.CustR2TextBox.TabStop = false;
            // 
            // CustR1TextBox
            // 
            this.CustR1TextBox.Enabled = false;
            this.CustR1TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustR1TextBox.Location = new System.Drawing.Point(337, 350);
            this.CustR1TextBox.Name = "CustR1TextBox";
            this.CustR1TextBox.ReadOnly = true;
            this.CustR1TextBox.Size = new System.Drawing.Size(128, 26);
            this.CustR1TextBox.TabIndex = 0;
            this.CustR1TextBox.TabStop = false;
            // 
            // CustCityTextBox
            // 
            this.CustCityTextBox.Enabled = false;
            this.CustCityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustCityTextBox.Location = new System.Drawing.Point(301, 77);
            this.CustCityTextBox.Name = "CustCityTextBox";
            this.CustCityTextBox.Size = new System.Drawing.Size(164, 26);
            this.CustCityTextBox.TabIndex = 3;
            // 
            // CustTotalReturnLabel
            // 
            this.CustTotalReturnLabel.AutoSize = true;
            this.CustTotalReturnLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustTotalReturnLabel.Location = new System.Drawing.Point(243, 314);
            this.CustTotalReturnLabel.Name = "CustTotalReturnLabel";
            this.CustTotalReturnLabel.Size = new System.Drawing.Size(83, 19);
            this.CustTotalReturnLabel.TabIndex = 22;
            this.CustTotalReturnLabel.Text = "Total Retur :";
            // 
            // CustSR2Label
            // 
            this.CustSR2Label.AutoSize = true;
            this.CustSR2Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustSR2Label.Location = new System.Drawing.Point(243, 392);
            this.CustSR2Label.Name = "CustSR2Label";
            this.CustSR2Label.Size = new System.Drawing.Size(78, 19);
            this.CustSR2Label.TabIndex = 21;
            this.CustSR2Label.Text = "S. Retur 2 :";
            // 
            // CustSR1Label
            // 
            this.CustSR1Label.AutoSize = true;
            this.CustSR1Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustSR1Label.Location = new System.Drawing.Point(243, 353);
            this.CustSR1Label.Name = "CustSR1Label";
            this.CustSR1Label.Size = new System.Drawing.Size(78, 19);
            this.CustSR1Label.TabIndex = 20;
            this.CustSR1Label.Text = "S. Retur 1 :";
            // 
            // CustJ3TextBox
            // 
            this.CustJ3TextBox.Enabled = false;
            this.CustJ3TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustJ3TextBox.Location = new System.Drawing.Point(85, 428);
            this.CustJ3TextBox.Name = "CustJ3TextBox";
            this.CustJ3TextBox.ReadOnly = true;
            this.CustJ3TextBox.Size = new System.Drawing.Size(138, 26);
            this.CustJ3TextBox.TabIndex = 0;
            this.CustJ3TextBox.TabStop = false;
            // 
            // CustJ2TextBox
            // 
            this.CustJ2TextBox.Enabled = false;
            this.CustJ2TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustJ2TextBox.Location = new System.Drawing.Point(85, 389);
            this.CustJ2TextBox.Name = "CustJ2TextBox";
            this.CustJ2TextBox.ReadOnly = true;
            this.CustJ2TextBox.Size = new System.Drawing.Size(138, 26);
            this.CustJ2TextBox.TabIndex = 0;
            this.CustJ2TextBox.TabStop = false;
            // 
            // CustJ1TextBox
            // 
            this.CustJ1TextBox.Enabled = false;
            this.CustJ1TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustJ1TextBox.Location = new System.Drawing.Point(85, 350);
            this.CustJ1TextBox.Name = "CustJ1TextBox";
            this.CustJ1TextBox.ReadOnly = true;
            this.CustJ1TextBox.Size = new System.Drawing.Size(138, 26);
            this.CustJ1TextBox.TabIndex = 0;
            this.CustJ1TextBox.TabStop = false;
            // 
            // CustSJ3Label
            // 
            this.CustSJ3Label.AutoSize = true;
            this.CustSJ3Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustSJ3Label.Location = new System.Drawing.Point(14, 431);
            this.CustSJ3Label.Name = "CustSJ3Label";
            this.CustSJ3Label.Size = new System.Drawing.Size(68, 19);
            this.CustSJ3Label.TabIndex = 16;
            this.CustSJ3Label.Text = "S. Jual 3 :";
            // 
            // CustSJ2Label
            // 
            this.CustSJ2Label.AutoSize = true;
            this.CustSJ2Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustSJ2Label.Location = new System.Drawing.Point(14, 392);
            this.CustSJ2Label.Name = "CustSJ2Label";
            this.CustSJ2Label.Size = new System.Drawing.Size(68, 19);
            this.CustSJ2Label.TabIndex = 15;
            this.CustSJ2Label.Text = "S. Jual 2 :";
            // 
            // CustSJ1Label
            // 
            this.CustSJ1Label.AutoSize = true;
            this.CustSJ1Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustSJ1Label.Location = new System.Drawing.Point(14, 353);
            this.CustSJ1Label.Name = "CustSJ1Label";
            this.CustSJ1Label.Size = new System.Drawing.Size(68, 19);
            this.CustSJ1Label.TabIndex = 14;
            this.CustSJ1Label.Text = "S. Jual 1 :";
            // 
            // CustNewButton
            // 
            this.CustNewButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNewButton.Location = new System.Drawing.Point(18, 566);
            this.CustNewButton.Name = "CustNewButton";
            this.CustNewButton.Size = new System.Drawing.Size(75, 35);
            this.CustNewButton.TabIndex = 13;
            this.CustNewButton.Text = "Baru";
            this.CustNewButton.UseVisualStyleBackColor = true;
            this.CustNewButton.Click += new System.EventHandler(this.CustButton1_Click);
            // 
            // CustNameTextBox
            // 
            this.CustNameTextBox.Enabled = false;
            this.CustNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameTextBox.Location = new System.Drawing.Point(85, 38);
            this.CustNameTextBox.Name = "CustNameTextBox";
            this.CustNameTextBox.Size = new System.Drawing.Size(138, 26);
            this.CustNameTextBox.TabIndex = 1;
            // 
            // CustMarketCheckBox
            // 
            this.CustMarketCheckBox.AutoSize = true;
            this.CustMarketCheckBox.Checked = true;
            this.CustMarketCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CustMarketCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustMarketCheckBox.Location = new System.Drawing.Point(301, 196);
            this.CustMarketCheckBox.Name = "CustMarketCheckBox";
            this.CustMarketCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustMarketCheckBox.Size = new System.Drawing.Size(80, 23);
            this.CustMarketCheckBox.TabIndex = 7;
            this.CustMarketCheckBox.Text = ": Market";
            this.CustMarketCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustMarketCheckBox.UseVisualStyleBackColor = true;
            // 
            // CustNpwpAddrTextBox
            // 
            this.CustNpwpAddrTextBox.Enabled = false;
            this.CustNpwpAddrTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNpwpAddrTextBox.Location = new System.Drawing.Point(85, 272);
            this.CustNpwpAddrTextBox.Name = "CustNpwpAddrTextBox";
            this.CustNpwpAddrTextBox.Size = new System.Drawing.Size(380, 26);
            this.CustNpwpAddrTextBox.TabIndex = 10;
            this.CustNpwpAddrTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.CustNpwpAddrTextBox.WaterMarkText = "Alamat NPWP";
            // 
            // CustNpwpNameTextBox
            // 
            this.CustNpwpNameTextBox.Enabled = false;
            this.CustNpwpNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNpwpNameTextBox.Location = new System.Drawing.Point(85, 233);
            this.CustNpwpNameTextBox.Name = "CustNpwpNameTextBox";
            this.CustNpwpNameTextBox.Size = new System.Drawing.Size(210, 26);
            this.CustNpwpNameTextBox.TabIndex = 8;
            this.CustNpwpNameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.CustNpwpNameTextBox.WaterMarkText = "Nama NPWP";
            // 
            // CustNotesTextBox
            // 
            this.CustNotesTextBox.Enabled = false;
            this.CustNotesTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNotesTextBox.Location = new System.Drawing.Point(106, 467);
            this.CustNotesTextBox.Name = "CustNotesTextBox";
            this.CustNotesTextBox.Size = new System.Drawing.Size(359, 26);
            this.CustNotesTextBox.TabIndex = 11;
            // 
            // CustJatuhTempoTextBox
            // 
            this.CustJatuhTempoTextBox.Enabled = false;
            this.CustJatuhTempoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustJatuhTempoTextBox.Location = new System.Drawing.Point(337, 428);
            this.CustJatuhTempoTextBox.Name = "CustJatuhTempoTextBox";
            this.CustJatuhTempoTextBox.ReadOnly = true;
            this.CustJatuhTempoTextBox.ShortcutsEnabled = false;
            this.CustJatuhTempoTextBox.Size = new System.Drawing.Size(128, 26);
            this.CustJatuhTempoTextBox.TabIndex = 0;
            this.CustJatuhTempoTextBox.TabStop = false;
            // 
            // CustPiutangTextBox
            // 
            this.CustPiutangTextBox.Enabled = false;
            this.CustPiutangTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustPiutangTextBox.Location = new System.Drawing.Point(85, 311);
            this.CustPiutangTextBox.Name = "CustPiutangTextBox";
            this.CustPiutangTextBox.ReadOnly = true;
            this.CustPiutangTextBox.Size = new System.Drawing.Size(138, 26);
            this.CustPiutangTextBox.TabIndex = 0;
            this.CustPiutangTextBox.TabStop = false;
            // 
            // CustAddr2TextBox
            // 
            this.CustAddr2TextBox.Enabled = false;
            this.CustAddr2TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustAddr2TextBox.Location = new System.Drawing.Point(85, 155);
            this.CustAddr2TextBox.Name = "CustAddr2TextBox";
            this.CustAddr2TextBox.Size = new System.Drawing.Size(380, 26);
            this.CustAddr2TextBox.TabIndex = 5;
            // 
            // CustAddr1TextBox
            // 
            this.CustAddr1TextBox.Enabled = false;
            this.CustAddr1TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustAddr1TextBox.Location = new System.Drawing.Point(85, 116);
            this.CustAddr1TextBox.Name = "CustAddr1TextBox";
            this.CustAddr1TextBox.Size = new System.Drawing.Size(380, 26);
            this.CustAddr1TextBox.TabIndex = 4;
            // 
            // CustPhoneTextBox
            // 
            this.CustPhoneTextBox.Enabled = false;
            this.CustPhoneTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustPhoneTextBox.Location = new System.Drawing.Point(85, 77);
            this.CustPhoneTextBox.Name = "CustPhoneTextBox";
            this.CustPhoneTextBox.Size = new System.Drawing.Size(138, 26);
            this.CustPhoneTextBox.TabIndex = 2;
            // 
            // CustNpwpNumTextBox
            // 
            this.CustNpwpNumTextBox.Enabled = false;
            this.CustNpwpNumTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNpwpNumTextBox.Location = new System.Drawing.Point(85, 194);
            this.CustNpwpNumTextBox.Name = "CustNpwpNumTextBox";
            this.CustNpwpNumTextBox.Size = new System.Drawing.Size(210, 26);
            this.CustNpwpNumTextBox.TabIndex = 6;
            this.CustNpwpNumTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.CustNpwpNumTextBox.WaterMarkText = "No. NPWP";
            // 
            // CustLamaKreditLabel
            // 
            this.CustLamaKreditLabel.AutoSize = true;
            this.CustLamaKreditLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustLamaKreditLabel.Location = new System.Drawing.Point(305, 236);
            this.CustLamaKreditLabel.Name = "CustLamaKreditLabel";
            this.CustLamaKreditLabel.Size = new System.Drawing.Size(93, 19);
            this.CustLamaKreditLabel.TabIndex = 0;
            this.CustLamaKreditLabel.Text = "Lama Kredit :";
            // 
            // CustJatuhTempoLabel
            // 
            this.CustJatuhTempoLabel.AutoSize = true;
            this.CustJatuhTempoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustJatuhTempoLabel.Location = new System.Drawing.Point(243, 431);
            this.CustJatuhTempoLabel.Name = "CustJatuhTempoLabel";
            this.CustJatuhTempoLabel.Size = new System.Drawing.Size(93, 19);
            this.CustJatuhTempoLabel.TabIndex = 0;
            this.CustJatuhTempoLabel.Text = "Jatuh Tempo :";
            // 
            // CustNpwpLabel
            // 
            this.CustNpwpLabel.AutoSize = true;
            this.CustNpwpLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNpwpLabel.Location = new System.Drawing.Point(14, 197);
            this.CustNpwpLabel.Name = "CustNpwpLabel";
            this.CustNpwpLabel.Size = new System.Drawing.Size(60, 19);
            this.CustNpwpLabel.TabIndex = 0;
            this.CustNpwpLabel.Text = "NPWP :";
            // 
            // CustSalesCodeLabel
            // 
            this.CustSalesCodeLabel.AutoSize = true;
            this.CustSalesCodeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustSalesCodeLabel.Location = new System.Drawing.Point(248, 509);
            this.CustSalesCodeLabel.Name = "CustSalesCodeLabel";
            this.CustSalesCodeLabel.Size = new System.Drawing.Size(87, 19);
            this.CustSalesCodeLabel.TabIndex = 0;
            this.CustSalesCodeLabel.Text = "Kode Sales :";
            // 
            // TelpCustLabel
            // 
            this.TelpCustLabel.AutoSize = true;
            this.TelpCustLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelpCustLabel.Location = new System.Drawing.Point(14, 80);
            this.TelpCustLabel.Name = "TelpCustLabel";
            this.TelpCustLabel.Size = new System.Drawing.Size(69, 19);
            this.TelpCustLabel.TabIndex = 0;
            this.TelpCustLabel.Text = "Telp/Fax :";
            // 
            // CustAddr2Label
            // 
            this.CustAddr2Label.AutoSize = true;
            this.CustAddr2Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustAddr2Label.Location = new System.Drawing.Point(12, 158);
            this.CustAddr2Label.Name = "CustAddr2Label";
            this.CustAddr2Label.Size = new System.Drawing.Size(67, 19);
            this.CustAddr2Label.TabIndex = 0;
            this.CustAddr2Label.Text = "Alamat2 :";
            // 
            // CustAddr1Label
            // 
            this.CustAddr1Label.AutoSize = true;
            this.CustAddr1Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustAddr1Label.Location = new System.Drawing.Point(14, 119);
            this.CustAddr1Label.Name = "CustAddr1Label";
            this.CustAddr1Label.Size = new System.Drawing.Size(67, 19);
            this.CustAddr1Label.TabIndex = 0;
            this.CustAddr1Label.Text = "Alamat1 :";
            // 
            // CustNotesLabel
            // 
            this.CustNotesLabel.AutoSize = true;
            this.CustNotesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNotesLabel.Location = new System.Drawing.Point(14, 470);
            this.CustNotesLabel.Name = "CustNotesLabel";
            this.CustNotesLabel.Size = new System.Drawing.Size(86, 19);
            this.CustNotesLabel.TabIndex = 0;
            this.CustNotesLabel.Text = "Keterangan :";
            // 
            // CustPiutangLabel
            // 
            this.CustPiutangLabel.AutoSize = true;
            this.CustPiutangLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustPiutangLabel.Location = new System.Drawing.Point(14, 314);
            this.CustPiutangLabel.Name = "CustPiutangLabel";
            this.CustPiutangLabel.Size = new System.Drawing.Size(60, 19);
            this.CustPiutangLabel.TabIndex = 0;
            this.CustPiutangLabel.Text = "Piutang :";
            // 
            // CustCityLabel
            // 
            this.CustCityLabel.AutoSize = true;
            this.CustCityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustCityLabel.Location = new System.Drawing.Point(248, 80);
            this.CustCityLabel.Name = "CustCityLabel";
            this.CustCityLabel.Size = new System.Drawing.Size(47, 19);
            this.CustCityLabel.TabIndex = 3;
            this.CustCityLabel.Text = "Kota :";
            // 
            // CustSalesNameLabel
            // 
            this.CustSalesNameLabel.AutoSize = true;
            this.CustSalesNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustSalesNameLabel.Location = new System.Drawing.Point(14, 509);
            this.CustSalesNameLabel.Name = "CustSalesNameLabel";
            this.CustSalesNameLabel.Size = new System.Drawing.Size(89, 19);
            this.CustSalesNameLabel.TabIndex = 0;
            this.CustSalesNameLabel.Text = "Nama Sales :";
            // 
            // CustCodeLabel
            // 
            this.CustCodeLabel.AutoSize = true;
            this.CustCodeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustCodeLabel.Location = new System.Drawing.Point(246, 41);
            this.CustCodeLabel.Name = "CustCodeLabel";
            this.CustCodeLabel.Size = new System.Drawing.Size(87, 19);
            this.CustCodeLabel.TabIndex = 0;
            this.CustCodeLabel.Text = "Kode Cust : ";
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.AutoSize = true;
            this.CustNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameLabel.Location = new System.Drawing.Point(14, 41);
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Size = new System.Drawing.Size(57, 19);
            this.CustNameLabel.TabIndex = 0;
            this.CustNameLabel.Text = "Nama : ";
            // 
            // customerOLV
            // 
            this.customerOLV.AllColumns.Add(this.olvColumn1);
            this.customerOLV.AllColumns.Add(this.olvColumn2);
            this.customerOLV.AllColumns.Add(this.olvColumn3);
            this.customerOLV.AllColumns.Add(this.olvColumn4);
            this.customerOLV.AllColumns.Add(this.olvColumn5);
            this.customerOLV.AllColumns.Add(this.olvColumn6);
            this.customerOLV.AllowDrop = true;
            this.customerOLV.AlternateRowBackColor = System.Drawing.Color.LemonChiffon;
            this.customerOLV.CellEditUseWholeCell = false;
            this.customerOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this.customerOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerOLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerOLV.FullRowSelect = true;
            this.customerOLV.HeaderFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.customerOLV.HeaderFormatStyle = this.olvHdr;
            this.customerOLV.Location = new System.Drawing.Point(6, 72);
            this.customerOLV.Name = "customerOLV";
            this.customerOLV.ShowGroups = false;
            this.customerOLV.Size = new System.Drawing.Size(846, 554);
            this.customerOLV.TabIndex = 0;
            this.customerOLV.UseAlternatingBackColors = true;
            this.customerOLV.UseCompatibleStateImageBehavior = false;
            this.customerOLV.UseFilterIndicator = true;
            this.customerOLV.UseFiltering = true;
            this.customerOLV.View = System.Windows.Forms.View.Details;
            this.customerOLV.VirtualMode = true;
            this.customerOLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.customerOLV_ItemSelectionChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Nama";
            this.olvColumn1.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn1.Text = "Nama";
            this.olvColumn1.UseInitialLetterForGroup = true;
            this.olvColumn1.Width = 133;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "KodeCustomer";
            this.olvColumn2.AspectToStringFormat = "K{0:0000}";
            this.olvColumn2.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn2.Text = "Kode Cust";
            this.olvColumn2.UseInitialLetterForGroup = true;
            this.olvColumn2.Width = 99;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Kota";
            this.olvColumn3.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn3.Text = "Kota";
            this.olvColumn3.UseInitialLetterForGroup = true;
            this.olvColumn3.Width = 155;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "NamaSales";
            this.olvColumn4.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn4.Text = "Nama Sales";
            this.olvColumn4.UseInitialLetterForGroup = true;
            this.olvColumn4.Width = 106;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "TelpFax";
            this.olvColumn5.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn5.Text = "Telp/Fax";
            this.olvColumn5.UseInitialLetterForGroup = true;
            this.olvColumn5.Width = 126;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Keterangan";
            this.olvColumn6.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn6.Text = "Keterangan";
            this.olvColumn6.UseInitialLetterForGroup = true;
            this.olvColumn6.Width = 205;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ItemBeliOLV);
            this.tabPage2.Controls.Add(this.FakturBeliOLV);
            this.tabPage2.Controls.Add(this.ItemBeliDetailsGroupBox);
            this.tabPage2.Controls.Add(this.FakturBeliDetailsGroupBox);
            this.tabPage2.Controls.Add(this.FakturBeliFilterGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1338, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Faktur Pembelian";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ItemBeliOLV
            // 
            this.ItemBeliOLV.AllColumns.Add(this.olvColumn36);
            this.ItemBeliOLV.AllColumns.Add(this.olvColumn37);
            this.ItemBeliOLV.AllColumns.Add(this.olvColumn38);
            this.ItemBeliOLV.AllowDrop = true;
            this.ItemBeliOLV.AlternateRowBackColor = System.Drawing.Color.LemonChiffon;
            this.ItemBeliOLV.CellEditUseWholeCell = false;
            this.ItemBeliOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn36,
            this.olvColumn37,
            this.olvColumn38});
            this.ItemBeliOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemBeliOLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBeliOLV.FullRowSelect = true;
            this.ItemBeliOLV.HideSelection = false;
            this.ItemBeliOLV.Location = new System.Drawing.Point(446, 75);
            this.ItemBeliOLV.Name = "ItemBeliOLV";
            this.ItemBeliOLV.ShowGroups = false;
            this.ItemBeliOLV.Size = new System.Drawing.Size(271, 551);
            this.ItemBeliOLV.TabIndex = 12;
            this.ItemBeliOLV.UseAlternatingBackColors = true;
            this.ItemBeliOLV.UseCompatibleStateImageBehavior = false;
            this.ItemBeliOLV.View = System.Windows.Forms.View.Details;
            this.ItemBeliOLV.VirtualMode = true;
            this.ItemBeliOLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ItemBeliOLV_ItemSelectionChanged);
            // 
            // olvColumn36
            // 
            this.olvColumn36.AspectName = "NamaStock";
            this.olvColumn36.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn36.Text = "Nama Stok";
            this.olvColumn36.UseInitialLetterForGroup = true;
            this.olvColumn36.Width = 116;
            // 
            // olvColumn37
            // 
            this.olvColumn37.AspectName = "Price";
            this.olvColumn37.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn37.Text = "Harga";
            this.olvColumn37.UseInitialLetterForGroup = true;
            this.olvColumn37.Width = 104;
            // 
            // olvColumn38
            // 
            this.olvColumn38.AspectName = "Quantity";
            this.olvColumn38.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn38.Text = "Qty";
            this.olvColumn38.UseInitialLetterForGroup = true;
            this.olvColumn38.Width = 46;
            // 
            // FakturBeliOLV
            // 
            this.FakturBeliOLV.AllColumns.Add(this.olvColumn32);
            this.FakturBeliOLV.AllColumns.Add(this.olvColumn33);
            this.FakturBeliOLV.AllColumns.Add(this.olvColumn34);
            this.FakturBeliOLV.AllColumns.Add(this.olvColumn35);
            this.FakturBeliOLV.AllowDrop = true;
            this.FakturBeliOLV.AlternateRowBackColor = System.Drawing.Color.LemonChiffon;
            this.FakturBeliOLV.CellEditUseWholeCell = false;
            this.FakturBeliOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn32,
            this.olvColumn33,
            this.olvColumn34,
            this.olvColumn35});
            this.FakturBeliOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.FakturBeliOLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliOLV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FakturBeliOLV.FullRowSelect = true;
            this.FakturBeliOLV.HideSelection = false;
            this.FakturBeliOLV.Location = new System.Drawing.Point(3, 75);
            this.FakturBeliOLV.Name = "FakturBeliOLV";
            this.FakturBeliOLV.ShowGroups = false;
            this.FakturBeliOLV.Size = new System.Drawing.Size(437, 551);
            this.FakturBeliOLV.TabIndex = 11;
            this.FakturBeliOLV.UseAlternatingBackColors = true;
            this.FakturBeliOLV.UseCompatibleStateImageBehavior = false;
            this.FakturBeliOLV.UseFilterIndicator = true;
            this.FakturBeliOLV.UseFiltering = true;
            this.FakturBeliOLV.View = System.Windows.Forms.View.Details;
            this.FakturBeliOLV.VirtualMode = true;
            this.FakturBeliOLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.FakturBeliOLV_ItemSelectionChanged);
            // 
            // olvColumn32
            // 
            this.olvColumn32.AspectName = "Id";
            this.olvColumn32.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn32.Text = "No. Faktur";
            this.olvColumn32.UseInitialLetterForGroup = true;
            this.olvColumn32.Width = 90;
            // 
            // olvColumn33
            // 
            this.olvColumn33.AspectName = "SupplierName";
            this.olvColumn33.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn33.Text = "Nama Supplier.";
            this.olvColumn33.UseInitialLetterForGroup = true;
            this.olvColumn33.Width = 110;
            // 
            // olvColumn34
            // 
            this.olvColumn34.AspectName = "CashCredit";
            this.olvColumn34.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn34.Text = "Jumlah Item";
            this.olvColumn34.UseInitialLetterForGroup = true;
            this.olvColumn34.Width = 80;
            // 
            // olvColumn35
            // 
            this.olvColumn35.AspectName = "Date";
            this.olvColumn35.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn35.Text = "Total";
            this.olvColumn35.UseInitialLetterForGroup = true;
            this.olvColumn35.Width = 136;
            // 
            // ItemBeliDetailsGroupBox
            // 
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliDeleteButton);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliTanggalTextBox);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliTotalLabel);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliTotalTextBox);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliQtyTextBox);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliHargaBeliTextBox);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliStokIDComboBox);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliEditButton);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliCancelButton);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliNewButton);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliPictureBox);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliTanggalLabel);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliQtyLabel);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliHargaBeliLabel);
            this.ItemBeliDetailsGroupBox.Controls.Add(this.ItemBeliStokIDLabel);
            this.ItemBeliDetailsGroupBox.Location = new System.Drawing.Point(723, 332);
            this.ItemBeliDetailsGroupBox.Name = "ItemBeliDetailsGroupBox";
            this.ItemBeliDetailsGroupBox.Size = new System.Drawing.Size(609, 294);
            this.ItemBeliDetailsGroupBox.TabIndex = 10;
            this.ItemBeliDetailsGroupBox.TabStop = false;
            this.ItemBeliDetailsGroupBox.Text = "Detail Item";
            // 
            // ItemBeliDeleteButton
            // 
            this.ItemBeliDeleteButton.Enabled = false;
            this.ItemBeliDeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBeliDeleteButton.Location = new System.Drawing.Point(253, 253);
            this.ItemBeliDeleteButton.Name = "ItemBeliDeleteButton";
            this.ItemBeliDeleteButton.Size = new System.Drawing.Size(75, 35);
            this.ItemBeliDeleteButton.TabIndex = 53;
            this.ItemBeliDeleteButton.Text = "Hapus";
            this.ItemBeliDeleteButton.UseVisualStyleBackColor = true;
            this.ItemBeliDeleteButton.Click += new System.EventHandler(this.ItemBeliDeleteButton_Click);
            // 
            // ItemBeliTanggalTextBox
            // 
            this.ItemBeliTanggalTextBox.Enabled = false;
            this.ItemBeliTanggalTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBeliTanggalTextBox.Location = new System.Drawing.Point(132, 158);
            this.ItemBeliTanggalTextBox.Name = "ItemBeliTanggalTextBox";
            this.ItemBeliTanggalTextBox.ReadOnly = true;
            this.ItemBeliTanggalTextBox.Size = new System.Drawing.Size(136, 26);
            this.ItemBeliTanggalTextBox.TabIndex = 52;
            // 
            // ItemBeliTotalLabel
            // 
            this.ItemBeliTotalLabel.AutoSize = true;
            this.ItemBeliTotalLabel.Location = new System.Drawing.Point(64, 129);
            this.ItemBeliTotalLabel.Name = "ItemBeliTotalLabel";
            this.ItemBeliTotalLabel.Size = new System.Drawing.Size(57, 21);
            this.ItemBeliTotalLabel.TabIndex = 51;
            this.ItemBeliTotalLabel.Text = "Total :";
            // 
            // ItemBeliTotalTextBox
            // 
            this.ItemBeliTotalTextBox.Enabled = false;
            this.ItemBeliTotalTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBeliTotalTextBox.Location = new System.Drawing.Point(132, 127);
            this.ItemBeliTotalTextBox.Name = "ItemBeliTotalTextBox";
            this.ItemBeliTotalTextBox.ReadOnly = true;
            this.ItemBeliTotalTextBox.Size = new System.Drawing.Size(136, 26);
            this.ItemBeliTotalTextBox.TabIndex = 50;
            // 
            // ItemBeliQtyTextBox
            // 
            this.ItemBeliQtyTextBox.Enabled = false;
            this.ItemBeliQtyTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBeliQtyTextBox.Location = new System.Drawing.Point(132, 96);
            this.ItemBeliQtyTextBox.Name = "ItemBeliQtyTextBox";
            this.ItemBeliQtyTextBox.Size = new System.Drawing.Size(136, 26);
            this.ItemBeliQtyTextBox.TabIndex = 48;
            this.ItemBeliQtyTextBox.TextChanged += new System.EventHandler(this.ItemBeliQtyTextBox_TextChanged);
            // 
            // ItemBeliHargaBeliTextBox
            // 
            this.ItemBeliHargaBeliTextBox.Enabled = false;
            this.ItemBeliHargaBeliTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBeliHargaBeliTextBox.Location = new System.Drawing.Point(132, 65);
            this.ItemBeliHargaBeliTextBox.Name = "ItemBeliHargaBeliTextBox";
            this.ItemBeliHargaBeliTextBox.Size = new System.Drawing.Size(136, 26);
            this.ItemBeliHargaBeliTextBox.TabIndex = 47;
            this.ItemBeliHargaBeliTextBox.TextChanged += new System.EventHandler(this.ItemBeliHargaBeliTextBox_TextChanged);
            // 
            // ItemBeliStokIDComboBox
            // 
            this.ItemBeliStokIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemBeliStokIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemBeliStokIDComboBox.Enabled = false;
            this.ItemBeliStokIDComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBeliStokIDComboBox.FormattingEnabled = true;
            this.ItemBeliStokIDComboBox.Location = new System.Drawing.Point(132, 34);
            this.ItemBeliStokIDComboBox.Name = "ItemBeliStokIDComboBox";
            this.ItemBeliStokIDComboBox.Size = new System.Drawing.Size(461, 27);
            this.ItemBeliStokIDComboBox.TabIndex = 46;
            this.ItemBeliStokIDComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemBeliStokIDComboBox_SelectedIndexChanged);
            // 
            // ItemBeliEditButton
            // 
            this.ItemBeliEditButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBeliEditButton.Location = new System.Drawing.Point(172, 253);
            this.ItemBeliEditButton.Name = "ItemBeliEditButton";
            this.ItemBeliEditButton.Size = new System.Drawing.Size(75, 35);
            this.ItemBeliEditButton.TabIndex = 42;
            this.ItemBeliEditButton.Text = "Edit";
            this.ItemBeliEditButton.UseVisualStyleBackColor = true;
            this.ItemBeliEditButton.Click += new System.EventHandler(this.ItemBeliEditButton_Click);
            // 
            // ItemBeliCancelButton
            // 
            this.ItemBeliCancelButton.Enabled = false;
            this.ItemBeliCancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBeliCancelButton.Location = new System.Drawing.Point(91, 253);
            this.ItemBeliCancelButton.Name = "ItemBeliCancelButton";
            this.ItemBeliCancelButton.Size = new System.Drawing.Size(75, 35);
            this.ItemBeliCancelButton.TabIndex = 41;
            this.ItemBeliCancelButton.Text = "Cancel";
            this.ItemBeliCancelButton.UseVisualStyleBackColor = true;
            this.ItemBeliCancelButton.Click += new System.EventHandler(this.ItemBeliCancelButton_Click);
            // 
            // ItemBeliNewButton
            // 
            this.ItemBeliNewButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBeliNewButton.Location = new System.Drawing.Point(10, 253);
            this.ItemBeliNewButton.Name = "ItemBeliNewButton";
            this.ItemBeliNewButton.Size = new System.Drawing.Size(75, 35);
            this.ItemBeliNewButton.TabIndex = 39;
            this.ItemBeliNewButton.Text = "Baru";
            this.ItemBeliNewButton.UseVisualStyleBackColor = true;
            this.ItemBeliNewButton.Click += new System.EventHandler(this.ItemBeliNewButton_Click);
            // 
            // ItemBeliPictureBox
            // 
            this.ItemBeliPictureBox.Location = new System.Drawing.Point(331, 96);
            this.ItemBeliPictureBox.Name = "ItemBeliPictureBox";
            this.ItemBeliPictureBox.Size = new System.Drawing.Size(262, 184);
            this.ItemBeliPictureBox.TabIndex = 18;
            this.ItemBeliPictureBox.TabStop = false;
            // 
            // ItemBeliTanggalLabel
            // 
            this.ItemBeliTanggalLabel.AutoSize = true;
            this.ItemBeliTanggalLabel.Location = new System.Drawing.Point(43, 160);
            this.ItemBeliTanggalLabel.Name = "ItemBeliTanggalLabel";
            this.ItemBeliTanggalLabel.Size = new System.Drawing.Size(77, 21);
            this.ItemBeliTanggalLabel.TabIndex = 17;
            this.ItemBeliTanggalLabel.Text = "Tanggal :";
            // 
            // ItemBeliQtyLabel
            // 
            this.ItemBeliQtyLabel.AutoSize = true;
            this.ItemBeliQtyLabel.Location = new System.Drawing.Point(74, 98);
            this.ItemBeliQtyLabel.Name = "ItemBeliQtyLabel";
            this.ItemBeliQtyLabel.Size = new System.Drawing.Size(47, 21);
            this.ItemBeliQtyLabel.TabIndex = 16;
            this.ItemBeliQtyLabel.Text = "Qty :";
            // 
            // ItemBeliHargaBeliLabel
            // 
            this.ItemBeliHargaBeliLabel.AutoSize = true;
            this.ItemBeliHargaBeliLabel.Location = new System.Drawing.Point(26, 67);
            this.ItemBeliHargaBeliLabel.Name = "ItemBeliHargaBeliLabel";
            this.ItemBeliHargaBeliLabel.Size = new System.Drawing.Size(96, 21);
            this.ItemBeliHargaBeliLabel.TabIndex = 13;
            this.ItemBeliHargaBeliLabel.Text = "Harga Beli :";
            // 
            // ItemBeliStokIDLabel
            // 
            this.ItemBeliStokIDLabel.AutoSize = true;
            this.ItemBeliStokIDLabel.Location = new System.Drawing.Point(23, 36);
            this.ItemBeliStokIDLabel.Name = "ItemBeliStokIDLabel";
            this.ItemBeliStokIDLabel.Size = new System.Drawing.Size(100, 21);
            this.ItemBeliStokIDLabel.TabIndex = 12;
            this.ItemBeliStokIDLabel.Text = "Kode Stok :";
            // 
            // FakturBeliDetailsGroupBox
            // 
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliPrintButton);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliTanggalTextBox);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliTanggalPajakDatePicker);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliJlhItemTextBox);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliTanggalPajakLabel);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliNoPajakTextBox);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliNoPajakLabel);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliNoFakturTextBox);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliKodeSuppTextBox);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliJatuhTempoTextBox);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliTotalBeliTextBox);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliTotalPPNTextBox);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliTotalAkhirTextBox);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliCashKreditComboBox);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliNamaSuppComboBox);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliBeliReturnComboBox);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliCancelButton);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliEditButton);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliNewButton);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliTotalPPNLabel);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliPPNCheckBox);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliTotalBeliLabel);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliTanggalLabel);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliTotalAkhirLabel);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliCashKreditLabel);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliJatuhTempoLabel);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliNamaSuppLabel);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliKodeSuppLabel);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliBeliReturnLabel);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliJlhItemLabel);
            this.FakturBeliDetailsGroupBox.Controls.Add(this.FakturBeliNoFakturLabel);
            this.FakturBeliDetailsGroupBox.Location = new System.Drawing.Point(723, 10);
            this.FakturBeliDetailsGroupBox.Name = "FakturBeliDetailsGroupBox";
            this.FakturBeliDetailsGroupBox.Size = new System.Drawing.Size(609, 316);
            this.FakturBeliDetailsGroupBox.TabIndex = 9;
            this.FakturBeliDetailsGroupBox.TabStop = false;
            this.FakturBeliDetailsGroupBox.Text = "Detail Faktur";
            // 
            // FakturBeliTanggalTextBox
            // 
            this.FakturBeliTanggalTextBox.Enabled = false;
            this.FakturBeliTanggalTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliTanggalTextBox.Location = new System.Drawing.Point(467, 27);
            this.FakturBeliTanggalTextBox.Name = "FakturBeliTanggalTextBox";
            this.FakturBeliTanggalTextBox.ReadOnly = true;
            this.FakturBeliTanggalTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturBeliTanggalTextBox.TabIndex = 63;
            this.FakturBeliTanggalTextBox.TabStop = false;
            // 
            // FakturBeliTanggalPajakDatePicker
            // 
            this.FakturBeliTanggalPajakDatePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliTanggalPajakDatePicker.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliTanggalPajakDatePicker.Location = new System.Drawing.Point(347, 182);
            this.FakturBeliTanggalPajakDatePicker.Name = "FakturBeliTanggalPajakDatePicker";
            this.FakturBeliTanggalPajakDatePicker.Size = new System.Drawing.Size(246, 25);
            this.FakturBeliTanggalPajakDatePicker.TabIndex = 13;
            // 
            // FakturBeliJlhItemTextBox
            // 
            this.FakturBeliJlhItemTextBox.Enabled = false;
            this.FakturBeliJlhItemTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliJlhItemTextBox.Location = new System.Drawing.Point(132, 58);
            this.FakturBeliJlhItemTextBox.Name = "FakturBeliJlhItemTextBox";
            this.FakturBeliJlhItemTextBox.ReadOnly = true;
            this.FakturBeliJlhItemTextBox.Size = new System.Drawing.Size(48, 26);
            this.FakturBeliJlhItemTextBox.TabIndex = 62;
            // 
            // FakturBeliTanggalPajakLabel
            // 
            this.FakturBeliTanggalPajakLabel.AutoSize = true;
            this.FakturBeliTanggalPajakLabel.Location = new System.Drawing.Point(343, 153);
            this.FakturBeliTanggalPajakLabel.Name = "FakturBeliTanggalPajakLabel";
            this.FakturBeliTanggalPajakLabel.Size = new System.Drawing.Size(127, 21);
            this.FakturBeliTanggalPajakLabel.TabIndex = 61;
            this.FakturBeliTanggalPajakLabel.Text = "Tanggal Pajak : ";
            // 
            // FakturBeliNoPajakTextBox
            // 
            this.FakturBeliNoPajakTextBox.Enabled = false;
            this.FakturBeliNoPajakTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliNoPajakTextBox.Location = new System.Drawing.Point(467, 120);
            this.FakturBeliNoPajakTextBox.Name = "FakturBeliNoPajakTextBox";
            this.FakturBeliNoPajakTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturBeliNoPajakTextBox.TabIndex = 60;
            // 
            // FakturBeliNoPajakLabel
            // 
            this.FakturBeliNoPajakLabel.AutoSize = true;
            this.FakturBeliNoPajakLabel.Location = new System.Drawing.Point(373, 122);
            this.FakturBeliNoPajakLabel.Name = "FakturBeliNoPajakLabel";
            this.FakturBeliNoPajakLabel.Size = new System.Drawing.Size(92, 21);
            this.FakturBeliNoPajakLabel.TabIndex = 59;
            this.FakturBeliNoPajakLabel.Text = "No. Pajak :";
            // 
            // FakturBeliNoFakturTextBox
            // 
            this.FakturBeliNoFakturTextBox.Enabled = false;
            this.FakturBeliNoFakturTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliNoFakturTextBox.Location = new System.Drawing.Point(132, 25);
            this.FakturBeliNoFakturTextBox.Name = "FakturBeliNoFakturTextBox";
            this.FakturBeliNoFakturTextBox.ReadOnly = true;
            this.FakturBeliNoFakturTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturBeliNoFakturTextBox.TabIndex = 58;
            // 
            // FakturBeliKodeSuppTextBox
            // 
            this.FakturBeliKodeSuppTextBox.Enabled = false;
            this.FakturBeliKodeSuppTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliKodeSuppTextBox.Location = new System.Drawing.Point(132, 151);
            this.FakturBeliKodeSuppTextBox.Name = "FakturBeliKodeSuppTextBox";
            this.FakturBeliKodeSuppTextBox.ReadOnly = true;
            this.FakturBeliKodeSuppTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturBeliKodeSuppTextBox.TabIndex = 56;
            // 
            // FakturBeliJatuhTempoTextBox
            // 
            this.FakturBeliJatuhTempoTextBox.Enabled = false;
            this.FakturBeliJatuhTempoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliJatuhTempoTextBox.Location = new System.Drawing.Point(132, 182);
            this.FakturBeliJatuhTempoTextBox.Name = "FakturBeliJatuhTempoTextBox";
            this.FakturBeliJatuhTempoTextBox.ReadOnly = true;
            this.FakturBeliJatuhTempoTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturBeliJatuhTempoTextBox.TabIndex = 53;
            // 
            // FakturBeliTotalBeliTextBox
            // 
            this.FakturBeliTotalBeliTextBox.Enabled = false;
            this.FakturBeliTotalBeliTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliTotalBeliTextBox.Location = new System.Drawing.Point(132, 213);
            this.FakturBeliTotalBeliTextBox.Name = "FakturBeliTotalBeliTextBox";
            this.FakturBeliTotalBeliTextBox.ReadOnly = true;
            this.FakturBeliTotalBeliTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturBeliTotalBeliTextBox.TabIndex = 52;
            // 
            // FakturBeliTotalPPNTextBox
            // 
            this.FakturBeliTotalPPNTextBox.Enabled = false;
            this.FakturBeliTotalPPNTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliTotalPPNTextBox.Location = new System.Drawing.Point(132, 244);
            this.FakturBeliTotalPPNTextBox.Name = "FakturBeliTotalPPNTextBox";
            this.FakturBeliTotalPPNTextBox.ReadOnly = true;
            this.FakturBeliTotalPPNTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturBeliTotalPPNTextBox.TabIndex = 51;
            // 
            // FakturBeliTotalAkhirTextBox
            // 
            this.FakturBeliTotalAkhirTextBox.Enabled = false;
            this.FakturBeliTotalAkhirTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliTotalAkhirTextBox.Location = new System.Drawing.Point(132, 275);
            this.FakturBeliTotalAkhirTextBox.Name = "FakturBeliTotalAkhirTextBox";
            this.FakturBeliTotalAkhirTextBox.ReadOnly = true;
            this.FakturBeliTotalAkhirTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturBeliTotalAkhirTextBox.TabIndex = 50;
            // 
            // FakturBeliCashKreditComboBox
            // 
            this.FakturBeliCashKreditComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FakturBeliCashKreditComboBox.Enabled = false;
            this.FakturBeliCashKreditComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FakturBeliCashKreditComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliCashKreditComboBox.FormattingEnabled = true;
            this.FakturBeliCashKreditComboBox.Location = new System.Drawing.Point(467, 89);
            this.FakturBeliCashKreditComboBox.Name = "FakturBeliCashKreditComboBox";
            this.FakturBeliCashKreditComboBox.Size = new System.Drawing.Size(47, 27);
            this.FakturBeliCashKreditComboBox.TabIndex = 45;
            // 
            // FakturBeliNamaSuppComboBox
            // 
            this.FakturBeliNamaSuppComboBox.Enabled = false;
            this.FakturBeliNamaSuppComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliNamaSuppComboBox.FormattingEnabled = true;
            this.FakturBeliNamaSuppComboBox.Location = new System.Drawing.Point(132, 120);
            this.FakturBeliNamaSuppComboBox.Name = "FakturBeliNamaSuppComboBox";
            this.FakturBeliNamaSuppComboBox.Size = new System.Drawing.Size(136, 27);
            this.FakturBeliNamaSuppComboBox.TabIndex = 44;
            this.FakturBeliNamaSuppComboBox.SelectedIndexChanged += new System.EventHandler(this.FakturBeliNamaSuppComboBox_SelectedIndexChanged);
            // 
            // FakturBeliBeliReturnComboBox
            // 
            this.FakturBeliBeliReturnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FakturBeliBeliReturnComboBox.Enabled = false;
            this.FakturBeliBeliReturnComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FakturBeliBeliReturnComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliBeliReturnComboBox.FormattingEnabled = true;
            this.FakturBeliBeliReturnComboBox.Location = new System.Drawing.Point(133, 89);
            this.FakturBeliBeliReturnComboBox.Name = "FakturBeliBeliReturnComboBox";
            this.FakturBeliBeliReturnComboBox.Size = new System.Drawing.Size(47, 27);
            this.FakturBeliBeliReturnComboBox.TabIndex = 43;
            this.FakturBeliBeliReturnComboBox.SelectedIndexChanged += new System.EventHandler(this.FakturBeliBeliReturnComboBox_SelectedIndexChanged);
            // 
            // FakturBeliCancelButton
            // 
            this.FakturBeliCancelButton.Enabled = false;
            this.FakturBeliCancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliCancelButton.Location = new System.Drawing.Point(437, 263);
            this.FakturBeliCancelButton.Name = "FakturBeliCancelButton";
            this.FakturBeliCancelButton.Size = new System.Drawing.Size(75, 35);
            this.FakturBeliCancelButton.TabIndex = 41;
            this.FakturBeliCancelButton.Text = "Cancel";
            this.FakturBeliCancelButton.UseVisualStyleBackColor = true;
            this.FakturBeliCancelButton.Click += new System.EventHandler(this.FakturBeliCancelButton_Click);
            // 
            // FakturBeliEditButton
            // 
            this.FakturBeliEditButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliEditButton.Location = new System.Drawing.Point(518, 263);
            this.FakturBeliEditButton.Name = "FakturBeliEditButton";
            this.FakturBeliEditButton.Size = new System.Drawing.Size(75, 35);
            this.FakturBeliEditButton.TabIndex = 40;
            this.FakturBeliEditButton.Text = "Edit";
            this.FakturBeliEditButton.UseVisualStyleBackColor = true;
            this.FakturBeliEditButton.Click += new System.EventHandler(this.FakturBeliEditButton_Click);
            // 
            // FakturBeliNewButton
            // 
            this.FakturBeliNewButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliNewButton.Location = new System.Drawing.Point(356, 263);
            this.FakturBeliNewButton.Name = "FakturBeliNewButton";
            this.FakturBeliNewButton.Size = new System.Drawing.Size(75, 35);
            this.FakturBeliNewButton.TabIndex = 39;
            this.FakturBeliNewButton.Text = "Baru";
            this.FakturBeliNewButton.UseVisualStyleBackColor = true;
            this.FakturBeliNewButton.Click += new System.EventHandler(this.FakturBeliNewButton_Click);
            // 
            // FakturBeliTotalPPNLabel
            // 
            this.FakturBeliTotalPPNLabel.AutoSize = true;
            this.FakturBeliTotalPPNLabel.Location = new System.Drawing.Point(32, 246);
            this.FakturBeliTotalPPNLabel.Name = "FakturBeliTotalPPNLabel";
            this.FakturBeliTotalPPNLabel.Size = new System.Drawing.Size(97, 21);
            this.FakturBeliTotalPPNLabel.TabIndex = 18;
            this.FakturBeliTotalPPNLabel.Text = "Total PPN :";
            // 
            // FakturBeliPPNCheckBox
            // 
            this.FakturBeliPPNCheckBox.AutoSize = true;
            this.FakturBeliPPNCheckBox.Location = new System.Drawing.Point(395, 60);
            this.FakturBeliPPNCheckBox.Name = "FakturBeliPPNCheckBox";
            this.FakturBeliPPNCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FakturBeliPPNCheckBox.Size = new System.Drawing.Size(64, 25);
            this.FakturBeliPPNCheckBox.TabIndex = 17;
            this.FakturBeliPPNCheckBox.Text = "PPN";
            this.FakturBeliPPNCheckBox.UseVisualStyleBackColor = true;
            this.FakturBeliPPNCheckBox.CheckedChanged += new System.EventHandler(this.FakturBeliPPNCheckBox_CheckedChanged);
            // 
            // FakturBeliTotalBeliLabel
            // 
            this.FakturBeliTotalBeliLabel.AutoSize = true;
            this.FakturBeliTotalBeliLabel.Location = new System.Drawing.Point(40, 215);
            this.FakturBeliTotalBeliLabel.Name = "FakturBeliTotalBeliLabel";
            this.FakturBeliTotalBeliLabel.Size = new System.Drawing.Size(90, 21);
            this.FakturBeliTotalBeliLabel.TabIndex = 16;
            this.FakturBeliTotalBeliLabel.Text = "Total Beli :";
            // 
            // FakturBeliTanggalLabel
            // 
            this.FakturBeliTanggalLabel.AutoSize = true;
            this.FakturBeliTanggalLabel.Location = new System.Drawing.Point(386, 29);
            this.FakturBeliTanggalLabel.Name = "FakturBeliTanggalLabel";
            this.FakturBeliTanggalLabel.Size = new System.Drawing.Size(77, 21);
            this.FakturBeliTanggalLabel.TabIndex = 15;
            this.FakturBeliTanggalLabel.Text = "Tanggal :";
            // 
            // FakturBeliTotalAkhirLabel
            // 
            this.FakturBeliTotalAkhirLabel.AutoSize = true;
            this.FakturBeliTotalAkhirLabel.Location = new System.Drawing.Point(26, 277);
            this.FakturBeliTotalAkhirLabel.Name = "FakturBeliTotalAkhirLabel";
            this.FakturBeliTotalAkhirLabel.Size = new System.Drawing.Size(102, 21);
            this.FakturBeliTotalAkhirLabel.TabIndex = 14;
            this.FakturBeliTotalAkhirLabel.Text = "Total Akhir :";
            // 
            // FakturBeliCashKreditLabel
            // 
            this.FakturBeliCashKreditLabel.AutoSize = true;
            this.FakturBeliCashKreditLabel.Location = new System.Drawing.Point(357, 91);
            this.FakturBeliCashKreditLabel.Name = "FakturBeliCashKreditLabel";
            this.FakturBeliCashKreditLabel.Size = new System.Drawing.Size(108, 21);
            this.FakturBeliCashKreditLabel.TabIndex = 12;
            this.FakturBeliCashKreditLabel.Text = "Cash/Kredit :";
            // 
            // FakturBeliJatuhTempoLabel
            // 
            this.FakturBeliJatuhTempoLabel.AutoSize = true;
            this.FakturBeliJatuhTempoLabel.Location = new System.Drawing.Point(16, 184);
            this.FakturBeliJatuhTempoLabel.Name = "FakturBeliJatuhTempoLabel";
            this.FakturBeliJatuhTempoLabel.Size = new System.Drawing.Size(115, 21);
            this.FakturBeliJatuhTempoLabel.TabIndex = 10;
            this.FakturBeliJatuhTempoLabel.Text = "Jatuh Tempo :";
            // 
            // FakturBeliNamaSuppLabel
            // 
            this.FakturBeliNamaSuppLabel.AutoSize = true;
            this.FakturBeliNamaSuppLabel.Location = new System.Drawing.Point(24, 122);
            this.FakturBeliNamaSuppLabel.Name = "FakturBeliNamaSuppLabel";
            this.FakturBeliNamaSuppLabel.Size = new System.Drawing.Size(107, 21);
            this.FakturBeliNamaSuppLabel.TabIndex = 9;
            this.FakturBeliNamaSuppLabel.Text = "Nama Supp :";
            // 
            // FakturBeliKodeSuppLabel
            // 
            this.FakturBeliKodeSuppLabel.AutoSize = true;
            this.FakturBeliKodeSuppLabel.Location = new System.Drawing.Point(4, 153);
            this.FakturBeliKodeSuppLabel.Name = "FakturBeliKodeSuppLabel";
            this.FakturBeliKodeSuppLabel.Size = new System.Drawing.Size(127, 21);
            this.FakturBeliKodeSuppLabel.TabIndex = 8;
            this.FakturBeliKodeSuppLabel.Text = "Kode Supplier :";
            // 
            // FakturBeliBeliReturnLabel
            // 
            this.FakturBeliBeliReturnLabel.AutoSize = true;
            this.FakturBeliBeliReturnLabel.Location = new System.Drawing.Point(39, 91);
            this.FakturBeliBeliReturnLabel.Name = "FakturBeliBeliReturnLabel";
            this.FakturBeliBeliReturnLabel.Size = new System.Drawing.Size(93, 21);
            this.FakturBeliBeliReturnLabel.TabIndex = 7;
            this.FakturBeliBeliReturnLabel.Text = "Beli/Retur :";
            // 
            // FakturBeliJlhItemLabel
            // 
            this.FakturBeliJlhItemLabel.AutoSize = true;
            this.FakturBeliJlhItemLabel.Location = new System.Drawing.Point(24, 60);
            this.FakturBeliJlhItemLabel.Name = "FakturBeliJlhItemLabel";
            this.FakturBeliJlhItemLabel.Size = new System.Drawing.Size(108, 21);
            this.FakturBeliJlhItemLabel.TabIndex = 6;
            this.FakturBeliJlhItemLabel.Text = "Jumlah Item :";
            // 
            // FakturBeliNoFakturLabel
            // 
            this.FakturBeliNoFakturLabel.AutoSize = true;
            this.FakturBeliNoFakturLabel.Location = new System.Drawing.Point(32, 29);
            this.FakturBeliNoFakturLabel.Name = "FakturBeliNoFakturLabel";
            this.FakturBeliNoFakturLabel.Size = new System.Drawing.Size(100, 21);
            this.FakturBeliNoFakturLabel.TabIndex = 5;
            this.FakturBeliNoFakturLabel.Text = "No. Faktur :";
            // 
            // FakturBeliFilterGroupBox
            // 
            this.FakturBeliFilterGroupBox.Controls.Add(this.FakturBeliFilterTextBox);
            this.FakturBeliFilterGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliFilterGroupBox.Location = new System.Drawing.Point(604, 10);
            this.FakturBeliFilterGroupBox.Name = "FakturBeliFilterGroupBox";
            this.FakturBeliFilterGroupBox.Size = new System.Drawing.Size(113, 59);
            this.FakturBeliFilterGroupBox.TabIndex = 8;
            this.FakturBeliFilterGroupBox.TabStop = false;
            this.FakturBeliFilterGroupBox.Text = "Filter";
            // 
            // FakturBeliFilterTextBox
            // 
            this.FakturBeliFilterTextBox.Location = new System.Drawing.Point(6, 25);
            this.FakturBeliFilterTextBox.Name = "FakturBeliFilterTextBox";
            this.FakturBeliFilterTextBox.Size = new System.Drawing.Size(100, 26);
            this.FakturBeliFilterTextBox.TabIndex = 0;
            this.FakturBeliFilterTextBox.TextChanged += new System.EventHandler(this.FakturBeliFilterTextBox_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FakturJualFilterGroupBox);
            this.tabPage1.Controls.Add(this.ItemJualDetailsGroupBox);
            this.tabPage1.Controls.Add(this.FakturJualDetailsGroupBox);
            this.tabPage1.Controls.Add(this.ItemJualOLV);
            this.tabPage1.Controls.Add(this.FakturJualOLV);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1338, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Faktur Penjualan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FakturJualFilterGroupBox
            // 
            this.FakturJualFilterGroupBox.Controls.Add(this.FakturJualFilterTextBox);
            this.FakturJualFilterGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualFilterGroupBox.Location = new System.Drawing.Point(604, 10);
            this.FakturJualFilterGroupBox.Name = "FakturJualFilterGroupBox";
            this.FakturJualFilterGroupBox.Size = new System.Drawing.Size(113, 59);
            this.FakturJualFilterGroupBox.TabIndex = 7;
            this.FakturJualFilterGroupBox.TabStop = false;
            this.FakturJualFilterGroupBox.Text = "Filter";
            // 
            // FakturJualFilterTextBox
            // 
            this.FakturJualFilterTextBox.Location = new System.Drawing.Point(6, 25);
            this.FakturJualFilterTextBox.Name = "FakturJualFilterTextBox";
            this.FakturJualFilterTextBox.Size = new System.Drawing.Size(100, 26);
            this.FakturJualFilterTextBox.TabIndex = 0;
            this.FakturJualFilterTextBox.TextChanged += new System.EventHandler(this.FakturJualFilterTextBox_TextChanged);
            // 
            // ItemJualDetailsGroupBox
            // 
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualDiscountTextBox);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualDiscountLabel);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualDeleteButton);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualHargaPokokTextBox);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualTanggalTextBox);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualProfitTextBox);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualQtyTextBox);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualHargaJualTextBox);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualStokIDComboBox);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualEditButton);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualCancelButton);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualNewButton);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualPictureBox);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualTanggalLabel);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualQtyLabel);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualHargaPokokLabel);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualProfitLabel);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualHargaJualLabel);
            this.ItemJualDetailsGroupBox.Controls.Add(this.ItemJualStokIDLabel);
            this.ItemJualDetailsGroupBox.Location = new System.Drawing.Point(723, 332);
            this.ItemJualDetailsGroupBox.Name = "ItemJualDetailsGroupBox";
            this.ItemJualDetailsGroupBox.Size = new System.Drawing.Size(609, 294);
            this.ItemJualDetailsGroupBox.TabIndex = 4;
            this.ItemJualDetailsGroupBox.TabStop = false;
            this.ItemJualDetailsGroupBox.Text = "Detail Item";
            // 
            // ItemJualDiscountTextBox
            // 
            this.ItemJualDiscountTextBox.Enabled = false;
            this.ItemJualDiscountTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemJualDiscountTextBox.Location = new System.Drawing.Point(132, 126);
            this.ItemJualDiscountTextBox.Name = "ItemJualDiscountTextBox";
            this.ItemJualDiscountTextBox.Size = new System.Drawing.Size(136, 26);
            this.ItemJualDiscountTextBox.TabIndex = 55;
            this.ItemJualDiscountTextBox.TextChanged += new System.EventHandler(this.ItemJualDiscountTextBox_TextChanged);
            // 
            // ItemJualDiscountLabel
            // 
            this.ItemJualDiscountLabel.AutoSize = true;
            this.ItemJualDiscountLabel.Location = new System.Drawing.Point(32, 128);
            this.ItemJualDiscountLabel.Name = "ItemJualDiscountLabel";
            this.ItemJualDiscountLabel.Size = new System.Drawing.Size(91, 21);
            this.ItemJualDiscountLabel.TabIndex = 54;
            this.ItemJualDiscountLabel.Text = "Discount : ";
            // 
            // ItemJualDeleteButton
            // 
            this.ItemJualDeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemJualDeleteButton.Location = new System.Drawing.Point(253, 253);
            this.ItemJualDeleteButton.Name = "ItemJualDeleteButton";
            this.ItemJualDeleteButton.Size = new System.Drawing.Size(75, 35);
            this.ItemJualDeleteButton.TabIndex = 52;
            this.ItemJualDeleteButton.TabStop = false;
            this.ItemJualDeleteButton.Text = "Hapus";
            this.ItemJualDeleteButton.UseVisualStyleBackColor = true;
            this.ItemJualDeleteButton.Click += new System.EventHandler(this.ItemJualDeleteButton_Click);
            // 
            // ItemJualHargaPokokTextBox
            // 
            this.ItemJualHargaPokokTextBox.Enabled = false;
            this.ItemJualHargaPokokTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemJualHargaPokokTextBox.Location = new System.Drawing.Point(132, 65);
            this.ItemJualHargaPokokTextBox.Name = "ItemJualHargaPokokTextBox";
            this.ItemJualHargaPokokTextBox.ReadOnly = true;
            this.ItemJualHargaPokokTextBox.Size = new System.Drawing.Size(136, 26);
            this.ItemJualHargaPokokTextBox.TabIndex = 51;
            this.ItemJualHargaPokokTextBox.TabStop = false;
            // 
            // ItemJualTanggalTextBox
            // 
            this.ItemJualTanggalTextBox.Enabled = false;
            this.ItemJualTanggalTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemJualTanggalTextBox.Location = new System.Drawing.Point(132, 216);
            this.ItemJualTanggalTextBox.Name = "ItemJualTanggalTextBox";
            this.ItemJualTanggalTextBox.ReadOnly = true;
            this.ItemJualTanggalTextBox.Size = new System.Drawing.Size(136, 26);
            this.ItemJualTanggalTextBox.TabIndex = 50;
            this.ItemJualTanggalTextBox.TabStop = false;
            // 
            // ItemJualProfitTextBox
            // 
            this.ItemJualProfitTextBox.Enabled = false;
            this.ItemJualProfitTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemJualProfitTextBox.Location = new System.Drawing.Point(132, 186);
            this.ItemJualProfitTextBox.Name = "ItemJualProfitTextBox";
            this.ItemJualProfitTextBox.ReadOnly = true;
            this.ItemJualProfitTextBox.Size = new System.Drawing.Size(136, 26);
            this.ItemJualProfitTextBox.TabIndex = 49;
            this.ItemJualProfitTextBox.TabStop = false;
            // 
            // ItemJualQtyTextBox
            // 
            this.ItemJualQtyTextBox.Enabled = false;
            this.ItemJualQtyTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemJualQtyTextBox.Location = new System.Drawing.Point(132, 156);
            this.ItemJualQtyTextBox.Name = "ItemJualQtyTextBox";
            this.ItemJualQtyTextBox.Size = new System.Drawing.Size(136, 26);
            this.ItemJualQtyTextBox.TabIndex = 3;
            this.ItemJualQtyTextBox.TextChanged += new System.EventHandler(this.ItemJualQtyTextBox_TextChanged);
            // 
            // ItemJualHargaJualTextBox
            // 
            this.ItemJualHargaJualTextBox.Enabled = false;
            this.ItemJualHargaJualTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemJualHargaJualTextBox.Location = new System.Drawing.Point(132, 96);
            this.ItemJualHargaJualTextBox.Name = "ItemJualHargaJualTextBox";
            this.ItemJualHargaJualTextBox.Size = new System.Drawing.Size(136, 26);
            this.ItemJualHargaJualTextBox.TabIndex = 2;
            this.ItemJualHargaJualTextBox.TextChanged += new System.EventHandler(this.ItemJualHargaJualTextBox_TextChanged);
            // 
            // ItemJualStokIDComboBox
            // 
            this.ItemJualStokIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemJualStokIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemJualStokIDComboBox.Enabled = false;
            this.ItemJualStokIDComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemJualStokIDComboBox.FormattingEnabled = true;
            this.ItemJualStokIDComboBox.Location = new System.Drawing.Point(132, 34);
            this.ItemJualStokIDComboBox.Name = "ItemJualStokIDComboBox";
            this.ItemJualStokIDComboBox.Size = new System.Drawing.Size(461, 27);
            this.ItemJualStokIDComboBox.TabIndex = 1;
            this.ItemJualStokIDComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemJualStokIDComboBox_SelectedIndexChanged);
            // 
            // ItemJualEditButton
            // 
            this.ItemJualEditButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemJualEditButton.Location = new System.Drawing.Point(172, 253);
            this.ItemJualEditButton.Name = "ItemJualEditButton";
            this.ItemJualEditButton.Size = new System.Drawing.Size(75, 35);
            this.ItemJualEditButton.TabIndex = 42;
            this.ItemJualEditButton.TabStop = false;
            this.ItemJualEditButton.Text = "Edit";
            this.ItemJualEditButton.UseVisualStyleBackColor = true;
            this.ItemJualEditButton.Click += new System.EventHandler(this.ItemJualEditButton_Click);
            // 
            // ItemJualCancelButton
            // 
            this.ItemJualCancelButton.Enabled = false;
            this.ItemJualCancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemJualCancelButton.Location = new System.Drawing.Point(91, 253);
            this.ItemJualCancelButton.Name = "ItemJualCancelButton";
            this.ItemJualCancelButton.Size = new System.Drawing.Size(75, 35);
            this.ItemJualCancelButton.TabIndex = 41;
            this.ItemJualCancelButton.Text = "Cancel";
            this.ItemJualCancelButton.UseVisualStyleBackColor = true;
            this.ItemJualCancelButton.Click += new System.EventHandler(this.ItemJualCancelButton_Click);
            // 
            // ItemJualNewButton
            // 
            this.ItemJualNewButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemJualNewButton.Location = new System.Drawing.Point(10, 253);
            this.ItemJualNewButton.Name = "ItemJualNewButton";
            this.ItemJualNewButton.Size = new System.Drawing.Size(75, 35);
            this.ItemJualNewButton.TabIndex = 4;
            this.ItemJualNewButton.Text = "Baru";
            this.ItemJualNewButton.UseVisualStyleBackColor = true;
            this.ItemJualNewButton.Click += new System.EventHandler(this.ItemJualNewButton_Click);
            // 
            // ItemJualPictureBox
            // 
            this.ItemJualPictureBox.Location = new System.Drawing.Point(331, 96);
            this.ItemJualPictureBox.Name = "ItemJualPictureBox";
            this.ItemJualPictureBox.Size = new System.Drawing.Size(262, 184);
            this.ItemJualPictureBox.TabIndex = 18;
            this.ItemJualPictureBox.TabStop = false;
            // 
            // ItemJualTanggalLabel
            // 
            this.ItemJualTanggalLabel.AutoSize = true;
            this.ItemJualTanggalLabel.Location = new System.Drawing.Point(41, 218);
            this.ItemJualTanggalLabel.Name = "ItemJualTanggalLabel";
            this.ItemJualTanggalLabel.Size = new System.Drawing.Size(77, 21);
            this.ItemJualTanggalLabel.TabIndex = 17;
            this.ItemJualTanggalLabel.Text = "Tanggal :";
            // 
            // ItemJualQtyLabel
            // 
            this.ItemJualQtyLabel.AutoSize = true;
            this.ItemJualQtyLabel.Location = new System.Drawing.Point(71, 158);
            this.ItemJualQtyLabel.Name = "ItemJualQtyLabel";
            this.ItemJualQtyLabel.Size = new System.Drawing.Size(47, 21);
            this.ItemJualQtyLabel.TabIndex = 16;
            this.ItemJualQtyLabel.Text = "Qty :";
            // 
            // ItemJualHargaPokokLabel
            // 
            this.ItemJualHargaPokokLabel.AutoSize = true;
            this.ItemJualHargaPokokLabel.Location = new System.Drawing.Point(6, 67);
            this.ItemJualHargaPokokLabel.Name = "ItemJualHargaPokokLabel";
            this.ItemJualHargaPokokLabel.Size = new System.Drawing.Size(117, 21);
            this.ItemJualHargaPokokLabel.TabIndex = 15;
            this.ItemJualHargaPokokLabel.Text = "Harga Pokok :";
            // 
            // ItemJualProfitLabel
            // 
            this.ItemJualProfitLabel.AutoSize = true;
            this.ItemJualProfitLabel.Location = new System.Drawing.Point(58, 188);
            this.ItemJualProfitLabel.Name = "ItemJualProfitLabel";
            this.ItemJualProfitLabel.Size = new System.Drawing.Size(61, 21);
            this.ItemJualProfitLabel.TabIndex = 14;
            this.ItemJualProfitLabel.Text = "Profit :";
            // 
            // ItemJualHargaJualLabel
            // 
            this.ItemJualHargaJualLabel.AutoSize = true;
            this.ItemJualHargaJualLabel.Location = new System.Drawing.Point(26, 98);
            this.ItemJualHargaJualLabel.Name = "ItemJualHargaJualLabel";
            this.ItemJualHargaJualLabel.Size = new System.Drawing.Size(96, 21);
            this.ItemJualHargaJualLabel.TabIndex = 13;
            this.ItemJualHargaJualLabel.Text = "Harga Jual :";
            // 
            // ItemJualStokIDLabel
            // 
            this.ItemJualStokIDLabel.AutoSize = true;
            this.ItemJualStokIDLabel.Location = new System.Drawing.Point(23, 36);
            this.ItemJualStokIDLabel.Name = "ItemJualStokIDLabel";
            this.ItemJualStokIDLabel.Size = new System.Drawing.Size(100, 21);
            this.ItemJualStokIDLabel.TabIndex = 12;
            this.ItemJualStokIDLabel.Text = "Kode Stok :";
            // 
            // FakturJualDetailsGroupBox
            // 
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualPrintButton);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualTanggalTextBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualJlhItemTextBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualTanggalLunasTextBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualTanggalLunasLabel);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualNoFakturTextBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualKodeCustomerTextBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualKodeSalesTextBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualNamaSalesTextBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualJthTempoTextBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualTotalJualTextBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualTotalPPNTextBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualTotalAkhirTextBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualCashKreditComboBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualNamaCustComboBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualJualReturnComboBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualCancelButton);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualEditButton);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualNewButton);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualTotalPPNLabel);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualPPNCheckBox);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualTotalJualLabel);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualTanggalabel);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualTotalAkhirLabel);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualNamaSalesLabel);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualCashKreditLabel);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualKodeSalesLabel);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualJthTempoLabel);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualNamaCustLabel);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualKodeCustomerLabel);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualJualReturnLabel);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualJlhItemLabel);
            this.FakturJualDetailsGroupBox.Controls.Add(this.FakturJualNoFakturLabel);
            this.FakturJualDetailsGroupBox.Location = new System.Drawing.Point(723, 10);
            this.FakturJualDetailsGroupBox.Name = "FakturJualDetailsGroupBox";
            this.FakturJualDetailsGroupBox.Size = new System.Drawing.Size(609, 316);
            this.FakturJualDetailsGroupBox.TabIndex = 3;
            this.FakturJualDetailsGroupBox.TabStop = false;
            this.FakturJualDetailsGroupBox.Text = "Detail Faktur";
            // 
            // FakturJualTanggalTextBox
            // 
            this.FakturJualTanggalTextBox.Enabled = false;
            this.FakturJualTanggalTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualTanggalTextBox.Location = new System.Drawing.Point(467, 25);
            this.FakturJualTanggalTextBox.Name = "FakturJualTanggalTextBox";
            this.FakturJualTanggalTextBox.ReadOnly = true;
            this.FakturJualTanggalTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturJualTanggalTextBox.TabIndex = 62;
            this.FakturJualTanggalTextBox.TabStop = false;
            // 
            // FakturJualJlhItemTextBox
            // 
            this.FakturJualJlhItemTextBox.Enabled = false;
            this.FakturJualJlhItemTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualJlhItemTextBox.Location = new System.Drawing.Point(132, 58);
            this.FakturJualJlhItemTextBox.Name = "FakturJualJlhItemTextBox";
            this.FakturJualJlhItemTextBox.ReadOnly = true;
            this.FakturJualJlhItemTextBox.Size = new System.Drawing.Size(48, 26);
            this.FakturJualJlhItemTextBox.TabIndex = 61;
            this.FakturJualJlhItemTextBox.TabStop = false;
            // 
            // FakturJualTanggalLunasTextBox
            // 
            this.FakturJualTanggalLunasTextBox.Enabled = false;
            this.FakturJualTanggalLunasTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualTanggalLunasTextBox.Location = new System.Drawing.Point(467, 213);
            this.FakturJualTanggalLunasTextBox.Name = "FakturJualTanggalLunasTextBox";
            this.FakturJualTanggalLunasTextBox.ReadOnly = true;
            this.FakturJualTanggalLunasTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturJualTanggalLunasTextBox.TabIndex = 60;
            this.FakturJualTanggalLunasTextBox.TabStop = false;
            // 
            // FakturJualTanggalLunasLabel
            // 
            this.FakturJualTanggalLunasLabel.AutoSize = true;
            this.FakturJualTanggalLunasLabel.Location = new System.Drawing.Point(332, 215);
            this.FakturJualTanggalLunasLabel.Name = "FakturJualTanggalLunasLabel";
            this.FakturJualTanggalLunasLabel.Size = new System.Drawing.Size(127, 21);
            this.FakturJualTanggalLunasLabel.TabIndex = 59;
            this.FakturJualTanggalLunasLabel.Text = "Tanggal Lunas :";
            // 
            // FakturJualNoFakturTextBox
            // 
            this.FakturJualNoFakturTextBox.Enabled = false;
            this.FakturJualNoFakturTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualNoFakturTextBox.Location = new System.Drawing.Point(132, 27);
            this.FakturJualNoFakturTextBox.Name = "FakturJualNoFakturTextBox";
            this.FakturJualNoFakturTextBox.ReadOnly = true;
            this.FakturJualNoFakturTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturJualNoFakturTextBox.TabIndex = 58;
            this.FakturJualNoFakturTextBox.TabStop = false;
            // 
            // FakturJualKodeCustomerTextBox
            // 
            this.FakturJualKodeCustomerTextBox.Enabled = false;
            this.FakturJualKodeCustomerTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualKodeCustomerTextBox.Location = new System.Drawing.Point(467, 120);
            this.FakturJualKodeCustomerTextBox.Name = "FakturJualKodeCustomerTextBox";
            this.FakturJualKodeCustomerTextBox.ReadOnly = true;
            this.FakturJualKodeCustomerTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturJualKodeCustomerTextBox.TabIndex = 56;
            this.FakturJualKodeCustomerTextBox.TabStop = false;
            // 
            // FakturJualKodeSalesTextBox
            // 
            this.FakturJualKodeSalesTextBox.Enabled = false;
            this.FakturJualKodeSalesTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualKodeSalesTextBox.Location = new System.Drawing.Point(467, 151);
            this.FakturJualKodeSalesTextBox.Name = "FakturJualKodeSalesTextBox";
            this.FakturJualKodeSalesTextBox.ReadOnly = true;
            this.FakturJualKodeSalesTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturJualKodeSalesTextBox.TabIndex = 55;
            this.FakturJualKodeSalesTextBox.TabStop = false;
            // 
            // FakturJualNamaSalesTextBox
            // 
            this.FakturJualNamaSalesTextBox.Enabled = false;
            this.FakturJualNamaSalesTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualNamaSalesTextBox.Location = new System.Drawing.Point(132, 152);
            this.FakturJualNamaSalesTextBox.Name = "FakturJualNamaSalesTextBox";
            this.FakturJualNamaSalesTextBox.ReadOnly = true;
            this.FakturJualNamaSalesTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturJualNamaSalesTextBox.TabIndex = 54;
            this.FakturJualNamaSalesTextBox.TabStop = false;
            // 
            // FakturJualJthTempoTextBox
            // 
            this.FakturJualJthTempoTextBox.Enabled = false;
            this.FakturJualJthTempoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualJthTempoTextBox.Location = new System.Drawing.Point(467, 182);
            this.FakturJualJthTempoTextBox.Name = "FakturJualJthTempoTextBox";
            this.FakturJualJthTempoTextBox.ReadOnly = true;
            this.FakturJualJthTempoTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturJualJthTempoTextBox.TabIndex = 53;
            this.FakturJualJthTempoTextBox.TabStop = false;
            // 
            // FakturJualTotalJualTextBox
            // 
            this.FakturJualTotalJualTextBox.Enabled = false;
            this.FakturJualTotalJualTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualTotalJualTextBox.Location = new System.Drawing.Point(132, 182);
            this.FakturJualTotalJualTextBox.Name = "FakturJualTotalJualTextBox";
            this.FakturJualTotalJualTextBox.ReadOnly = true;
            this.FakturJualTotalJualTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturJualTotalJualTextBox.TabIndex = 52;
            this.FakturJualTotalJualTextBox.TabStop = false;
            // 
            // FakturJualTotalPPNTextBox
            // 
            this.FakturJualTotalPPNTextBox.Enabled = false;
            this.FakturJualTotalPPNTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualTotalPPNTextBox.Location = new System.Drawing.Point(132, 213);
            this.FakturJualTotalPPNTextBox.Name = "FakturJualTotalPPNTextBox";
            this.FakturJualTotalPPNTextBox.ReadOnly = true;
            this.FakturJualTotalPPNTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturJualTotalPPNTextBox.TabIndex = 51;
            this.FakturJualTotalPPNTextBox.TabStop = false;
            // 
            // FakturJualTotalAkhirTextBox
            // 
            this.FakturJualTotalAkhirTextBox.Enabled = false;
            this.FakturJualTotalAkhirTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualTotalAkhirTextBox.Location = new System.Drawing.Point(132, 244);
            this.FakturJualTotalAkhirTextBox.Name = "FakturJualTotalAkhirTextBox";
            this.FakturJualTotalAkhirTextBox.ReadOnly = true;
            this.FakturJualTotalAkhirTextBox.Size = new System.Drawing.Size(136, 26);
            this.FakturJualTotalAkhirTextBox.TabIndex = 50;
            this.FakturJualTotalAkhirTextBox.TabStop = false;
            // 
            // FakturJualCashKreditComboBox
            // 
            this.FakturJualCashKreditComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FakturJualCashKreditComboBox.Enabled = false;
            this.FakturJualCashKreditComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FakturJualCashKreditComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualCashKreditComboBox.FormattingEnabled = true;
            this.FakturJualCashKreditComboBox.Location = new System.Drawing.Point(467, 89);
            this.FakturJualCashKreditComboBox.Name = "FakturJualCashKreditComboBox";
            this.FakturJualCashKreditComboBox.Size = new System.Drawing.Size(47, 27);
            this.FakturJualCashKreditComboBox.TabIndex = 3;
            this.FakturJualCashKreditComboBox.SelectedIndexChanged += new System.EventHandler(this.FakturJualCashKreditComboBox_SelectedIndexChanged);
            // 
            // FakturJualNamaCustComboBox
            // 
            this.FakturJualNamaCustComboBox.Enabled = false;
            this.FakturJualNamaCustComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualNamaCustComboBox.FormattingEnabled = true;
            this.FakturJualNamaCustComboBox.Location = new System.Drawing.Point(132, 120);
            this.FakturJualNamaCustComboBox.Name = "FakturJualNamaCustComboBox";
            this.FakturJualNamaCustComboBox.Size = new System.Drawing.Size(136, 27);
            this.FakturJualNamaCustComboBox.TabIndex = 4;
            this.FakturJualNamaCustComboBox.SelectedValueChanged += new System.EventHandler(this.FakturJualNamaCustComboBox_SelectedValueChanged);
            // 
            // FakturJualJualReturnComboBox
            // 
            this.FakturJualJualReturnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FakturJualJualReturnComboBox.Enabled = false;
            this.FakturJualJualReturnComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FakturJualJualReturnComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualJualReturnComboBox.FormattingEnabled = true;
            this.FakturJualJualReturnComboBox.Location = new System.Drawing.Point(133, 89);
            this.FakturJualJualReturnComboBox.Name = "FakturJualJualReturnComboBox";
            this.FakturJualJualReturnComboBox.Size = new System.Drawing.Size(47, 27);
            this.FakturJualJualReturnComboBox.TabIndex = 2;
            this.FakturJualJualReturnComboBox.SelectedIndexChanged += new System.EventHandler(this.FakturJualJualReturnComboBox_SelectedIndexChanged);
            // 
            // FakturJualCancelButton
            // 
            this.FakturJualCancelButton.Enabled = false;
            this.FakturJualCancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualCancelButton.Location = new System.Drawing.Point(437, 263);
            this.FakturJualCancelButton.Name = "FakturJualCancelButton";
            this.FakturJualCancelButton.Size = new System.Drawing.Size(75, 35);
            this.FakturJualCancelButton.TabIndex = 41;
            this.FakturJualCancelButton.TabStop = false;
            this.FakturJualCancelButton.Text = "Cancel";
            this.FakturJualCancelButton.UseVisualStyleBackColor = true;
            this.FakturJualCancelButton.Click += new System.EventHandler(this.FakturJualCancelButton_Click);
            // 
            // FakturJualEditButton
            // 
            this.FakturJualEditButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualEditButton.Location = new System.Drawing.Point(518, 263);
            this.FakturJualEditButton.Name = "FakturJualEditButton";
            this.FakturJualEditButton.Size = new System.Drawing.Size(75, 35);
            this.FakturJualEditButton.TabIndex = 40;
            this.FakturJualEditButton.TabStop = false;
            this.FakturJualEditButton.Text = "Edit";
            this.FakturJualEditButton.UseVisualStyleBackColor = true;
            this.FakturJualEditButton.Click += new System.EventHandler(this.FakturJualEditButton_Click);
            // 
            // FakturJualNewButton
            // 
            this.FakturJualNewButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualNewButton.Location = new System.Drawing.Point(355, 263);
            this.FakturJualNewButton.Name = "FakturJualNewButton";
            this.FakturJualNewButton.Size = new System.Drawing.Size(75, 35);
            this.FakturJualNewButton.TabIndex = 7;
            this.FakturJualNewButton.Text = "Baru";
            this.FakturJualNewButton.UseVisualStyleBackColor = true;
            this.FakturJualNewButton.Click += new System.EventHandler(this.FakturJualNewButton_Click);
            // 
            // FakturJualTotalPPNLabel
            // 
            this.FakturJualTotalPPNLabel.AutoSize = true;
            this.FakturJualTotalPPNLabel.Location = new System.Drawing.Point(32, 215);
            this.FakturJualTotalPPNLabel.Name = "FakturJualTotalPPNLabel";
            this.FakturJualTotalPPNLabel.Size = new System.Drawing.Size(97, 21);
            this.FakturJualTotalPPNLabel.TabIndex = 18;
            this.FakturJualTotalPPNLabel.Text = "Total PPN :";
            // 
            // FakturJualPPNCheckBox
            // 
            this.FakturJualPPNCheckBox.AutoSize = true;
            this.FakturJualPPNCheckBox.Location = new System.Drawing.Point(395, 60);
            this.FakturJualPPNCheckBox.Name = "FakturJualPPNCheckBox";
            this.FakturJualPPNCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FakturJualPPNCheckBox.Size = new System.Drawing.Size(64, 25);
            this.FakturJualPPNCheckBox.TabIndex = 1;
            this.FakturJualPPNCheckBox.Text = "PPN";
            this.FakturJualPPNCheckBox.UseVisualStyleBackColor = true;
            this.FakturJualPPNCheckBox.CheckedChanged += new System.EventHandler(this.FakturJualPPNCheckBox_CheckedChanged);
            // 
            // FakturJualTotalJualLabel
            // 
            this.FakturJualTotalJualLabel.AutoSize = true;
            this.FakturJualTotalJualLabel.Location = new System.Drawing.Point(40, 184);
            this.FakturJualTotalJualLabel.Name = "FakturJualTotalJualLabel";
            this.FakturJualTotalJualLabel.Size = new System.Drawing.Size(90, 21);
            this.FakturJualTotalJualLabel.TabIndex = 16;
            this.FakturJualTotalJualLabel.Text = "Total Jual :";
            // 
            // FakturJualTanggalabel
            // 
            this.FakturJualTanggalabel.AutoSize = true;
            this.FakturJualTanggalabel.Location = new System.Drawing.Point(386, 29);
            this.FakturJualTanggalabel.Name = "FakturJualTanggalabel";
            this.FakturJualTanggalabel.Size = new System.Drawing.Size(77, 21);
            this.FakturJualTanggalabel.TabIndex = 15;
            this.FakturJualTanggalabel.Text = "Tanggal :";
            // 
            // FakturJualTotalAkhirLabel
            // 
            this.FakturJualTotalAkhirLabel.AutoSize = true;
            this.FakturJualTotalAkhirLabel.Location = new System.Drawing.Point(26, 246);
            this.FakturJualTotalAkhirLabel.Name = "FakturJualTotalAkhirLabel";
            this.FakturJualTotalAkhirLabel.Size = new System.Drawing.Size(102, 21);
            this.FakturJualTotalAkhirLabel.TabIndex = 14;
            this.FakturJualTotalAkhirLabel.Text = "Total Akhir :";
            // 
            // FakturJualNamaSalesLabel
            // 
            this.FakturJualNamaSalesLabel.AutoSize = true;
            this.FakturJualNamaSalesLabel.Location = new System.Drawing.Point(25, 153);
            this.FakturJualNamaSalesLabel.Name = "FakturJualNamaSalesLabel";
            this.FakturJualNamaSalesLabel.Size = new System.Drawing.Size(106, 21);
            this.FakturJualNamaSalesLabel.TabIndex = 13;
            this.FakturJualNamaSalesLabel.Text = "Nama Sales :";
            // 
            // FakturJualCashKreditLabel
            // 
            this.FakturJualCashKreditLabel.AutoSize = true;
            this.FakturJualCashKreditLabel.Location = new System.Drawing.Point(351, 95);
            this.FakturJualCashKreditLabel.Name = "FakturJualCashKreditLabel";
            this.FakturJualCashKreditLabel.Size = new System.Drawing.Size(108, 21);
            this.FakturJualCashKreditLabel.TabIndex = 12;
            this.FakturJualCashKreditLabel.Text = "Cash/Kredit :";
            // 
            // FakturJualKodeSalesLabel
            // 
            this.FakturJualKodeSalesLabel.AutoSize = true;
            this.FakturJualKodeSalesLabel.Location = new System.Drawing.Point(355, 154);
            this.FakturJualKodeSalesLabel.Name = "FakturJualKodeSalesLabel";
            this.FakturJualKodeSalesLabel.Size = new System.Drawing.Size(104, 21);
            this.FakturJualKodeSalesLabel.TabIndex = 11;
            this.FakturJualKodeSalesLabel.Text = "Kode Sales :";
            // 
            // FakturJualJthTempoLabel
            // 
            this.FakturJualJthTempoLabel.AutoSize = true;
            this.FakturJualJthTempoLabel.Location = new System.Drawing.Point(344, 184);
            this.FakturJualJthTempoLabel.Name = "FakturJualJthTempoLabel";
            this.FakturJualJthTempoLabel.Size = new System.Drawing.Size(115, 21);
            this.FakturJualJthTempoLabel.TabIndex = 10;
            this.FakturJualJthTempoLabel.Text = "Jatuh Tempo :";
            // 
            // FakturJualNamaCustLabel
            // 
            this.FakturJualNamaCustLabel.AutoSize = true;
            this.FakturJualNamaCustLabel.Location = new System.Drawing.Point(25, 122);
            this.FakturJualNamaCustLabel.Name = "FakturJualNamaCustLabel";
            this.FakturJualNamaCustLabel.Size = new System.Drawing.Size(107, 21);
            this.FakturJualNamaCustLabel.TabIndex = 9;
            this.FakturJualNamaCustLabel.Text = "Nama Cust. :";
            // 
            // FakturJualKodeCustomerLabel
            // 
            this.FakturJualKodeCustomerLabel.AutoSize = true;
            this.FakturJualKodeCustomerLabel.Location = new System.Drawing.Point(321, 122);
            this.FakturJualKodeCustomerLabel.Name = "FakturJualKodeCustomerLabel";
            this.FakturJualKodeCustomerLabel.Size = new System.Drawing.Size(138, 21);
            this.FakturJualKodeCustomerLabel.TabIndex = 8;
            this.FakturJualKodeCustomerLabel.Text = "Kode Customer :";
            // 
            // FakturJualJualReturnLabel
            // 
            this.FakturJualJualReturnLabel.AutoSize = true;
            this.FakturJualJualReturnLabel.Location = new System.Drawing.Point(39, 91);
            this.FakturJualJualReturnLabel.Name = "FakturJualJualReturnLabel";
            this.FakturJualJualReturnLabel.Size = new System.Drawing.Size(93, 21);
            this.FakturJualJualReturnLabel.TabIndex = 7;
            this.FakturJualJualReturnLabel.Text = "Jual/Retur :";
            // 
            // FakturJualJlhItemLabel
            // 
            this.FakturJualJlhItemLabel.AutoSize = true;
            this.FakturJualJlhItemLabel.Location = new System.Drawing.Point(24, 60);
            this.FakturJualJlhItemLabel.Name = "FakturJualJlhItemLabel";
            this.FakturJualJlhItemLabel.Size = new System.Drawing.Size(108, 21);
            this.FakturJualJlhItemLabel.TabIndex = 6;
            this.FakturJualJlhItemLabel.Text = "Jumlah Item :";
            // 
            // FakturJualNoFakturLabel
            // 
            this.FakturJualNoFakturLabel.AutoSize = true;
            this.FakturJualNoFakturLabel.Location = new System.Drawing.Point(32, 29);
            this.FakturJualNoFakturLabel.Name = "FakturJualNoFakturLabel";
            this.FakturJualNoFakturLabel.Size = new System.Drawing.Size(100, 21);
            this.FakturJualNoFakturLabel.TabIndex = 5;
            this.FakturJualNoFakturLabel.Text = "No. Faktur :";
            // 
            // ItemJualOLV
            // 
            this.ItemJualOLV.AllColumns.Add(this.olvColumn29);
            this.ItemJualOLV.AllColumns.Add(this.olvColumn30);
            this.ItemJualOLV.AllColumns.Add(this.olvColumn31);
            this.ItemJualOLV.AllowDrop = true;
            this.ItemJualOLV.AlternateRowBackColor = System.Drawing.Color.LemonChiffon;
            this.ItemJualOLV.CellEditUseWholeCell = false;
            this.ItemJualOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn29,
            this.olvColumn30,
            this.olvColumn31});
            this.ItemJualOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemJualOLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemJualOLV.FullRowSelect = true;
            this.ItemJualOLV.HideSelection = false;
            this.ItemJualOLV.Location = new System.Drawing.Point(446, 75);
            this.ItemJualOLV.Name = "ItemJualOLV";
            this.ItemJualOLV.ShowGroups = false;
            this.ItemJualOLV.Size = new System.Drawing.Size(271, 551);
            this.ItemJualOLV.TabIndex = 2;
            this.ItemJualOLV.UseAlternatingBackColors = true;
            this.ItemJualOLV.UseCompatibleStateImageBehavior = false;
            this.ItemJualOLV.View = System.Windows.Forms.View.Details;
            this.ItemJualOLV.VirtualMode = true;
            this.ItemJualOLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ItemJualOLV_ItemSelectionChanged);
            // 
            // olvColumn29
            // 
            this.olvColumn29.AspectName = "NamaStock";
            this.olvColumn29.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn29.Text = "Nama Stok";
            this.olvColumn29.UseInitialLetterForGroup = true;
            this.olvColumn29.Width = 116;
            // 
            // olvColumn30
            // 
            this.olvColumn30.AspectName = "SellingPrice";
            this.olvColumn30.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn30.Text = "Harga";
            this.olvColumn30.UseInitialLetterForGroup = true;
            this.olvColumn30.Width = 104;
            // 
            // olvColumn31
            // 
            this.olvColumn31.AspectName = "Quantity";
            this.olvColumn31.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn31.Text = "Qty";
            this.olvColumn31.UseInitialLetterForGroup = true;
            this.olvColumn31.Width = 46;
            // 
            // FakturJualOLV
            // 
            this.FakturJualOLV.AllColumns.Add(this.olvColumn25);
            this.FakturJualOLV.AllColumns.Add(this.olvColumn26);
            this.FakturJualOLV.AllColumns.Add(this.olvColumn27);
            this.FakturJualOLV.AllColumns.Add(this.olvColumn28);
            this.FakturJualOLV.AllowDrop = true;
            this.FakturJualOLV.AlternateRowBackColor = System.Drawing.Color.LemonChiffon;
            this.FakturJualOLV.CellEditUseWholeCell = false;
            this.FakturJualOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn25,
            this.olvColumn26,
            this.olvColumn27,
            this.olvColumn28});
            this.FakturJualOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.FakturJualOLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualOLV.FullRowSelect = true;
            this.FakturJualOLV.HideSelection = false;
            this.FakturJualOLV.Location = new System.Drawing.Point(3, 75);
            this.FakturJualOLV.Name = "FakturJualOLV";
            this.FakturJualOLV.ShowGroups = false;
            this.FakturJualOLV.Size = new System.Drawing.Size(437, 551);
            this.FakturJualOLV.TabIndex = 1;
            this.FakturJualOLV.UseAlternatingBackColors = true;
            this.FakturJualOLV.UseCompatibleStateImageBehavior = false;
            this.FakturJualOLV.UseFilterIndicator = true;
            this.FakturJualOLV.UseFiltering = true;
            this.FakturJualOLV.View = System.Windows.Forms.View.Details;
            this.FakturJualOLV.VirtualMode = true;
            this.FakturJualOLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.FakturJualOLV_ItemSelectionChanged);
            // 
            // olvColumn25
            // 
            this.olvColumn25.AspectName = "Id";
            this.olvColumn25.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn25.Text = "No. Faktur";
            this.olvColumn25.UseInitialLetterForGroup = true;
            this.olvColumn25.Width = 90;
            // 
            // olvColumn26
            // 
            this.olvColumn26.AspectName = "CustomerName";
            this.olvColumn26.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn26.Text = "Nama Cust.";
            this.olvColumn26.UseInitialLetterForGroup = true;
            this.olvColumn26.Width = 110;
            // 
            // olvColumn27
            // 
            this.olvColumn27.AspectName = "KodeSales";
            this.olvColumn27.AspectToStringFormat = "SL{0:000}";
            this.olvColumn27.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn27.Text = "Kode Sales";
            this.olvColumn27.UseInitialLetterForGroup = true;
            this.olvColumn27.Width = 80;
            // 
            // olvColumn28
            // 
            this.olvColumn28.AspectName = "JatuhTempo";
            this.olvColumn28.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn28.Text = "Jatuh Tempo";
            this.olvColumn28.UseInitialLetterForGroup = true;
            this.olvColumn28.Width = 136;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(40, 22);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 1);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1346, 659);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox4);
            this.tabPage8.Controls.Add(this.PiutangOLV);
            this.tabPage8.Location = new System.Drawing.Point(4, 26);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1338, 629);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Piutang";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1222, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 59);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 25);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 26);
            this.textBox7.TabIndex = 0;
            // 
            // PiutangOLV
            // 
            this.PiutangOLV.AllColumns.Add(this.olvColumn39);
            this.PiutangOLV.AllColumns.Add(this.olvColumn40);
            this.PiutangOLV.AllColumns.Add(this.olvColumn41);
            this.PiutangOLV.AllColumns.Add(this.olvColumn42);
            this.PiutangOLV.AllColumns.Add(this.olvColumn43);
            this.PiutangOLV.AllColumns.Add(this.olvColumn44);
            this.PiutangOLV.AllColumns.Add(this.olvColumn49);
            this.PiutangOLV.AllowDrop = true;
            this.PiutangOLV.AlternateRowBackColor = System.Drawing.Color.LemonChiffon;
            this.PiutangOLV.CellEditUseWholeCell = false;
            this.PiutangOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn39,
            this.olvColumn40,
            this.olvColumn41,
            this.olvColumn42,
            this.olvColumn43,
            this.olvColumn44,
            this.olvColumn49});
            this.PiutangOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.PiutangOLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiutangOLV.FullRowSelect = true;
            this.PiutangOLV.HeaderFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.PiutangOLV.HeaderFormatStyle = this.olvHdr;
            this.PiutangOLV.Location = new System.Drawing.Point(6, 72);
            this.PiutangOLV.Name = "PiutangOLV";
            this.PiutangOLV.ShowGroups = false;
            this.PiutangOLV.Size = new System.Drawing.Size(1329, 554);
            this.PiutangOLV.TabIndex = 1;
            this.PiutangOLV.UseAlternatingBackColors = true;
            this.PiutangOLV.UseCompatibleStateImageBehavior = false;
            this.PiutangOLV.UseFilterIndicator = true;
            this.PiutangOLV.UseFiltering = true;
            this.PiutangOLV.View = System.Windows.Forms.View.Details;
            this.PiutangOLV.VirtualMode = true;
            // 
            // olvColumn39
            // 
            this.olvColumn39.AspectName = "Nama";
            this.olvColumn39.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn39.Text = "Nama";
            this.olvColumn39.UseInitialLetterForGroup = true;
            this.olvColumn39.Width = 157;
            // 
            // olvColumn40
            // 
            this.olvColumn40.AspectName = "NoFaktur";
            this.olvColumn40.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn40.Text = "No Faktur";
            this.olvColumn40.UseInitialLetterForGroup = true;
            this.olvColumn40.Width = 99;
            // 
            // olvColumn41
            // 
            this.olvColumn41.AspectName = "Date";
            this.olvColumn41.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn41.Text = "Tanggal Bon";
            this.olvColumn41.UseInitialLetterForGroup = true;
            this.olvColumn41.Width = 118;
            // 
            // olvColumn42
            // 
            this.olvColumn42.AspectName = "JatuhTempo";
            this.olvColumn42.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn42.Text = "Jatuh Tempo";
            this.olvColumn42.UseInitialLetterForGroup = true;
            this.olvColumn42.Width = 161;
            // 
            // olvColumn43
            // 
            this.olvColumn43.AspectName = "KodeSales";
            this.olvColumn43.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn43.Text = "Kode Sales";
            this.olvColumn43.UseInitialLetterForGroup = true;
            this.olvColumn43.Width = 140;
            // 
            // olvColumn44
            // 
            this.olvColumn44.AspectName = "Kota";
            this.olvColumn44.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn44.Text = "Kota";
            this.olvColumn44.UseInitialLetterForGroup = true;
            this.olvColumn44.Width = 165;
            // 
            // olvColumn49
            // 
            this.olvColumn49.AspectName = "TotalPiutang";
            this.olvColumn49.AspectToStringFormat = "Rp. {0:N}";
            this.olvColumn49.ButtonPadding = new System.Drawing.Size(10, 10);
            this.olvColumn49.Text = "Piutang";
            this.olvColumn49.UseInitialLetterForGroup = true;
            this.olvColumn49.Width = 165;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.White;
            this.tabPage9.Controls.Add(this.groupBox1);
            this.tabPage9.Controls.Add(this.groupBox3);
            this.tabPage9.Location = new System.Drawing.Point(4, 26);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1338, 629);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Laporan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GrafikComboBox);
            this.groupBox1.Controls.Add(this.LaporanChart);
            this.groupBox1.Location = new System.Drawing.Point(593, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 337);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafik";
            // 
            // GrafikComboBox
            // 
            this.GrafikComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GrafikComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GrafikComboBox.FormattingEnabled = true;
            this.GrafikComboBox.Location = new System.Drawing.Point(6, 21);
            this.GrafikComboBox.Name = "GrafikComboBox";
            this.GrafikComboBox.Size = new System.Drawing.Size(121, 29);
            this.GrafikComboBox.TabIndex = 29;
            this.GrafikComboBox.SelectedIndexChanged += new System.EventHandler(this.GrafikComboBox_SelectedIndexChanged);
            // 
            // LaporanChart
            // 
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 12;
            chartArea1.AxisX.Title = "Bulan";
            chartArea1.AxisY.Title = "Rupiah";
            chartArea1.Name = "ChartArea1";
            this.LaporanChart.ChartAreas.Add(chartArea1);
            this.LaporanChart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Name = "Legend1";
            this.LaporanChart.Legends.Add(legend1);
            this.LaporanChart.Location = new System.Drawing.Point(14, 58);
            this.LaporanChart.Name = "LaporanChart";
            this.LaporanChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Omset";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "HPP";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Laba/Rugi";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Piutang";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Ekuilitas";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Kas";
            this.LaporanChart.Series.Add(series1);
            this.LaporanChart.Series.Add(series2);
            this.LaporanChart.Series.Add(series3);
            this.LaporanChart.Series.Add(series4);
            this.LaporanChart.Series.Add(series5);
            this.LaporanChart.Series.Add(series6);
            this.LaporanChart.Size = new System.Drawing.Size(719, 260);
            this.LaporanChart.TabIndex = 28;
            this.LaporanChart.Text = "test";
            title1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Laporan Tahunan";
            this.LaporanChart.Titles.Add(title1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label58);
            this.groupBox3.Controls.Add(this.label57);
            this.groupBox3.Controls.Add(this.label56);
            this.groupBox3.Controls.Add(this.label55);
            this.groupBox3.Controls.Add(this.label54);
            this.groupBox3.Controls.Add(this.label53);
            this.groupBox3.Controls.Add(this.label52);
            this.groupBox3.Controls.Add(this.label51);
            this.groupBox3.Controls.Add(this.label50);
            this.groupBox3.Controls.Add(this.label49);
            this.groupBox3.Controls.Add(this.label48);
            this.groupBox3.Controls.Add(this.label47);
            this.groupBox3.Controls.Add(this.label46);
            this.groupBox3.Controls.Add(this.label45);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.label44);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label43);
            this.groupBox3.Controls.Add(this.label41);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 617);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pembukuan";
            // 
            // label58
            // 
            this.label58.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label58.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(186, 576);
            this.label58.Name = "label58";
            this.label58.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label58.Size = new System.Drawing.Size(152, 20);
            this.label58.TabIndex = 65;
            this.label58.Text = "Rp. 3.500.000.000,00";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label57
            // 
            this.label57.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label57.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(187, 557);
            this.label57.Name = "label57";
            this.label57.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label57.Size = new System.Drawing.Size(152, 20);
            this.label57.TabIndex = 64;
            this.label57.Text = "Rp. 3.500.000.000,00";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label56.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(187, 538);
            this.label56.Name = "label56";
            this.label56.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label56.Size = new System.Drawing.Size(152, 20);
            this.label56.TabIndex = 63;
            this.label56.Text = "Rp. 3.500.000.000,00";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label55
            // 
            this.label55.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label55.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(187, 519);
            this.label55.Name = "label55";
            this.label55.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label55.Size = new System.Drawing.Size(152, 20);
            this.label55.TabIndex = 62;
            this.label55.Text = "Rp. 3.500.000.000,00";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label54
            // 
            this.label54.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label54.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(186, 427);
            this.label54.Name = "label54";
            this.label54.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label54.Size = new System.Drawing.Size(152, 20);
            this.label54.TabIndex = 61;
            this.label54.Text = "Rp. 3.500.000.000,00";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label53
            // 
            this.label53.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label53.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(187, 408);
            this.label53.Name = "label53";
            this.label53.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label53.Size = new System.Drawing.Size(152, 20);
            this.label53.TabIndex = 60;
            this.label53.Text = "Rp. 3.500.000.000,00";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label52.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(186, 39);
            this.label52.Name = "label52";
            this.label52.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label52.Size = new System.Drawing.Size(152, 20);
            this.label52.TabIndex = 59;
            this.label52.Text = "Rp. 3.500.000.000,00";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label51
            // 
            this.label51.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label51.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(187, 58);
            this.label51.Name = "label51";
            this.label51.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label51.Size = new System.Drawing.Size(152, 20);
            this.label51.TabIndex = 58;
            this.label51.Text = "Rp. 3.500.000.000,00";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label50.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(187, 96);
            this.label50.Name = "label50";
            this.label50.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label50.Size = new System.Drawing.Size(152, 20);
            this.label50.TabIndex = 57;
            this.label50.Text = "Rp. 3.500.000.000,00";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label49
            // 
            this.label49.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label49.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(187, 77);
            this.label49.Name = "label49";
            this.label49.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label49.Size = new System.Drawing.Size(152, 20);
            this.label49.TabIndex = 56;
            this.label49.Text = "Rp. 3.500.000.000,00";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label48.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(345, 115);
            this.label48.Name = "label48";
            this.label48.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label48.Size = new System.Drawing.Size(152, 20);
            this.label48.TabIndex = 55;
            this.label48.Text = "Rp. 3.500.000.000,00";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label47.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(187, 191);
            this.label47.Name = "label47";
            this.label47.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label47.Size = new System.Drawing.Size(152, 20);
            this.label47.TabIndex = 54;
            this.label47.Text = "Rp. 3.500.000,00";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label46
            // 
            this.label46.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label46.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(187, 172);
            this.label46.Name = "label46";
            this.label46.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label46.Size = new System.Drawing.Size(152, 20);
            this.label46.TabIndex = 53;
            this.label46.Text = "Rp. 3.500.000.000,00";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label45
            // 
            this.label45.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label45.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(187, 153);
            this.label45.Name = "label45";
            this.label45.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label45.Size = new System.Drawing.Size(152, 20);
            this.label45.TabIndex = 52;
            this.label45.Text = "Rp. 3.500.000.000,00";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(187, 300);
            this.label39.Name = "label39";
            this.label39.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label39.Size = new System.Drawing.Size(152, 20);
            this.label39.TabIndex = 51;
            this.label39.Text = "Rp. 3.500.000.000,00";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label44.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(187, 318);
            this.label44.Name = "label44";
            this.label44.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label44.Size = new System.Drawing.Size(152, 20);
            this.label44.TabIndex = 50;
            this.label44.Text = "Rp. 3.500.000.000,00";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label40.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(187, 337);
            this.label40.Name = "label40";
            this.label40.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label40.Size = new System.Drawing.Size(152, 20);
            this.label40.TabIndex = 49;
            this.label40.Text = "Rp. 3.500.000.000,00";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(187, 356);
            this.label38.Name = "label38";
            this.label38.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label38.Size = new System.Drawing.Size(152, 20);
            this.label38.TabIndex = 48;
            this.label38.Text = "Rp. 3.500.000.000,00";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(345, 594);
            this.label37.Name = "label37";
            this.label37.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label37.Size = new System.Drawing.Size(152, 20);
            this.label37.TabIndex = 47;
            this.label37.Text = "Rp. 3.500.000.000,00";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label36.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(345, 485);
            this.label36.Name = "label36";
            this.label36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label36.Size = new System.Drawing.Size(152, 20);
            this.label36.TabIndex = 46;
            this.label36.Text = "Rp. 3.500.000.000,00";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(345, 445);
            this.label35.Name = "label35";
            this.label35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label35.Size = new System.Drawing.Size(152, 20);
            this.label35.TabIndex = 45;
            this.label35.Text = "Rp. 3.500.000.000,00";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(345, 374);
            this.label34.Name = "label34";
            this.label34.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label34.Size = new System.Drawing.Size(152, 20);
            this.label34.TabIndex = 44;
            this.label34.Text = "Rp. 3.500.000.000,00";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 266);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Rp. 3.500.000.000,00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label43.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(345, 228);
            this.label43.Name = "label43";
            this.label43.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label43.Size = new System.Drawing.Size(152, 20);
            this.label43.TabIndex = 42;
            this.label43.Text = "Rp. 3.500.000.000,00";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label41.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(183, 209);
            this.label41.Name = "label41";
            this.label41.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label41.Size = new System.Drawing.Size(156, 20);
            this.label41.TabIndex = 41;
            this.label41.Text = "Rp. 3.800.000.000,00";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(90, 446);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(248, 19);
            this.label33.TabIndex = 32;
            this.label33.Text = "Hutang Akhir : .....................................";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(95, 427);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 19);
            this.label32.TabIndex = 31;
            this.label32.Text = "Pembayaran : ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(55, 408);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(135, 19);
            this.label31.TabIndex = 30;
            this.label31.Text = "Hutang Awal Bulan : ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(106, 595);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(232, 19);
            this.label30.TabIndex = 29;
            this.label30.Text = "Saldo Kas : .....................................";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(90, 375);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(249, 19);
            this.label29.TabIndex = 28;
            this.label29.Text = "Piutang Akhir : .....................................";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(48, 576);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(142, 19);
            this.label28.TabIndex = 27;
            this.label28.Text = "Pembayaran Hutang : ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(72, 557);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(118, 19);
            this.label27.TabIndex = 26;
            this.label27.Text = "Pembelian Tunai : ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(76, 538);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(114, 19);
            this.label26.TabIndex = 25;
            this.label26.Text = "Tagihan Piutang : ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(77, 519);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(114, 19);
            this.label25.TabIndex = 24;
            this.label25.Text = "Penjualan Tunai : ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(24, 486);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(315, 19);
            this.label24.TabIndex = 23;
            this.label24.Text = "Stok + Piutang - Hutang : .....................................";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(114, 356);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 19);
            this.label23.TabIndex = 22;
            this.label23.Text = "Potongan : ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(110, 337);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 19);
            this.label22.TabIndex = 21;
            this.label22.Text = "Penagihan : ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(94, 318);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 19);
            this.label21.TabIndex = 20;
            this.label21.Text = "Piutang Baru : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(55, 300);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 19);
            this.label20.TabIndex = 19;
            this.label20.Text = "Piutang Awal Bulan : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(70, 267);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(268, 19);
            this.label19.TabIndex = 18;
            this.label19.Text = "Penjualan - HPP : .....................................";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(75, 229);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(264, 19);
            this.label18.TabIndex = 17;
            this.label18.Text = "HPP (a+b+c-d) : .....................................";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(76, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 19);
            this.label17.TabIndex = 16;
            this.label17.Text = "Stok Akhir Kini : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(62, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 19);
            this.label16.TabIndex = 15;
            this.label16.Text = " Pembelian Kredit : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(74, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 19);
            this.label15.TabIndex = 14;
            this.label15.Text = "Pembelian Cash : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(70, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 19);
            this.label14.TabIndex = 13;
            this.label14.Text = "Stok Awal Bulan : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(48, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(291, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "Penjualan (a+b-c-d) : .....................................";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(114, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Potongan : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(138, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Retur : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kredit : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(140, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cash : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "5. Hutang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "7. Kas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "6. Ekuilitas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "4. Piutang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "3. Laba / Rugi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "2. Harga Pokok Penjualan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. Penjualan / Omset";
            // 
            // FakturJualPrintButton
            // 
            this.FakturJualPrintButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturJualPrintButton.Location = new System.Drawing.Point(274, 263);
            this.FakturJualPrintButton.Name = "FakturJualPrintButton";
            this.FakturJualPrintButton.Size = new System.Drawing.Size(75, 35);
            this.FakturJualPrintButton.TabIndex = 63;
            this.FakturJualPrintButton.Text = "Print";
            this.FakturJualPrintButton.UseVisualStyleBackColor = true;
            // 
            // FakturBeliPrintButton
            // 
            this.FakturBeliPrintButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturBeliPrintButton.Location = new System.Drawing.Point(274, 263);
            this.FakturBeliPrintButton.Name = "FakturBeliPrintButton";
            this.FakturBeliPrintButton.Size = new System.Drawing.Size(75, 35);
            this.FakturBeliPrintButton.TabIndex = 64;
            this.FakturBeliPrintButton.Text = "Print";
            this.FakturBeliPrintButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1343, 687);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV. Wira Meubel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PembayaranDetailsGroupBox.ResumeLayout(false);
            this.PembayaranDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PembayaranOLV)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.StokFilterGroupBox.ResumeLayout(false);
            this.StokFilterGroupBox.PerformLayout();
            this.StokGroupBox.ResumeLayout(false);
            this.StokGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokOLV)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.SalesFilterGroupBox.ResumeLayout(false);
            this.SalesFilterGroupBox.PerformLayout();
            this.SalesGroupBox.ResumeLayout(false);
            this.SalesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesOLV)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.SupplierFilterGroupBox.ResumeLayout(false);
            this.SupplierFilterGroupBox.PerformLayout();
            this.SuppGroupBox.ResumeLayout(false);
            this.SuppGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierOLV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.CustomerFilterGroupBox.ResumeLayout(false);
            this.CustomerFilterGroupBox.PerformLayout();
            this.CustGroupBox.ResumeLayout(false);
            this.CustGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerOLV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemBeliOLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FakturBeliOLV)).EndInit();
            this.ItemBeliDetailsGroupBox.ResumeLayout(false);
            this.ItemBeliDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBeliPictureBox)).EndInit();
            this.FakturBeliDetailsGroupBox.ResumeLayout(false);
            this.FakturBeliDetailsGroupBox.PerformLayout();
            this.FakturBeliFilterGroupBox.ResumeLayout(false);
            this.FakturBeliFilterGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.FakturJualFilterGroupBox.ResumeLayout(false);
            this.FakturJualFilterGroupBox.PerformLayout();
            this.ItemJualDetailsGroupBox.ResumeLayout(false);
            this.ItemJualDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemJualPictureBox)).EndInit();
            this.FakturJualDetailsGroupBox.ResumeLayout(false);
            this.FakturJualDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemJualOLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FakturJualOLV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PiutangOLV)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LaporanChart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public string getNPWPNumTextBox()
        {
            return CustNpwpNumTextBox.Text;
        }

        public string getNPWPAddrTextBox()
        {
            return CustNpwpAddrTextBox.Text;
        }

        public string getNPWPNameTextBox()
        {
            return CustNpwpNameTextBox.Text;
        }

        private OpenFileDialog openFileDialog1;
        public Timer timer1;
        public Label TimeLabel;
        public BrightIdeasSoftware.HeaderFormatStyle olvHdr;
        public ToolStripMenuItem toolStripMenuItem1;
        public ToolStripMenuItem ubahTanggalToolStripMenuItem;
        public ToolStripMenuItem exitToolStripMenuItem;
        public ToolStripMenuItem userToolStripMenuItem;
        public ToolStripMenuItem ubahPasswordToolStripMenuItem;
        public ToolStripMenuItem tambahPasswordToolStripMenuItem;
        public MenuStrip menuStrip1;
        public TabPage tabPage7;
        public TabPage tabPage6;
        private GroupBox StokFilterGroupBox;
        private TextBox StokFilterTextBox;
        public GroupBox StokGroupBox;
        public TextBox StokPhotoTextBox;
        public Label StokPhotoLabel;
        private Button StokBrowseButton;
        public Label StockIDLabel;
        public ComboBox StokBuatanTextBox;
        public Button StokCancelButton;
        public Button StokEditButton;
        public Button StokNewButton;
        public TextBox StokIDTextBox;
        public TextBox StokHargaListTextBox;
        public TextBox StokHargaPokokTextBox;
        public Label StokHargaListLabel;
        public Label StokHargaPokokLabel;
        public TextBox StokSaldoAkhirTextBox;
        public TextBox StokSaldoAwalTextBox;
        public TextBox StokKategoriTextBox;
        public Label StokKategoriLabel;
        public Label StolBuatanLabel;
        public Label StockEndLabel;
        public Label StockInitialLabel;
        public TextBox StockDateInDateTextBox;
        public Label StokDateInLabel;
        public TextBox StokDimensionsTextBox;
        public TextBox StokWeightTextBox;
        public TextBox StokCollyTextBox;
        public Label StokDimensionsLabel;
        public Label StokWeightLabel;
        public Label StokCollyLabel;
        public TextBox StockDateListDateTextBox;
        public Label StokDateListLabel;
        public TextBox StokColorTextBox;
        public TextBox StokNameTextBox;
        public TextBox StokNotesTextBox;
        public TextBox StokSizeTextBox;
        public TextBox StokUnitTextBox;
        public TextBox StokQuantityTextBox;
        public TextBox StokMerkTextBox;
        public Label StokSizeLabel;
        public Label StokMerkLabel;
        public Label StokQuantityLabel;
        public Label StokNotesLabel;
        public Label StokUnitLabel;
        public Label StokColorLabel;
        public Label StokCodeLabel;
        public Label StokNameLabel;
        public BrightIdeasSoftware.FastObjectListView stokOLV;
        public BrightIdeasSoftware.OLVColumn olvColumn13;
        public BrightIdeasSoftware.OLVColumn olvColumn14;
        public BrightIdeasSoftware.OLVColumn olvColumn15;
        public BrightIdeasSoftware.OLVColumn olvColumn16;
        public BrightIdeasSoftware.OLVColumn olvColumn17;
        public BrightIdeasSoftware.OLVColumn olvColumn18;
        public TabPage tabPage5;
        private GroupBox SalesFilterGroupBox;
        private TextBox SalesFilterTextBox;
        public GroupBox SalesGroupBox;
        private Label KomisiImportALabel;
        private Label KomisiLokalELabel;
        private Label KomisiLokalDLabel;
        private Label KomisiLokalCLabel;
        private Label KomisiLokalBLabel;
        private Label KomisiLokalALabel;
        private Label KomisiImportELabel;
        private Label KomisiImportDLabel;
        private Label KomisiImportBLabel;
        private Label KomisiImportCLabel;
        public TextBox SalesLocalETagihTextBox;
        public TextBox SalesLocalDTagihTextBox;
        public TextBox SalesLocalCTagihTextBox;
        public TextBox SalesLocalBTagihTextBox;
        public TextBox SalesLocalATagihTextBox;
        public TextBox SalesImportETagihTextBox;
        public TextBox SalesImportDTagihTextBox;
        public TextBox SalesImportCTagihTextBox;
        public TextBox SalesImportBTagihTextBox;
        public TextBox SalesImportATagihTextBox;
        public TextBox SalesLocalETextBox;
        public TextBox SalesLocalDTextBox;
        public TextBox SalesLocalCTextBox;
        public TextBox SalesLocalBTextBox;
        public TextBox SalesLocalATextBox;
        public TextBox SalesImportETextBox;
        public TextBox SalesImportDTextBox;
        public TextBox SalesImportCTextBox;
        public TextBox SalesImportBTextBox;
        public TextBox SalesImportATextBox;
        public Button SalesCancelButton;
        public Button SalesEditButton;
        public Button SalesNewButton;
        public Label SalesTagihLocalLabel;
        public Label SalesTagihImportLabel;
        public TextBox SalesOmsetLocalTextBox;
        public Label SalesOmsetLocalLabel;
        public Label SalesKomisiLocalLabel;
        public Label SalesKomisiImportLabel;
        public TextBox SalesProfitTextBox;
        public TextBox SalesDiscountTextBox;
        public TextBox SalesReturnTextBox;
        public Label SalesProfitLabel;
        public Label SalesDiscountLabel;
        public Label SalesReturnLabel;
        public DateTimePicker SalesDateTimePicker;
        public Label SalesDateInLabel;
        public TextBox SalesCityTextBox;
        public TextBox SalesNameTextBox;
        public TextBox SalesNotesTextBox;
        public TextBox SalesTagihTextBox;
        public TextBox SalesOmsetImportTextBox;
        public TextBox SalesAddrTextBox;
        public TextBox SalesPhoneTextBox;
        public Label SalesTagihLabel;
        public Label SalesPhoneLabel;
        public Label SalesAddrLabel;
        public Label SalesNotesLabel;
        public Label SalesOmsetImportLabel;
        public Label SalesCityLabel;
        public Label SalesCodeLabel;
        public Label SalesNameLabel;
        public BrightIdeasSoftware.FastObjectListView salesOLV;
        public BrightIdeasSoftware.OLVColumn olvColumn7;
        public BrightIdeasSoftware.OLVColumn olvColumn8;
        public BrightIdeasSoftware.OLVColumn olvColumn9;
        public BrightIdeasSoftware.OLVColumn olvColumn10;
        public BrightIdeasSoftware.OLVColumn olvColumn11;
        public BrightIdeasSoftware.OLVColumn olvColumn12;
        public TabPage tabPage4;
        private GroupBox SupplierFilterGroupBox;
        private TextBox SupplierFilterTextBox;
        public GroupBox SuppGroupBox;
        public ComboBox SupplierCreditDayTextBox;
        public Button SuppCancelButton;
        public Button SuppEditButton;
        public Button SuppNewButton;
        public TextBox SupplierJatuhTempoTextBox;
        public Label SupplierJatuhTempoLabel;
        public Label SupplierCreditDayLabel;
        public TextBox SupplierCityTextBox;
        public TextBox SupplierNameTextBox;
        public TextBox SupplierNotesTextBox;
        public TextBox SupplierAddrTextBox;
        public TextBox SupplierPhoneTextBox;
        public Label SupplierPhoneLabel;
        public Label SupplierAddrLabel;
        public Label SupplierNotesLabel;
        public Label SupplierCityLabel;
        public Label SupplierCodeLabel;
        public Label SupplierNameLabel;
        public BrightIdeasSoftware.FastObjectListView supplierOLV;
        public BrightIdeasSoftware.OLVColumn olvColumn19;
        public BrightIdeasSoftware.OLVColumn olvColumn20;
        public BrightIdeasSoftware.OLVColumn olvColumn21;
        public BrightIdeasSoftware.OLVColumn olvColumn22;
        public BrightIdeasSoftware.OLVColumn olvColumn23;
        public BrightIdeasSoftware.OLVColumn olvColumn24;
        public TabPage tabPage3;
        private GroupBox CustomerFilterGroupBox;
        private TextBox CustomerFilterTextBox;
        public GroupBox CustGroupBox;
        public ComboBox CustSalesNameTextBox;
        public ComboBox CustLamaKreditTextBox;
        public Label CustSalesNumLabel;
        public Button CustEditButton;
        public Button CustCancelButton;
        public TextBox CustTotalReturnTextBox;
        public TextBox CustR2TextBox;
        public TextBox CustR1TextBox;
        public TextBox CustCityTextBox;
        public Label CustTotalReturnLabel;
        public Label CustSR2Label;
        public Label CustSR1Label;
        public TextBox CustJ3TextBox;
        public TextBox CustJ2TextBox;
        public TextBox CustJ1TextBox;
        public Label CustSJ3Label;
        public Label CustSJ2Label;
        public Label CustSJ1Label;
        public Button CustNewButton;
        public TextBox CustNameTextBox;
        public CheckBox CustMarketCheckBox;
        private wmgCMS.WaterMarkTextBox CustNpwpAddrTextBox;
        private wmgCMS.WaterMarkTextBox CustNpwpNameTextBox;
        public TextBox CustNotesTextBox;
        public TextBox CustJatuhTempoTextBox;
        public TextBox CustPiutangTextBox;
        public TextBox CustAddr2TextBox;
        public TextBox CustAddr1TextBox;
        public TextBox CustPhoneTextBox;
        private wmgCMS.WaterMarkTextBox CustNpwpNumTextBox;
        public Label CustLamaKreditLabel;
        public Label CustJatuhTempoLabel;
        public Label CustNpwpLabel;
        public Label CustSalesCodeLabel;
        public Label TelpCustLabel;
        public Label CustAddr2Label;
        public Label CustAddr1Label;
        public Label CustNotesLabel;
        public Label CustPiutangLabel;
        public Label CustCityLabel;
        public Label CustSalesNameLabel;
        public Label CustCodeLabel;
        public Label CustNameLabel;
        public BrightIdeasSoftware.FastObjectListView customerOLV;
        public BrightIdeasSoftware.OLVColumn olvColumn1;
        public BrightIdeasSoftware.OLVColumn olvColumn2;
        public BrightIdeasSoftware.OLVColumn olvColumn3;
        public BrightIdeasSoftware.OLVColumn olvColumn4;
        public BrightIdeasSoftware.OLVColumn olvColumn5;
        public BrightIdeasSoftware.OLVColumn olvColumn6;
        public TabPage tabPage2;
        private GroupBox ItemBeliDetailsGroupBox;
        private Label ItemBeliTotalLabel;
        public ComboBox ItemBeliStokIDComboBox;
        public Button ItemBeliEditButton;
        public Button ItemBeliCancelButton;
        public Button ItemBeliNewButton;
        private PictureBox ItemBeliPictureBox;
        private Label ItemBeliTanggalLabel;
        private Label ItemBeliQtyLabel;
        private Label ItemBeliHargaBeliLabel;
        private Label ItemBeliStokIDLabel;
        private GroupBox FakturBeliDetailsGroupBox;
        private Label FakturBeliTanggalPajakLabel;
        private Label FakturBeliNoPajakLabel;
        public ComboBox FakturBeliCashKreditComboBox;
        public ComboBox FakturBeliNamaSuppComboBox;
        public ComboBox FakturBeliBeliReturnComboBox;
        public Button FakturBeliCancelButton;
        public Button FakturBeliEditButton;
        public Button FakturBeliNewButton;
        private Label FakturBeliTotalPPNLabel;
        private Label FakturBeliTotalBeliLabel;
        private Label FakturBeliTanggalLabel;
        private Label FakturBeliTotalAkhirLabel;
        private Label FakturBeliCashKreditLabel;
        private Label FakturBeliJatuhTempoLabel;
        private Label FakturBeliNamaSuppLabel;
        private Label FakturBeliKodeSuppLabel;
        private Label FakturBeliBeliReturnLabel;
        private Label FakturBeliJlhItemLabel;
        private Label FakturBeliNoFakturLabel;
        private GroupBox FakturBeliFilterGroupBox;
        private TextBox FakturBeliFilterTextBox;
        public TabPage tabPage1;
        private GroupBox FakturJualFilterGroupBox;
        private TextBox FakturJualFilterTextBox;
        private GroupBox ItemJualDetailsGroupBox;
        public ComboBox ItemJualStokIDComboBox;
        public Button ItemJualEditButton;
        public Button ItemJualCancelButton;
        public Button ItemJualNewButton;
        private PictureBox ItemJualPictureBox;
        private Label ItemJualTanggalLabel;
        private Label ItemJualQtyLabel;
        private Label ItemJualHargaPokokLabel;
        private Label ItemJualProfitLabel;
        private Label ItemJualHargaJualLabel;
        private Label ItemJualStokIDLabel;
        private GroupBox FakturJualDetailsGroupBox;
        private Label FakturJualTanggalLunasLabel;
        public ComboBox FakturJualCashKreditComboBox;
        public ComboBox FakturJualNamaCustComboBox;
        public ComboBox FakturJualJualReturnComboBox;
        public Button FakturJualCancelButton;
        public Button FakturJualEditButton;
        public Button FakturJualNewButton;
        private Label FakturJualTotalPPNLabel;
        private Label FakturJualTotalJualLabel;
        private Label FakturJualTotalAkhirLabel;
        private Label FakturJualNamaSalesLabel;
        private Label FakturJualCashKreditLabel;
        private Label FakturJualKodeSalesLabel;
        private Label FakturJualJthTempoLabel;
        private Label FakturJualNamaCustLabel;
        private Label FakturJualKodeCustomerLabel;
        private Label FakturJualJualReturnLabel;
        private Label FakturJualJlhItemLabel;
        private Label FakturJualNoFakturLabel;
        public BrightIdeasSoftware.FastObjectListView ItemJualOLV;
        public BrightIdeasSoftware.OLVColumn olvColumn29;
        public BrightIdeasSoftware.OLVColumn olvColumn30;
        public BrightIdeasSoftware.OLVColumn olvColumn31;
        public BrightIdeasSoftware.FastObjectListView FakturJualOLV;
        public BrightIdeasSoftware.OLVColumn olvColumn25;
        public BrightIdeasSoftware.OLVColumn olvColumn26;
        public BrightIdeasSoftware.OLVColumn olvColumn27;
        public BrightIdeasSoftware.OLVColumn olvColumn28;
        public TabControl tabControl1;
        public BrightIdeasSoftware.FastObjectListView ItemBeliOLV;
        public BrightIdeasSoftware.OLVColumn olvColumn36;
        public BrightIdeasSoftware.OLVColumn olvColumn37;
        public BrightIdeasSoftware.OLVColumn olvColumn38;
        public BrightIdeasSoftware.FastObjectListView FakturBeliOLV;
        public BrightIdeasSoftware.OLVColumn olvColumn32;
        public BrightIdeasSoftware.OLVColumn olvColumn33;
        public BrightIdeasSoftware.OLVColumn olvColumn34;
        public BrightIdeasSoftware.OLVColumn olvColumn35;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private GroupBox groupBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart LaporanChart;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private ComboBox GrafikComboBox;
        public TextBox ItemBeliTanggalTextBox;
        public TextBox ItemBeliTotalTextBox;
        public TextBox ItemBeliQtyTextBox;
        public TextBox ItemBeliHargaBeliTextBox;
        public TextBox FakturBeliNoPajakTextBox;
        public TextBox FakturBeliNoFakturTextBox;
        public TextBox FakturBeliKodeSuppTextBox;
        public TextBox FakturBeliJatuhTempoTextBox;
        public TextBox FakturBeliTotalBeliTextBox;
        public TextBox FakturBeliTotalPPNTextBox;
        public TextBox FakturBeliTotalAkhirTextBox;
        public CheckBox FakturBeliPPNCheckBox;
        public TextBox ItemJualHargaPokokTextBox;
        public TextBox ItemJualTanggalTextBox;
        public TextBox ItemJualProfitTextBox;
        public TextBox ItemJualQtyTextBox;
        public TextBox ItemJualHargaJualTextBox;
        public TextBox FakturJualTanggalLunasTextBox;
        public TextBox FakturJualNoFakturTextBox;
        public TextBox FakturJualKodeCustomerTextBox;
        public TextBox FakturJualKodeSalesTextBox;
        public TextBox FakturJualNamaSalesTextBox;
        public TextBox FakturJualJthTempoTextBox;
        public TextBox FakturJualTotalJualTextBox;
        public TextBox FakturJualTotalPPNTextBox;
        public TextBox FakturJualTotalAkhirTextBox;
        public CheckBox FakturJualPPNCheckBox;
        public Label FakturJualTanggalabel;
        public TextBox FakturJualJlhItemTextBox;
        public TextBox FakturBeliJlhItemTextBox;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem callToolStripMenuItem;
        private GroupBox groupBox4;
        private TextBox textBox7;
        public BrightIdeasSoftware.FastObjectListView PiutangOLV;
        public BrightIdeasSoftware.OLVColumn olvColumn39;
        public BrightIdeasSoftware.OLVColumn olvColumn40;
        public BrightIdeasSoftware.OLVColumn olvColumn41;
        public BrightIdeasSoftware.OLVColumn olvColumn42;
        public BrightIdeasSoftware.OLVColumn olvColumn43;
        public BrightIdeasSoftware.OLVColumn olvColumn44;
        public BrightIdeasSoftware.OLVColumn olvColumn49;
        public BrightIdeasSoftware.FastObjectListView PembayaranOLV;
        public BrightIdeasSoftware.OLVColumn olvColumn45;
        public BrightIdeasSoftware.OLVColumn olvColumn46;
        public BrightIdeasSoftware.OLVColumn olvColumn47;
        public BrightIdeasSoftware.OLVColumn olvColumn48;
        public GroupBox PembayaranDetailsGroupBox;
        public TextBox PembayaranKeteranganTextBox;
        public ComboBox PembayaranSudahCairComboBox;
        public ComboBox PembayaranNoFakturComboBox4;
        public ComboBox PembayaranNoFakturComboBox3;
        public ComboBox PembayaranNoFakturComboBox2;
        public ComboBox PembayaranNoFakturComboBox1;
        public Label PembayaranNamaCustLabel;
        public ComboBox PembayaranNamaCustComboBox;
        public DateTimePicker PembayaranJthTempoDatePicker;
        public DateTimePicker PembayaranTglGiroDatePicker;
        public TextBox PembayaranKodeCustTextBox;
        public TextBox PembayaranNoRekTextBox;
        public TextBox PembayaranNamaBankTextBox;
        public Label PembayaranKeteranganLabel;
        public Label PembayaranSudahCairLabel;
        public Label PembayaranSisaLabel;
        public Label PembayaranBayarLabel;
        public Label PembayaranTotalFakturLabel;
        public Label PembayaranNoFakturLabel;
        public Label PembayaranKodeCustLabel;
        public Label PembayaranJthTempoLabel;
        public Label PembayaranNoRekLabel;
        public Button PembayaranCancelButton;
        public Button PembayaranEditButton;
        public Button PembayaranNewButton;
        public TextBox PembayaranNoGiroTextBox;
        public Label PembayaranTglGiroLabel;
        public Label PembayaranNamaBankLabel;
        public Label PembayaranNoGiroLabel;
        private Label label58;
        private Label label57;
        private Label label56;
        private Label label55;
        private Label label54;
        private Label label53;
        private Label label52;
        private Label label51;
        private Label label50;
        private Label label49;
        private Label label48;
        private Label label47;
        private Label label46;
        private Label label45;
        private Label label39;
        private Label label44;
        private Label label40;
        private Label label38;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label1;
        private Label label43;
        private Label label41;
        private GroupBox groupBox2;
        private TextBox textBox1;
        public DateTimePicker FakturBeliTanggalPajakDatePicker;
        public Button ItemBeliDeleteButton;
        public Button ItemJualDeleteButton;
        public TextBox PembayaranNilaiTextBox;
        public Label PembayaranNilaiLabel;
        private TableLayoutPanel tableLayoutPanel1;
        public TextBox ItemJualDiscountTextBox;
        private Label ItemJualDiscountLabel;
        public TextBox FakturBeliTanggalTextBox;
        public TextBox FakturJualTanggalTextBox;
        public Button FakturBeliPrintButton;
        public Button FakturJualPrintButton;
    }
}

