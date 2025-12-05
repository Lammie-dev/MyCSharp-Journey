using System;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

class UniversityRegistrationSystem
{
  static string connectionString = "server=localhost;user=root;password=yourpassword;database=university_db;";

 public static void Main()
  {
    while (true)
    {
      Console.Clear();
      Console.WriteLine("University Registration System");
      Console.WriteLine("-------------------------------");
      Console.WriteLine("1. Register a New Student");
      Console.WriteLine("2. Add a New Course");
      Console.WriteLine("3. Register a Student for a Course");
      Console.WriteLine("4. View All Students and their Registered Courses");
      Console.WriteLine("5. Update Student Information");
      Console.WriteLine("6. Delete a Student (and all their registrations)");
      Console.WriteLine("7. Exit");
      Console.Write("Select an option: ");

      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1": RegisterStudent(); break;
        case "2": AddCourse(); break;
        case "3": RegisterForCourse(); break;
        case "4": ViewRegistrations(); break;
        case "5": UpdateStudent(); break;
        case "6": DeleteStudent(); break;
        case "7": return;
        default: Console.WriteLine("Invalid choice. Press any key to try again."); Console.ReadKey(); break;
      }
    }
  }


}


  