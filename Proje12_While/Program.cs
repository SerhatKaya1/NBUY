namespace Proje12_While;
class Program
{
    static void Main(string[] args)
    {
        // int sayac=1;
        // while (sayac<=5)          
        // {
        //     Console.WriteLine("Hello, World!");
        //     sayac++;
        // }

        //  int toplam = 0;
        //  string girilenDeger="";
        //  int sayac = 1;
        //  while (girilenDeger != "exit")        
         
         
        //     Console.Write($"{sayac"}.sayıyı giriniz(Çıkış için exit): ");
        //     girilenDeger = Console.ReadLine();
        //    if (girilenDeger!="exit") toplam += 
        //   try
        //   {
        //     toplam += Convert.ToInt32(girilenDeger);
        //   }
        //    catch (System.Exception)

        //    {
        //     Console.Writeline(toplam);
        //     break;

        //    }
        //         sayac++;

        //SORU : KLAVYEDEN EXİT YAZIANA KADAR İSİM GİRİMESİNİ İSTEYEN PROGRAM 

        // string isim ="";
        // while (isim!="exit")
        // {
        //     Console.Write("İsim giriniz: ");
        //     isim =  Consol.Readline();

        // }
        //  Console.WriteLine("Program sona erdi...");

        //ÇÖZÜM 2
        // string isim;
        // do 
        // {
        //    Console.WriteLine( "İsim Giriniz: " );
        //    isim=Console.ReadLine();
        // } while (isim!="exit");
        // Console.WriteLine("Program sona erdi...");


        //KLAVYEDEN EXİT YAZILANA KADAR SAYI ALMAYA DEVAM EDEN VE BU SAYILARIN TOPAMINI EXİT YAZILINCA EKRANA YAZAN PROGRAM 
        // string girilenDeger;
        // int sayac=1;
        // int toplam = 0;

        // do
        // {
        //     Console.WriteLine($"{sayac}.sayıyı giriniz: ");
        //     girilenDeger = Console.ReadLine();
        //     if(girilenDeger!="exit") toplam += Convert.ToInt32(girilenDeger);
        // } while (girilenDeger!="exit");

         //DİZİLER
        //  Random rastgele = new Random();
        //  int rastgeleSayi = rastgele.Next();
        //  Console.WriteLine(rastgeleSayi);
        //  int rastgeleSayi2 = rastgele.Next(100); //0-100 arasında rastgee sayı üretir. 0 dahi,100 hariçtir.dotnet
        //  Console.WriteLine(rastgeleSayi2);
        //  int rastgeleSayi3 = rastgele.Next(1000,2000); // 1000 ile 2000 arasında rastgee sayı üretir. 1000 dahi , 2000 hariçtir.
        //  Console.WriteLine(rastgeleSayi3);

           //OYUN : Uyguamanın rastgele üreteceği bir sayıyı tahmin etmesini isteyeceğiz.
           // Rastgele üretilecek sayı 1-11 arasında olsun .
            //Kulanıcı rastgee sayıdan küçük yada büyük bir sayı girdiğinde kullanıcıya uygun bir mesaj versilsin.
           //Doğru sayıyı tahmin edene kadar uygulama çalışsın.
           //Kulanıcı dogru sayıyı tahmin ettiyse ya da 5 


            Random rnd = new Random();
            int uretilenSayi = rnd.Next(1,101);
            Console.WriteLine($"HİLE: {uretilenSayi}");
            Console.WriteLine("****************");
             int tahminEdilenSayi;
             int hak=1;//Kullanıcının o sırada kaçıncı hakkını kullandığı bilgisi
             int hakSiniri=5;//Kullanıcının toplam kaç hakka sahip olduğu bilgisi
            //  do
         //   {
         //     Console.Write($"{hak}.Tahmininizi giriniz(1-100): ");
         //    tahminEdilenSayi=Convert.ToInt32(Console.ReadLine());
         //    hak++;
         //    if (tahminEdilenSayi>uretilenSayi)
         //    {
         //     Console.WriteLine("Büyük bir değer girdiniz, daha küçük bir değer girerek yeniden deneyiniz!");
         //    }
         //    else if (tahminEdilenSayi<uretilenSayi)
         //    {
         //       Console.WriteLine("Küçük bir değer girdiniz, daha büyük bir değer girerek yeniden deneyiniz!");
         //    }
         //    else
         //    {
         //        Console.WriteLine("Tebrikler, bildiniz!");
              //    }      //   } while (tahminEdilenSayi!=uretilenSayi && hak<=hakSiniri);

               do
        {
            Console.Write($"{hak}.Tahmininizi giriniz(1-100): ");
            tahminEdilenSayi=Convert.ToInt32(Console.ReadLine());
            hak++;
            if (tahminEdilenSayi>uretilenSayi)
            tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
            if (tahminEdilenSayi > uretilenSayi)
            {
                Console.WriteLine("Büyük girdin");
            }
            else if (tahminEdilenSayi < uretilenSayi)
            {
                Console.WriteLine("Büyük bir değer girdiniz, daha küçük bir değer girerek yeniden deneyiniz!");
                Console.WriteLine("Küçük girdin");
            }
            else if (tahminEdilenSayi<uretilenSayi)
            if (tahminEdilenSayi != uretilenSayi)
            {
                Console.WriteLine("Küçük bir değer girdiniz, daha büyük bir değer girerek yeniden deneyiniz!");
                hak++;
                if (hak <= hakSiniri)
                {
                    Console.WriteLine("Kaybettin!");
                }
            }
            else
            {
                Console.WriteLine("Tebrikler, bildiniz!");
                Console.WriteLine("Kazandın!");
            }
        } while (tahminEdilenSayi!=uretilenSayi && hak<=hakSiniri);

        } while (tahminEdilenSayi != uretilenSayi && hak <= hakSiniri);
        //Eğer program bu satıra gelmiş ise ya doğru tahminde bulunulmuştur ya da hak sona ermiştir.
    }
}
                 
   
      

        
         
            
        
