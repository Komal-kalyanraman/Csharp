using System.Collections.Generic;
using Newtonsoft.Json;

namespace SWD_Day6
{
    public class InputExtractor
    {
        string path = "/home/phoenix/Desktop/Csharp/SWD-Day6/InputExtractor/UseCase.txt";
        public Dictionary<string, string> InputData = new Dictionary<string, string>();
        private string result;
        
        public class Parameters
        {
            public string UseCase { get; set; }
            public object SocketEnergyThreshold { get; set; }
            public object StartTime { get; set; }
            public object EndTime { get; set; }
            public object Timer { get; set; }
        }

        public void ReadFile()
        {
            string readText = File.ReadAllText(path); 
            Parameters myDeserializedClass = JsonConvert.DeserializeObject<Parameters>(readText);

            InputData.Add("UseCase", myDeserializedClass.UseCase.ToString());
            InputData.Add("SocketEnergyThreshold", myDeserializedClass.SocketEnergyThreshold.ToString());
            InputData.Add("StartTime", myDeserializedClass.StartTime.ToString());
            InputData.Add("EndTime", myDeserializedClass.EndTime.ToString());
            InputData.Add("Timer", myDeserializedClass.Timer.ToString());
        }

        public string UseCase()
        {
            InputData.TryGetValue("UseCase", out result);
            return result;
        }

        public string SocketEnergyThreshold()
        {
            InputData.TryGetValue("SocketEnergyThreshold", out result);
            return result;
        }

        public string StartTime()
        {
            InputData.TryGetValue("StartTime", out result);
            return result;
        }

        public string EndTime()
        {
            InputData.TryGetValue("EndTime", out result);
            return result;
        }

        public string Timer()
        {
            InputData.TryGetValue("Timer", out result);
            return result;
        }
    }
}