using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Utilities
    {
        Log log = new Log();

        //Format Rupiah
        public static string FormatRupiah = "Rp. {0:N}"; // {0 : amount}
        CultureInfo culture = CultureInfo.CreateSpecificCulture("id-id");

        public static bool ParseBoolean(string s)
        {
            bool ret = false;
            bool.TryParse(s, out ret);
            return ret;
        }
        public static void print(object o, params object[] obj)
        {
            Log.print(o, obj);
        }

        //public static string SetCustomerCode(int code)
        //{
        //    string CustomerCode = String.Format()
        //    return;
        //}

        public static string SetNoFaktur(int i)
        {
            return String.Format("{0:00}{1:00}{2:0000}" , DateTime.Today.ToString("yy"), DateTime.Today.ToString("MM"), i);
        }


        public static int GetNoFaktur(string s)
        {
            int res = 0;
            try
            {
                print("Kode Faktur " + s.Substring(s.Length - 8));
                res = int.Parse(s.Substring(s.Length - 8));
            }
            catch (Exception e)
            {
                // Handle exception maybe ?
                Console.WriteLine("Error trying to parse Kode Faktur : " + e.Message);
                res = -1;
            }
            return res;
        }

        public static int GetSupplierCode(string s)
        {
            int res = 0;
            try
            {
                print("Supplier SUBSTRING " + s.Substring(s.Length - 3));
                res = int.Parse(s.Substring(s.Length - 3));
            }
            catch (Exception e)
            {
                // Handle exception maybe ?
                Console.WriteLine("Error trying to parse Supplier code : " + e.Message);
                res = -1;
            }
            return res;
        }

        public static int GetCustomerCode(string s)
        {
            int res = 0;
            try
            {
                print("CUSTOMER SUBSTRING " + s.Substring(s.Length - 4));
                res = int.Parse(s.Substring(s.Length - 4));
            }
            catch (Exception e)
            {
                // Handle exception maybe ?
                Console.WriteLine("Error trying to parse Customer code : " + e.Message);
                res = -1;
            }
            return res;
        }

        public static int GetSalesCode(string s, Boolean f)
        {
            int res = 0;
            int r = f ? s.Length - 3 : 2;
            try
            {
                //Console.WriteLine("SUBSTRING :" + s.Substring(r));
                res = int.Parse(s.Substring(r));
            }
            catch (Exception e)
            {
                // Handle exception maybe ?
                Console.WriteLine("Error trying to parse Sales code : " + e.Message);
                res = -1;
            }
            return res;
        }

        public static int GetInt(string s, bool rupiah = false)
        {
            if (s.Length < 1)
                return 0;
            int res = 0;
            if (rupiah)
            {
                StringBuilder sb = new StringBuilder();
                var arr = s.ToArray();
                int len = arr.Length;
                for (var i = 0; i < len; i++)
                {
                    char c = arr[i];
                    if (!(c == 'R' || c == 'p' || c == ' ' || c == ',' || c == '.'))
                        sb.Append(c);
                }
                sb.Length = sb.Length - 2;
                s = sb.ToString();
            }
            try
            {
                res = int.Parse(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error trying to parse Integer" + e.Message);
                res = 0;
            }
            return res;
            //return rupiah ? res / 100 : res;
        }

        public static string GetDateNow(int addDays = 0, string from = "")
        {
            DateTime dateFrom = DateTime.Now;
            if (!from.Equals(""))
            {
                dateFrom = DateTime.Parse(from);
            }

            return dateFrom.AddDays(addDays).ToString("ddd,  MMM-dd-yyyy");
        }

        public static string ConvertDateToString(Object s)
        {
            
            return String.Format("{0:ddd,  MMM-dd-yyyy}", s);
        }

        public static string ChangeDateFormatToyyyyMMdd(string s)
        {
            String date = "";
            try
            {
                date = System.DateTime.Parse(s).ToString("yyyy-MM-dd");
            }
            catch
            {

            }
            return date;
        }

        public static string ChangeDateFormatToDDDMMMDDyyyy(string s)
        {
            String date = "";
            try
            {
                date = System.DateTime.Parse(s).ToString("ddd,  MMM-dd-yyyy");
            }
            catch
            {

            }
            return date;
        }

        public static Int64 GetBigInt(string s)
        {
            StringBuilder sb = new StringBuilder();
            char[] arr = s.ToArray();
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                if (!(arr[i] == '.' || arr[i] == '-'))
                    sb.Append(arr[i]);
            }
            Int64 res = 0;
            try
            {
                res = Int64.Parse(sb.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error trying to parse BigInteger" + e.Message);
                res = 0;
            }
            return res;
        }

    }
    class Log
    {
        static bool debug = true;
        public static void print(object o, params object[] obj)
        {
            if (debug)
            {
                Console.WriteLine(o.ToString(), obj);
            }
        }
    }
}
