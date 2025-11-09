internal class BankingSystem
{
    private decimal _balance;

    public BankingSystem()
    {
        _balance = 0;
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Balance: {_balance}");
    }

    public void WithdrawMoney(decimal amount)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(amount, _balance);

        _balance -= amount;
    }

    public void AddMoney(decimal amount)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);
        _balance += amount;
    }
}
