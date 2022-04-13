
using Newtonsoft.Json;

namespace SWD_Day6
{
    public class SensorData : ISensorData
    {
        Http api = new Http();
        JsonObject obj = new JsonObject();
        string base_URL = "http://192.168.1.10:8080/shapi/";

        public class Parameters
        {
            public string type { get; set; }
            public string state { get; set; }
            public double power { get; set; }
            public string id { get; set; }
            public bool motionDetected { get; set; }
        }

        public string CurrentTime()
        {
            string TimeNow = DateTime.Now.ToString("HH");
            return TimeNow;
        }

        public string SocketEnergy()
        {
            string JsonDataNew = ExtractJson("state?identifier=SocketEnergy");
            Parameters myDeserializedClass = JsonConvert.DeserializeObject<Parameters>(JsonDataNew);
            string SocketEnergy = myDeserializedClass.power.ToString() + " watt";
            return SocketEnergy;
        }

        public string SocketState()
        {
            string JsonDataNew = ExtractJson("state?identifier=Socket");
            Parameters myDeserializedClass = JsonConvert.DeserializeObject<Parameters>(JsonDataNew);
            string SocketState = myDeserializedClass.state.ToString();
            return SocketState;
        }

        public string ButtonState()
        {
            string JsonDataNew = ExtractJson("state?identifier=Button");

            if (JsonDataNew.Length == 259)
            {
                return "RELEASED";
            }
            else
            {
                Parameters myDeserializedClass = JsonConvert.DeserializeObject<Parameters>(JsonDataNew);
                string ButtonState = myDeserializedClass.state.ToString();
                return ButtonState;
            }
        }

        public string Motion()
        {
            string JsonDataNew = ExtractJson("state?identifier=Motion");
            int startIndex = 63;
            int endIndex = JsonDataNew.Length - startIndex;
            string MotionJson = JsonDataNew.Substring(startIndex, endIndex);
            Parameters myDeserializedClass = JsonConvert.DeserializeObject<Parameters>(MotionJson);
            string Motion = myDeserializedClass.motionDetected.ToString();
            return Motion;
        }

        public virtual string ExtractJson(string sensor_url)
        {
            string JsonData = api.Get(base_URL + sensor_url).Result;
            string JsonDataNew = JsonData.Substring(1, JsonData.Length - 2);
            return JsonDataNew;
        }

        public string TurnOnSocket()
        {
            string result = api.Put(base_URL, obj.SwitchOnSocket).Result;
            result = "Socket Turned ON";
            return result;
        }

        public string TurnOffSocket()
        {
            string result = api.Put(base_URL, obj.SwitchOffSocket).Result;
            result = "Socket Turned OFF";
            return result;
        }
    }
}
