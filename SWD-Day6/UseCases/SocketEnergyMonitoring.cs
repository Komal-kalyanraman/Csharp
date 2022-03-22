using System.Collections.Generic;

namespace SWD_Day6
{
    public class SocketEnergyMonitoring
    {
        DataCollection sensorData = new DataCollection();
        InputExtractor inputJson = new InputExtractor();

        public async Task<string> CheckUseCase()
        {
            string result;
            inputJson.ReadFile();

            string SocketEnergyThreshold;
            inputJson.InputData.TryGetValue("SocketEnergyThreshold", out SocketEnergyThreshold);
            int SocketEnergyThresholdInt = 0;
            Int32.TryParse(SocketEnergyThreshold, out SocketEnergyThresholdInt);

            string Timer;
            inputJson.InputData.TryGetValue("Timer", out Timer);
            int TimerInt = 0;
            Int32.TryParse(Timer, out TimerInt);
            
            result = await sensorData.TurnOnSocket();            
            return result;
        }
    }
}