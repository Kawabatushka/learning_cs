using System;

namespace Program.Transport_classes;

public class Car : Transport
{
    public override ushort Year
    {
        get => base.Year;
        set
        {
            if (value >= 1850) Year = value;
        }
    }
    public ushort GroundClearance { set; get; }

    public Car() : base()
    {
        GroundClearance = 0;
    }
    public Car(string _name, ushort _mass, ushort _year, ushort _groundClearance) 
        : base(_name, _mass, _year)
    {
        GroundClearance = _groundClearance;
        Console.WriteLine("Car");
    }

    public override void GetInfo() =>
        Console.WriteLine($"Car:\nname = {Name}\tmass = {Mass}\tyear = {Year}" +
                          $"\tgroundClearance = {GroundClearance}\n");
}

class Cargo : Car
{
    public ushort Capacity { set; get; }

    public Cargo() : base()
    {
        Capacity = 0;
        Console.WriteLine("Cargo");
    }
    public Cargo(string _name, ushort _mass, ushort _year, ushort _groundClearance, ushort _capacity) 
        : base(_name, _mass, _year, _groundClearance)
    {
        Capacity = _capacity;
        Console.WriteLine("Cargo");
    }
    public override void GetInfo() =>
        Console.WriteLine($"Cargo:\nname = {Name}\tmass = {Mass}\tyear = {Year}" +
                          $"\tgroundClearance = {GroundClearance}" +
                          $"\tcapacity = {Capacity}\n");
}

class PassengerCar : Car
{
    
}