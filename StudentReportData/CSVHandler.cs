using System.IO;
public static class CSVHandler
{
  public static void SaveStudentData(Student student, string filePath)
  {
    string line = $"{student.Name}, {student.Gender}, {string.Join(" , " , student.Scores)}, {student.Average}, {student.Grade}";

   File.AppendAllLines(filePath, new[] { line });
  }
}