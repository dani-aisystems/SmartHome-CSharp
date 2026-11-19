using System;

public class SmartLight : SmartDevice, IControllable
{
    public SmartLight(string name, string model)
        : base(name, model)
    {
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

    public void Status()
    {
        if (this.IsOn)
        {
            Console.WriteLine($"{this.Name} ({this.Model}) - включена");
        }
        else
        {
            Console.WriteLine($"{this.Name} ({this.Model}) - изключена");
        }
    }
}
