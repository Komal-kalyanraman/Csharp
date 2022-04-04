using SWD_Day6;
using System.Collections.Generic;

InputExtractor Finder = new InputExtractor();
NotificationCenter Alert = new NotificationCenter();

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
        Alert.Notification(notification);
        break;
    
    case "SocketEnergyMonitoring":
        notification = await SEM.CheckUseCase();
        Alert.Notification(notification);
        break;

    case "GrannySleepMonitoring":
        notification = await GSM.CheckUseCase();
        Alert.Notification(notification);
        break;
    
    case "BoschConference":
        notification = await BOCSE.CheckUseCase();
        Alert.Notification(notification);
        break;

    default:
        Alert.Notification("ERROR in JSON input");
        break;
}
