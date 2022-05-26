using BasicLearning.Math;
using System;
namespace BasicLearning
{
    public enum ShippingMethod
    {
        RegularAirMail =1,
        RegisteredAirMails=2,
        Express=3
    }
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

            //working with string

            var firstWord = "Something";
            var lastWord = "Don'tKnow";
            var namecon = firstWord + "" + lastWord;
            var nameformat = string.Format("{0},{1}", firstWord, lastWord);
            Console.WriteLine(nameformat);

            var names = new string[4] { "Neha", "Some", "try ", "yes" };
            var formatednames = string.Join(",", names);
            Console.WriteLine(formatednames);

            //verbatim string 
            var text = @"Hi !
            Look at the path 
             c:\project\folder";
            Console.WriteLine(text);

            //working with enum
            var method = ShippingMethod.Express;

            //cpnverting enum to int
            Console.WriteLine((int)method);

            //converting int to enum
            var methodid = 3;
            Console.WriteLine((ShippingMethod)methodid);

            //converting enum to string
            Console.WriteLine(method.ToString());

            //converting string to enum
            var methodName = "Express";
            var shippingmethod =(ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingmethod);




        }
    }
}
