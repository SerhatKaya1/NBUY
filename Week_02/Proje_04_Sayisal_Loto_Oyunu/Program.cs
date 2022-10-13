namespace Proje_04_Sayisal_Loto_Oyunu
{
    internal class Program
    {
        static int[] SayiUret()
        
        {
            Random rnd = new Random();
            int[] loto = new int[6];
            int sayi;
            for (int i = 0; i < 6; i++)
            {
                
                do
                {
                    sayi = rnd.Next(1, 50);

                }   while (loto.Contains(sayi));
                    loto[i] = sayi;
            }
                   return loto;
        }            
        static void Main(string[] args)
        {
            /*
             * 1) Sistem 1-49 arasında 6 tane farklı üretsin.
             * 2-) Kuanıcıdan 6 tahmin alalım.
             * 3-) Sonuç olarak kulanıcının kaç tane doğru tahmin yaptığını yazalım.
             * 4-) Not: Hiç doğru tahmin yapamazsa Kaybettiniz yazsın.
             */
            int[] loto = SayiUret();
            Hile(loto);
            int tahmin;
            
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    tahmin = TahminYap(i + 1);
                }   while (tahmin<0 || tahmin>49);
                    tahminler[i] = tahmin;
            }
              arrayList bilinener = new arrayList   //Arraylisterin kaç elemanlı olacağı söyenmez! İçinde her bir eleman istenilen tipte değer tutabilir, int , string , char vb.
              
                
            Console.ReadLine();

        }
    }
}