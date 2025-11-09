public class BankingSystem
{
    private decimal _balance;


    /// <summary>
    /// ახდენს <see cref="BankingSystem"/> კლასის ახალი ეგზემპლარის ინიციალიზაციას ნულის ტოლი ნაგულისხმევი ბალანსით.
    /// </summary>
    public BankingSystem()
    {
        _balance = 0;
    }

    // <summary>
    /// აჩვენებს მიმდინარე ანგარიშის ბალანსს კონსოლზე.
    /// </summary>
    /// <remarks>ბალანსი ნაჩვენებია ფორმატში "ბალანსი: {amount}", სადაც {amount} არის ანგარიშის ბალანსის მიმდინარე
    /// მნიშვნელობა. ეს მეთოდი პირდაპირ წერს კონსოლზე და განკუთვნილია მარტივი გამომავალი
    /// სცენარებისთვის.</remarks>
    public void ShowBalance()
    {
        Console.WriteLine($"Balance: {_balance}");
    }

    /// <summary>
    /// ანგარიშის ბალანსიდან მითითებული თანხის გამოტანა.
    /// </summary>
    /// <param name="amount">გამოსატანი თანხის ოდენობა. უნდა იყოს ნულზე მეტი და მიმდინარე ბალანსზე ნაკლები ან ტოლი.</param>
    public void WithdrawMoney(decimal amount)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(amount, _balance);

        _balance -= amount;
    }
    /// <summary>
    /// მიმდინარე ბალანსს უმატებს მითითებული თანხის ოდენობას.
    /// </summary>
    /// <param name = "amount" > დასამატებელი თანხის ოდენობა. უნდა იყოს დადებითი მნიშვნელობა.</param>
    public void AddMoney(decimal amount)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);
        _balance += amount;
    }
    /// <summary>
    /// მიმდინარე ბალანსის მოძიება.
    /// </summary>
    /// <returns> მიმდინარე ბალანსი, როგორც <see cref="decimal"/> მნიშვნელობა.</returns>
    public decimal GetBalance()
    {
        return _balance;
    }
}
