using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Day6
{
    public interface ISensorData
    {
        string CurrentTime();
        string SocketEnergy();
        string SocketState();
        string ButtonState();
        string Motion();
        string TurnOnSocket();
        string TurnOffSocket();
    }
}
