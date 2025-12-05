//Grading system.

using System;
using System.Collections.Generic;
using System.Globalization;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<string> genders = new List<string>();
            List<String> ages = new List<string>();

            List<List<string>> courseNames = new List<List<string>>();
            List<List<int>> courseScores = new List<List<int>>();
            List<List<string>> courseGrades = new List<List<string>>();
            List<double> averages = new List<double>();
            List<string> finalGrades = new List<string>();

            // String grade = "";

            Console.WriteLine("Fill in the details below\n");
            Console.Write("How many students are you registering? ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Student Form {i + 1}\n");
                Console.Write("Full name: ");
                names.Add(Console.ReadLine());
                Console.Write("Gender: ");
                genders.Add(Console.ReadLine());
                Console.Write("Age: ");
                ages.Add(Console.ReadLine());

                List<string> studentCourses = new List<string>();
                List<int> studentScores = new List<int>();
                List<string> studentGrades = new List<string>();

                int total = 0;


                Console.WriteLine("Enter 5 courses and their scores: ");
                for (int k = 1; k <= 5; k++)
                {
                    Console.Write($"{k} Course name: ");

                    string course = Console.ReadLine();
                    studentCourses.Add(course);

                    int score;
                    while (true)
                    {
                        Console.Write($"Score for {course}: ");
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out score)) break;
                        else
                        {
                            Console.WriteLine("Wrong input. Please enter a numeric score.");

                        }
                    }
                    studentScores.Add(score);

                    string grade = "";
                    if (score >= 70)
                    {
                        grade = "A";
                    }
                    else if (score >= 60)
                    {
                        grade = "B";
                    }
                    else if (score >= 50)
                    {
                        grade = "C";
                    }
                    else if (score >= 40)
                    {
                        grade = "D";
                    }
                    else
                    {
                        grade = "F";
                    }
                    studentGrades.Add(grade);
                    total += score;
                }

                courseNames.Add(studentCourses);
                courseScores.Add(studentScores);
                courseGrades.Add(studentGrades);

                double average = total / 5.0;
                averages.Add(average);
                string finalGrade = "";
                if (average >= 70)
                {
                    finalGrade = "A";
                }
                else if (average >= 60)
                {
                    finalGrade = "B";

                }
                else if (average >= 50)
                {
                    finalGrade = "C";
                }
                else if (average >= 40)
                {
                    finalGrade = "D";
                }
                else
                {
                    finalGrade = "F";
                }

                finalGrades.Add(finalGrade);

            }

            //output
            Console.WriteLine("\n Students' Result Details.\n ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Name: {names[i]}\n");
                Console.WriteLine($"Gender: {genders[i]}\n");
                Console.WriteLine($"Age: {ages[i]}\n");
                Console.WriteLine("Course\t\tScore\tGrade");

                for (int k = 1; k < 5; k++)
                { 
                    Console.WriteLine($"{courseNames[i][k],-10}\t {courseScores[i][k]}\t {courseGrades[i][k]}");
                }

                Console.WriteLine($"\n Total Score:  {courseScores[i].Sum()}");
                Console.WriteLine($"\n Average Score: {averages[i]:F2}");
                Console.WriteLine($"\n Final Grade: {finalGrades[i]}");
                Console.WriteLine(new string('-', 60));
            }
        }
    }
}


