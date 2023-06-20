using System;

namespace Lecture5LoopStatement
{
    public class Program
{
        public static void Main(string[] args)
        {
            //for loop
             for (var i= 1; i <= 10; i++)
            {
                if(i% 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //foreach loop
            string name = "Neha Ambrale";
            foreach(var charcter in name)
            {
                Console.WriteLine(charcter);
            }

            //while loop (echo name example with break and continue statement)

            while(true)
            {
                Console.Write("Type your name :");
                string input = Console.ReadLine();

                if ( !String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Echo name :" + input);
                    continue;
                }
                    break;
               
            }


        }

    }

}
