using SWD_Day6;
using System.Collections.Generic;

DataCollection sensorData = new DataCollection();

string energy = await sensorData.SocketEnergy();
Console.WriteLine(energy);

string SocketState = await sensorData.SocketState();
Console.WriteLine(SocketState);

string ButtonState = await sensorData.ButtonState();
Console.WriteLine(ButtonState);

string CurrentTime = sensorData.CurrentTime();
Console.WriteLine(CurrentTime);