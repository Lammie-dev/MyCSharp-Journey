using System;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Linq;

public class Program
{
  public static void Main(string[] args)
  {
    var studentOperation = new studentOps();
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
        case "1": studentOperation.RegisterStudent(); break;
        case "2": studentOperation.AddCourse(); break;
        case "3": studentOperation.RegisterForCourse(); break;
        case "4": /* studentOperation.ViewRegistrations(); */ break;
        case "5": /* studentOperation.UpdateStudent(); */ break;
        case "6": /* studentOperation.DeleteStudent(); */ break;
        case "7": return;
        default: Console.WriteLine("Invalid choice. Press any key to try again."); Console.ReadKey(); break;
      }
    }
  }
}
