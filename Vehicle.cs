using System.Security.Cryptography.X509Certificates;

namespace ProjectINSY4051;

public class Vehicle
{
    
    public int VIN { get; set;}

    private string Make;

    public string make
    {
        get {return Make;}
        set {Make = value;}
    }

    private string Model;

    public string model
    {
        get{return Model;}
        set{Model = value;}
    }

    private string Color;

    public string color
    {
        get {return Color;}
        set {Color = value;}
    }

    private int NumberOfSeats;

    public int numberOfSeats
    {
        get {return NumberOfSeats;}
        set {NumberOfSeats = value;}
    }

    public Vehicle(int VIN, string Make, string Model, string Color, int NumberOfSeats)
    {
        this.VIN = VIN;
        this.Make = Make;
        this.Model = Model;
        this.Color = Color;
        this.NumberOfSeats = numberOfSeats;
        
    }

}
