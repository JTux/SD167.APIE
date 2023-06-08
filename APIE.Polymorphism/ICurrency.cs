namespace APIE.Polymorphism;

// An interface defines a "contract" to be signed
// Anything that implements this interface agrees to meet the expectations
public interface ICurrency
{
    // Any class that implements the ICurrency interface
    // MUST have a readonly public Name and a readonly public Value
    string Name { get; }
    double Value { get; }
}
