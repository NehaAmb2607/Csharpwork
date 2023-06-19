using System;

namespace Exercise4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the speed limit");
             string SpeedLimit = Console.ReadLine();
            int speedLimit =Convert.ToInt32(SpeedLimit); ;

            Console.WriteLine("Please enter the speed of car");
            string CarSpeed =Console.ReadLine();
            int carSpeed =Convert.ToInt32(CarSpeed);

            

           if(carSpeed > speedLimit)
            {
                int demerits = 0;
                int speedDiff = carSpeed - speedLimit;
                int speedcheck = speedDiff / 5;
                if(speedcheck >12)
                    Console.WriteLine("Lience Suspended");
                else
                    Console.WriteLine("Your demrites :" +speedcheck);
            }
           else
            {
                Console.WriteLine("OK");
            }

        }
    }
}