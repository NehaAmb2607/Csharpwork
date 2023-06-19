using System;

namespace Exercise3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the height : ");
            string h = Console.ReadLine();
            int height = Convert.ToInt32(h);

            Console.WriteLine("Enter the width : ");
            string w = Console.ReadLine();
            int width = Convert.ToInt32(w);

            if(height == 1920 && width == 1080)
            {
                Console.WriteLine("the image is landscape");
            }
            else
            {
                Console.WriteLine("the image is portrait");
            }
        }
    }
}