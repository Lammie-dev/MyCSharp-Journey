using System;
using System.Collections.Generic;
using System.Linq;

class Report
{
    public string Name { get; set; }

    public Dictionary<string, int> Subjects { get; set; }
    public Report(string name)
    {
        Name = name;
        Subjects = new Dictionary<string, int>();
    }
}

class Program
{
    static double CalculateAverage(Dictionary<string, int> Subjects)
    {
        return Subjects.Values.Average();
    }
    static string GetGrades(double average)

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
        List<Report> reports = new List<Report>();
        while (true)
        {
            string name;
            do
            {
                Console.WriteLine("Enter Student name: ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name space must not be empty!");
                }
            }
            while (string.IsNullOrEmpty(name));
            Report report = new Report(name);

            for (int i = 1; i <= 3; i++)
            {
                string subject;
                do
                {
                    Console.WriteLine($"\nEnter Subject {i} name");
                    subject = Console.ReadLine();
                    if (string.IsNullOrEmpty(subject))
                    {
                        Console.WriteLine("Subject space must not be empty!");
                    }
                } while (string.IsNullOrEmpty(subject));
                int score = 0;
                while (true)
                {
                    Console.WriteLine($"Enter score for {subject} ");
                    string input = Console.ReadLine();
                    if
                    (int.TryParse(input, out score) && score != 0 && score != 100) break;
                    {
                        Console.WriteLine("\nInvalid input! Enter number between 0 and 100. ");
                    }

                }
                report.Subjects[subject] = score;

            }
            reports.Add(report);
            Console.WriteLine("\n Do you want to continue?");
            string choice = Console.ReadLine().Trim().ToLower();
            if (choice != "yes")
            {
                break;
            }

        }
        //output
        Console.WriteLine("\n ---Student Report Card---");
        foreach (var report in reports)
        {
            Console.WriteLine($" Student name: {report.Name}");
            Console.WriteLine("Subjects and Score: ");
            foreach (var subject in report.Subjects)
            {
                Console.WriteLine($"- {subject.Key}: {subject.Value}");
            }

            double avg = CalculateAverage(report.Subjects);
            string Grades = GetGrades(avg);
            Console.WriteLine($"\nAverage score is: {avg:F2}");
            Console.WriteLine($"\nAverage Grade is: {Grades}");


//TO SHOW THE LAST SUBJECT AND SCORE
            var lastSubject = report.Subjects.Skip(2).ToArray();
            Console.WriteLine("Last subject in the list: ");
            foreach (var item in lastSubject)
            {
                Console.WriteLine($"- {item.Key}: {item.Value}");
            }
            //TO SHOW ALL NUMBERS BELOW 50
            var subjects = report.Subjects
            .Where(s => s.Value < 50)
            .ToDictionary(s => s.Key, s => s.Value);

            Console.WriteLine($"These are the subjects score below 50:");
            foreach (var item in subjects)
            {
                Console.WriteLine($" {item.Key} {item.Value} ");
            }

        }

    }
}


// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using System.Linq;
// namespace ContactBooks
// {
//   class ContactBook
//   {
//     public string Name;
//     public long Phone;
//     public string Email;
//     public ContactBook(string name, long phone, string email)
//     {
//       Name = name;
//       Phone = phone;
//       Email = email;
//     }
//   }
//   class Program
//   {
//     static void Main()
//     {
//       // List<ContactBook> contactBooks = new List<ContactBook>();
//       // while (true)
//       // {
//       //   ContactBook contactBook = new ContactBook();
//       // }
















//       List<ContactBook> contactBooks = new List<ContactBook>();


//       while (true)

//       {
//         string name;
//         long phone = 0;
//         string email ="";
        
    


//           Console.Write("Contact Name: ");
//           name = Console.ReadLine();



//           System.Int64 pnum;




//         ContactBook contactBook = new ContactBook(name,phone,email);
//         contactBook.Phone = phone;
//             Console.Write("Contact Number: ");
//             string input = Console.ReadLine();

//         if (long.TryParse(input, out phone) && input.Length == 10)

//           contactBooks.Add(contactBook);

//         else
//         {
//           Console.WriteLine("Invalid input! Enter number not more than 10 digits.");
//         }
          
          
          
//             Console.Write("Email: ");
//             email = Console.ReadLine();


          
//           // string email;


//           Console.WriteLine("Press show to view all contacts or press any key to continue. ");
//           string choice = Console.ReadLine();
//         if (choice != "show")
//         {
//           contactBooks.Add(contactBook);
//         }



//           //to display all contacts
//           Console.WriteLine("CONTACTS LIST ");
//           Console.WriteLine("\nContact name\t\tContact number\tContact email");
//           Console.WriteLine(new string('-', 60));

//           Console.Write($"-  {name}\t");
//           Console.Write($"- {phone}\t");
//           Console.Write($"- {email}\t");

        



        





//       }

//     }
//   }
// }




 // foreach (var item in contactBooks)
          // {
          //   Console.WriteLine("item");
          // }





          //  foreach (var contactBook in contactBooks)

          //             Console.WriteLine($"\n Contacts list:\n {contactBook.Name}\t{contactBook.Phone}\t{contactBook.Email}");

          // var contactBookk = contactBook.Name[name];
          // var contactBookk = contactBooks.Phone;
          // foreach (var contactBook in contactBookk)


          //  foreach (var contactBook in contactBookk)

          //   {
          //     Console.WriteLine("\nContact name\t\tContact number\tContact email");
          //     Console.WriteLine($"\n Contacts list:\n {contactBook.Name}\t{contactBook.Phone}\t{contactBook.Email}");

          //   } 

  // ContactBook contactBook = new ContactBook(name, phone, email);

            // contactBooks.Add(contactBook);