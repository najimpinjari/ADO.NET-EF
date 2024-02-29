using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;  
using System.Data.SqlClient;

namespace DOT.NET_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Connection();
            Console.ReadLine();
        }   
        
        static void Connection() // for making connection string 
        {
            string cs = "Data Source=DESKTOP-LQCK449\\SQLEXPRESS;Initial Catalog=ADODOTNET;Integrated Security=true;";

            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("connection has been created successfully ");
                }
    
            }catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
