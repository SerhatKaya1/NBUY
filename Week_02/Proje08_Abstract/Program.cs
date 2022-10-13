namespace Proje08_Abstract
{
    abstract class Person //Eğer bir class abstract ise, o clasdan yeni bir nesne yaratımaz!
    class Student : Person        
    {
        public Student(string firstName, string lastName ,int studentNumber):base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Branch = branch;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Greeting()
        {
            Console.WriteLine("I am a person.");
        
            Console.WriteLine($"First Name: {this.FirstName}, Last Name: {this.LastName});
        }
        public abstract void Intro(); //Soyut metot
          //Eğer bir classın içinde abstract bir metot var ise , o class da abstract omalı!
    }
    class Teacher
    class Writer: Person
    {
      

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ayşen Umay", "Ergül", 101);
            student1.Greeting();
            student1.Intro(); // İstemediğimiz hade ,Person'dak Intro çalışıyor.

            Teacher teacher1 = new Teacher("Maria", "Canan", "Fizik");
            teacher1.Greeting();
            teacher1.Intro(); // İstemediğimiz hade , Person'daki Intro çalışıyor. 

            Writer writer1 = new Writer("Math", "Haig", "Gece Yarısı Kütüphanesi");
            Writer1.Greeting();
            Writer1.Intro();

            Person person = new Person
            
            

        }
    }
}