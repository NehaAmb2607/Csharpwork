using System;

namespace RandomClass
{
    public class Progarm
    {
        public static void Main(string[] args)
        {
            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            var random = new Random();

            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var passowrd = new string(buffer);

            Console.WriteLine(passowrd);
        }
    }
}