using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intel.RealSense;
using AForge.Video;
using AForge.Video.DirectShow;

namespace RealsenseTest
{
    public class Camera
    {
        private float cameraDepth;

        public float CheckDepth()
        {
            var pipe = new Pipeline();
            pipe.Start();

            while (true)
            {
                using var frames = pipe.WaitForFrames();
                using var depth = frames.DepthFrame;
                Console.SetCursorPosition(0, 0);
                cameraDepth = depth.GetDistance(depth.Width / 2, depth.Height / 2);
                return cameraDepth;
            }
        }

        public bool DistCheck(float depth)
        {
            while(true)
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
    public class QR
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice CaptureDevice;

        private void Load()
        {
           /* filterInfoCollection = new FilterInfoCollection(cameraName);
            * foreach (FilterInfo filterinfo in filterInfoCollection)
            *   cboDevice.Items.Add(filterInfo.Name);
            * cboDevice.SelectedIndex=0;
            * 
            */
        }

        private void Start()
        {
            /* cameraName = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
             * captureDevice.NewFrame += CaptureDevice_NewFrame;
             * captureDevice.Start();
             */
        }

        private void Stop()
        {
            /* if (captureDevice.IsRunning)
             *     captureDevice.Stop();
             */
        }
    }
}
