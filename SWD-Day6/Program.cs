using SWD_Day6;
using System.Collections.Generic;

InputExtractor Finder = new InputExtractor();
NotificationCenter Alert = new NotificationCenter();

SensorData sensorData = new SensorData();

TimeBasedMonitoring TBM = new TimeBasedMonitoring(sensorData);
SocketEnergyMonitoring SEM = new SocketEnergyMonitoring(sensorData);
GrannySleepMonitoring GSM = new GrannySleepMonitoring(sensorData);
BoschConference BOCSE = new BoschConference(sensorData);

Finder.ReadFile();
string result = Finder.UseCase();
Console.WriteLine("Selected usecase = " + result);

string notification;

switch (result)
{
    case "TimeBasedMonitoring":
        notification = TBM.CheckUseCase();
        Alert.Notification(notification);
        break;
    
    case "SocketEnergyMonitoring":
        notification = SEM.CheckUseCase();
        Alert.Notification(notification);
        break;

    case "GrannySleepMonitoring":
        notification = GSM.CheckUseCase();
        Alert.Notification(notification);
        break;
    
    case "BoschConference":
        notification = BOCSE.CheckUseCase();
        Alert.Notification(notification);
        break;

    default:
        Alert.Notification("ERROR in JSON input");
        break;
}
