namespace Final_Project
{
    public class UserAccountStorage
    {
        private readonly string _filePath;

        public UserAccountStorage(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// სთავაზობს შენახვას ბალანსის მნიშვნელობის ფაილში.
        /// </summary>
        public void SaveBalance(decimal balance)
        {
            try
            {
                File.WriteAllText(_filePath, balance.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving balance: {ex.Message}");
            }
        }

        /// <summary>
        /// იტვირთავს ბალანსს ფაილიდან. თუ ფაილი არ არსებობს ან ცარიელია, აბრუნებს 0.
        /// </summary>
        public decimal LoadBalance()
        {
            try
            {
                if (!File.Exists(_filePath))
                    return 0;

                string content = File.ReadAllText(_filePath);
                if (decimal.TryParse(content, out decimal balance))
                    return balance;

                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading balance: {ex.Message}");
                return 0;
            }
        }
    }
}
