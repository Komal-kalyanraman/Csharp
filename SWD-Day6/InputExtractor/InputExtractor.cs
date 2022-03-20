using System.Collections.Generic;
using Newtonsoft.Json;

namespace SWD_Day6
{
    public class InputExtractor
    {
        string path = "/home/phoenix/Desktop/Csharp/SWD-Day6/InputExtractor/UseCase.txt";
        Dictionary<string, string> InputData = new Dictionary<string, string>();
        
        public class Parameters
        {
            public string UseCase { get; set; }
            public object SocketEnergyThreshold { get; set; }
            public object StartTime { get; set; }
            public object EndTime { get; set; }
        }

        public void ReadFile()
        {
            try
            {
                string readText = File.ReadAllText(path); 
                Parameters myDeserializedClass = JsonConvert.DeserializeObject<Parameters>(readText);

                InputData.Add("UseCase", myDeserializedClass.UseCase.ToString());
                InputData.Add("SocketEnergyThreshold", myDeserializedClass.SocketEnergyThreshold.ToString());
                InputData.Add("StartTime", myDeserializedClass.StartTime.ToString());
                InputData.Add("EndTime", myDeserializedClass.EndTime.ToString());

                // foreach(string s in readText)
                // {
                //     // Printing the string array containing
                //     // all lines of the file.
                //     Console.WriteLine(s);
                // }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        public string UseCase()
        {
            string result;
            InputData.TryGetValue("UseCase", out result);
            return result;
        }
    }
}