using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SWD_Day6
{    
    public class DataCollection
    {
        SensorData Data = new SensorData();

        Http api = new Http();
        JsonObject obj = new JsonObject();
        string base_URL = "http://192.168.1.10:8080/shapi/";

        public string CurrentTime()
        {
            string TimeNow = DateTime.Now.ToString("HH");
            return TimeNow;
        }

        public string SocketEnergy()
        {
            string result = Data.SocketEnergy();
            return result;
        }
        public string SocketState()
        {
            string result = Data.SocketState();
            return result;
        }
        public string ButtonState()
        {
            string result = Data.ButtonState();
            return result;
        }
        public string Motion()
        {
            string result = Data.Motion();
            return result;
        }
        public virtual string TurnOnSocket()
        {
            string result = api.Put(base_URL, obj.SwitchOnSocket).Result;
            result = "Socket Turned ON";
            return result;
        }
        public virtual string TurnOffSocket()
        {
            string result = api.Put(base_URL, obj.SwitchOffSocket).Result;
            result = "Socket Turned OFF";
            return result;
        }
    }
}