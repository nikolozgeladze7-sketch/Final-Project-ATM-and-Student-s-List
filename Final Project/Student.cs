//namespace Final_Project
//{
//    public class Student
//    {
//        public string Name { get; set; } = string.Empty;
//        public int RollNumber {  get; set; }
//        public char Grade {  get; set; }

//        public override string ToString()
//        {
//            return $"Name: {Name}, RollNumber: {RollNumber}, Grade: {Grade}";
//        }

//        private List<Student> _students = new List<Student>();

//        public void AddStudent()
//        {
//            Console.Write("Enter name: ");
//            string name = Console.ReadLine()!;
//            Console.Write("Enter roll number: ");
//            int roll = int.Parse(Console.ReadLine()!);
//            Console.Write("Enter grade: ");
//            char grade = char.Parse(Console.ReadLine()!);

//            _students.Add(new Student { Name = name, RollNumber = roll, Grade = grade });
//            Console.WriteLine("Student added successfully!");
//        }

//        public void ShowAll(int st)
//        {
//            foreach (var s in _students)
//            {
//                Console.WriteLine(s);
//            }
//        }

//        public void Search(int stu)
//        {
//            Console.Write("Enter roll number to search: ");
//            int roll = int.Parse(Console.ReadLine()!);
//            var student = _students.FirstOrDefault(s => s.RollNumber == roll);
//            if (student != null)
//                Console.WriteLine(student);
//            else
//                Console.WriteLine("Student not found.");
//        }

//        public void RemoveStudent(int stud)
//        {
//            Console.Write("Enter roll number to remove: ");
//            int roll = int.Parse(Console.ReadLine()!);
//            var student = _students.FirstOrDefault(s => s.RollNumber == roll);
//            if (student != null)
//            {
//                _students.Remove(student);
//                Console.WriteLine("Student removed successfully!");
//            }
//            else
//            {
//                Console.WriteLine("Student not found.");
//            }
//        }
//    }
//}
