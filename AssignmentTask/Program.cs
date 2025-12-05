using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public class Student
{
    public int StudentId { get; set; }
    public string? Name { get; set; }
    public List<double> Scores { get; set; }
    public double Average { get; set; }
    public string? Grade { get; set; }

    public Student(int Id, string name, double average, string grade)
    {
        StudentId = Id;
        Name = name;
        Scores = new List<double>();
        Average = average;
        Grade = grade;
    }

   public Student() {
    
} 
}


public class StudentScoreProcessor
{
    public List<Student> ReadStudentScores(string filePath)
    {
        var students = new List<Student>();
        var lines = File.ReadAllLines(filePath);

        for (int i = 1; i < lines.Length; i++) // Skip header
        {
            var parts = lines[i].Split(',');

            var student = new Student
            {
                StudentId = int.Parse(parts[0]),
                Name = parts[1],
                Scores = parts.Skip(2).Select(s => double.Parse(s, CultureInfo.InvariantCulture)).ToList()
            };

            students.Add(student);
        }

        return students;
    }

    public void CalculateAveragesAndGrades(List<Student> students)
    {
        foreach (var student in students)
        {
            student.Average = student.Scores.Average();
            student.Grade = GetGrade(student.Average);
        }
    }

    private string GetGrade(double average)
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

    public void WriteStudentResults(string outputPath, List<Student> students)
    {
        using (var writer = new StreamWriter(outputPath))
        {
            writer.WriteLine("StudentId,Name,Score1,Score2,Score3,Average,Grade");

            foreach (var student in students)
            {
                var scores = string.Join(",", student.Scores.Select(s => s.ToString("F2")));
                writer.WriteLine($"{student.StudentId},{student.Name},{scores},{student.Average:F2},{student.Grade}");
            }
        }
    }
}
