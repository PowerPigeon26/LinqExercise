using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("----------Sum of Array Numbers--------");
            Console.WriteLine($"| {numbers.Sum()}");
            Console.WriteLine("--------------------------------------");

            //TODO: Print the Average of numbers
            Console.WriteLine("--------Average of Array Numbers------");
            Console.WriteLine($"| {numbers.Average()}");
            Console.WriteLine("--------------------------------------");

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("--------Sort to Ascending Order-------");
            numbers.OrderBy(x => x).ToList().ForEach(number => Console.WriteLine($"| {number} "));
            Console.WriteLine("--------------------------------------");

            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("--------Sort to Descending Order------");
            numbers.OrderByDescending(x => x).ToList().ForEach(number => Console.WriteLine($"| {number} "));
            Console.WriteLine("--------------------------------------");

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("------------Greater than Six----------");
            numbers.Where(x => x > 6).ToList().ForEach(number => Console.WriteLine($"| {number} "));
            Console.WriteLine("--------------------------------------");

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("--------Sort and print only four------");
            numbers.OrderByDescending(x => x).Take(4).ToList().ForEach(number => Console.WriteLine($"| {number} "));
            Console.WriteLine("--------------------------------------");

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("----Change Index 4 to Age and Sort----");
            numbers[4] = 28;
            numbers.OrderByDescending(x => x).ToList().ForEach(number => Console.WriteLine($"| {number} "));
            Console.WriteLine("--------------------------------------");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName
            //starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("----Print All Emplyee Names Starting with C or S in Descending Order----");
            employees.Where(x => (x.FirstName[0] == 'C') || (x.FirstName[0] == 'S')).OrderBy(x => x.FirstName).ToList().
                ForEach(x => Console.WriteLine($"| {x.FullName} "));
            Console.WriteLine("------------------------------------------------------------------------");

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and
            //order this by Age first and then by FirstName in the same result.
            Console.WriteLine("----Print All Employee Names and Ages Over 26 and Sort by Age then by Firstname----");
            employees.Where(x => (x.Age > 26)).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().
                ForEach(x => Console.WriteLine($"| {x.FullName}, Age {x.Age} "));
            Console.WriteLine("-----------------------------------------------------------------------------------");

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal
            //to 10 AND Age is greater than 35.
            Console.WriteLine("----Sum of YOE for Employees with YOE <= to 10 and Age > 35----");
            Console.WriteLine($"| Sum: {employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience)}");
            Console.WriteLine("---------------------------------------------------------------");

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than
            //or equal to 10 AND Age is greater than 35.
            Console.WriteLine("----Average of YOE for Employees with YOE <= to 10 and Age > 35----");
            Console.WriteLine($"| Sum: " +
                $"{employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience)}");
            Console.WriteLine("-------------------------------------------------------------------");

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("----Add an Employee to the list without using .Add()----");
            employees.Append(new Employee("Ratchet &", "Clank", 23, 2)).OrderBy(x => x.Age).ToList().
                ForEach(x => Console.WriteLine($"| {x.FullName}, Age {x.Age} "));
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
