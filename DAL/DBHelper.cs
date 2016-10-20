using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class DBHelper
    {
       
        public static DataTable GetDt(string strSql)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(connectionString, strSql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        


        public static DataTable GetDataTable(string strSql)
        {
            string connnectionString = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
            SqlConnection connection = new SqlConnection(connnectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(strSql, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        public static List<string> GetDistinceColoum(string strSql,string str1)
        {
            DataTable dt = GetDataTable(strSql);
            List<string> strList = new List<string>();
            foreach ( DataRow dr in dt.Rows)
            {
                string str = dr[str1].ToString();
                strList.Add(str);
            }
            return strList;
        }



        
    }
}
