namespace ProjectINSY4051;

public class VehicleReservation
{
    public  Reservation r {get; set;}
    public Vehicle v {get; set;}

    public VehicleReservation(Reservation r, Vehicle v)
    {
        this.r = r;
        this.v = v;
    }

}
