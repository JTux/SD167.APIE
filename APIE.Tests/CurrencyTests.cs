using APIE.Polymorphism;
using APIE.Polymorphism.Currencies;
using APIE.Polymorphism.Currencies.Bills;
using APIE.Polymorphism.Currencies.Coins;

namespace APIE.Tests;

[TestClass]
public class CurrencyTests
{
    [TestMethod]
    public void PennyTest()
    {
        ICurrency penny = new Penny();

        Assert.AreEqual(0.01, penny.Value);
        Assert.AreEqual("Penny", penny.Name);
    }

    [TestMethod]
    public void DollarTest()
    {
        Dollar dollar = new();

        Assert.AreEqual(1, dollar.Value);
        Assert.AreEqual("Dollar Bill", dollar.Name);

        Assert.IsInstanceOfType(dollar, typeof(ICurrency));
        Assert.IsInstanceOfType(dollar, typeof(Bill));
    }

    [DataTestMethod]
    [DataRow(100.2)]
    [DataRow(36.12)]
    [DataRow(1.50)]
    [DataRow(42)]
    public void ElectronicPaymentTest(double value)
    {
        var ePayment = new ElectronicPayment(value);

        Assert.AreEqual(value, ePayment.Value);
        Assert.AreEqual("Electronic Payment", ePayment.Name);
        Assert.AreEqual(DateTime.Today, ePayment.DateOfPayment);
    }
}