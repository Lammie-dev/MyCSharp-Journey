using System;
using System.Linq;
namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // string fname = "";
            // string lname= "";
            Console.WriteLine("First Name:");
            var fName = Console.ReadLine();

            Console.WriteLine("Last Name:");
            
            var lName = Console.ReadLine();
            Console.WriteLine("Gender:");
            var gender = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Courses offered\n Instruction: Enter any five courses offered and input your score below.");
           
            Console.WriteLine("Enter your course...");
            var course =(Console.ReadLine());
// char[] grade = {'A', 'B', 'C', 'D', 'F' };
            Console.WriteLine("Input your score");
            int score = Convert.ToInt32(Console.ReadLine());
int total = 0;
total += score;




            if (score<=39)
            {
                Console.WriteLine("Grade: F");
            }
            else if (score>=40)
            {
                Console.WriteLine("Grade: D");

            }

            else if (score>=50)
            {
                Console.WriteLine("Grade: C.");
            }
            else if (score>=60)
            {
                Console.WriteLine("Grade: B.");
            }
            else if (score>=80)
            {
                Console.WriteLine("Grade: A.");
            }
            else
            {
                Console.WriteLine("You have not input your score.");
            }
            var grade = "";
             Console.WriteLine("Your grade is:" + grade);
            double avgScore = Convert.ToInt64(Console.ReadLine());
            string studentDetails = $"Student Details:\n Full Name:{fName} {lName}\n Gender:{gender}\n Age:{age}\nCourses offered\n Instruction: Enter any five courses offered and input your score below.\n {course} {score} {grade} {avgScore}";
            Console.WriteLine(studentDetails);



            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
