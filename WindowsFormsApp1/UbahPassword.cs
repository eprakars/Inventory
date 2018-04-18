using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UbahPassword : Form
    {
        string oldPass;
        public UbahPassword(string password)
        {
            InitializeComponent();
            oldPass = password;
        }
        internal bool Success
        {
            get;
            set;
        }

        public string GetPassword()
        {
            return oldPass;
        }

        private void UbahPasswordOkButton_Click(object sender, EventArgs e)
        {
            if (!ChangePasswordOldTextBox.Text.Equals(oldPass))
            {
                MessageBox.Show("Password Lama Anda salah");
                return;
            }
            string n = ChangePasswordNewTextBox.Text;

            if (n.Equals("") || n.Length <= 6)
            {
                MessageBox.Show("Password Tidak Boleh Kosong dan harus lebih dari 6 karakter");
                return;
            }

            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.ConnectionString = @"Data Source=localhost;Initial Catalog=Vera;";
            sb.UserID = "sa";
            sb.Password = "productive2018";
            using (var connection = new SqlConnection(sb.ConnectionString))
            {
                connection.Open();
                SqlCommand com = new SqlCommand(QueryString.UpdateAccount, connection);
                com.Parameters.Add("@oldpass", Base.VarChar).Value = oldPass;
                com.Parameters.Add("@newpass", Base.VarChar).Value = n;

                int rows = com.ExecuteNonQuery();
                if (rows == 1)
                {
                    Success = true;
                    oldPass = n;
                    MessageBox.Show("Update Success!");
                }
                else
                {
                    Success = false;
                    MessageBox.Show("Update failed!");
                }
            }
        }
    }
}
