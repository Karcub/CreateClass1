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
}