namespace Proje09_IfConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * if(logical)
             *{
             *     bool true ise yapılacak işler
             */
            // int sayi = Convert.ToInt32(Console.ReadLine());
            // if (sayi >= 0) ;
            //{
               // Console.WriteLine("Merhaba Dünya");
            //}
            //Kullanıcıdan yaın girmesini isteyelim
            //18 yaından küçüklere "Giriş Yasak" mesajını yazdıraım
            //Console.Write("Lütfen yaşınızı giriniz: ");
            //byte yas = Convert.ToByte(Console.ReadLine());
            //if (yas < 18)  //true ise else koyarız ve alta geçmesini engelleriz.
            //{
            //    Console.WriteLine("Giriş yasak");
            //}
            //else if (yas >= 18)
            //{
            //    Console.WriteLine("Giriş serbest");
            //}
            //else
            //}

            //Girilen iki sayıdan büyük olanı yazdıraım
            //Console.Write("1.sayıyı gir: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.sayıyı gir: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1>sayi2)
            //{
            //    Console.WriteLine($"Büyük sayı1: ({sayi1}");

            //    {
            //        else if (sayi2>sayi1)
            //    }
            //    {
            //        Console.WriteLine($"Büyük sayı1: ({sayi2}")
            //    }
            //    else
            //    {

            //    }

            //hatalı yazdırma
            //Girilen 3 sayıdan büyük olanı yazdıralım
            //Bu doğru olmayan bir algoritma
            //    Console.Write("1.sayıyı gir: ");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("2.sayıyı gir: ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("3.sayıyı gir: ");
            //    int sayi3 = Convert.ToInt32(Console.ReadLine());

            //   if (sayi1>sayi2)
            //{
            //    if (sayi1>sayi3)
            //    { 
            //Console.WriteLine(sayi2);
            //{
            //    if (sayi)
            //}

            //Girilen 3 sayıdan büyük olanı yazdıralım

            //    Console.Write("1.sayıyı gir: ");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("2.sayıyı gir: ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("3.sayıyı gir: ");
            //    int sayi3 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 > sayi2 && sayi1 > sayi3)
            //{
            //    Console.WriteLine(sayi1);
            //}
            //else if (sayi2 >= sayi1 && sayi2 >= sayi3)
            //{
            //    Console.WriteLine(sayi2);
            //}

            //else if (sayi3 >= sayi1 && sayi3 >= sayi2)

            //

                Console.Write("1.sayıyı gir: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.sayıyı gir: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
               string sonuc = sayi1 > sayi2 ? "1.Sayı 2.Sayıdan büyüktür."

            sayi2 > sayi1 ? "2.Sayı 1.Sayıdan Büyüktür." :
            sayi2 > sayi1 ? "İki sayı birbirine eşittir.";
            
            Console.WriteLine(sonuc);


              //  int buyukSayı = sayi1 > sayi2 ? sayi1 : sayi2;
              //  Console.WriteLine(buyukSayı);





        }
    }
    
}