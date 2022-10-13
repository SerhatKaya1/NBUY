namespace Proje05_Methods_Advanced
{
    internal class Program
    {
        class person
        {
            public string Name { get; set; }
            public int Year { get; set; }
            public string Intro()
            {
                return $"Merhaba {this.Name}, Yaş: {this.CalcuateAge()}";
            }
            private int CalcuateAge()
            {
                return DateOnly.FromDateTime.Now.Year - this.Year;
            }
        }              
        static void Main(string[] args)
        {
            person person1 = new person() { Name = "Engin", Year = 1975 };
            person person2 = new person() { Name = "Umay", Year = 2007 };
            person person3 = new person() { Name = "Begum", Year = 2000 };
            person person4 = new person() { Name = "Aysen", Year = 1985 };
            person person5 = new person() { Name = "Ceyda", Year = 1990 };

            Console.WriteLine(person3.Intro());
            //Tüm kişilerin Into bilgierini ekrana yazdırın.

            person[] persons = new person[] { person1, person2, person3, person4, person5};

            foreach (var person in persons)
            {
                Console.WriteLine(person.Intro());
            }

            Console.ReadLine();
          //C#'da her ŞEY bir NESNEDİR!

        }
    }
}