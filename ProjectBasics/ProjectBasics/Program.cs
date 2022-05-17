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
        }
    }
}
