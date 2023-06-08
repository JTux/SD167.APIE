namespace APIE.Polymorphism.Currencies;

public class ElectronicPayment : ICurrency
{
    public ElectronicPayment(double value)
    {
        Value = value;
        DateOfPayment = DateTime.Today;
    }

    public string Name
    {
        get
        {
            return "Electronic Payment";
        }
    }

    public double Value { get; }
    public DateTime DateOfPayment { get; }
}