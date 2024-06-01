using System;
using MySql.Data.MySqlClient;

namespace newproject.TestEntityFrameWork.connection
{
    public class Connection
{
    private static string connectionString = "your_connection_string_here";

    public static MySqlConnection ConnectionDTB()
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        
        try
        {
            connection.Open();
        }
        catch (MySqlException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        return connection;
    }
}
}