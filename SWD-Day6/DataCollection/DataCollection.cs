using System;
using System.Collections.Generic;

namespace SWD_Day6
{    
    public class DataCollection
    {
        string TimeNow = DateTime.Now.ToString("HH");
        public string SensorValue = "";
        
        public string CurrentTime()
        {
            //Console.WriteLine(TimeNow);
            return TimeNow;
        }

        public string SensorState()
        {            
            Console.WriteLine(SensorValue);
            return SensorValue;
        }

    }
}