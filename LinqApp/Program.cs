using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
namespace MyOrganization
{
    public struct Employee
    {
        public Dictionary<int, string> Employees { get; set; }
        public Employee()
        {
            Employees = new Dictionary<int, string>();
        }
    }
    class Department
    {
        public Dictionary<int, string> Departments { get; set; }

        public Dictionary<int, int> EmployeeDepartments { get; set; }
public Employee DepartmentEmployee { get; set; }
        public Department(Employee employee)
        {
            DepartmentEmployee = employee;
            Departments = new Dictionary<int, string>();
            EmployeeDepartments = new Dictionary<int, int>();
        }
    }
    public class Program
    {
        static void Main()
        {
            // List<Employee> employees = new List<Employee>();

            Employee employee = new Employee();
            Department department = new Department(employee);


            Console.WriteLine("------------Employees Details------------");
            // while (true)
            // {


                Console.Write("Employee ID: ");

                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Employee Name: ");
                string name = Console.ReadLine();
                Console.Write("Department ID: ");
                int dID = Convert.ToInt32(Console.ReadLine());




                // List<Department> departments = new List<Department>();
                int ID = dID;

                Console.WriteLine("\n Enter Departments Information\n");
                Console.Write("Department ID: ");
                ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Department Name: ");
                string dName = Console.ReadLine();



                employee.Employees[id] = name;
                department.Departments[dID] = dName;
                department.EmployeeDepartments[ID] = dID;


                // Console.Write("Press X to exit or C to continue. ");
                // string choice = Console.ReadLine();
                // if (choice.ToLower() != "c")
                    // break;

            // }
                Console.WriteLine("Staff Information");
                foreach (var emp in employee.Employees)
                {
               int empId = emp.Key;
                string empName = emp.Value;
                int DeptId = department.Departments.ContainsKey(empId) ?
                 department.EmployeeDepartments[empId] : -1;
                string DeptName = department.Departments.ContainsKey(DeptId) ?
                department.Departments[DeptId] : "unknown";
                    Console.WriteLine($"Employee ID: {empId}Employee Name: {empName} | Department ID: {DeptId} Department Name: {DeptName}");
                }
                // var query = from e in employee.Employees
                //             join ed in department.EmployeeDepartments on e.Key equals ed.Value
                //             join d in department.Departments on ed.Value equals d.Key
                //             select new
                //             {
                                
                //             };
            
                
            }
        }
    }












