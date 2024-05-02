namespace ProjectINSY4051;

public class CustomerReservation
{
public Customer c {get; set;}
    public Reservation r {get; set;}

    public CustomerReservation(Customer c, Reservation r)
    {
        this.c = c;
        this.r = r;
    }
}
