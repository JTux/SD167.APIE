namespace APIE.Inheritance;

public abstract class Employee : Person
{
    public int EmployeeId { get; set; }
    public DateTime HireDate { get; set; }

    public abstract double Pay();

    public override void WishHappyBirthday()
    {
        if (DateOfBirth.Date == DateTime.Today)
        {
            Console.WriteLine($"Happy birthday employee #{EmployeeId}. Enjoy the day off.");
        }
    }
}

public class HourlyEmployee : Employee
{
    public double HourlyWage { get; set; }
    public double HoursWorked { get; set; }

    public override double Pay()
    {
        double payment = HourlyWage * HoursWorked;
        HoursWorked = 0;
        return payment;
    }

    public override void WishHappyBirthday()
    {
        base.WishHappyBirthday();
        Console.WriteLine("Reminder that you do not get paid on your days off.");
    }
}

public class SalaryEmployee : Employee
{
    public double Salary { get; set; }

    public override double Pay()
    {
        return Salary / 12 / 2;
    }
}