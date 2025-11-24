using System.Net.NetworkInformation;

namespace Day5Assignment;

public class BankAccountTests
{
    //Exercise 1: Bank Account
    [Test]
    public void OpeningBalance_ShouldBe500()
    {
        BankAccount acc = new BankAccount(500);

        Assert.That(acc.Balance, Is.EqualTo(500));
    }

    //Exercise 2: Test Deposit Method
    [Test]
    public void Deposit_ShouldIncreaseBalance()
    {
        BankAccount acc = new BankAccount(1000);

        acc.Deposit(200);

        Assert.That(acc.Balance, Is.EqualTo(1200));
    }

    //Exercise 3: Test Withdraw Method
    [Test]
    public void WithdrawTest()
    {
        BankAccount acc = new BankAccount(500);

        acc.Withdraw(300);

        Assert.That(acc.Balance, Is.EqualTo(200));
        Assert.That(() => acc.Withdraw(600),
                Throws.TypeOf<InvalidOperationException>());
    }

    //Exercise 4: TestCase Attribute
    [TestCase(100, 50, 150)]
    [TestCase(0, 100, 100)]
    [TestCase(500, 0, 500)]
    public void Deposit_TestCases(decimal opening, decimal deposit, decimal expected)
    {
        BankAccount acc = new BankAccount(opening);

        if (deposit > 0)
            acc.Deposit(deposit);

        Assert.That(acc.Balance, Is.EqualTo(expected));
    }

    //Exercise 5: Transaction History Count
    [Test]
    public void HistoryCount_ShouldBe2_AfterTwoDeposits()
    {
        BankAccount acc = new BankAccount(0);

        acc.Deposit(100);
        acc.Deposit(50);

        Assert.That(acc.History.Count, Is.EqualTo(2));
    }

    //Exercise 6: Using TestCaseSource
    public static IEnumerable<object[]> WithdrawalCases()
    {
        yield return new object[] { 1000m, 200m, 800m };
        yield return new object[] { 500m, 100m, 400m };
        yield return new object[] { 250m, 50m, 200m };
    }

    [Test]
    [TestCaseSource(nameof(WithdrawalCases))]
    public void WithdrawCases_ShouldReturnCorrectBalance(decimal opening, decimal amount, decimal expected)
    {
        BankAccount acc = new BankAccount(opening);

        acc.Withdraw(amount);

        Assert.That(acc.Balance, Is.EqualTo(expected));
    }

    //Exercise 7: Negative Deposit Should Throw Exception
    [Test]
    public void Deposit_NegativeAmount_ShouldThrow()
    {
        BankAccount acc = new BankAccount(0);

        var ex = Assert.Throws<ArgumentException>(() => acc.Deposit(-10));

        Assert.That(ex.Message, Does.Contain("positive"));
    }

    //Exercise 8: Balance Should Never Become Negative
    [Test]
    public void Withdraw_TooMuch_ShouldNotChangeBalance()
    {
        BankAccount acc = new BankAccount(500);

        Assert.Throws<InvalidOperationException>(() => acc.Withdraw(600));

        Assert.That(acc.Balance, Is.EqualTo(500));
    }

    //Exercise 9: Test Interest Calculation
    [Test]
    public void ApplyInterest_ShouldIncreaseBalanceCorrectly()
    {
        BankAccount acc = new BankAccount(1000);

        acc.ApplyInterest(0.05m);

        Assert.That(acc.Balance, Is.EqualTo(1050));
    }

}
