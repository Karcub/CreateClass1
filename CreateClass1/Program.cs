using System;

namespace CreateClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person anna = new Person("Anna", new DateTime(1990, 01, 01), Gender.Female);
            Console.WriteLine(anna);
        }
    }
}