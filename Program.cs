using System;
using System.Data.SqlClient;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConString = @"Data Source=Likhithavm;Initial Catalog=demo;Integrated Security=True;Pooling=False";
            SqlConnection con = new SqlConnection(ConString);
            string querystring = "Select * from emp";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
        }
    }
}