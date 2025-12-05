public static void AddCourse()
    {
        Console.Write("Enter course title: ");
        string title = Console.ReadLine();
        Console.Write("Enter course code: ");
        string code = Console.ReadLine();
        Console.Write("Enter credit units: ");
        int units = int.Parse(Console.ReadLine());

        using var con = new MySqlConnection(connectionString);
        con.Open();
        string query = "INSERT INTO courses (title, code, credit_units) VALUES (@title, @code, @units)";
        using var cmd = new MySqlCommand(query, con);
        cmd.Parameters.AddWithValue("@title", title);
        cmd.Parameters.AddWithValue("@code", code);
        cmd.Parameters.AddWithValue("@units", units);
        cmd.ExecuteNonQuery();
        Console.WriteLine("Course added. Press any key to continue.");
        Console.ReadKey();
    }