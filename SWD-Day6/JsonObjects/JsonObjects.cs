using System.Collections.Generic;

namespace SWD_Day6
{
    public class JsonObject
    {
        // Switch ON the light
        public Dictionary<string, string> SwitchOnSocket = new Dictionary<string, string>
        {
            {"address", "Socket"},
            {"state", "ON"}
        };
        
        // Switch OFF the light
        public Dictionary<string, string> SwitchOffSocket = new Dictionary<string, string>
        {
            {"address", "Socket"},
            {"state", "OFF"}
        };
    }
}