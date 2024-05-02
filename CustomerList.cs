namespace ProjectINSY4051;

public class CustomerList
{
    public List<Customer> customerList {get; set;}

    public CustomerList()
    {
        customerList = new List<Customer>();
    }

    public Customer Authenticate(string username, string password)
    {
        var c = customerList.Where(o => (o.userName == username) && (o.passWord == password));

        if (c.Count() > 0)
        {
            return c.First();
        }
        else
        {
            return null;
        }

    }

}
