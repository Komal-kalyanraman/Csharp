using System.Collections.Generic;
using System.Threading.Tasks;

namespace SWD_Day6
{
    public class GrannySleepMonitoring
    {
        DataCollection sensorData = new DataCollection();
        InputExtractor inputJson = new InputExtractor();

        private string result;

        public string CheckUseCase()
        {
            inputJson.ReadFile();

            string StartTime;
            inputJson.InputData.TryGetValue("StartTime", out StartTime);
            int StartTimeInt = 0;
            Int32.TryParse(StartTime, out StartTimeInt);

            string EndTime;
            inputJson.InputData.TryGetValue("EndTime", out EndTime);
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