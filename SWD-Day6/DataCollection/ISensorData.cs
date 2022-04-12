using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Day6
{
    internal interface ISensorData
    {
        string SocketEnergy();
        string SocketState();
        string ButtonState();
        string Motion();

    }
}
