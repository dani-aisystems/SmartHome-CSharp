using System;

public class SmartThermostat : SmartDevice, IControllable
{
    public int Temperature { get; private set; }

    public SmartThermostat(string name, string model)
        : base(name, model)
    {
        this.Temperature = 20;
    }

    public void TurnOn()
    {
        this.IsOn = true;
        Console.WriteLine($"{this.Name} се включи.");
    }

    public void TurnOff()
    {
        this.IsOn = false;
        Console.WriteLine($"{this.Name} се изключи.");
    }

    public void AdjustTemperature(string period)
    {
        if (period == "сутрин")
        {
            this.Temperature = 22;
        }
        else if (period == "ден")
        {
            this.Temperature = 20;
        }
        else if (period == "вечер")
        {
            this.Temperature = 24;
        }
        else
        {
            this.Temperature = 19;
        }

        Console.WriteLine($"{this.Name} настрои температурата на {this.Temperature} градуса.");
    }

    public void Status()
    {
        if (this.IsOn)
        {
            Console.WriteLine($"{this.Name} ({this.Model}) - включен, {this.Temperature} градуса");
        }
        else
        {
            Console.WriteLine($"{this.Name} ({this.Model}) - изключен");
        }
    }
}
