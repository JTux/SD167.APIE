namespace APIE.Polymorphism;

public class Transaction
{
    private readonly List<ICurrency> _currencies;
    public Transaction(params ICurrency[] currencies)
    {
        // shorthand for "new List<ICurrency>(currencies)"
        _currencies = new(currencies);
        DateOfTransaction = DateTime.Now;
    }

    public DateTime DateOfTransaction { get; }

    public double GetTotalValue()
    {
        double sum = _currencies.Sum(c => c.Value);
        return Math.Round(sum, 2);
    }

    public string GetCurrencyTypes()
    {
        if (_currencies.Count == 0)
        {
            return "No currency in this transaction.";
        }

        // Get the unique types in the _currencies list
        HashSet<Type> currencyTypes = _currencies
            .OrderByDescending(c => c.Value)
            .Select(c => c.GetType())
            .ToHashSet();

        List<string> currencyCounts = new();

        // Iterate over our hashset
        foreach (var type in currencyTypes)
        {
            var numberOfOccurences = _currencies.Where(c => c.GetType() == type).Count();
            currencyCounts.Add($"{numberOfOccurences} {type.Name}(s)");
        }

        return string.Join(", ", currencyCounts);
    }
}