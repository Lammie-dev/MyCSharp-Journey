using System;
using OfficeOpenXml;
using System.IO;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Linq;




public class MyData
{
  public int? StudentId { get; set; }
  public string? Name { get; set; }
  public string LastName{ get; set; }
  public List<int> Scores { get; set; }
  public double Average { get; set; }
  public string? Grade { get; set; }
  public MyData() { }
  public MyData(int Id, string name, string lastName, double average, string grade)
  {
    StudentId = Id;
    Name = name;
    LastName = lastName;
    Scores = new List<int>();
    Average = average;
    Grade = grade;
  }
}

public class CSVTest
{
  public static List<MyData> ReadCSV(string filePath)
  {
    var students = new List<MyData>();

    var lines = File.ReadAllLines(filePath);

    for (int i = 1; i < lines.Length; i++)
    {
      var parts = lines[i].Split(',');
      var student = new MyData
      {
        StudentId = int.Parse(parts[0]),
       Name = parts[1],
       LastName =parts[2],
        Scores = parts.Skip(5).Select(score => int.Parse(score)).ToList()
      };
      students.Add(student);
    }
    return students;
  }

  public static  void CalculateAveragesAndGrades(List<MyData> scores)
  {
    foreach (var score in scores)
    {
      score.Average = score.Scores.Average();
      score.Grade = GetGrade(score.Average);
    }
  }

  public static string GetGrade(double average)
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

  public static void WriteStudentData(string outputFilePath, List<MyData> students)
  {
    if (students.Count == 0) return;

    List<string> lines = new List<string>();

    int subjectCount = students[0].Scores.Count;
    var headers = Enumerable.Range(1, subjectCount).Select(i => $"Subject{i}");
    string header = $"Full-Name,{string.Join(",", headers)},Average,Grade";
    lines.Add(header);

    foreach (var student in students)
    {
      string line = $"{student.Name} {student.LastName}{string.Join(",", student.Scores)},{student.Average:F2},{student.Grade}";
      lines.Add(line);
    }

    File.WriteAllText(outputFilePath, string.Join(outputFilePath, lines));
  }

  public static void WriteToCSV(string outputPath, List<MyData> students)
  {
    using (var writer = new StreamWriter(outputPath))
    {
      writer.WriteLine("StudentId,Full-Name,Score1,Score2,Score3,Score4,Score5,Average,Grade");

      foreach (var student in students)
      {
        var scores = string.Join(",", student.Scores);
        writer.WriteLine($"{student.StudentId},{student.Name} {student.LastName},{scores},{student.Average:F2},{student.Grade}");
      }
    }
  }

  
}
