

//namespace Final_Project
//{
//    public class StudentManager
//    {
       

//        public event Action OnAddStudent = null!;
//        public event Action<int> OnRemoveStudent = null!;
//        public event Action<int> OnShowStudent = null!;
//        public event Action<int> OnSearchStudent = null!;

//        public void StartStudentList()
//        {
//            int amount;

//            while (true)
//            {
//                ConsoleKeyInfo keyValue = InsertKey();

//                if (keyValue.Key == ConsoleKey.Escape) 
//                {
//                    break;
//                }

//                switch (keyValue.Key)
//                {
//                    case ConsoleKey.A:
//                        Console.Write("Enter student:");
//                        break;
//                        case ConsoleKey.W:
//                        Console.Write("Enter student:");
//                        amount = Convert.ToInt32(Console.ReadLine());
//                        OnRemoveStudent?.Invoke(amount);
//                        break;
//                        case ConsoleKey.B:
//                        Console.Write("Enter student:");
//                        amount = Convert.ToInt32(Console.ReadLine());
//                        OnShowStudent?.Invoke(amount);
//                        break;
//                        case ConsoleKey.S:
//                        Console.Write("Enter student:");
//                        amount = Convert.ToInt32(Console.ReadLine());
//                        OnSearchStudent?.Invoke(amount);
//                        break;
//                    default:
//                        Console.WriteLine("Invalid key. Try again!");
//                        break;

//                }
//            }
//        }

//        private static ConsoleKeyInfo InsertKey()
//        {
//            Console.WriteLine("Enter A - to add student;");
//            Console.WriteLine("Enter B - to show student;");
//            Console.WriteLine("Enter W - to remove student;");
//            Console.WriteLine("Enter S - to search student");
//            Console.WriteLine("Esc - to exit:");

//            ConsoleKeyInfo keyValue = Console.ReadKey(true);
//            return keyValue;
//        }

//        private List<Student> _students = new List<Student>
//        {
//            new Student { Name = "Nika", RollNumber = 1, Grade = 'A' },
//            new Student { Name = "Luka", RollNumber = 2, Grade = 'B' },
//            new Student { Name = "Ana", RollNumber = 3, Grade = 'A' },
//            new Student { Name = "Mari", RollNumber = 4, Grade = 'C' },
//            new Student { Name = "Giorgi", RollNumber = 5, Grade = 'F' },
//            new Student { Name = "Sandro", RollNumber = 6, Grade = 'A' },
//            new Student { Name = "Nino", RollNumber = 7, Grade = 'D' },
//            new Student { Name = "Dato", RollNumber = 8, Grade = 'C' },
//            new Student { Name = "Saba", RollNumber = 9, Grade = 'D' },
//            new Student { Name = "Irakli", RollNumber = 10, Grade = 'C' },
//            new Student { Name = "Salome", RollNumber = 11, Grade = 'A' },
//            new Student { Name = "Lizi", RollNumber = 12, Grade = 'C' },
//            new Student { Name = "Misho", RollNumber = 13, Grade = 'F' },
//            new Student { Name = "Tako", RollNumber = 14, Grade = 'D' },
//            new Student { Name = "Lasha", RollNumber = 15, Grade = 'F' },
//            new Student { Name = "Eka", RollNumber = 16, Grade = 'B' },
//            new Student { Name = "Natia", RollNumber = 17, Grade = 'D' },
//            new Student { Name = "Tornike", RollNumber = 18, Grade = 'D' },
//            new Student { Name = "Ia", RollNumber = 19, Grade = 'C' },
//            new Student { Name = "Beka", RollNumber = 20, Grade = 'A' },
//            new Student { Name = "Sopo", RollNumber = 21, Grade = 'B' },
//            new Student { Name = "Gvantsa", RollNumber = 22, Grade = 'D' },
//            new Student { Name = "Vano", RollNumber = 23, Grade = 'A' },
//            new Student { Name = "Tatia", RollNumber = 24, Grade = 'D' },
//            new Student { Name = "Gega", RollNumber = 25, Grade = 'A' },
//            new Student { Name = "Elene", RollNumber = 26, Grade = 'C' },
//            new Student { Name = "Davit", RollNumber = 27, Grade = 'B' },
//            new Student { Name = "Nene", RollNumber = 28, Grade = 'A' },
//            new Student { Name = "Kato", RollNumber = 29, Grade = 'C' },
//            new Student { Name = "Zurab", RollNumber = 30, Grade = 'C' }

//        };

//        public void AddStudent()
//        {
//            Console.Write("Enter Name: ");
//            string name = Console.ReadLine()!;
//            Console.Write("Enter Roll Number: ");
//            int roll = int.Parse(Console.ReadLine()!);
//            Console.Write("Enter Grade: ");
//            char grade = char.Parse(Console.ReadLine()!);

//            _students.Add(new Student { Name = name, RollNumber = roll, Grade = grade });
//            Console.WriteLine("Student added successfully!\n");
//        }

//        public void ShowAll()
//        {
//            foreach (var s in _students)
//            {
//                Console.WriteLine(s);
//            }
//            Console.WriteLine();
//        }

//        public void Search()
//        {
//            Console.Write("Enter Roll Number to search: ");
//            int roll = int.Parse(Console.ReadLine()!);
//            var student = _students.FirstOrDefault(s => s.RollNumber == roll);
//            if (student != null)
//                Console.WriteLine(student);
//            else
//                Console.WriteLine("Student not found.");
//            Console.WriteLine();
//        }

//        public void RemoveStudent()
//        {
//            Console.Write("Enter Roll Number to remove: ");
//            int roll = int.Parse(Console.ReadLine()!);
//            var student = _students.FirstOrDefault(s => s.RollNumber == roll);
//            if (student != null)
//            {
//                _students.Remove(student);
//                Console.WriteLine("Student removed successfully!\n");
//            }
//            else
//            {
//                Console.WriteLine("Student not found.\n");
//            }
//        }
//    }
//}
