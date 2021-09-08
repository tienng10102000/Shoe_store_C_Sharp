using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace App.NET.Class
{
    public class SQLConnection
    {
        public DataTable data;
        public SqlDataReader dr;
        public String connstr = @"Data Source=CANBO-NAMDU;Initial Catalog=QLSBG;Persist Security Info=True;User ID=sa;Password=123456";
        SqlConnection conn2;
        public Boolean GetIn4 (String Query)
        {
            data = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                    adapter.Fill(data);
                    conn.Close();
                }
                return true;
            } catch
            {
                return false;
            }
        }
        public Boolean ChangeData(String Query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(Query, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean SetDataReader(String Query)
        {

            try
            {
                conn2 = new SqlConnection(connstr);
                conn2.Open();
                SqlCommand cmd = new SqlCommand(Query, conn2); // thuc hien cau lenh tren sql
                dr = cmd.ExecuteReader(); // dr la 1 mang chua dữ liệu
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void dongKN()
        {
            conn2.Close();
        }
    }
}
