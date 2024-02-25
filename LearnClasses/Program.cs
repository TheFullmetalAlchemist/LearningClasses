using System;
using LearnClasses;


namespace LearnClasses
{
    public class Person
    {
        public string? Name;
        public void Introduce(string To)
        {
            System.Console.WriteLine("Hi {0}, My name is {1}", To, Name);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var point = new Point(10,20);
            point.Move(new Point(40,50));
            System.Console.WriteLine("point x is at {0},{1}",point.X,point.Y);
            point.Move(100,200);
            System.Console.WriteLine("point x is at {0},{1}",point.X,point.Y);
        }
    }

}