namespace APIE.Inheritance;
public class Person
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }

    public virtual void WishHappyBirthday()
    {
        if (DateOfBirth.Date == DateTime.Today)
        {
            Console.WriteLine($"Happy birthday {Name}!");
        }
    }
}
