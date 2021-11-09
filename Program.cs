using System.Collections.Generic;
using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {

        static List<Employee> GetEmployees()
        {


            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                // Create a new Employee instance
                Employee currentEmployee = new Employee(input, "Smith");
                employees.Add(currentEmployee);

            }
            // This is important!
            return employees;
        }

        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].GetName());
            }
        }
        static void Main(string[] args)
        {
            // This is our employee-getting code now
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }


    }
}
