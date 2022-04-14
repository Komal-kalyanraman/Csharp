using System.Collections.Generic;

namespace SWD_Day6
{
    public class TimeBasedMonitoring
    {
        ISensorData sensorData;
        private string result;

        public TimeBasedMonitoring(ISensorData sensorData)
        {
            this.sensorData = sensorData;
        }

        public string Run(string StartTime, string EndTime)
        {            
            int StartTimeInt = 0;
            Int32.TryParse(StartTime, out StartTimeInt);

            int EndTimeInt = 0;
            Int32.TryParse(EndTime, out EndTimeInt);

            string SocketState;
            SocketState = sensorData.SocketState();

            int CurrentTime = 0;
            Int32.TryParse(sensorData.CurrentTime(), out CurrentTime);

            if( (CurrentTime > StartTimeInt) && (CurrentTime < EndTimeInt) && (SocketState == "ON"))
            {
                result = "Socket is Switched ON during wrong time.";
            }
            else
            {
                result = "Nothing suspicious happening";
            }

            return result;
        }
    }
}