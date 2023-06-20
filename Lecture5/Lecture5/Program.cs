using System;

namespace Lecture5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int hour = 10;
            //If-else

            if(hour >0 && hour < 12)
            {
                Console.WriteLine("it is morning");
            }
            else if (hour >12 && hour <18)
            {
                Console.WriteLine("it is afternoon");
            }
            else
            {
                Console.WriteLine("it is evening");
            }

            //switch case

            var season = Season.Winter;
            switch(season)
            {
                case Season.Spring:
                    Console.WriteLine("Spring");
                    break;

                case Season.Winter:
                    Console.WriteLine("Winter");
                    break;

                default:
                    Console.WriteLine("Don't know");
                    break;
            }
        
        }

    }
    

}
