using System.Collections.Generic;
using System.Threading.Tasks;

namespace SWD_Day6
{
    public class SocketEnergyMonitoring
    {
        ISensorData sensorData;
        private string result;

        public SocketEnergyMonitoring(ISensorData sensorData)
        {
            this.sensorData = sensorData;
        }

        public string Run(string Timer, string SocketEnergyThreshold)
        {
            int SocketEnergyThresholdInt = 0;
            Int32.TryParse(SocketEnergyThreshold, out SocketEnergyThresholdInt);

            int TimerInt = 0;
            Int32.TryParse(Timer, out TimerInt);

            string SocketEnergy;
            SocketEnergy = sensorData.SocketEnergy();
            int SocketEnergyInt = 0;
            Int32.TryParse(SocketEnergy, out SocketEnergyInt);
            
            if(SocketEnergyInt > SocketEnergyThresholdInt)
            {
                result = sensorData.TurnOffSocket();
                result = "Socket power crossed threshold";
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