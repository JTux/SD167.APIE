namespace APIE.Polymorphism.Currencies;

public abstract class Bill : ICurrency
{
    public abstract string Name { get; }
    public abstract double Value { get; }
    public abstract string Face { get; }
}
