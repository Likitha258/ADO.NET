using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class delete
    {
        static void Main(string[] args)
        { 
        SqlConnection sqlConnection;
        string connectionString = @"Data Source=Likhithavm;Initial Catalog=demo;Integrated Security=True;Pooling=False";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            try
            {
                Console.WriteLine("enter the employee id:");
                int id = Convert.ToInt32(Console.ReadLine());

                string deleteQuery = "delete id from emp where id =" + id;

                SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                Console.WriteLine("data deleted");
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadKey();   
        }
        }
}
