using System;

namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number : ");
            string number = Console.ReadLine();
            int v = Convert.ToInt32(number);
              if (v >1 && v < 10)
            {
                Console.WriteLine("valid");
            }
              else
            {
                Console.WriteLine("invalid");
            }
                }
    }
}
