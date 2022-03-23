using SWD_Day6;
using System.Collections.Generic;

InputExtractor Finder = new InputExtractor();

TimeBasedMonitoring TBM = new TimeBasedMonitoring();
SocketEnergyMonitoring SEM = new SocketEnergyMonitoring();
GrannySleepMonitoring GSM = new GrannySleepMonitoring();
BoschConference BOCSE = new BoschConference();

Finder.ReadFile();
string result = Finder.UseCase();
Console.WriteLine("Selected usecase = " + result);

string notification;

switch (result)
{
    case "TimeBasedMonitoring":
        notification = await TBM.CheckUseCase();
        Console.WriteLine(notification);
        break;
    
    case "SocketEnergyMonitoring":
        notification = await SEM.CheckUseCase();
        Console.WriteLine(notification);
        break;

    case "GrannySleepMonitoring":
        notification = await GSM.CheckUseCase();
        Console.WriteLine(notification);
        break;
    
    case "BoschConference":
        notification = await BOCSE.CheckUseCase();
        Console.WriteLine(notification);
        break;

    default:
        Console.WriteLine("ERROR in JSON input");
        break;
}
