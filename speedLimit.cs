using System;

namespace SpeedLimit
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter speed limit.");

            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter car speed.");

            var speedCar = Convert.ToInt32(Console.ReadLine());

            if (speedCar <= speedLimit)
            {
                Console.WriteLine("Your car speed is OK!");
            }

            else if (speedCar > speedLimit)
            {
                var demeritPoints = (speedCar - speedLimit) / 5;
                Console.WriteLine(demeritPoints);

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended!");
                }
            }

            Main();
        }
    }
}
