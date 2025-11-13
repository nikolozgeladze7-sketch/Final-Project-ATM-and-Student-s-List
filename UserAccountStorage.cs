
using System;
using System.IO;


namespace Final_Project
{
    public class UserAccountStorage
    {
        public readonly string _filePath;

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
        public void Signup()
        {
            Console.WriteLine("Enter username");
            var username = Console.ReadLine();
            if (username == null)
            {
                throw new ArgumentOutOfRangeException("username cant be nothing");
            }
            if (UserExists(username))
            {
                Console.WriteLine("Username already exists.");
                return;
            }
            Console.WriteLine("Enter a Password");
            var password = Console.ReadLine();
            //<sumamry>
            //მოწოდებულ ინფორმაციას ერთ ცვლადში ამატებს და საწყის მაყუთად 0-ს მიანიჭებს
            //<sumamry>
            string newUser = $"{username}:{password}:0";
            //<summary>
            //ეს ახალ Users ამატებს მეხსიერებაში
            //<summary>
            File.AppendAllText(_filePath, newUser + Environment.NewLine);
        }
        
        //<sumamry>
        //ეს ამოწმებს თუ გამოყენებულია სახელი
        //<sumamry>
        public bool UserExists(string username)
        {
            if (!File.Exists(_filePath))
                return false;
        
            string[] lines = File.ReadAllLines(_filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length > 0 && parts[0] == username)
                    return true;
            }
            return false;
        }

        public void Login()
        {
            UserAccountStorage storage = new UserAccountStorage("users.txt");
            bool loggedIn = false;

            while (!loggedIn) // sul kitxavs sanam sworad chawers logins
            {
                Console.WriteLine("Enter username:");
                var username = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(username))
                {
                    Console.WriteLine("Username can't be empty.");
                    continue; // loopis dasawyishi midis
                }

                if (!storage.UserExists(username))
                {
                    Console.WriteLine("User does not exist. Please sign up first.");
                    continue; //  loopis dasawyishi midis
                }

                Console.WriteLine("Enter password:");
                var password = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(password))
                {
                    Console.WriteLine("Password can't be empty.");
                    continue; //  loopis dasawyishi midis
                }

                // amowmebs parols da users
                string[] lines = File.ReadAllLines("users.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length >= 2 && parts[0] == username && parts[1] == password)
                    {
                        Console.WriteLine("Login successful!");
                        loggedIn = true;  // amtavrebs loops
                        break;
                    }
                }

                if (!loggedIn)
                {
                    Console.WriteLine(" Incorrect username or password. Try again.");
                }
            }
        }


    }
}


