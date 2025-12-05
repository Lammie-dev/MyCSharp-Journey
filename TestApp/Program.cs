using System;
using System.Collections.Generic;
using System.Linq;

//Correction
class Student
{
    public string Name { get; set; }
    public Dictionary<string, int> Subjects { get; set; }
    public Student(string name)
    {
        Name = name;
        Subjects = new Dictionary<string, int>();
    }
}

class Program
{
    //method to calculate average score
    static double AverageScore(Dictionary<string, int> subjects)
    {
        return subjects.Values.Average();
    }
    //method to return grade based on the average
    static string Grades(double average)
    {
        if (average >= 70)
        {
            return "A";
        }
        else if (average >= 60)
        {
            return "B";
        }
        else if (average >= 50)
        {
            return "C";
        }
        else if (average >= 40)
        {
            return "D";
        }
        else
        {
            return "F";
        }

    }
    static void Main()
    {
        List<Student> students = new List<Student>();
        while (true)
        {
            string name;
            do
            {


                Console.Write("\n Enter student name:");
                name = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name cannot be empty!");
                }
            }
            while (string.IsNullOrEmpty(name));

            Student student = new Student(name);



            for (int i = 0; i < 5; i++)
            {

                string subject;

                do
                {
                    Console.WriteLine($"Enter subject {i + 1} name: ");
                    subject = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(subject))
                    {
                        Console.WriteLine("Subject cannot be empty!");
                    }
                }
                while (string.IsNullOrEmpty(subject));
                int score = 0;
                while (true)
                {

                    Console.WriteLine($"\nEnter score for {subject}: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out score) && score >= 0 && score <= 100) break;
                    Console.WriteLine("Wrong input! Please enter a number between 0 and 100. ");
                }
                student.Subjects[subject] = score;

            }

            students.Add(student);
            Console.Write("\nDo you want to enter new student? ");
            string choice = Console.ReadLine().Trim().ToLower();
            if (choice != "yes")break;
        }
        Console.WriteLine("\nSTUDENT DATA");
        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student.Name}");
            Console.WriteLine("Subjects and Scores:");
            foreach (var item in student.Subjects)
            {
            Console.WriteLine($"- {item.Key}: {item.Value}");    
            }
            var lastTwo = student.Subjects.Skip(3).ToArray();
            Console.WriteLine("Last two courses entered: ");
            foreach (var item in lastTwo)
            {
                Console.WriteLine($"- {item.Key}: {item.Value}");
            }
            double avg = AverageScore(student.Subjects);
            string grade = Grades(avg);
            Console.WriteLine($"Average Score: {avg:F2}");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}

    































































// namespace TestApp
// {
//     class Students
//     {
//         public string Name { get; set; }
//         public string Subject { get; set; }
//         public int Score { get; set; }
//         Dictionary<string, int> students = new Dictionary<string, int>();
//         public Students(string name, string subject, int score)
//         {
//             Name = name;
//             Subject = subject;
//             Score = score;
//         }


//     }
//     class Program
//     {
//         static(string Grades,  double averageScore)
//         GetStudentData(Students students)
//         {

//         double averageScore = students.Score.averageScore();
//             return (students.Name, averageScore);
//     }
//         static void Main()
//         {
//             List<Students> students = new List<Students>();

//             Console.WriteLine("Enter number of students: ");
//             int count = int.Parse(Console.ReadLine());

//             for (int i = 0; i < count; i++)
//             {
//                 Console.WriteLine($"Student {i} name:");
//                 Console.WriteLine("Name:  ");
//                 string name = Console.ReadLine();



//                 // string input = "";
//                 // int score = 0;
//                 //            while (input != "5")


// int[] subject = new int[5];
//                 for (int j = 0; j <= subject.Length; j++)
//                 {
//                     Console.WriteLine($"Enter subject {j} : ");
//                     string Subject = Console.ReadLine();
//                     Console.WriteLine($"Enter Score for {subject}: ");

//                     int score = int.Parse(Console.ReadLine());


// students.Add(new Students(subject, score));



//                 double AverageScore = 0;
//                 AverageScore += score;
//                 string Grades = "";

//                 }
//             }
//         }
//     }
// }
// using System;
// namespace YourNamespace
// {
//     class YourClass
//     {
//     }

//     struct YourStruct
//     {
//     }

//     interface IYourInterface
//     {
//     }

//     delegate int YourDelegate();

//     enum YourEnum
//     {
//     }

//     namespace YourNestedNamespace
//     {
//         struct YourStruct
//         {
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello world!");
//         }
//     }
// }