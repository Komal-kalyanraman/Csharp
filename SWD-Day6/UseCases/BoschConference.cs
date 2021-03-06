using System.Collections.Generic;
using System.Threading.Tasks;

namespace SWD_Day6
{
    public class BoschConference
    {
        ISensorData sensorData;

        private string result;
        private string response;

        public BoschConference(ISensorData sensorData)
        {
            this.sensorData = sensorData;
        }

        public string Run(string Timer)
        {
            int TimerInt = 0;
            Int32.TryParse(Timer, out TimerInt);

            for(int i=0; i<5; i++)
            {
                response = sensorData.TurnOnSocket();
                Task.Delay(TimerInt*100).Wait();

                response = sensorData.TurnOffSocket();
                Task.Delay(TimerInt*100).Wait();
            }

            result = "Thanks for Watching";

            return result;
        }
    }
}