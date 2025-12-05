using System;
using MySql.Data.MySqlClient;


class Program
{



    public static void Main(string[] args)
    {
        string connStr = "server=localhost;user=root;password=;database=student_db;";
        using (var conn = new MySqlConnection(connStr))
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connected to database");
                string query = "SELECT * FROM students";
                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt16("id");
                    string first_name = reader.GetString("first_name");
                    string last_name = reader.GetString("last_name");

                    Console.WriteLine($"#{id}: {first_name} {last_name}");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



    }
    
}
