using Lecture4.Math;
using System;

namespace Lecture4
{
    public enum Shippindmethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express =3
    }
    public class NonPrimitiveType
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.firstName = "Neha";
            person.lastName = "Ambrale";
            person.Introduce();

            Calculator calculator = new Calculator();
            var result=calculator.Add(23, 34);
            Console.WriteLine(result);

            //array

            var number = new int[3] { 1, 2, 3 };
            

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);

            //string

            var fristName = "Neha";
            var lastName = "Ambarle";
            var fullName = string.Format("{0} {1}",fristName, lastName);

            var numbers = new int[3] { 1, 2, 3 };
            string list = string.Join(",", numbers);

            Console.WriteLine(fullName);
            Console.WriteLine(list);

            string path = @"hello
                            there
                             nice one";
            Console.WriteLine(path);

            //enum

            var method = Shippindmethod.Express;
            Console.WriteLine((int)method);

            var methodid = 2;
            Console.WriteLine((Shippindmethod)methodid);

           // Console.WriteLine(method);

            var methodname = "1";
           var shippingmethod = Enum.Parse(typeof(Shippindmethod), methodname);
            Console.WriteLine(shippingmethod);


            //value type and reference type 

            var a = 12;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a :{0} b: {1}", a, b));

            //refrence type
             var array1 =new int[3] {1,2,3};
            var array2 = array1;
            array2[1] = 5;
            Console.WriteLine(string.Format("array1 : {0} \n array2 :{1} ", array1[1], array2[1]));


        }
    }
}
