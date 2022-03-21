using SWD_Day6;
using System.Collections.Generic;

// InputExtractor inputJson = new InputExtractor();

// string result = inputJson.UseCase();
// Console.WriteLine(result);

InputExtractor Finder = new InputExtractor();
TimeBasedMonitoring TBM = new TimeBasedMonitoring();


Finder.ReadFile();
string result = Finder.UseCase();
Console.WriteLine(result);

switch (result)
{
    case "TimeBasedMonitoring":
        await TBM.CheckUseCase();
        //ExtractJsonData(retval);
        break;

    default:
        Console.WriteLine("ERROR");
        break;
}

// InputExtractor input = new InputExtractor();

// input.ReadFile();

// DataCollection sensorData = new DataCollection();

// string energy = await sensorData.SocketEnergy();
// Console.WriteLine(energy);

// string SocketState = await sensorData.SocketState();
// Console.WriteLine(SocketState);

// string ButtonState = await sensorData.ButtonState();
// Console.WriteLine(ButtonState);

// string Motion = await sensorData.Motion();
// Console.WriteLine(Motion);

// string CurrentTime = sensorData.CurrentTime();
// Console.WriteLine(CurrentTime);