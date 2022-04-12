using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Day6
{
    internal class MockSensorData : ISensorData
    {
        public string ButtonState()
        {
            string buttonState = "PRESSED";
            return buttonState;
        }

        public string Motion()
        {
            string motionDetected = "Yes";
            return motionDetected; 
        }

        public string SocketEnergy()
        {
            string threshold = "1";
            return threshold;
        }

        public string SocketState()
        {
            string socketState = "ON";
            return socketState;
        }
    }
}
