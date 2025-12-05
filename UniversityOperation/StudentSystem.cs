   public static void RegisterStudent()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter email: ");
        string email = Console.ReadLine();
        Console.Write("Enter year of study: ");
        int year = int.Parse(Console.ReadLine());

        using var con = new MySqlConnection(connectionString);
        con.Open();
        string query = "INSERT INTO students (name, email, year_of_study) VALUES (@name, @email, @year)";
        using var cmd = new MySqlCommand(query, con);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@year", year);
        cmd.ExecuteNonQuery();
        Console.WriteLine("Student registered. Press any key to continue.");
        Console.ReadKey();
    }