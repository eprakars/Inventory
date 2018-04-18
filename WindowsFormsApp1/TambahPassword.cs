using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TambahPassword : Form
    {
        int Role = -1;
        public TambahPassword()
        {
            InitializeComponent();
        }

        private void TambahPassword_Load(object sender, EventArgs e)
        {
            //Load Role Combo Box
            LoadRoleComboBox();
        }

        private void LoadRoleComboBox()
        {
            TambahPasswordRoleComboBox.Items.Clear();
            TambahPasswordRoleComboBox.BeginUpdate();
            TambahPasswordRoleComboBox.Items.Add("Administrator");
            TambahPasswordRoleComboBox.Items.Add("First Operator");
            TambahPasswordRoleComboBox.Items.Add("Second Operator");
            TambahPasswordRoleComboBox.Items.Add("Third Operator");
            TambahPasswordRoleComboBox.EndUpdate();
        }

        private void TambahPasswordRoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TambahPasswordRoleComboBox.SelectedIndex == 0)
            {
                TambahPasswordRoleDetailsLabel1.Text = "All Access";
                TambahPasswordRoleDetailsLabel2.Text = "";
                TambahPasswordRoleDetailsLabel3.Text = "";
                TambahPasswordRoleDetailsLabel4.Text = "";
                Role = 0;
            } else if (TambahPasswordRoleComboBox.SelectedIndex == 1)
            {
                TambahPasswordRoleDetailsLabel1.Text = "No Edit and Delete";
                TambahPasswordRoleDetailsLabel2.Text = "Laporan Denied";
                TambahPasswordRoleDetailsLabel3.Text = "";
                TambahPasswordRoleDetailsLabel4.Text = "";
                Role = 1;

            } else if (TambahPasswordRoleComboBox.SelectedIndex == 2)
            {
                TambahPasswordRoleDetailsLabel1.Text = "No Edit and Delete";
                TambahPasswordRoleDetailsLabel2.Text = "Laporan Denied";
                TambahPasswordRoleDetailsLabel3.Text = "Faktur Beli Denied";
                TambahPasswordRoleDetailsLabel4.Text = "Supplier Denied";
                Role = 2;
            } else if (TambahPasswordRoleComboBox.SelectedIndex == 3)
            {
                TambahPasswordRoleDetailsLabel1.Text = "No Edit and Delete";
                TambahPasswordRoleDetailsLabel2.Text = "Laporan Denied";
                TambahPasswordRoleDetailsLabel3.Text = "Faktur Beli Denied";
                TambahPasswordRoleDetailsLabel4.Text = "Pembayaran Denied";
                Role = 3;
            }

        }

        public int GetRole()
        {
            return Role;
        }

        public string GetPassword()
        {
            return TambahPasswordNewPassTextBox.Text;
        }
    }
}
