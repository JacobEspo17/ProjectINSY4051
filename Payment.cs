namespace ProjectINSY4051;

public class Payment
{
 private static int autoIncrement;
 public string CreditCardNumber { get; set; }
 public string CardHolderName { get; set; }
 public string BillingAdress { get; set; }
 public DateTime ExpiryDate { get; set; }
 public bool HasDiscount { get; set; }
 
 public Payment (string creditCardNumber, string cardHolderName, string billingAdress, DateTime expiryDate, bool hasDiscount)
 {
    CreditCardNumber = creditCardNumber;
    CardHolderName = cardHolderName;
    BillingAdress = billingAdress;
    ExpiryDate = expiryDate;
    HasDiscount = hasDiscount;

 }
 public void ProcessPayment (decimal amount)
 {
    Console.WriteLine ($"Processing payment of:" + amount);
    
    if (HasDiscount)
    {
        Console.WriteLine("Applying discount:");
        amount = 0.9m;

    }
    Console.WriteLine($"Payment processed successfuly. Amount charged:" + amount);
 }

}
