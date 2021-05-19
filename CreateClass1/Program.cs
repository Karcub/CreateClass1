using System;

namespace CreateClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person anna = new Person("Anna", new DateTime(1990, 01, 01), Gender.Female);
            Employee employee1 = new Employee("Pisti", DateTime.Now, Gender.Male, 2000, "scum artist");
            employee1.Room = new Room(666);
            Console.WriteLine(employee1);
        }
    }
}