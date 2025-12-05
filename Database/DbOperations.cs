using System;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;

class DbOperations
{



  public static void Main(string[] args)
  {
    string connStr = "server=localhost;user=root;password=;database=student_db;";

    MySqlConnection conn = new MySqlConnection(connStr);
    Student student;
    public void getStudentRecord() {
    Console.WriteLine("Enter student firstname: ");
    string firstname = Console.ReadLine();
    Console.WriteLine("Enter student lastname: ");
    string lastname = Console.ReadLine();
    Console.WriteLine("Enter student firstname: ");
    string gender = Console.ReadLine();
    Console.WriteLine("Enter student firstname: ");
    string matric = Console.ReadLine();

    Student student = new Student(firstname, lastname, gender, matric);
  }



    // {
    //   try
    //   {
    //     conn.Open();
    //     Console.WriteLine("Connected to database");
    //     string query = "SELECT * FROM students";
    //     using var cmd = new MySqlCommand(query, conn);
    //     using var reader = cmd.ExecuteReader();
    //     while (reader.Read())
    //     {
    //       int id = reader.GetInt16("id");
    //       string first_name = reader.GetString("first_name");
    //       string last_name = reader.GetString("last_name");

    //       Console.WriteLine($"#{id}: {first_name} {last_name}");
    //     }
    //   }
    //   catch (MySqlException ex)
    //   {
    //     Console.WriteLine(ex.Message);
    //   }


    // }



    }
    
}
