using SWD_Day6;
using System.Collections.Generic;

Http api = new Http();
JsonObject obj = new JsonObject();
DataCollection sensorData = new DataCollection();

string base_URL = "http://192.168.1.10:8080/shapi/";

string ret1 = await api.Put(base_URL, obj.SwitchOnSocket);
Console.WriteLine(ret1);

// string ret2 = await api.Put(control_URL, obj.SwitchOffSocket);
// Console.WriteLine(ret2);

string ret3 = await api.Get(base_URL+"state?identifier=Button");
Console.WriteLine(sensorData.SensorState());
//Console.WriteLine(ret3);

string ret4 = await api.Get(base_URL+"state?identifier=SocketEnergy");
Console.WriteLine(sensorData.SensorState());
//Console.WriteLine(ret4);

string ret5 = await api.Get(base_URL+"state?identifier=Socket");
Console.WriteLine(sensorData.SensorState());
//Console.WriteLine(ret5);

//string data = sensorData.SensorState().ToString();
//Console.WriteLine(data);
Console.WriteLine(sensorData.CurrentTime());


//Console.WriteLine("hello-world");
