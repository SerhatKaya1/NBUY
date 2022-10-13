using System.Collections;
namespace Proje10_Coections_ArrayList
{
    internal class Program
    {
        static void Yazdir(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item  );
            }
        }
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList() { 54, 12, 66, 34, 19 };
            Console.WriteLine("Default Sira");
            Yazdir(sayilar);
            sayilar.Sort();
            Console.WriteLine("********");
            Console.WriteLine("Küçükten büyüğe sıralı");
            Yazdir(sayilar);
            sayilar.Sort();
            Console.WriteLine("********");
            Console.WriteLine("Büyükten küçüğe sıralı");
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            sayilar.Sort();

            











            //  ArrayList myList = new ArrayList();
            //  myList.Add(120);
            //  myList.Add("120");
            //  myList.Add("Zeynep");
            //  myList.Add(11.5);
            //  myList.Add(DateTime.Now);
            //  myList.Add(true);

            //  myList.Insert(0, "Yeni eleman");

            //  ArrayList addedist =new ArrayList { "Ali", "Veli" ,"Kazım" };

            //  myList.InsertRange(4,addedist); //İstediğim yere ekememi sağladı.
            //  myList.AddRange(addedist); //Listenin sonuna yazmamızı sağlıyor.

            //  myList.Remove("Zeynep");
            //  //myList.Remove("120");
            //  //myList.RemoveAt(0);
            //  //myList.RemoveRange(0, 10);
            //  foreach (var item in myList)
            //  {
            //      Console.WriteLine(item);
            //  }
            //  if (myList.Contains("Zeynep")==true)

            //  {
            //      Console.WriteLine("Evet, Zeynep istede mevcut! ");
            //  }
            //  else

            //  Console.WriteLine();
            ////  Console.WriteLine(myList[3]);

            Console.ReadLine();
        }
    }
}