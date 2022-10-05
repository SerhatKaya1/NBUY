namespace Proje04_TipDönütürme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            byte a = 5;
            short b = 10;
            sbyte c = 30;
            int d = a + b + c;  //Implicit convert - Örtülü dönüştürme
            Console.WriteLine($"Sonuç(d)= {d}");

            string metin = "NBUY";
            char karakter = 'k'
            object e = metin + karakter + d;    //Implitic Convert
            Console.WriteLine($"Objet= {e}"); ///int yerine object yazdık .3 unun ortak noktası
            // hepsinin ortak atası object kabul edilir. c# için genel bir object olduğunu bil .
            */
            /*
            byte a = 155;
            byte b = 101;
            byte c = Convert.ToByte(a + b);  // kızar. bu değer sığmaz.Convert.ToByte(a+b); yapmak lazım
                                                 //Explicit Convert- Biçli dönüüm
            Console.WriteLine($"Sonuç(c): {c}");

            byte d = (byte)(a + b);  //Unboxing
            Console.WriteLine($"Sonuç(d);
            */

            // int a = 511;
            //byte b = (byte)a;
            // Console.WriteLine(b);

            byte a = 155;
            byte b = 111;
            int c = a + b;
            Console.WriteLine(c);

           Convert.ToDouble(c);
           Convert.ToInt64(c);


        }
    }
}