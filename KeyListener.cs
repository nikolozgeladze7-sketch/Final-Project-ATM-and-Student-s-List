internal class KeyListener
{
    public event Action OnBalanceCheck = null!;
    public event Action<decimal> OnWithdraw = null!;
    public event Action<decimal> OnAddMoney = null!;

    public void StartListening()
    {
        decimal amount;

        while (true)
        {
            ConsoleKeyInfo keyValue = InsertKey();

            if (keyValue.Key == ConsoleKey.Escape)
            {
                break;
            }

            switch (keyValue.Key)
            {
                case ConsoleKey.W:
                    Console.Write("Enter amount: ");
                    amount = Convert.ToDecimal(Console.ReadLine());
                    OnWithdraw?.Invoke(amount);
                    break;
                case ConsoleKey.A:
                    Console.Write("Enter amount: ");
                    amount = Convert.ToDecimal(Console.ReadLine());
                    OnAddMoney?.Invoke(amount);
                    break;
                case ConsoleKey.B:
                    OnBalanceCheck?.Invoke();
                    break;
                default:
                    Console.WriteLine("Invalid key. Try again!");
                    break;
            }
        }
    }

    private static ConsoleKeyInfo InsertKey()
    {
        Console.WriteLine("Enter A - to add money;");
        Console.WriteLine("Enter B - to see balance;");
        Console.WriteLine("Enter W - to withdraw money;");
        Console.WriteLine("Esc - to exit:");

        ConsoleKeyInfo keyValue = Console.ReadKey(true);
        return keyValue;
    }
}
