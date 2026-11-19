using System;

public class SmartDevice
{
    public string Name { get; private set; }
    public string Model { get; private set; }
    public bool IsOn { get; protected set; }

    public SmartDevice(string name, string model)
    {
        this.Name = name;
        this.Model = model;
        this.IsOn = false;
    }
}
