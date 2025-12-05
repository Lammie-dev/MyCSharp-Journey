using System;
using OfficeOpenXml;
using System.IO;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Linq;




public class Student
{
  public int? StudentId { get; set; }
  public string? Name { get; set; }
  public List<int>Scores { get; set; }
  public double Average { get; set; }
  public string? Grade { get; set; }
  public Student() { }
  public Student(int Id, string name, double average, string grade)
  {
    StudentId = Id;
    Name = name;
    Scores = new List<int>();
    Average = average;
    Grade = grade;
  }

  
}

public class CSVoperation
{
  public static List<Student> ReadCSV(string filePath)
  {
    var students = new List<Student>();

    var lines = File.ReadAllLines(filePath);

    for (int i = 1; i < lines.Length; i++)
    {
      var parts = lines[i].Split(',');
      var student = new Student
      {
        StudentId = int.Parse(parts[0]),
        Name = parts[1],
        Scores = parts.Skip(5).Select(score => int.Parse(score)).ToList()
      };
      students.Add(student);
    }
    return students;
  }

  public void CalculateAveragesAndGrades(List<Student> scores)
  {
    foreach (var score in scores)
    {
      score.Average = score.Scores.Average();
      score.Grade = GetGrade(score.Average);
    }
  }

  public string GetGrade(double average)
  {
    if (average >= 90)
      return "A";
    else if (average >= 80)
      return "B";
    else if (average >= 70)
      return "C";
    else if (average >= 60)
      return "D";
    else
      return "F";
  }

  public void WriteStudentData(string displayFilePath, List<Student> students)
  {
    if (students.Count == 0) return;

    List<string> lines = new List<string>();

    int subjectCount = students[0].Scores.Count;
    var headers = Enumerable.Range(1, subjectCount).Select(i => $"Subject{i}");
    string header = $"Name,{string.Join(",", headers)},Average,Grade";
    lines.Add(header);

    foreach (var student in students)
    {
      string line = $"{student.Name},{string.Join("|", student.Scores)},{student.Average:F2},{student.Grade}";
      lines.Add(line);
    }

    File.WriteAllText(displayFilePath, string.Join(Environment.NewLine, lines));
  }

  public static void WriteToCSV(string outputPath, List<Student> students)
  {
    using (var writer = new StreamWriter(outputPath))
    {
      writer.WriteLine("StudentId,Name,Score1,Score2,Score3,score4,score5,Average,Grade");

      foreach (var student in students)
      {
        var scores = string.Join(",", student.Scores);
        writer.WriteLine($"{student.StudentId},{student.Name},{scores},{student.Average:F2},{student.Grade}");
      }
    }
  }

}
