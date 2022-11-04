// See https://aka.ms/new-console-template for more information
using InheritanceTest;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

//Employee e1 = new Employee(2, "Kurt", "3434434");
//.WriteLine("Employee " + e1  + " Salary "  + e1.CalculateSalary());


Secretary s1 = new Secretary(100, "Jens Hansen", "12312312", 1000);
Console.WriteLine("Secretary " + s1.ToString() + " Salary " + s1.CalculateSalary());

Teacher t1 = new Teacher("SWD", 1, "Lone", "5454545");
Console.WriteLine("Teacher " +  t1 + " Salary " + t1.CalculateSalary());


Employee e2 = new Secretary(43, "Ulla", "45455", 600);
//int typingspeed= e2.TypingSpeed ikke muligt

Console.WriteLine($"Ullas løn { e2.CalculateSalary()}" );
e2 = new Teacher("SWD", 444, "POul", "343454");
Console.WriteLine($"Pouls løn {e2.CalculateSalary()}");
// = t1;
//Console.WriteLine($"{e2.Name} {e2.CalculateSalary()}");

//Teacher t2 = new Employee(123, "TestNAme", "43434");

List<Employee> list = new List<Employee>();
//list.Add(e1);
list.Add(s1);
list.Add(t1);
list.Add(e2);
foreach (Employee item in list)
{
    Console.WriteLine(item.Name + " løn " + item.CalculateSalary() + " pension " + item.CalculatePension());
}


IGeometryDraw g12 = new GeometryDrawV10();

