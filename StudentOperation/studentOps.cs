using System;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;


public class studentOps{


  string connStr = "server=localhost;user=root;password=;database=university_db;";

  public  void RegisterStudent()
  {
    Console.Write("Enter name: ");
    string name = Console.ReadLine();
    Console.Write("Enter email: ");
    string email = Console.ReadLine();
    Console.Write("Enter year of study: ");
    int year = int.Parse(Console.ReadLine());

    using var con = new MySqlConnection(connStr);
    con.Open();
    string query = "INSERT INTO students (student_name, student_email, year_of_study) VALUES (@name, @email, @year)";
    using var cmd = new MySqlCommand(query, con);
    cmd.Parameters.AddWithValue("@name", name);
    cmd.Parameters.AddWithValue("@email", email);
    cmd.Parameters.AddWithValue("@year", year);
    cmd.ExecuteNonQuery();
    Console.WriteLine("Student registered. Press any key to continue.");
    Console.ReadKey();
  }







  public void AddCourse()
  {
    Console.Write("Enter course title: ");
    string title = Console.ReadLine();
    Console.Write("Enter course code: ");
    string code = Console.ReadLine();
    Console.Write("Enter credit units: ");
    int units = int.Parse(Console.ReadLine());

    using var con = new MySqlConnection(connStr);
    con.Open();
    string query = "INSERT INTO courses (course_title, course_code, credit_units) VALUES (@title, @code, @units)";
    using var cmd = new MySqlCommand(query, con);
    cmd.Parameters.AddWithValue("@title", title);
    cmd.Parameters.AddWithValue("@code", code);
    cmd.Parameters.AddWithValue("@units", units);
    cmd.ExecuteNonQuery();
    Console.WriteLine("Course added. Press any key to continue.");
    Console.ReadKey();
  }

  public void RegisterForCourse()
  {
    Console.Write("Enter student ID: ");
    int studentId = int.Parse(Console.ReadLine());
    Console.Write("Enter course ID: ");
    int courseId = int.Parse(Console.ReadLine());
  }
}