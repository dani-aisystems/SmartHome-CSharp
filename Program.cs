using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        SmartLight light = new SmartLight("Лампа", "L-100");
        SmartThermostat thermostat = new SmartThermostat("Термостат", "T-200");
        SmartSpeaker speaker = new SmartSpeaker("Колона", "S-300");

        List<IControllable> devices = new List<IControllable>();
        devices.Add(light);
        devices.Add(thermostat);
        devices.Add(speaker);

        int hour = DateTime.Now.Hour;
        string period;

        if (hour >= 6 && hour < 10)
        {
            period = "сутрин";
        }
        else if (hour >= 10 && hour < 18)
        {
            period = "ден";
        }
        else if (hour >= 18 && hour < 23)
        {
            period = "вечер";
        }
        else
        {
            period = "нощ";
        }

        Console.WriteLine("УМНА КЪЩА");
        Console.WriteLine($"Часът е {hour}, сега е {period}.");
        Console.WriteLine();

        thermostat.TurnOn();
        thermostat.AdjustTemperature(period);

        if (period == "сутрин")
        {
            light.TurnOn();
            speaker.TurnOn();
            speaker.MakeAnnouncement("Добро утро!");
        }
        else if (period == "вечер")
        {
            light.TurnOn();
            speaker.TurnOn();
            speaker.PlayMusic("Imagine");
        }
        else
        {
            light.TurnOff();
            speaker.TurnOff();
        }

        Console.WriteLine();
        Console.WriteLine("Състояние на устройствата:");

        foreach (IControllable device in devices)
        {
            device.Status();
        }
    }
}
