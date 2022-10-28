// See https://aka.ms/new-console-template for more information
using InheritanceTest;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

Employee e1 = new Employee(2, "Kurt", "3434434");
Console.WriteLine("Employee " + e1  + " Salary "  + e1.CalculateSalary());


Secretary s1 = new Secretary(100, "Jens Hansen", "12312312", 1000);
Console.WriteLine("Secretary " + s1.ToString() + " Salary " + s1.CalculateSalary());

Teacher t1 = new Teacher("SWD", 1, "Lone", "5454545");
Console.WriteLine("Teacher " +  t1 + " Salary " + t1.CalculateSalary());
