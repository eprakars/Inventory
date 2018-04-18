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
    class Piutangs : Base
    {

        public static List<Piutang> LoadPiutang(DataTable data)
        {
            List<Piutang> list = new List<Piutang>();
            foreach (DataRow drCurrent in data.Rows)
            {
                list.Add(new Piutang(
                    nama: drCurrent["_name"].ToString()
                    , nofaktur: Utilities.GetInt(drCurrent["_idJual"].ToString())
                    , date: Utilities.ConvertDateToString(drCurrent["_date"])
                    , jatuhtempo: Utilities.ConvertDateToString(drCurrent["_jatuhTempo"])
                    , kodesales: Utilities.GetInt(drCurrent["_cid"].ToString())
                    , kota: drCurrent["_city"].ToString()
                    , totalpiutang: Utilities.GetInt(drCurrent["_total"].ToString())
                ));
            }
            return list;
        }
    }
}
