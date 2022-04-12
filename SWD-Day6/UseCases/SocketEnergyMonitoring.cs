using System.Collections.Generic;
using System.Threading.Tasks;

namespace SWD_Day6
{
    public class SocketEnergyMonitoring
    {
        DataCollection sensorData = new DataCollection();
        InputExtractor inputJson = new InputExtractor();
        private string result;

        public string CheckUseCase()
        {
            inputJson.ReadFile();

            string SocketEnergyThreshold;
            inputJson.InputData.TryGetValue("SocketEnergyThreshold", out SocketEnergyThreshold);
            int SocketEnergyThresholdInt = 0;
            Int32.TryParse(SocketEnergyThreshold, out SocketEnergyThresholdInt);

            string Timer;
            inputJson.InputData.TryGetValue("Timer", out Timer);
            int TimerInt = 0;
            Int32.TryParse(Timer, out TimerInt);

            string SocketEnergy;
            SocketEnergy = sensorData.SocketEnergy();
            int SocketEnergyInt = 0;
            Int32.TryParse(SocketEnergy, out SocketEnergyInt);
            
            if(SocketEnergyInt > SocketEnergyThresholdInt)
            {
                result = sensorData.TurnOffSocket();
                Task.Delay(TimerInt*60*1000).Wait();
            }
            else
            {
                result = "Socket power below threshold";
            }
            
            return result;
        }
    }
}