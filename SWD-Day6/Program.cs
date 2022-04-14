using SWD_Day6;
using System.Collections.Generic;

InputExtractor UserInput = new InputExtractor();
NotificationCenter Alert = new NotificationCenter();

SensorData sensorData = new SensorData();

TimeBasedMonitoring TBM = new TimeBasedMonitoring(sensorData);
SocketEnergyMonitoring SEM = new SocketEnergyMonitoring(sensorData);
GrannySleepMonitoring GSM = new GrannySleepMonitoring(sensorData);
BoschConference BOCSE = new BoschConference(sensorData);

UserInput.ReadFile();
string Timer = UserInput.Timer();
string EndTime = UserInput.EndTime();
string UseCase = UserInput.UseCase();
string StartTime = UserInput.StartTime();
string SocketEnergyThreshold = UserInput.SocketEnergyThreshold();

Console.WriteLine("Selected usecase = " + UseCase);

string notification;

switch (UseCase)
{
    case "TimeBasedMonitoring":
        notification = TBM.Run(StartTime, EndTime);
        Alert.Notification(notification);
        break;
    
    case "SocketEnergyMonitoring":
        notification = SEM.Run(Timer, SocketEnergyThreshold);
        Alert.Notification(notification);
        break;

    case "GrannySleepMonitoring":
        notification = GSM.Run(StartTime, EndTime);
        Alert.Notification(notification);
        break;
    
    case "BoschConference":
        notification = BOCSE.Run(Timer);
        Alert.Notification(notification);
        break;

    default:
        Alert.Notification("ERROR in JSON input");
        break;
}
