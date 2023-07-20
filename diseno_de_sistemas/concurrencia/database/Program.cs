using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Create a database connection string.
        string connectionString = "Data Source=localhost;Initial Catalog=Northwind;User ID=sa;Password=UMGGT2023*;MultipleActiveResultSets=True";

        // Create a database connection.
        SqlConnection connection = new SqlConnection(connectionString);

        // Open the database connection.
        await connection.OpenAsync();

        // Create two queries.
        string query1 = "SELECT CustomerID, CompanyName FROM Customers";
        string query2 = "SELECT ProductID, ProductName FROM Products";

        // Execute the queries concurrently.
        var task1 = Task.Run(async () =>
        {
            SqlCommand command1 = new SqlCommand(query1, connection);
            SqlDataReader reader1 = await command1.ExecuteReaderAsync();
            while (await reader1.ReadAsync())
            {
                Console.WriteLine($"CustomerID: {reader1["CustomerID"]}, CompanyName: {reader1["CompanyName"]}");
            }
        });

        var task2 = Task.Run(async () =>
        {
            SqlCommand command2 = new SqlCommand(query2, connection);
            SqlDataReader reader2 = await command2.ExecuteReaderAsync();
            while (await reader2.ReadAsync())
            {
                Console.WriteLine($"ProductID: {reader2["ProductID"]}, ProductName: {reader2["ProductName"]}");
            }
        });

        // Wait for the tasks to finish.
        await Task.WhenAll(task1, task2);

        // Close the database connection.
        connection.Close();
    }
}
