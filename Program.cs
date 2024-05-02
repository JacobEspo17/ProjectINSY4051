using System.ComponentModel.DataAnnotations;

namespace ProjectINSY4051;

class Program
{
    private static CustomerList customers;
    private static List<Reservation> reservations;
    private static List<CustomerReservation> customerReservations;
    private static Customer authenticatedCustomer;

    static void Main(string[] args)
    {
        Console.WriteLine("Initializing...");
        Initialize();
        Menu();
    }

        static void Initialize()
    {
        var c1 = new Customer
        {
            firstName = "Jacob",
            lastName = "Espinosa",
            userName = "jespo17",
            passWord = "9567",
            email = "jacobespo@outlook.com",
            streetAddress = "391 Holly St.Kalispell, MT 59900",
            birthDate = "07/25/2004"

        };

        var c2 = new Customer
        {
            firstName = "Evelyn",
            lastName = "Do",
            userName = "Edo94",
            passWord = "5954",
            email = "evelyndo@outlook.com",
            streetAddress = "879 Sutor Ave.Unit 283 Newnan, GA 30263",
            birthDate = "05/09/2003"
            
        };

        var c3 = new Customer
        {   
            firstName = "Nasra",
            lastName = "Abdirahman",
            userName = "Nabdiraham12",
            passWord = "4805",
            email = "nasraabdirahman@outlook.com",
            streetAddress = "245 Brewery St.Malden, MA 02148",
            birthDate = "06/25/2003"

        };

        var c4 = new Customer
        {
            firstName = "Ayisha",
            lastName = "El-Refaie",
            userName = "Aelrefaie15",
            passWord = "4895",
            email = "ayishaelrefaie@outlook.com",
            streetAddress = "702 Fairway Rd.Glastonbury, CT 06033",
            birthDate = "05/07/2002"
        };

        var a1 = new Reservation();
        var a2 = new Reservation();
        var a3 = new Reservation();
        var a4 = new Reservation();

        var ca1 = new CustomerReservation(c3, a4);
        var ca2 = new CustomerReservation(c2, a2);
        var ca3 = new CustomerReservation(c4, a3);
        var ca4 = new CustomerReservation(c1, a1);

        customers = new CustomerList();
        customers.customerList.Add(c1);
        customers.customerList.Add(c2);
        customers.customerList.Add(c3);
        customers.customerList.Add(c4);

        customerReservations = new List<CustomerReservation>();
        customerReservations.Add(ca1);
        customerReservations.Add(ca2);
        customerReservations.Add(ca3);
        customerReservations.Add(ca4);

        reservations = new List<Reservation>();
        reservations.Add(a1);
        reservations.Add(a2);
        reservations.Add(a3);
        reservations.Add(a4);
    }

    static void Menu()
    {
        bool done = false;

        while (!done)
        {
            Console.WriteLine("Options: Login: 1, Logout: 2, Sign Up: 3, Reservations: 4, Payment: 5, Quit: q");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    LoginMenu();
                    break;
                case "2":
                    LogOutMenu();
                    break;
                case "3":
                    SignUpMenu();
                    break;
                case "4":
                    ReservationsMenu();
                    break;
                case "5":
                    PaymentMenu();
                    break;
                case "q":
                    done = true;
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }

        }
    }

    static void LoginMenu()
    {
        if(authenticatedCustomer == null)
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            authenticatedCustomer = customers.Authenticate(username, password);
            if (authenticatedCustomer != null)
            {
                Console.WriteLine($"Welcome valued customer {authenticatedCustomer.firstName}");
                Console.WriteLine("Your Information");
                Console.WriteLine($"{authenticatedCustomer.email}");
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }
        }


    }
    static void LogOutMenu()
    {
        authenticatedCustomer = null;
        Console.WriteLine("Logged out!, We hope to see you next time!");
    }

    static void SignUpMenu()
    {
        Console.Write("First Name: ");
        string firstname = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastname = Console.ReadLine();
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        var newCustomer = new Customer
        {
            firstName = firstname,
            lastName = lastname,
            userName= username,
            passWord = password
        };
        customers.customerList.Add(newCustomer);
        Console.WriteLine("Profile created!, thank you for loyalty");
        
    }

    static void ReservationsMenu()
    {
        if (authenticatedCustomer == null)
        {
            Console.WriteLine("Please log in first!");
            return;
        }

        var reservationList = customerReservations.Where(o => o.c.userName == authenticatedCustomer.userName);

        if(reservationList.Count() == 0)
        {
            Console.WriteLine("0 reservations found.");
        }
        else
        {
            foreach(var reservation in reservationList)
            {
                Console.WriteLine("Here is your reservation");
            }
        }
        
    }

    static void PaymentMenu()
    {
        Console.WriteLine("Payment Menu");
        Console.WriteLine("1. Make Payment");
        Console.WriteLine("2. View Billing Information");
        Console.WriteLine("3. Cancel Reservation");
        Console.WriteLine("4. Report Damage");
        Console.WriteLine("5. Pay Late Fee");
        Console.WriteLine("6. Pay No-show Fee");
        Console.WriteLine("7. Return to Main Menu");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
    {
        case "1":
            MakePayment();
            break;
        case "2":
            ViewBillingInformation();
            break;
        case "3":
            CancelReservation();
            break;
        case "4":
            ReportDamage();
            break;
        case "5":
            PayLateFee();
            break;
        case "6":
            PayNoShowFee();
            break;
        case "7":
            Console.WriteLine("Returning to Main Menu...");
            break;
        default:
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
            break;

    }
        static void MakePayment()
    {
        Console.WriteLine("Enter Credit Card Information:");
       

        Console.WriteLine("Enter Billing Address:");
        

        Console.WriteLine("Payment successful!");
    }

    static void ViewBillingInformation()
    {
        
        Console.WriteLine("Billing Information:");
        
    }

    static void CancelReservation()
    {
        Console.WriteLine("Cancellation Fee: $50");
        
    }

    static void ReportDamage()
    {
        Console.WriteLine("Damage Fee: $100");
        
    }

    static void PayLateFee()
    {
        Console.WriteLine("Late Fee: $20");
        
    }

    static void PayNoShowFee()
    {
        Console.WriteLine("No-show Fee: $30");
        
    }


    }

}
