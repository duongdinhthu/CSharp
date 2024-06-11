//C# Collection
using Pro4;

class Program
{
    public static void Main(string[] args)
    {
        //List<T>
        List<string> students = new List<string> { "Thu", "Thao", "Manh" };
        students.Add("Hoang");
        Console.WriteLine("List of students: ");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        //LinkedList<T> , danh sách liên kết động(2 chiều) phù hợp Thêm, Xóa danh sách ở vị trí bất kì  
        LinkedList<string> languages = new LinkedList<string>();
        languages.AddLast("C#");
        languages.AddLast("Java");
        languages.AddFirst("Python");
        languages.AddFirst("Scala");
        Console.WriteLine("LinkedList of programming languages: ");
        foreach (var language in languages)
        {
            Console.WriteLine(language);
        }

        //Stack<T> LIFO, xử lí ngược của giá trị thêm vào
        Stack<string> books = new Stack<string>();
        books.Push("Java");
        books.Push("C#");
        books.Push("Python");
        Console.WriteLine("Stack of books: ");
        while (books.Count > 0)
        {
            Console.WriteLine(books.Pop());
        }

        //Queue<T> FIFO, xử lí theo thứ tự thêm vào, vào trước, xử lí trước
        Queue<string> customers = new Queue<string>();
        customers.Enqueue("Cus1");
        customers.Enqueue("Cus2");
        customers.Enqueue("Cus3");
        customers.Enqueue("Cus4");
        Console.WriteLine("Queue of customers: ");
        while (customers.Count > 0)
        {
            Console.WriteLine(customers.Dequeue());
        }

        //Dictionary<TKey, TValue> => Truy cập giá trị nhanh thông qua Key
        Dictionary<int, string> studentGrades = new Dictionary<int, string>{
            {1, "A"},
            {2, "B"},
            {3, "C"},
        };

        //HashSet<T>: kko trùng lặp giá trị, ko sắp xếp, đảm bảo các giá trị duy nhất
        HashSet<string> cities = new HashSet<string> { "Ha Noi", "TP.HCM", "Hai Phong" };
        cities.Add("Ha Tinh");
        cities.Add("Nam Dinh");
        Console.WriteLine("HashSet of cities: ");
        foreach (var city in cities)
        {
            Console.WriteLine(city);
        }

        //Tạo Repository cho Student
        EntityRepository<Student> studentRepository = new EntityRepository<Student>();
        //Tạo Repository cho SchoolClass
        EntityRepository<SchoolClass> schoolClassRepository = new EntityRepository<SchoolClass>();
        //Tạo Repository cho Teacher
        EntityRepository<Teacher> teacherRepository = new EntityRepository<Teacher>();
        //Add
        studentRepository.Add(new Student { Id = 1, Name = "Gia Binh" });
        foreach (var student in studentRepository.GetAll())
        {
            Console.WriteLine(student);
        }
        schoolClassRepository.Add(new SchoolClass { Id = 101, Name = "C#" });
        foreach (var schoolClass in schoolClassRepository.GetAll())
        {
            Console.WriteLine(schoolClass);
        }
        teacherRepository.Add(new Teacher { Id = 201, Name = "Truong Trung" });
        foreach (var teacher in teacherRepository.GetAll())
        {
            Console.WriteLine(teacher);
        }
    }
}