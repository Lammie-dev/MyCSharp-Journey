class Program
{
  const string filePath = "Studentsfile/newStudents_scores.csv";
  const string path = "Studentsfile/perfomanceManager.csv";

  public static void Main()
  {

    List<Student> students = new List<Student>();
    Console.WriteLine(" Existing Student from CSV file\n");
   PerfomanceAnalyzer.GetStudentFromCSV(filePath);
    students.AddRange(PerfomanceAnalyzer.Students);
    Console.WriteLine($"{students.Count} Existing Student from CSV file\n");

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



      double score;
      while (true)
      {
        Console.WriteLine("Enter Average score:  ");
        if
        (double.TryParse(Console.ReadLine(), out score) && score != 0 && score != 100)
        {
          student.AverageScore = score;
          break;

        }
        
          Console.WriteLine("Invalid input! Enter number between 0 and 100. ");

      }


      students.Add(student);

      Console.WriteLine("\n Do you want to continue?");
      GetDetails = Console.ReadLine().Trim().ToLower();
    }
    while (GetDetails == "yes");

    PerfomanceAnalyzer pAnalyzer = new PerfomanceAnalyzer();

    pAnalyzer.GenerateReport(students);
    pAnalyzer.DisplayTopPerformance(students);
    PerfomanceAnalyzer.AddStudentsToCSV(path, students);

  }
  
}



