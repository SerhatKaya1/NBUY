using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_03_Sayi_Bulmaca_With_Methods
{
    public static int SayiUret()
    {
        Random rnd = new Random;
        int sayi = rnd.Next(1, 101);
        return sayi;
    }
    public static int TahminGir(int tahminSiraNo)
    {
        Console.Write($"{tahminSiraNo}.tahmininizi giriniz: ");
        return int.Parse(Console.ReadLine());
    }
    public static string TespitEt(int tahmin, int sayi)
    {
        if(tahmin > sayi)
        {
            return "Daha küçük bir sayı gir!";
        }
    public static void Oyna()
    }

    internal class Class1
    {
    }
}
