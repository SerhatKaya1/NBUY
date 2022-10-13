namespace Proje06_Inheritance_Kaitim_Miras
{
    class Person // Bir class , istenildiği kadar başka classsa miras verebilir.
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public override void Intro() 
        
    }
    class Writer : Person
    {
        public string BookName { get; set; }

        class Teacher : Person
        {
            public string Branch { get; set; }
        }
    }
    class Student: Person //Bir class sadece tek bir class dan miras alabilir.
    class a
        {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
    class b : a
    {
        public int MyProperty3 { get; set; }
        public int MyProperty4 { get; set; }
    }
    {
        public int StudentNumber { get; set; }
        public override void Intro()  // Bu metodun miras alınan sınıftaki versiyonunu ezip , yok sayıp                                          yerine bu metodu kabul eder! // 

        {
            Console.WriteLine($"First Name: {this.FirstName}, LastName={this.LastName}, Student Name:);
        }



    }
    internal class Program
    {
        static virtual void Main(string[] args) //virtual keywordu miras alınan classlarda override edilmesine izin verilir!

        {
            Person person = new Person();
            Student student = new Student();
            student.FirstName = "Kemal";
            student.LastName = "Kapucu";
            student.StudentNumber = 125;
            student.Intro();
            Console.ReadLine();
            Teacher teacher = new Teacher()
            
                FirstName = "Alican";
                LastName = "Kuloplu";
                  Branch = "Software Development";

            person person1 = new Student();
            //Student student1 = new Person();

            //Bir teacher tanımlayın , içini doldurun, ekrana yazdırın .

        }
    }
}