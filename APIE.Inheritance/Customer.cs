namespace APIE.Inheritance;

// To inherit from a class we use "Class : BaseClass"
public class Customer : Person
{
    // Normal constructor for our Customer class
    public Customer(string name, string email, string phoneNumber, bool isPremium)
    {
        // this keyword references the current class
        // and all of its inherited and created members
        this.IsPremium = isPremium;
        this.Name = name;
        this.Email = email;

        // base references the inherited class (parent class)
        base.PhoneNumber = phoneNumber;
    }

    public bool IsPremium { get; set; }
    public bool AllowsEmails { get; set; }

    public override void WishHappyBirthday()
    {
        base.WishHappyBirthday();

        if (AllowsEmails && DateTime.Today == DateOfBirth.Date)
        {
            Console.WriteLine("Send email coupon");
        }
    }
}