using Intel.RealSense;
using System;

namespace RealsenseTest
{
    class Program
    {
        static void Main()
        {
            Camera Camera1 = new();

            while (true)
            {
                Console.WriteLine("The camera is pointing at an object " +
                    Camera1.checkDepth() + " meters away\t");

                if (Camera1.distCheck(Camera1.checkDepth()) == false)
                    Console.WriteLine("The camera is not far enough");
                else
                    Console.WriteLine("The camera is far enough");
            }
        }
    }
}
