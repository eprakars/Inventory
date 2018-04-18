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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string getPassword
        {
            get { return passwordTextbox.Text; }
        }

        private void LoginOkButton_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
            conn.ConnectionString = "Data Source=localhost;Initial Catalog=Vera;";
            conn.UserID = "sa";
            conn.Password = "productive2018";
            using (var connection = new SqlConnection(conn.ConnectionString))
            {
                connection.Open();
                var r = Account.GetAccount(connection, getPassword);
                if (r != null)
                {
                    int role = Utilities.GetInt(r.ToString());
                    this.Hide();
                    var form1 = new Form1(role, getPassword);
                    form1.Closed += (s, args) => this.Close();
                    form1.Show();
                }
                else
                {
                    timer1.Enabled = true;
                    timer1.Interval = 3000;
                    label1.Show();
                    return;
                }
            }
        }

        private void LoginCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Hide();
            timer1.Enabled = false;
        }
    }
}
