internal class KeyListener
{
    /// <summary>
    /// ხდება ბალანსის შემოწმების ოპერაციის შესრულებისას.
    /// </summary>
    /// <remarks>ეს მოვლენა აქტიურდება აბონენტებისთვის ბალანსის შემოწმების დასრულების შესახებ შეტყობინების გასაგზავნად.
    /// აბონენტებს შეუძლიათ გამოიყენონ ეს მოვლენა ბალანსის შემოწმების საპასუხოდ მორგებული ლოგიკის შესასრულებლად.</remarks>
    public event Action OnBalanceCheck = null!;
    public event Action<decimal> OnWithdraw = null!;
    public event Action<decimal> OnAddMoney = null!;


    /// <summary>
    /// იწყებს მომხმარებლის შეყვანის მოსმენას და ამუშავებს ბრძანებებს თანხის განაღდებისთვის, თანხის დასამატებლად ან ბალანსის შესამოწმებლად.
    /// მეთოდი ციკლურად მუშაობს Escape ღილაკზე დაჭერამდე. /// </summary>
    /// <remarks>ეს მეთოდი კონკრეტული გასაღების შეყვანის მონაცემებს უსმენს: <list type="bullet"> <item> <description><see
    /// cref="ConsoleKey.W"/>: მომხმარებელს თანხის შეყვანის მოთხოვნა და <see cref="OnWithdraw"/> მოვლენას იწვევს.</description>
    /// </item> <item> <description><see cref="ConsoleKey.A"/>: მომხმარებელს თანხის შეყვანის მოთხოვნა და
    /// <see cref="OnAddMoney"/> მოვლენას იწვევს.</description> </item> <item> <description><see
    /// cref="ConsoleKey.B"/>: <see cref="OnBalanceCheck"/> მოვლენას იწვევს.</description> </item> <item>
    /// <description>ნებისმიერი სხვა გასაღები: აჩვენებს შეცდომის შეტყობინებას, რომელიც მიუთითებს არასწორ გასაღებზე.</description> </item> </list>
    /// მეთოდი მთავრდება Escape ღილაკზე (<see cref="ConsoleKey.Escape"/>) დაჭერისას.</remarks>
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


    /// <summary>
    /// მომხმარებლისთვის პარამეტრების მენიუს აჩვენებს და კონსოლიდან კლავიშზე დაჭერის შესახებ ინფორმაციას კითხულობს.
    /// </summary>
    /// <remarks>მეთოდი მომხმარებელს წინასწარ განსაზღვრული პარამეტრების ნაკრებით აწვდის ინფორმაციას და კლავიშზე დაჭერას ელოდება. კლავიშზე დაჭერა/დაჭერა კონსოლზე ღილაკის ჩვენების გარეშე ფიქსირდება.</remarks>
    /// <returns><see cref="ConsoleKeyInfo"/> ობიექტი, რომელიც მომხმარებლის მიერ დაჭერილ კლავიშს წარმოადგენს.</returns>
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
