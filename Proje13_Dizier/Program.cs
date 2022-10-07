namespace Proje13_Dizier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string adSoyad = "Fatih Candan, Cemal Gündem, Selin Dilci";
            //Console.WriteLine(adSoyad);
            //string ad;
            //ad = "Engin";
            //string[] adlar = new string[7];//İçinde 3 adet string bigi tutabilecek bir dizi.
            //adlar[0] = "Fatih Candan";
            //adlar[1] = "Cemal Gündem";
            //adlar[2] = "Selin Dilci";          
            //adlar[3] = "Kemal Kurt";
            //adlar[4] = "Begüm Yancı";
            //adlar[5] = "Selma Halıcı";
            //adlar[6] = "Emre Mor";
            ///* Console.WriteLine(adlar[0]);*/


            //for (int i = 0; i < adlar.Length; i++) //özel metotlar var . Bnları kulanmak zounu değil

            //{
            //    Console.WriteLine(adlar[i]);
            //}

            //int[] yaslar = new int[3];
            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };
            ////int toplam = 0;

            //for (int i = 0; i < rakamlar.Lengt; i++) 
            //{
            //    toplam += rakamlar[i];
            //}
            //Console.WriteLine(toplam);
            //string okul = "Wissen Akademie";
            //Console.WriteLine(okul[8]);

            //ÇALIŞMA : Klavyeden kulanıcının adı soyadını girmesini isteyiniz.
            //Girilen ad soyadı aşağıya doğru yazdırınız.
            //Engün Niyazi Ergül

            //Console.WriteLine("Adınızı giriniz");
            //string ad = Console.ReadLine().ToUpper();
            //for (int i = 0; i < ad.Length; i++)
            //{
            //    Console.WriteLine(ad[i]);
            //}

            //Console.WriteLine("Bir metin giriniz: ");
            //string girilenMetin = Console.ReadLine);
            //Console.WriteLine("Hangi karakterin sırasını bumamı istersiniz ");
            //string karakter = Console.ReadLine().ToLower;
            //int siraNO = girilenMetin.IndexOf(karakter)+1;
            //Console.WriteLine("******");
            //Console.WriteLine($"GirilenMetin : {girilenMetin}\nAradığınız Karakter: {karakter}\nAradığınız Karakterin Girilen Metindeki Sırası: {siraNo}");


            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i}.Eleman: {rakamlar[i]});
            //}

            // Kendimiz en büyük sayıyı bulunuz.
            //int enBuyuk = rakamlar[0];
            //int enKucuk = rakamlar[0];
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    if (rakamlar[i]>enBuyuk)
            //    {
            //      enBuyuk = rakamlar[i];
            //    }
            //    if(rakamlar[i] < enKucuk)

            //    {
            //        enKucuk = rakamlar[i];
            //    }


            //}

            //isteğe bağı çalışma ödev, : Bu diziyi küçükten büyüğe doğru sıralayınız

            //Console.WriteLine($"En Küçük:\t{rakamlar.Min{}");
            //Console.WriteLine($"En Buyuk:\t{rakamlar.Max{}");

            //Console.WriteLine("Dizinin Ters Çevrimiş Hali");
            //Console.WriteLine("**************************");
            //Array.Reverse(rakamlar);
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    cw
            //}

            // Console.WriteLine("Dizinin Küçükten Büyüğe Sıralanmı Hali");
            // Console.WriteLine("**************************");
            // Array.Short(rakamlar);
            // for (int i = 0; i < rakamlar.Length; i++)
            //  



            //Console.WriteLine("Dizinin Küçükten Büyüğe Sıralanmı Hali");
            //Console.WriteLine("**************************");
            //Array.Sort(rakamlar);
            //Array.Reverse(rakamlar);


            //ÖRNEKLER
            //ÖRNEK:1
            //int[] sayılar = { 5, -16, 8, 12, -15, 78, 90, 0 };
            //int toplam = sayılar.Sum();
            //Console.WriteLine($"{toplam}");

            //ÖRNEK2:SAYILAR DİZİSİNDEKİ ÇİFT SAYILARI EKRANA YAZDIRALIM
            //ÖRNEK3: sayıar dizisindeki sayıları yanlarında pozitif negatif yada 0 işaretsiz olarak yazdıralım.
            //string tip = "";
            //for (int i = 0; i < sayılar.Length; i++)
            //{
            //    tip = sayilar[i] > 0 ? "Pozitif" : sayilar[i] < 0 ? "Negatif" : "İaretsiz";
            //    Console.WriteLine($"{i+1}.Sayi: {i} - Tipi:{tip}");

            //}

            //ÖRNEK 4: kullanıcının gireceği bir metnin içndeki sesli harf sayısını ekrana yazdıralım 
            //char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            //int sesliHarflerAdedi = 0;
            //Console.WriteLine("Bir metin giriniz. ");
            //string girilenMetin = Console.ReadLine().ToLower();
            //for (int i = 0; i < girilenMetin.Length; i++)
            //{
            //    if(sesliHarfler.Contains(girilenMetin[i]))
            //}
            //    sesliHarfler
            // Console.WriteLine(sesli);

            //ÖRNEK5: Klavyeden girilen bir cümledeki yine klavyedem girilecek bir kelimenin kaç kez geçtiğini bulduralım .

            //string ornekMetin = "Mustafa Kemal Atatürk";
            //string[] sozcukDizisi = ornekMetin.Split(" ");
            //for (int i = 0; i < sozcukDizisi.Length; i++)
            //{
            //    Console.WriteLine(sozcukDizisi[i]);
            //}

            int sozcukAdedi = 0;
            Console.WriteL("Cümleyi Giriniz");
            string girilenCumle = Console.ReadLine();
            Console.WriteLine("Adedini Bulmak İstediğiniz sözcüğü giriniz: ");
            string sayılacakSozcuk = Console.ReadLine();
            string[] girilenCumleninDiziHali = girilenCumle.Split(" ");
            for (int i = 0; i < girilenCumleninDiziHali.Length; i++)
            {
                if (sayılacakSozcuk.ToLower() == girilenCumleninDiziHali[i].ToString().ToLower())
                {
                    sozcukAdedi++;
                }

            }
            Console.WriteLine($"{girilenCumle}' cümle içinde '{sayılacakSozcuk}' sözcüğü {sozcukAdedi} kez geçmektedir!");
            //***********************
            //ARAŞTIRMA ÖDEVİ:Çok boyutlu dizileri araştırın
            //***********************
            //PROJE ODEVİ
            /* İçinde Türkçe karakterler hariç tüm harfler, 0-9 arası rakamlar , nokta(.),virgül(,), artı(+), eksi(-) karakterleri bulabilecek toplam uzunluğu 6 karakter oacak şekilde Rastgele Şifre üreten programı yazınız.
            






        }
    }
}
