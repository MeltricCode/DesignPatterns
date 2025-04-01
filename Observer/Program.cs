using Observer.Class;
using Observer.Implementation;
using Observer.Interface;

WeatherStation weatherStation = new();
IObserver mobile1 = new MobileApp("Mobile 1");
IObserver mobile2 = new MobileApp("Mobile 2");
IObserver billBoard = new DigitalBillboard("Billboard");

weatherStation.Attach(mobile1);
weatherStation.Attach(mobile2);
weatherStation.Attach(billBoard);

weatherStation.SetTemperature("30°C");


weatherStation.Detach(mobile2);
Console.WriteLine("--------------------------------------------------");
Console.WriteLine($"Mobile 2 Removed");
Console.WriteLine("--------------------------------------------------");

weatherStation.SetTemperature("28°C");