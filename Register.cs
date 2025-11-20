using System.Text.Json;

namespace Final_Project
{
    internal class Register
    {
        private readonly string _filePath;

        public Register(string filePath)
        {
            _filePath = filePath;
        }

        public void Signup()
        {
            Console.WriteLine("Enter username");
            var username = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentOutOfRangeException("Username cannot be empty.");

            if (UserExists(username))
            {
                Console.WriteLine("Username already exists.");
                return;
            }

            Console.WriteLine("Enter a password");
            var password = Console.ReadLine();

            var newUser = new User
            {
                Username = username,
                Password = password,
            };

            List<User> users = LoadUsers();
            users.Add(newUser);

            SaveUsers(users);

            Console.WriteLine("User successfully created!");
        }

        private bool UserExists(string username)
        {
            List<User> users = LoadUsers();
            return users.Exists(u => u.Username == username);
        }

        private List<User> LoadUsers()
        {
            if (!File.Exists(_filePath))
                return new List<User>();

            string json = File.ReadAllText(_filePath);
            if (string.IsNullOrWhiteSpace(json))
                return new List<User>();

            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        private void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
