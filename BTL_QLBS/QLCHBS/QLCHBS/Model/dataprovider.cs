using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBS
{
    class dataprovider
    {
        private string connectString = @"Data Source=DESKTOP-AGD9BP2\SQLEXPRESS;Initial Catalog=qlbs;Integrated Security=True";

        public DataTable execQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adappter = new SqlDataAdapter(cmd);
                adappter.Fill(data);
                conn.Close();
            }
            return data;
        }
        public int execNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                data = cmd.ExecuteNonQuery();

                conn.Close();

            }
            return data;
        }
        public object execScaler(string query)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                data = cmd.ExecuteScalar();
                conn.Close();

            }
            return data;

        }
    }
}
