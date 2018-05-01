using System;

public class Car
{
    private int Speed;
    private string Make;
    private string Model;
    private int Year;

    public Car(string make, string model, int year,int speed)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.Speed = speed;
    }
    public Car(string make, string model, int year)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.Speed = 0;
    }
    public int SpeedUp()
    {
        this.Speed++;
        return this.Speed;
    }
    public int SlowDown()
    {
        if (this.Speed > 0)
        {
            this.Speed = this.Speed - 1;
        }
        return this.Speed;
    }
    public void Display()
    {
        Console.WriteLine(this.Year + " " + this.Make + " " + this.Model + " is going " + this.Speed + " MPH.");
    }
}
