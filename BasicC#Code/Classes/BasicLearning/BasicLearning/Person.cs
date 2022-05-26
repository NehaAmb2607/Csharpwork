using System;

namespace BasicLearning
{
    public class Person
    {
        public String FirstName;
        public String LastName;
        public void Introduction ()
        {
            Console.WriteLine("Hi , My name is "+FirstName +" " +LastName);
        }
    }
}
