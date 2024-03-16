using System;
using System.Data;
using System.Data.SqlClient;

namespace YourNamespace
{
    class Program
    {
        public static string SelectDistinctValues { get; private set; }

        static void Main(string[] args)
        {
            // Connection string for your SQL Server
            string connectionString = "\"Data Source=DESKTOP-LQCK449\\SQLEXPRESS;Initial Catalog=ADODOTNET;Integrated Security=true;\";";

            // Stored procedure name
            string storedProcedureName = "SelectDistinctValues";

            // Parameters
            string tableName = "UserName";
            string columnName = "city";

            // Create SqlConnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create SqlCommand
                using (SqlCommand command = new SqlCommand(SelectDistinctValues, connection))
                {
                    // Specify command type as stored procedure
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.AddWithValue("@TableName", tableName);
                    command.Parameters.AddWithValue("@ColumnName", columnName);

                    // Open the connection
                    connection.Open();

                    // Execute the command
                    SqlDataReader reader = command.ExecuteReader();

                    // Check if there are rows
                    if (reader.HasRows)
                    {
                        // Loop through the rows
                        while (reader.Read())
                        {
                            // Read the data
                            string columnValue = reader.GetString(0); // Assuming the column is of string type, adjust as needed

                            // Do something with the data, e.g., print it
                            Console.WriteLine(columnValue);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }

                    // Close the reader
                    reader.Close();
                }
            }
        }
    }
}
