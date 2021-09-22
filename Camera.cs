using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intel.RealSense;

namespace RealsenseTest
{
    class Camera
    {
        public float checkDepth()
        {
            var pipe = new Pipeline();
            pipe.Start();

            while (true)
            {
                using var frames = pipe.WaitForFrames();
                using var depth = frames.DepthFrame;
                Console.SetCursorPosition(0, 0);

                return depth.GetDistance(depth.Width / 2, depth.Height / 2);
            }
        }

        public bool distCheck(float depth)
        {

            if (depth <= 0.5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
