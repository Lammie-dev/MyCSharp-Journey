// Employee Management System
using System;
using System.Collections.Generic;
namespace EmployeeSystem
{
    class Program
    {

        enum Role
        {
            Manager,
            Engineer,
            Technician,
            Clerk

        }
        struct ContactInfo
        {
            public string Email;
            public int Phone;
            public ContactInfo(string email, int phone)
            {
                Email = email;
                Phone = phone;
            }
        }
        class Employee
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public ContactInfo EmployeeContactInfo { get; set; }
            public Role EmployeeRole { get; set; }

            public Employee(int id, string name, Role role, ContactInfo contactInfo)
            {
                ID = id;
                Name = name;
                EmployeeRole = role;
                EmployeeContactInfo = contactInfo;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"\nID: {ID} ");
                Console.WriteLine($"Full Name: {Name}");
                Console.WriteLine($"Phone Number: {EmployeeContactInfo.Phone}");
                Console.WriteLine($"Email: {EmployeeContactInfo.Email}");
                Console.WriteLine($"Role: {EmployeeRole}");
                Console.WriteLine(new string('-', 30));

            }

        }

        class Programs
        {
            static void Main()
            {
                List<Employee> employees = new List<Employee>();
                Console.WriteLine("Kindly fill in employee's data below:");
                Console.WriteLine("How many employee do you want to register?");
                int num = int.Parse(Console.ReadLine());

                
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine($"Enter Employee {i} Data");
                    Console.WriteLine("Full Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Phone Number: ");

                    int phone;
                    while (true)
                    {
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out phone)) break;



                        //  && (input.Length == 10)
                        // 
                        // && (input.StartsWith("70") || 
                        // input.StartsWith("80") || input.StartsWith("90") || input.StartsWith("81") ||
                        // input.StartsWith("91") ))

                        else
                        {

                            Console.WriteLine("Invalid Input! Enter 9 digits number like 802500078.");
                        }
                    }




                    // int phone = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Email: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Select Employee Role (0 = Manager, 1 = Engineer, 2 = Technician, 3 = Clerk): ");
                    int roleInput = int.Parse(Console.ReadLine());
                    Role empRole = (Role)roleInput;
                    ContactInfo contactInfo = new ContactInfo(email, phone);
                    Employee emp = new Employee(i, name, empRole, contactInfo);
                    employees.Add(emp);

                }
                Console.WriteLine("\n---All Employees Data----");
                foreach (var emp in employees)
                {
                    emp.DisplayInfo();
                }

// var index = names.IndexOf("Felipe");
// if (index == -1)
// {
//     Console.WriteLine($"When an item is not found, IndexOf returns {index}");
// }
// else
// {
//     Console.WriteLine($"The name {names[index]} is at index {index}");
// }

// index = names.IndexOf("Not Found");
// if (index == -1)
// {
//     Console.WriteLine($"When an item is not found, IndexOf returns {index}");
// }
// else
// {
//     Console.WriteLine($"The name {names[index]} is at index {index}");
// }
            }
        }
    }

}

