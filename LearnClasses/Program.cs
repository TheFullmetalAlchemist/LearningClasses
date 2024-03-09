using System;


namespace LearnClasses
{
    public class Program
    {
    public static void Main(){
        var car = new Car("XYZ1234");
    }
    }
    public class Vehicle{
        private readonly String _registrationNumber;
    //    public Vehicle()
    //    {
    //        System.Console.WriteLine("Vehicle is being initialized");
    //    }
        public Vehicle(string registrationNumber){
            _registrationNumber = registrationNumber;
            System.Console.WriteLine("vehicle number is called as {0}",registrationNumber);
        }
    }
    public class Car: Vehicle{
        public Car(string registrationNumber)
        :base(registrationNumber)
        {
            System.Console.WriteLine("Car is being initialized {0}", registrationNumber);
        }
        
    }
}