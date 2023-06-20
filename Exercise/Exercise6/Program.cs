using System;

namespace Exercise6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*program and continuously ask the user to enter a number or "ok" to exit.
            Calculate the sum of all the previously entered numbers and display it on the console.*/
            int total = 0;

            while(true)
            {

                Console.WriteLine("Enter number : ");
                string num = Console.ReadLine();

                if (num == "ok" || num == "OK" || num =="Ok" || num =="oK")
                {
                    break;
                }
                else
                {
                    int number = Convert.ToInt32(num);
                    total = total + number;
                }
                Console.WriteLine("Sum of all previously entered number : " +total);
            }
        }
    }
}
