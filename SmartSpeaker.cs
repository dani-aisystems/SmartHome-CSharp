using System;

public class SmartSpeaker : SmartDevice, IControllable
{
    public SmartSpeaker(string name, string model)
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

    public void PlayMusic(string song)
    {
        if (this.IsOn)
        {
            Console.WriteLine($"{this.Name} пуска песента {song}");
        }
    }

    public void MakeAnnouncement(string message)
    {
        if (this.IsOn)
        {
            Console.WriteLine($"{this.Name} казва: {message}");
        }
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
