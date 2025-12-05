// using System;
// namespace Assignment
// {
//     class Program
//     {
//       static void Main(string[] args)
//       {
//         string myTxt = "Programming allows us to turn our ideas into reality by writing instructions a computer can understand.";
//         string myScdTxt = "Every time you practice, you improve your ability to think logically and solve real-world problems.";
//         string myThdTxt = "Learning a new language like C# can be challenging at first, but it becomes easier with consistency and curiousity";
//         var vowels = new[] {'a', 'e', 'i', 'o', 'u' };
//         string sentence = $"Rules of a Beginner:\n {myTxt}\n {myScdTxt}\n {myThdTxt} ";
// Console.WriteLine(sentence);
//         foreach (var v in vowels)
//         {
//             sentence = sentence.Replace(Convert.ToString(v), "ggy");
           
//         }
//         Console.WriteLine(sentence);
//       }  
//     }
// }




using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StudentPerformanceManager
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public class Student : Person
    {
        public string StudentId { get; set; }
        public double AverageScore { get; set; }

        public Student() { }

        public Student(string id, string firstName, string lastName, double average)
        {
            StudentId = id;
            FirstName = firstName;
            LastName = lastName;
            AverageScore = average;
        }

        public override string GetFullName()
        {
            return $"{StudentId}: {FirstName} {LastName}";
        }
    }

    public abstract class Report
    {
        public abstract void DisplayTopPerformers(List<Student> students);
    }

    public interface IReportGenerator
    {
        void GenerateReport(List<Student> students);
    }

    public class PerformanceAnalyzer : Report, IReportGenerator
    {
        public override void DisplayTopPerformers(List<Student> students)
        {
            Console.WriteLine("\n===> Top 3 Students <===");
            var top = students.OrderByDescending(s => s.AverageScore).Take(3);
            foreach (var student in top)
            {
                Console.WriteLine($"{student.GetFullName()} - {student.AverageScore:F2}");
            }
        }

        public void GenerateReport(List<Student> students)
        {
            Console.WriteLine("\n--- Student Performance Report ---");
            Console.WriteLine("ID        Name                     Average");
            Console.WriteLine(new string('-', 40));
            foreach (var student in students)
            {
                Console.WriteLine($"{student.StudentId,-10} {student.GetFullName(),-20} {student.AverageScore,7:F2}");
            }
        }

        public static List<Student> LoadStudentsFromCSV(string path)
        {
            var students = new List<Student>();
            if (!File.Exists(path)) return students;

            var lines = File.ReadAllLines(path).Skip(1); // Skip header
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 4 && double.TryParse(parts[3], out double avg))
                {
                    students.Add(new Student(parts[0], parts[1], parts[2], avg));
                }
            }
            return students;
        }

        public static void SaveStudentsToCSV(string path, List<Student> students)
        {
            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine("StudentId,FirstName,LastName,AverageScore");
                foreach (var student in students)
                {
                    writer.WriteLine($"{student.StudentId},{student.FirstName},{student.LastName},{student.AverageScore:F2}");
                }
            }
        }
    }
}



class Program
{
  static string FilePath = "Studentsfile/perfomanceManager.csv";
  //static string inpufilePath = "Studentsfile/newStudents_scores.csv";


  public static void Main()
  {
    //   List<Student> students = new List<Student>();
    //   Console.WriteLine(" Existing Student from CSV file\n");
    // //var oldStudents = PerfomanceAnalyzer.GetStudentFromCSV(path);
    //  PerfomanceAnalyzer.GetStudentFromCSV(inpufilePath);
    //  PerfomanceAnalyzer.GetStudentFromCSV(FilePath);
    //  //students.AddRange(PerfomanceAnalyzer.Students);
    //   Console.WriteLine($"{students.Count} Existing Student from CSV file\n");



    var existingStudents = PerformanceAnalyzer.GetStudentFromCSV(FilePath);

    // Optionally load from new file only once
    if (existingStudents.Count == 0)
    {
      existingStudents = PerfomanceAnalyzer.GetStudentFromCSV(FilePath);
    }

    Console.WriteLine("\nTotal students loaded: " + existingStudents.Count);


    string GetDetails;
    do
    {
      Student student = new Student();

      Console.WriteLine("Enter StudentID: ");
      student.StudentId = Console.ReadLine();

      Console.WriteLine($"First name:  ");
      student.FirstName = Console.ReadLine();

      while (string.IsNullOrEmpty(student.FirstName))
      {
        Console.WriteLine("Name space must not be empty!");
        Console.WriteLine($"First name:  ");
        student.FirstName = Console.ReadLine();
      }
      Console.WriteLine("Last name: ");
      student.LastName = Console.ReadLine();
      while (string.IsNullOrEmpty(student.LastName))
      {
        Console.WriteLine("Last name is required!");
        Console.WriteLine("Last name: ");
        student.LastName = Console.ReadLine();
      }



      double average;
      while (true)
      {
        Console.WriteLine("Enter Average score:  ");
        if
        (double.TryParse(Console.ReadLine(), out average) && average != 0 && average != 100)
        {
          student.AverageScore = average;
          break;

        }

        Console.WriteLine("Invalid input! Enter number between 0 and 100. ");

      }
      
      
      existingStudents.Add(student);

      //students.Add(student);

      Console.WriteLine("\n Do you want to continue?");
      GetDetails = Console.ReadLine().Trim().ToLower();
    }
    while (GetDetails == "yes");

   // merging
    var newstudents = existingStudents.Concat(existingStudents)
    .GroupBy(s => s.StudentId)
    .Select(g => g.First())
    .ToList();
    //display

    PerfomanceAnalyzer pAnalyzer = new PerfomanceAnalyzer();

    pAnalyzer.GenerateReport(existingStudents);
    pAnalyzer.DisplayTopPerformance(existingStudents);
    PerfomanceAnalyzer.AddStudentsToCSV(FilePath, existingStudents);
     Console.WriteLine("\nAll data saved successfully to performanceManager.csv");

foreach (var student in existingStudents)
        {
          Console.WriteLine($"{student.GetFullName()},{student.AverageScore:F2}");
        }
  }
  
}








//classs



using System;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Person
{
  public string? FirstName { get; set; }
  public string? LastName { get; set; }
  public virtual string GetFullName()
   {
   return $" {FirstName} {LastName} ";;
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
  {}

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

public class PerfomanceAnalyzer : Report, IReportGenerator
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
  public static List<Student> GetStudentFromCSV(string path)

  {
    var students = new List<Student>();
    if (!File.Exists(path))
    {
      Console.WriteLine("File not found" + path);
      return students;
    }
    var lines = File.ReadAllLines(path).Skip(1);
    foreach (var line in lines)
    {
      var parts = line.Split(',');
      if (parts.Length >= 4 && double.TryParse(parts[7], out double average))
      //if (parts.Length >= 4)
      {
      

        var student = new Student
        {
          StudentId = parts[0],
          FirstName = parts[1],
          AverageScore= average


        //LastName = parts[2],
        //AverageScore = double.TryParse(parts[7], out double average)? average:0

        };

      // Console.WriteLine($"Updated list: {student.GetFullName()}, Average:{student.AverageScore:F2}");
      // students.Add(student);
     }
    // else
    //{
    // Console.WriteLine("skippd a row: missing");
    //}
 }
    return students;
   


  }
  public static void AddStudentsToCSV(string path, List<Student> students)
  {
   // bool fileExists = File.Exists(path);
    using (var writer = new StreamWriter(path, false))
    {
      //if (!fileExists)
      //{
writer.WriteLine("StudentId, Full-Name, AverageScore");
     // }
      

      foreach (var student in students)
      {

        writer.WriteLine($"{student.StudentId}, {student.FirstName} {student.LastName}, {student.AverageScore:F2}");
        // Students.Add(new Student());
      }
    }
  }

}

  
