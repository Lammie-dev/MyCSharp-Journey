using System.Collections.Generic;
using System.IO;
// CSVoperation.ReadCSV("CSVfiles/students_scores.csv");

  class Program
{
  static void Main(string[] args)
  {
    var cSVTest = new CSVTest();
    var cSVoperation = new CSVoperation();


    // Input CSV (pipe-delimited): "StudentId|Name|Score1|Score2|Score3"
    string inputFilePath = "CSVfiles/students_scores.csv";
    string outputFilePath = "CSVfiles/newStudents_scores.csv";

    string displayFilePath = "CSVfiles/StudentsData_scores.csv";
    // try
    //{
    // Read the student data
    var students = CSVTest.ReadCSV(inputFilePath);
    var studentsData = CSVoperation.ReadCSV(inputFilePath);

    // Calculate averages and assign grades
    CSVTest.CalculateAveragesAndGrades(students);
    cSVoperation.CalculateAveragesAndGrades(studentsData);
    // Write the results to a new CSV file
    CSVTest.WriteToCSV(outputFilePath, students);
    CSVoperation.WriteToCSV(displayFilePath, studentsData);

    Console.WriteLine("Student results written to CSV successfully!");
    
















    
    //}
    // catch (Exception ex)
    // {
    //     Console.WriteLine($"Error: {ex.Message}");
    // }










    // foreach (var student in students)
    // {
    //   Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, Average: {student.Average:F2}, Grade: {student.Grade}");
    // }
  }
}



   



   
  


