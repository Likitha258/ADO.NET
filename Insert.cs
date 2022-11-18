using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class Insert
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=Likhithavm;Initial Catalog=demo;Integrated Security=True;Pooling=False";
            sqlConnection = new SqlConnection(connectionString);

        sqlConnection.Open();
            Console.WriteLine("enter the employee id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the employee name:");
            string emp_name = Console.ReadLine();

            Console.WriteLine("enter the employee role:");
             string role = Console.ReadLine();

            string insertQuery = "insert into emp(id, emp_name, role) values('" +id +"','" + emp_name + "','" + role + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("data inserted");
            sqlConnection.Close();
            Console.ReadKey();
        }
    }
}
