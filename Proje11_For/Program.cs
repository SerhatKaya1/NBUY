namespace Proje11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i < 5; i++)
            //{ 
            //  Console.WriteLine($"{i+1}.Hello, World!");
            //}
            // }

            //Alt alta 11 kere 1 yazan program 
            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    // topam = toplam + i;
            //    toplam = toplam + 1;
            //}
            //Console.WriteLine($"Topam: {toplam}");


            //1-10 Arasındaki çift sayıların toplamını buldurun.
            //int toplam = 0;
            //for (int i = 0; i <=10;  i=i+2)  //i++= i değerini 1 arttır
            //    if (toplam == 0) ;
            //{
            //    toplam += i;     
            //}
            //Console.WriteLine(toplam);

            //int toplam = 0;
            //for (int i = 0; i <=10;  i++)
            //{                            //i++= i değerini 1 arttır
            //    if (i % 2 == 0) toplam += i;
            //{
            //        Console.WriteLine(toplam);
            //    }

            int ciftToplam = 0;
            int tekToplam = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0) toplam += i;
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;

                }


           
            }
        }
    }

}
