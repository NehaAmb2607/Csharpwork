using System;

namespace ReferencetypeValueType
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        { 
            //value type
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a :{0} b :{1}",a,b));

            //refernce type

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 4;
            Console.WriteLine(string.Format("array1 :{0}  array2 :{1}",array1[0],array2[0]));

            //value type

            var number = 1;
            Increment(number);
            Console.WriteLine(number); //value will be 1 as it memory allocated in stack

            //refrence type

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);//value will be updated as memory allocated in heap
        }
        public static void Increment (int number)
        {
            number += 10;
        }
        public static void MakeOld (Person person)
        {
            person.Age += 10; 
        }
    }
}
