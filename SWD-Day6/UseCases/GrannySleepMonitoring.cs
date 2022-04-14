using System.Collections.Generic;
using System.Threading.Tasks;

namespace SWD_Day6
{
    public class GrannySleepMonitoring
    {
        ISensorData sensorData;

        private string result;

        public GrannySleepMonitoring(ISensorData sensorData)
        {
            this.sensorData = sensorData;
        }

        public string Run(string StartTime, string EndTime)
        {
            int StartTimeInt = 0;
            Int32.TryParse(StartTime, out StartTimeInt);

            int EndTimeInt = 0;
            Int32.TryParse(EndTime, out EndTimeInt);

            int CurrentTime = 0;
            Int32.TryParse(sensorData.CurrentTime(), out CurrentTime);

            string ButtonState = sensorData.ButtonState();
            string SocketState = sensorData.SocketState();

            if(ButtonState == "PRESSED")
            {
                if( (CurrentTime > StartTimeInt) && (CurrentTime < EndTimeInt))
                {
                    result = "Granny is sleeping on bed";
                }
            }
            else
            {
                if( (CurrentTime > StartTimeInt) && (CurrentTime < EndTimeInt))
                {
                    result = "Granny is not on bed";
                }
                else
                {
                    result = "Granny sleep time is over. She is out of bed";
                }
            }

            return result;
        }
    }
}