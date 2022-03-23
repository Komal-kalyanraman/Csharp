using System.Collections.Generic;
using System.Threading.Tasks;

namespace SWD_Day6
{
    public class BoschConference
    {
        DataCollection sensorData = new DataCollection();
        InputExtractor inputJson = new InputExtractor();

        private string result;
        private string response;

        public async Task<string> CheckUseCase()
        {
            inputJson.ReadFile();

            string Timer;
            inputJson.InputData.TryGetValue("Timer", out Timer);
            int TimerInt = 0;
            Int32.TryParse(Timer, out TimerInt);

            for(int i=0; i<5; i++)
            {
                response = await sensorData.TurnOnSocket();
                await Task.Delay(TimerInt*100);

                response = await sensorData.TurnOffSocket();
                await Task.Delay(TimerInt*100);
            }

            result = "Thanks for Watching";

            return result;
        }
    }
}