using System;

namespace Exercise8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Write a program that picks a random number between 1 and 10.
            Give the user 4 chances to guess the number. If the user guesses the number, display “You won";
            otherwise, display “You lost".*/

            var random = new Random();

            for (var i = 0; i <= 4; i++)
            {
                Console.WriteLine("Enter an number : ");
                string num = Console.ReadLine();
                int number = Convert.ToInt32(num);
                int secretnum = random.Next(1, 10);
               // Console.WriteLine(secretnum);
                if (secretnum == number)
                {
                    Console.WriteLine("You won");
                }
                else
                {
                    Console.WriteLine("you lost, try again ");
                }
            }
            
        }
    }
}