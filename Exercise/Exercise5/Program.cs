using System;
namespace Exercise5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*program to count how many numbers between
            1 and 100 are divisible by 3 with no remainder.*/

            int count = 0;
             for (var i=1; i<=100;i++)
            {
                if(i%3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("count of number divisible by 3 : " +count);
        }
    }
}