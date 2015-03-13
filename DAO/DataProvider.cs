using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        public static SqlConnection KetNoi()
        {
            string sChuoiketnoi = @"Data Source=HP;Initial Catalog=SQL_QUANLYHOCSINH;Integrated Security=TRUE;User ID=HP\KHACCHINH;Password=";
            SqlConnection con = new SqlConnection(sChuoiketnoi);
            con.Open();
            return con;

        }
        public static void DongKetNoiDatabase(SqlConnection con)
        {
            con.Close();
        }
        public static DataTable LayDataTable(string sTruyvan, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyvan, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void ThucthiTruyVanNonQuery(string sTruyvan, SqlConnection con)
        {
            SqlCommand cm = new SqlCommand(sTruyvan, con);
            cm.ExecuteNonQuery();
        }
    }
}
