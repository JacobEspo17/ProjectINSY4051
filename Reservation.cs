namespace ProjectINSY4051;

public class Reservation
{
 private static int autoIncrement;
    public int ReservationID { get; set; }
    public int Duration { get; set; }
    public DateTime PickupDate { get; set; }
    public DateTime Dropoffdate { get; set; }
    public bool Insurance { get; set; }
    public bool GPS { get; set; }
    public bool CarSeats { get; set; }
    public bool HighwayPass { get; set; }
    public double TotalDue { get { return CalculateTotalDue();}}

     public Reservation()
    {
        autoIncrement++;
        ReservationID = autoIncrement;
    }
    
    public Reservation(int reservationID, int duration, DateTime pickupDate, DateTime dropoffdate, bool insurance, bool gps, bool carSeats, bool highwayPass)
    {
        ReservationID = reservationID;
        Duration = duration;
        PickupDate = pickupDate;
        Dropoffdate = dropoffdate;
        Insurance = insurance;
        GPS = gps;
        CarSeats = carSeats;
        HighwayPass = highwayPass;
       
    }
     private double CalculateTotalDue()
    {
        double basePriceValue = 60;
        double insuranceCost = Insurance ? 15 : 0;
        double gpsCost = GPS ? 8 : 0;
        double carSeatsCost = CarSeats ? 10 : 0;
        double highwayPassCost = HighwayPass ? 5 : 0;

        int totalDays = (Dropoffdate - PickupDate).Days;
        double totalDue = (basePriceValue * totalDays) + insuranceCost + gpsCost + carSeatsCost + highwayPassCost;
        return totalDue;

    }


}
