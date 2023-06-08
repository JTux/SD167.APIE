using APIE.Inheritance;

namespace APIE.Tests;

[TestClass]
public class PersonTests
{
    // Unit Test
    // A block of code that tests some other code (a unit of code)
    [TestMethod]
    public void Person_WishHappyBirthday()
    {
        Person person = new Person();
        person.Name = "Ingeborg Slegers";
        person.DateOfBirth = DateTime.Now;
        // person.DateOfBirth = new DateTime(2023, 1, 1);

        person.WishHappyBirthday();
    }

    [TestMethod]
    public void Customer_WishHappyBirthday()
    {
        Customer customer = new("Adam Jayne", "adam@jayne.com", "12345678910", true);
        customer.DateOfBirth = DateTime.Now;
        customer.AllowsEmails = true;

        customer.WishHappyBirthday();
    }

    [TestMethod]
    public void People_WishHappyBirthday()
    {
        List<Person> people = new();

        Person josh = new()
        {
            Name = "Joshua Tucker",
            DateOfBirth = DateTime.Today
        };

        Customer justin = new Customer("Justin Ahmann", "jahmann@gmail.com", "12345678910", true);
        justin.AllowsEmails = true;
        justin.DateOfBirth = DateTime.Today;

        people.Add(josh);
        people.Add(justin);

        foreach (var person in people)
        {
            person.WishHappyBirthday();
        }
    }

    [TestMethod]
    public void Employees_WishHappyBirthday()
    {
        Employee employee1 = new SalaryEmployee();
        employee1.EmployeeId = 1;
        employee1.DateOfBirth = DateTime.Today;

        Employee employee2 = new HourlyEmployee();
        employee2.EmployeeId = 2;
        employee2.DateOfBirth = DateTime.Today;

        List<Employee> employees = new()
        {
            employee1,
            employee2
        };

        foreach (Employee e in employees)
        {
            e.WishHappyBirthday();
        }
    }

    [TestMethod]
    public void Employees_Pay()
    {
        HourlyEmployee hourly = new()
        {
            HourlyWage = 26,
            HoursWorked = 32
        };

        double hourlyPayment = hourly.Pay();
        double expectedHourly = 832;

        Assert.AreEqual(expectedHourly, hourlyPayment);

        SalaryEmployee salary = new()
        {
            Salary = 50000
        };

        double actualPay = salary.Pay();
        double expectedPay = 50000 / 12 / 2;

        Assert.AreEqual(expectedPay, Math.Round(actualPay, 0));
    }
}