using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Day6
{
    public class MockSensorData : ISensorData
    {
        public string CurrentTime()
        {
            string TimeNow = "10";
            return TimeNow;
        }
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
            string threshold = "1 watt";
            return threshold;
        }

        public string SocketState()
        {
            string socketState = "ON";
            return socketState;
        }
        public string TurnOnSocket()
        {
            string socketState = "Socket Turned ON";
            return socketState;
        }
        public string TurnOffSocket()
        {
            string socketState = "Socket Turned OFF";
            return socketState;
        }
    }
}
