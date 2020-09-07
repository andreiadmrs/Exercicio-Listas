using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine("How many employees will be registered?");
            int times = int.Parse(Console.ReadLine());

            for (int i = 1; i <= times; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.WriteLine("ID:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Salary:");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));

            }
            Console.WriteLine("Enter the employee id that will have salary increase :");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.WriteLine("Enter the porcentage of the increase :");
                double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(porcentage);

            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}