using System;

namespace Exercise7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Compute the factorial of the number and print it on the console

            Console.WriteLine("Enter number : ");
            string num = Console.ReadLine();
            int number = Convert.ToInt32(num);
            int fact = 1;
           for(var i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of" +number+"! =" +fact);
        }
    }
}
