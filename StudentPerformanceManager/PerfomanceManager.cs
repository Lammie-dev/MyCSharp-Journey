using System;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


//polymorphism and classes
public class Person
{
  public string? FirstName { get; set; }
  public string? LastName { get; set; }
  public virtual string GetFullName()
  {
    return $" {FirstName} {LastName} "; ;
  }
}

public class Student : Person
{
  public string StudentId { get; set; }

  public double AverageScore { get; set; }
  public Student(string id, double average, string firstname, string lastname)
  {
    StudentId = id;
    FirstName = firstname;
    LastName = lastname;
    AverageScore = average;
  }

  public Student()
  {
  }

  public  override string GetFullName()
  {
    return $" {StudentId}, {FirstName} {LastName} ";
  }

}

public abstract class Report
{
  public abstract void DisplayTopPerformance(List<Student> students);
}

interface IReportGenerator
{
  void GenerateReport(List<Student> students);
}

class PerfomanceAnalyzer : Report, IReportGenerator
{

  public void GenerateReport(List<Student> students)
  {
    Console.WriteLine("\n-----------Students Report--------------");
    Console.WriteLine("StudentID     FullName              Average");
    Console.WriteLine(new string('-', 60));
    foreach (var student in students)
    {

      Console.WriteLine($"{student.GetFullName(),-25}, Average:{student.AverageScore:F2}");
     

    }

  }

  public override void DisplayTopPerformance(List<Student> students)
  
  {
    Console.WriteLine("\n===>Student with High Performance<===");

    var topPerformance = students.OrderByDescending(s => s.AverageScore).Take(3).ToList();
    foreach (var student in topPerformance)
    {
      Console.WriteLine($"{student.GetFullName(),-25}, Average:{student.AverageScore:F2}");
 
  }
  }


  public static List<Student> Students = new List<Student>();
  public static void GetStudentFromCSV(string path )

  {
    if (!File.Exists(path))
    {
      Console.WriteLine("File not found" + path);
       return;
    }
     



    var lines = File.ReadAllLines(path).Skip(1);


    foreach (var line in lines)
    {
      var parts = line.Split(',');
    
      if (parts.Length >= 4 )
      {
        var student = new Student
        {
          StudentId = parts[0],
          FirstName = parts[1],
        
          AverageScore = double.TryParse(parts[7], out double average)? average: 0

        };
        Students.Add(student);
      }
     
    }
   


  }
  public static void AddStudentsToCSV(string path, List<Student> students)
  {
    bool fileExists = File.Exists(path);
    using (var writer = new StreamWriter(path ,false))
    {
      if (!fileExists)
      {
      writer.WriteLine("StudentId, Full-Name, AverageScore");
      }
      

      foreach (var student in students)
      {

        writer.WriteLine($"{student.StudentId}, {student.FirstName} {student.LastName}, {student.AverageScore:F2}");
  
      }
    }
  }

}

  
