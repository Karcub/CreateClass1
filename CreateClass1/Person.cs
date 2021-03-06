using System;

namespace CreateClass1
{
    public class Person
    {
        public string Name;
        public DateTime BirthDay;
        public Gender Gender;

        public Person(string name, DateTime birthDay, Gender gender)
        {
            Name = name;
            BirthDay = birthDay;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(BirthDay)}: {BirthDay}, {nameof(Gender)}: {Gender}";
        }
    }
    
    public enum Gender
    {
        Male,
        Female
    }
    
    class Employee : Person, ICloneable
    {
        public int Salary;
        public string Profession;
        public Room Room;


        public Employee(string name, DateTime birthDay, Gender gender, int salary, string profession) : base(name, birthDay, gender)
        {
            Salary = salary;
            Profession = profession;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Salary)}: {Salary}, {nameof(Profession)}: {Profession}, {nameof(Room)}: {Room.Number}";
        }

        // public object Clone()
        // {
        //     return this.MemberwiseClone();
        // }
        
        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }
    }
    
    public class Room
    {
        public int Number;


        public Room(int number)
        {
            Number = number;
        }
    }
}