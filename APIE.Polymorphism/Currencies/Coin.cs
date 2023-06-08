namespace APIE.Polymorphism.Currencies;

public abstract class Coin : ICurrency
{
    public abstract string Name { get; }
    public abstract double Value { get; }
    public abstract string Material { get; }

    public string Flip()
    {
        var random = new Random(); // Creates a System.Random object
        var face = random.Next(2); // randomly chooses 0 or 1
        return face == 0 ? "Heads" : "Tails"; // returns Heads or Tails
    }
}
