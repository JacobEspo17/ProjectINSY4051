namespace ProjectINSY4051;

public class Customer
{

    private static int autoIncrement; 
    public int CustomerID { get; set; }
    private string LastName;
    public string lastName
    {
        get {return LastName;}
        set {LastName = value;}
    }
    private string FirstName;
    public string firstName
    {
        get {return FirstName;}
        set {FirstName = value;}
    }
    private string Birthdate;
    public string birthDate 
    {
        get {return Birthdate;}
        set {Birthdate = value;}
    }
    private string Email;
    public string email 
    {
        get {return Email;}
        set {Email = value;}
    }
    private long PhoneNumber;
    public long phoneNumber 
    {
        get {return PhoneNumber;}
        set {PhoneNumber = value;}
    }
    private string StreetAddress;
    public string streetAddress
    {
        get {return StreetAddress;}
        set {StreetAddress = value;}
    }
    private string City;
    public string city
    {
        get {return City;}
        set {City = value;}
    }
    private string State;
    public string state
    {
        get {return State;}
        set {State = value;}
    }
    private int ZipCode;
    public int zipCode 
    {
        get {return ZipCode;}
        set {ZipCode = value;}
    }
    private string UserName;
    public string userName 
    {
        get {return UserName;}
        set {UserName = value;}
    }
    private string PassWord;
    public string passWord 
    {
        get {return PassWord;}
        set {PassWord = value;}
    }

    public Customer(int CustomerID, string LastName,
     string FirstName, string Birthdate, string Email, 
     long PhoneNumber, string StreetAddress, string City, string State,
      int ZipCode, string UserName, string PassWord)
     {
        autoIncrement++;
        this.CustomerID = autoIncrement;
        this.LastName = LastName;
        this.FirstName = FirstName;
        this.Birthdate = Birthdate;
        this.Email = Email;
        this.PhoneNumber = PhoneNumber;
        this.StreetAddress = StreetAddress;
        this.City = City;
        this.State = State;
        this.ZipCode = ZipCode;
        this.UserName = UserName;
        this.PassWord = PassWord;
     }

}
