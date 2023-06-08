namespace APIE.Polymorphism.Currencies.Bills;

public class Dollar : Bill
{
    // public override string Name 
    // {
    //     get
    //     {
    //         return "Dollar Bill";
    //     }
    // }
    public override string Name => "Dollar Bill";
    public override double Value => 1.00;
    public override string Face => "George Washington";
}
