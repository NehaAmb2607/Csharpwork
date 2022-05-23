using System;

namespace ProjectBasics
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Variables and constants 
            byte number =2;
            int count = 56;
            float totalprice = 1.26f;
            char character = 'W';
            string str = "Neha";
            bool isOutput = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalprice);
            Console.WriteLine(character);
            Console.WriteLine(str);
            Console.WriteLine(isOutput);
            Console.WriteLine("{0} {1}", byte.MinValue ,byte.MaxValue);

            //Type conversion

            //implicit type
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            //explicit type 

            long l = 10;
            int c = (int)l;
            Console.WriteLine(c);

            //non-compatible type

            string s = "1234";
            long f= Convert.ToInt64(s);
            Console.WriteLine(f);

            //operators

            var number1 = 10;
            var number2 = 3;

            //arithmetic operators
            Console.WriteLine(number1 + number2 );
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 / number2);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 % number2);

            //comparison operators

            Console.WriteLine(number1 == number2);
            Console.WriteLine(number1 != number2);
            Console.WriteLine(number1 > number2);
            Console.WriteLine(number1 < number2);
            Console.WriteLine(number1 >= number2);
            Console.WriteLine(number1 <= number2);

            //logical operators

            var number3 = 1;

            Console.WriteLine(number3 < number1 && number3 > number2);
            Console.WriteLine(number1 != number3 || number1 != number2);





        }
    }
}
