using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class Select
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionstring = @"Data Source = likhithavm; Initial Catalog = product; Integrated Security = True; Pooling = False";
            SqlConnection sqlConnection1= new SqlConnection(connectionstring);
            string querystring = "select * from product";
            sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand(querystring, sqlConnection1);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() +" "+ reader[1].ToString +" "+ reader[2].ToString());

            }

        }
    }
}