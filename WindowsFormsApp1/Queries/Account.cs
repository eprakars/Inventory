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
    class Account : Base
    {

        internal static Object GetAccount(SqlConnection conn, string password)
        {
            SqlCommand com = new SqlCommand(QueryString.AccountRole, conn);
            com.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            
            var res = com.ExecuteScalar();

            return res;       
        }


        internal static void InsertAccount(SqlConnection conn, string password, int role)
        {

            SqlCommand com = new SqlCommand(QueryString.InsertAccount, conn);
            com.Parameters.Add("@password", VarChar).Value = password;
            com.Parameters.Add("@role", Int).Value = role;

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Console.WriteLine("Insert new Account failed");
                    // throw Exception ?
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }

        internal static void UpdateAccount(SqlConnection conn, string oldpass, string newpass)
        {

            SqlCommand com = new SqlCommand(QueryString.UpdateAccount, conn);
            com.Parameters.Add("@newpass", VarChar).Value = newpass;
            com.Parameters.Add("@oldpass", VarChar).Value = oldpass;

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    Utilities.print("Update Account failed");
                    // throw Exception ?
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }
        
    }
}
