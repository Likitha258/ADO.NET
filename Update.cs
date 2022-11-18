using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class Update
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=Likhithavm;Initial Catalog=demo;Integrated Security=True;Pooling=False";
            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            try
            {
                Console.WriteLine("enter the id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the name:");
                string name = Convert.ToString(Console.ReadLine());


                string updateQuery = "update emp set name = '" + name + "'where id= '" + id + "";

                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                updateCommand.ExecuteNonQuery();
                Console.WriteLine("data updated");
                sqlConnection.Close();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
