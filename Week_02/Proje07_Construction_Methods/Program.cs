namespace Proje07_Construction_Methods
{
    class Person
    
    {
        public Person() //Method , Constructor Method-Tipi olmaz!
        {
            //Her classın default olarak bir constructor methodu vardır, ama impicittir,yani örtülü,gizlidir.Şu anda biz kendimiz bir constructor method yazdık!
            //Constructor method, ilgii clastan new keywordü ile yeni bir nesne yarattıldığı esnada çalışacak kodları barındırır.
            //Yani, bu classtan bir nesne üretildiği anda buradaki kodları çalışır.
            Console.WriteLine("Merhaba, ben Person, şu an yaratıldım!");
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Student : Person
    {
        public Student(string firstName, string lastName, int studentNumber):base(firstName, lastName)
        {
            
            StudentNumber = studentNumber;
        }

        public int StudentNumber { get; set; }
    }
    internal class Program
    {       

        static void Main(string[] args)
        {
            //Person person1 = new Person();
            //Person person2 = new Person("Serhat", "Kaya");
            //Console.WriteLine($"{person2.FirstName} {person2.LastName}");

            Student student1 = new Student("Selin","Candaş",345)
            Console.WriteLine($"{student1.FirstName} {student1.LastName} {student1.StudentNumber}");
            Console.ReadLine();

            //Bir nesnenin ilk üretildiği anda kodları yazdığımız method.

        }
    }
}