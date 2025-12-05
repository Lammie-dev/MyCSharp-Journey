class Program
{
  static void Main()
  {
    var student = new Student
    {
      Name = "Jemima Williams",
      Gender = "Female",
      Scores = new List<int>
      {
        30, 67, 90, 88, 50
      }
    };
    Console.WriteLine($"Student: {student.Name}");
    Console.WriteLine($"Gender: {student.Gender}");
    Console.WriteLine($"Average: {student.Average}");
    Console.WriteLine($"Grade: {student.Grade}");

    string path = "students-List.csv";
    CSVHandler.SaveStudentData(student, path);
    Console.WriteLine("Student data saved successfully");
  }
}