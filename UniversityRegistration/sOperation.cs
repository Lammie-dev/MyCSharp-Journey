using System;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;


public class StudentOperation
{

  string connStr = "server=localhost;user=root;password=;database=student_db;";

  public Student acceptStudentRecord()
  {
    Console.WriteLine("Enter student firstname: ");
    string fname = Console.ReadLine();
    Console.WriteLine("Enter student lastname: ");
    string lname = Console.ReadLine();
    Console.WriteLine("Enter student gender: ");
    string gender = Console.ReadLine();
    Console.WriteLine("Enter student matric: ");
    string matric = Console.ReadLine();


    Student student = new Student(fname, lname, gender, matric);
    return student;

  }


  public void insertStudentRecord()
  {
    MySqlConnection conn = new MySqlConnection(connStr);
    try
    {
      conn.Open();
      Student newStudent = acceptStudentRecord();
      string query = " INSERT INTO students (first_name, last_name, gender, matric_no) VALUES (@fname, @lname, @gender, @matric)";
      MySqlCommand cmd = new MySqlCommand(query, conn);
      cmd.Parameters.AddWithValue("@fname", newStudent.Firstname);
      cmd.Parameters.AddWithValue("@lname", newStudent.Lastname);
      cmd.Parameters.AddWithValue("@gender", newStudent.Gender);
      cmd.Parameters.AddWithValue("@matric", newStudent.Matric);
      int ret = cmd.ExecuteNonQuery();
    }
    catch (Exception ex)
    {
      conn.Close();
      Console.WriteLine(ex.Message);
    }

  }


  public void updateStudentRecord()
  {
    MySqlConnection conn = new MySqlConnection(connStr);
    try
    {

      conn.Open();
      string query = " UPDATE students SET amount=@amount WHERE matric_no= @matric";


      MySqlCommand cmd = new MySqlCommand(query, conn);

      Console.WriteLine("Enter student amount: ");
      double amount = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Enter student Matric: ");
      string matric = Console.ReadLine();
     
      cmd.Parameters.AddWithValue("@amount", amount);
       cmd.Parameters.AddWithValue("@matric", matric);
      int ret = cmd.ExecuteNonQuery();
    }
    catch (Exception ex)
    {

      Console.WriteLine(ex.Message);
    }
    finally
    {
      conn.Close();

    }

  }
}