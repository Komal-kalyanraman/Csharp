using System.Collections.Generic;

namespace SWD_Day6
{
    public class TimeBasedMonitoring
    {
        DataCollection sensorData = new DataCollection();
        InputExtractor inputJson = new InputExtractor();

        public async Task<string> CheckUseCase()
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

            if( (CurrentTime > StartTimeInt) && (CurrentTime < EndTimeInt))
            {
                Console.WriteLine("yes");
            }

            return null;
            
        }
    }
}