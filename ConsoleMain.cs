
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
                float depth = Camera1.CheckDepth();
                Console.WriteLine("The camera is pointing at an object " + depth + " meters away\t\n");
                
                if (Camera1.DistCheck(depth) == false)
                {
                    Console.WriteLine("The camera is not far enough from object \n");
                }
                else
                {
                    Console.WriteLine("The camera is far enough the object \n");
                }
                    
            }
        }
    }
}
