using System;


namespace Learnclasses 
{
    public class Person
{
    public string ? Name;
    public void Introduce(string To)
    {
        System.Console.WriteLine("Hi {0}, My name is {1}",To,Name);
    }
    public static Person Parse(string str){
        var person = new Person();
        person.Name = str;
        return person;
    }
}
class Program
{
 static void Main(string[] args)
    {
        var person = Person.Parse("John");
        person.Introduce("Mosh");
    }
  }
}