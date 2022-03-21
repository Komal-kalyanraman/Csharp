using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SWD_Day6
{    
    public class DataCollection
    {
        Http api = new Http();
        string base_URL = "http://192.168.1.10:8080/shapi/";

        public string CurrentTime()
        {
            string TimeNow = DateTime.Now.ToString("HH");
            return TimeNow;
        }

        // https://json2csharp.com/json-to-csharp
        public class Parameters
        {
            public string type { get; set; }
            public string state { get; set; }
            public double power { get; set; }
            public string id { get; set; }
            public bool motionDetected { get; set; }
        }

        public async Task<string> SocketEnergy()
        {
            string JsonDataNew = await ExtractJson("state?identifier=SocketEnergy");
            Parameters myDeserializedClass = JsonConvert.DeserializeObject<Parameters>(JsonDataNew);
            string SocketEnergy = myDeserializedClass.power.ToString() + " watt";
            return SocketEnergy;
        }

        public async Task<string> SocketState()
        {
            string JsonDataNew = await ExtractJson("state?identifier=Socket");
            Parameters myDeserializedClass = JsonConvert.DeserializeObject<Parameters>(JsonDataNew);
            string SocketState = myDeserializedClass.state.ToString();
            return SocketState;
        }

        public async Task<string> ButtonState()
        {
            string JsonDataNew = await ExtractJson("state?identifier=Button");
            
            if(JsonDataNew.Length == 259)
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

        public async Task<string> Motion()
        {
            string JsonDataNew = await ExtractJson("state?identifier=Motion");
            int startIndex = 63;
            int endIndex = JsonDataNew.Length - startIndex;
            string MotionJson = JsonDataNew.Substring(startIndex, endIndex);
            Parameters myDeserializedClass = JsonConvert.DeserializeObject<Parameters>(MotionJson);
            string Motion = myDeserializedClass.motionDetected.ToString();
            return Motion;
        }

        public async Task<string> ExtractJson(string sensor_url)
        {
            string JsonData = await api.Get(base_URL + sensor_url);
            string JsonDataNew = JsonData.Substring(1, JsonData.Length - 2);
            return JsonDataNew;
        }

    }
}