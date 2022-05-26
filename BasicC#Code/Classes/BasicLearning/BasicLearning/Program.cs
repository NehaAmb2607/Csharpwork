using BasicLearning.Math;
using System;
namespace BasicLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object of class Person
            Person person = new Person();
            person.FirstName = "Neha";
            person.LastName = "Ambrale";
            person.Introduction();

            //creating static methods without obj creation

            var result = Calculator.Addition(23, 74);
            Console.WriteLine("addition is " +result);
        }
    }
}
