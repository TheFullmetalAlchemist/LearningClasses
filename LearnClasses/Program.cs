using System;

namespace LearnClasses
{
    public class Person
    {
        private DateTime _birthdate;

        // Use PascalCase for method names
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        // Use PascalCase for method names
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1982, 1, 1)); // Correct the capitalization of DateTime
            Console.WriteLine(person.GetBirthdate()); // Use Console instead of System.Console
        }
    }
}
