using System;
namespace Exercise2

{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number : ");
            string num1 = Console.ReadLine();
            int number1 =Convert.ToInt32(num1);

            Console.WriteLine("enter 2nd number : ");
            string num2 =Console.ReadLine();
            int number2 =Convert.ToInt32(num2);
 
             if (number1 > number2)
            {
                Console.WriteLine("Number 1 is max");
            }
             else
            {
                Console.WriteLine("Number 2 is max");
            }
        }
    }
}
