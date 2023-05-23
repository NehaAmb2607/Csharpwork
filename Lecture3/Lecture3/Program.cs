using System;

namespace Typeconversion
{
 class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        byte b = (byte)i;
        Console.WriteLine(b);

            //non compatible type
            try
            {
                var s = "1234";
                byte num = Convert.ToByte(s);
                Console.WriteLine(num);
            }
            catch (Exception)
            {
                Console.WriteLine("Size issue");
            }

            //opertors

            var num1 = 10;
            var num2 = 5;
            //Arithmetic
            Console.WriteLine(num1+num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);

            //Comparison 

            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 >= num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 <= num2);



        }
    }
}
