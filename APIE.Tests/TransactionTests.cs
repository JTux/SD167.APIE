using APIE.Polymorphism;
using APIE.Polymorphism.Currencies.Coins;

namespace APIE.Tests;

[TestClass]
public class TransactionTests
{
    [TestMethod]
    public void GetCurrencyTypesTest()
    {
        var currencies = new ICurrency[]
        {
            new Penny(),
            new Penny(),
            new Dime(),
            new Dime()
        };

        Transaction transaction = new(currencies);

        string expected = "2 Dime(s), 2 Penny(s)";
        string actual = transaction.GetCurrencyTypes();

        Assert.AreEqual(expected, actual);
    }
}