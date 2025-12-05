// Tracking student Grades
using System;
using System.Collections.Generic;
using System.Linq;
namespace TrackingApp
{


    class StudentInfo
    {
        public string Name { get; set; }
        public int[] Grades { get; set; }
        //constructor
        public StudentInfo(string name, int[] grades)
        {
            Name = name;
            Grades = grades;
        }

        public (string, int[])
        GetStudentData()
        {
            return (Name, Grades);
        }

    }


    class Program
    {
        static (string name, double average)
        GetStudentInfo(StudentInfo studentInfo)
        {
            double average = studentInfo.Grades.Average();
            return (studentInfo.Name, average);
        }
        static void Main()
        {

            List<StudentInfo> studentInfo = new List<StudentInfo>();
            studentInfo.Add(new StudentInfo("Dija", [50, 45, 78, 94, 85]));
            studentInfo.Add(new StudentInfo("Mercy", [76, 39, 67, 55, 46]));
            studentInfo.Add(new StudentInfo("Emma", [39, 66, 75, 77, 18]));
            studentInfo.Add(new StudentInfo("Hammed", [76, 45, 78, 56, 85]));
            studentInfo.Add(new StudentInfo("Jemima", [50, 39, 67, 55, 46]));
            studentInfo.Add(new StudentInfo("Paul", [67, 66, 75, 90, 18]));

// to input studnet data through the console
Console.WriteLine("Enter number of student(s) to register.");
            int studentInfoCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentInfoCount; i++)
            {
                Console.WriteLine($"\nEnter information for student {i+1}: ");
                Console.WriteLine("Full- names: ");
                string studentInfoname = Console.ReadLine();
                Console.WriteLine("Register 5 grade scores");
                int[] GradeScore = new int[5];
                for (int j = 0; j < GradeScore.Length; j++)
                {
                  Console.WriteLine($"Enter Grade score for subject {j+1}: ");
                  GradeScore[j] = int.Parse(Console.ReadLine());  
                } 
                studentInfo.Add(new StudentInfo(studentInfoname, GradeScore));
            }


//grades and average for all students
 Console.WriteLine("---->Students Information<----");
         foreach (var student in studentInfo)
            {
                int[] lastThree = student.Grades;


                Console.WriteLine($"Full Name: {student.Name}");
                Console.WriteLine("Grade:" + string.Join(",", lastThree));
                var (names, avg) = GetStudentInfo(student);

                Console.WriteLine($"Average Grade: {avg:F2}\n");
            }




            //To remove a student data
            studentInfo.RemoveAll(s => s.Name == "Mercy");

//output for last three grades for all student
            Console.WriteLine("----Students Information with the last three gradescore----");
            foreach (var student in studentInfo)
            {
                int[] lastThree = student.Grades[2..];


                Console.WriteLine($"Full Name: {student.Name}");
                Console.WriteLine("Grade:" + string.Join(",", lastThree));
                var (names, avg) = GetStudentInfo(student);

                Console.WriteLine($"Average Grade: {avg:F2}\n");
            }


            //if you want to view last three grades for just one student

            var (name, averageGrade) = studentInfo[0].GetStudentData();


            int[] dijaAverageGradeSubset = studentInfo[0].Grades[2..];
            Console.WriteLine("First three Grades of Dija: " + string.Join(",", dijaAverageGradeSubset));

        }
    }





}


