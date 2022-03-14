using SWD_Day6;
using System.Collections.Generic;

Http api = new Http();

// Switch on the light
Dictionary<string, string> data = new Dictionary<string, string>
{
    {"address", "Socket"},
    {"state", "ON"}
};

string ret = await api.Put("http://192.168.1.10:8080/shapi/control", data);
//string ret = await api.Put("http://localhost:8080/shapi/control", data);
Console.WriteLine(ret);

//Console.WriteLine("hello-world");
