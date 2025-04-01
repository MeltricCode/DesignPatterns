using Observer.Interface;

namespace Observer.Class;

public class WeatherStation
{
    private List<IObserver> _observers = new(); 
    private string _temperature;

    public void SetTemperature(string temperature)
    {
        _temperature = temperature;
        Notify();
    }
    public void Attach(IObserver observer) => _observers.Add(observer);
    
    public void Detach(IObserver observer) => _observers.Remove(observer);
    
    private void Notify()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update($"Current temperature: {_temperature}");
        }
    }
}