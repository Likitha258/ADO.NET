using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class retrieve
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionstring = @"Data Source = likhithavm; Initial Catalog = product; Integrated Security = True; Pooling = False";
            SqlConnection connect = new SqlConnection(connectionstring);

            string querystring = "Select * from product";
            connect.Open();
            SqlCommand cmd = new SqlCommand(querystring, connect);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
        }
    }
}