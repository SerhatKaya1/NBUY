using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiApp.Entity.Concrate;

namespace YemekTarifiApp.Data.Config
{
    public class FoodConfig : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).ValueGeneratedOnAdd();

            builder.Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(f => f.Material)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(f => f.Description)
                .IsRequired()
                .HasMaxLength(900);

            builder.Property(p => p.ImageUrl)
               .IsRequired()
               .HasMaxLength(250);

            builder.Property(f => f.Url)
                .IsRequired();

            builder.Property(f => f.AddDate)
                .HasDefaultValueSql("date('now')");

            builder.HasKey(f => f.Point);
            builder.Property(f => f.Point).ValueGeneratedOnAdd();

            builder.ToTable("Foods");

            builder.HasData(
                //5 ADET ÇORBA EKLEYELİM
                 new Food { Id=1, Name= "Borscht Çorbası", 
                  Material = "2 – 3 yemek kaşığı zeytinyağı\r\n1 adet soğan\r\n2 adet patates\r\n½ adet küçük mor lahana\r\n1 adet havuç\r\n1 adet kırmızı kapya biber\r\n1 adet kereviz sapı\r\n1 diş sarımsak\r\n2 yemek kaşığı domates püresi\r\n3 adet pancar\r\n1 adet defne yaprağı\r\n1 yemek kaşığı beyaz sirke\r\nTuz\r\nKarabiber\r\n3 su bardağı et suyu\r\n7 su bardağı su",
                  Description = "Bu çorba ilk kez Kuzeydoğu Çin'de, Rus sınırından yakın mesafede bulunan Harbin şehrinde ortaya çıktı; zaman geçtikçe bu çorba ta Hong Kong'a kadar yayıldı.",
                  ImageUrl = "1.Png", Url= "borscht-corbası", IsHome = true , IsApproved =true},

                 new Food
                 {
                     Id = 2,
                     Name = "Çeşmi Nigar Çorbası",
                     Material = "¼ su bardağı zeytinyağı\r\n1 adet soğan\r\n1 yemek kaşığı un\r\n1 su bardağı kırmızı mercimek\r\nTuz\r\nKarabiber\r\n7 su bardağı su\r\nTerbiyesi için Malzemeler\r\n1 yumurta sarısı\r\n½ su bardağı süt\r\n1 adet limonun suyu\r\nSosu için Malzemeler\r\n1 yemek kaşığı tereyağı\r\nKuru nane\r\nToz kırmızı biber\r\nPul biber",
                     Description = "Çeşmi nigar çorbası, Osmanlı mutfağından günümüze uzanmış lezzetlerden. Bir tür mercimek çorbası olan çeşmi nigar çorbasının en önemli özelliği, içine eklenen yumurtalı limonlu terbiye",
                     ImageUrl = "2.Png",
                     Url = "cesmi-nigar-corbasi",
                     IsHome = true,
                     IsApproved = true
                 },

                 new Food
                 {
                     Id = 3,
                     Name = "Ezogelin Çorbası",
                     Material = "2 yemek kaşığı tereyağı\r\n1 adet orta boy soğan\r\n2 diş sarımsak\r\n1 su bardağı kırmızı mercimek\r\n¼ su bardağı pilavlık bulgur\r\n¼ su bardağı pirinç\r\n2 çay kaşığı tuz\r\n2 çay kaşığı karabiber\r\n7 su bardağı su\r\nMeyanesi için Malzemeler\r\n2 yemek kaşığı tereyağı\r\n1 yemek kaşığı domates salçası\r\n1 yemek kaşığı un\r\nKuru nane\r\nPul biber\r\n2 su bardağı su veya et suyu\r\nKruton için Malzemeler\r\n½ adet ramazan pidesi\r\n2 – 3 yemek kaşığı tereyağı",
                     Description = "Ezogelin çorbası, Türk mutfağına has; domates (veya salçası), pirinç ve kırmızı mercimek ile yapılan bir çorba. Adı, Barak Türkmenlerinden Gaziantep'in Oğuzeli ilçesine bağlı Uruş (yeni adıyla Dokuzyol) köyünden Ezo Gelin'in adından gelir.",
                     ImageUrl = "3.Png",
                     Url = "ezogelin-corbasi",
                     IsHome = true,
                     IsApproved = true
                 },

                  new Food
                  {
                      Id = 4,
                      Name = "Balkabağı Çorbası",
                      Material = "1 tepeleme yemek kaşığı tereyağı\r\n1 adet büyük boy soğan\r\n1 adet patates\r\n750 gr. balkabağı\r\n¼ adet muskat – rende\r\n1 adet yıldız anason\r\nTuz\r\nKarabiber\r\n5 su bardağı et veya sebze suyu\r\n2 yemek kaşığı krema",
                      Description = "Balkabağı çorbası, balkabağı püresinden yapılan genellikle 'bağlı' bir çorbadır. Harmanlanmış balkabağının etinin et suyu veya et suyu ile birleştirilmesiyle yapılır. Sıcak veya soğuk olarak servis edilebilir ve Amerika Birleşik Devletleri'nde yaygın bir Şükran Günü yemeğidir.",
                      ImageUrl = "4.Png",
                      Url = "balkabagı-corbası",
                      IsHome = true,
                      IsApproved = true
                  },

                  new Food
                  {
                      Id = 5,
                      Name = "Naneli Bezelye Çorbası",
                      Material = "2 yemek kaşığı ayçiçek yağı\r\n1 adet soğan\r\n1 diş sarımsak – ezilmiş\r\n1 adet patates\r\n5 su bardağı tavuk suyu\r\n2 su bardağı bezelye\r\n4 – 5 dal taze nane\r\nTuz\r\nKarabiber\r\n1 adet tavuk göğüs – haşlanmış\r\nSüslemek için Malzemeler\r\nTaze nane yaprağı",
                      Description = "Fransız mutfağından alınarak Kanada tarzının eklendiği bezelye çorbası, füme jambon ile yapılıyor.",
                      ImageUrl = "5.Png",
                      Url = "balkabagı-corbası",
                      IsHome = true,
                      IsApproved = true
                  },

                  //5 ADET ETLİ YEMEK YAZALIM

                  new Food
                  {
                      Id = 6,
                      Name = "İsveç Köftesi",
                      Material = "500 gr. orta yağlı kıyma\r\n1 su bardağı panko – ekmek kırıntısı\r\n1 adet yumurta\r\n1 adet orta boy soğan – rende\r\n¼ su bardağı süt\r\n1 tatlı kaşığı sarımsak tozu\r\n1 tatlı kaşığı yenibahar\r\nTuz\r\nKarabiber\r\n1 – 2 yemek kaşığı tereyağı\r\nKrema Sosu için Malzemeler\r\n2 yemek kaşığı tereyağı\r\n1 yemek kaşığı un\r\n2 su bardağı et suyu\r\n1 su bardağı krema – 200 ml.\r\n1 çay kaşığı hardal\r\nTuz\r\nKarabiber\r\nÜzeri için Malzemeler\r\n1 adet bayat ekmek\r\nKaşar peyniri – rende\r\nMaydanoz",
                      Description = "İsveç köftesi genellikle kekreyemiş (lingonberry) reçeli, özel et sosu ve haşlanmış veya kızarmış patatesle birlikte servis edilir. Orijinal ismi “köttbullar” olan İsveç köftesi, İsveç mutfağının geleneksel bir yemeğidir",
                      ImageUrl = "6.Png",
                      Url = "ısvec-koftesi",
                      IsHome = true,
                      IsApproved = true
                  },

                   new Food
                   {
                       Id = 7,
                       Name = "Kayısılı Kuzu Eti",
                       Material = "750 gr. kemiksiz kuzu but ya da kol\r\nTuz\r\nKarabiber\r\n2 yemek kaşığı un\r\n2 yemek kaşığı zeytinyağı\r\n2 adet orta boy soğan\r\n3 adet yeşil biber\r\n1 tutam rendelenmiş taze zencefil\r\n3 su bardağı et suyu\r\n1 tutam tel safran ya da aspir\r\n1 su bardağı sıcak su – safran için\r\n1 limonun suyu\r\n1 tatlı kaşığı tane kişniş\r\n1 su bardağı kuru kayısı\r\n1 adet yeşil biber",
                       Description = "Osmanlı saray mutfağında padişah sofralarında ve sarayın önde gelen paşalarına verilen önemli ziyafetlerde yemek menülerinde de öncelikte yer almıştır. Ayni zamanda ahalide Osmanlı ve Türk Mutfağı, Geleneksel Türk Mutfağı, Yöresel Yemekler, Yöresel Mutfaklar da et yemekleri ve tercih edilen tencere yemekleri arasında kendi yerini almıştır. Domatesin tam olarak keşfedilmeden önce eski Türk topluluklarında ve Osmanlıda yemekler koruk suyu, baharatlar ve kuru meyveler ile tatlandırılıyordu.",
                       ImageUrl = "7.Png",
                       Url = "ısvec-koftesi",
                       IsHome = true,
                       IsApproved = true
                   },

                   new Food
                   {
                       Id = 8,
                       Name = "Meksika Çıtırı: Taco Tarifi",
                       Material = "12\r\nadet\r\nmini lavaş\r\n(ya da taco kabuğu)\r\n3\r\nyemek kaşığı\r\nzeytinyağı\r\n500\r\ngram\r\norta yağlı kıyma\r\n1\r\nadet\r\nküçük boy kuru soğan\r\n(küp küp doğranmış)\r\n1\r\nadet\r\norta boy domates\r\n(püre haline getirilmiş)\r\n1\r\ntatlı kaşığı\r\nacı sos\r\n1\r\ntatlı kaşığı\r\ndomates salçası\r\n1/2\r\nçay kaşığı\r\ntuz\r\n1/4\r\nçay kaşığı\r\nkimyon\r\n4\r\ndal\r\ntaze kişniş\r\n(ya da maydanoz)\r\nServisi için:\r\n1/2\r\ndemet\r\nmaydanoz\r\n(ince kıyılmış)\r\n1/2\r\nadet\r\navokado\r\n1\r\nadet\r\nbüyük boy domates\r\n(küp küp doğranmış)\r\n1\r\nadet\r\norta boy kırmızı soğan\r\n(küp küp doğranmış)\r\n1/2\r\nsu bardağı\r\nrendelenmiş kaşar peyniri\r\n1/2\r\nsu bardağı\r\nrendelenmiş cheddar peyniri",
                       Description = "Taco, (İspanyolca: Taco) geleneksel Meksika yemeği. Birçok şekilde yapılabilmektedir. Yapımında tortilla, et, peynir ve çeşitli sebzeler kullanılır. Ayrıca, yanında bazı garnitürler de tüketilebilir.",
                       ImageUrl = "8.Png",
                       Url = "meksika-citiri-taco",
                       IsHome = true,
                       IsApproved = true
                   },

                      new Food
                      {
                          Id = 9,
                          Name = " Narlı Kuzu Eti",
                          Material = "1 yemek kaşığı tereyağı\r\n1 yemek kaşığı zeytinyağı\r\n1 kilo kuzu eti – iri kuşbaşı\r\n20 – 25 adet arpacık soğan\r\n1 yemek kaşığı domates salçası\r\n1 yemek kaşığı un\r\nTuz\r\nKarabiber\r\n2 – 3 dal taze kekik\r\n1 tutam tane kişniş\r\n1 yemek kaşığı nar ekşisi\r\n4 su bardağı sıcak su\r\n2 adet defne yaprağı\r\nÜzeri için Malzemeler\r\n1 su bardağı nar tanesi\r\n3 dal taze soğanın yeşil kısmı",
                          Description = " Sonbahar ve kış aylarında Topkapı sarayında yapılan bir yemekti. Osmanlı döneminde ''rummamiye'' denilen bu yemek, yıllar içerisinde unutulmayarak günümüz mutfağında da yer almaktadır. ",
                          ImageUrl = "9.Png",
                          Url = "narlı-kuzu-eti",
                          IsHome = true,
                          IsApproved = true
                      },

                      new Food
                      {
                          Id = 10,
                          Name = " Etli Fajita",
                          Material = "600 gram julyen doğranmış dana bonfile\r\n1 adet kırmızı Kaliforniya biberi\r\n1 adet sarı Kaliforniya biberi\r\n1 adet yeşil biber\r\n1 baş kırmızı kuru soğan\r\nYarım çay bardağı zeytinyağı\r\n2 yemek kaşığı soya sosu\r\nEt marinasyonu için;\r\n\r\n1 yarım limon suyu\r\n1 çay bardağı zeytinyağı\r\nYarım çay bardağı soya sosu\r\n2 diş sarımsak\r\n1 çay kaşığı karabiber\r\n1 tatlı kaşığı kekik tuz, tatlı toz biber",
                          Description = " Fajita, Meksika mutfağına ait bir etli yemek türüdür. Orijinal olarak dana eti ile yapılan yemek günümüzde tavuk ve karides ile yapılmaktadır. Yemek tortilla ekmeği ile birlikte servis edilmektedir. ",
                          ImageUrl = "10.Png",
                          Url = "etli-fajita",
                          IsHome = true,
                          IsApproved = true
                      },

                      // 5 adet TAVUK YEMEKLERİ YAZALIM
                      new Food
                      {
                          Id = 11,
                          Name = " Tavuk Nugget ",
                          Material = "2 adet tavuk göğsü\r\n2 adet yumurta\r\n2 yemek kaşığı un\r\n2 yemek kaşığı zeytinyağı\r\n1 tutam tuz\r\n1 tutam karabiber\r\nPanelemek için Malzemeler\r\n1 su bardağı un\r\n2 adet yumurta\r\n1 su bardağı galeta unu\r\nKızartmak için Malzemeler\r\nAyçiçek yağı",
                          Description = "Şnitzel veya şinitzel (Almanca: Wiener Schnitzel), Avusturya mutfağından, gayet ince kesilmiş bir dilim dana, domuz veya tavuk etinin sırasıyla una, yumurta sarısına ve galeta ununa bandırılarak kızgın yağda kızartılmasıyla yapılan bir yemek türüdür.",
                          ImageUrl = "11.Png",
                          Url = "tavuk-nugget",
                          IsHome = true,
                          IsApproved = true
                      },

                      new Food
                      {
                          Id = 12,
                          Name = " Tavuklu Kağıt Kebabı ",
                          Material = "2 – 3 yemek kaşığı zeytinyağı\r\n1 adet patlıcan\r\n1 adet kabak\r\n1 adet patates\r\n2 adet tavuk göğüs\r\n10 – 15 adet arpacık soğan\r\n1 su bardağı bezelye – haşlanmış ya da dondurulmuş\r\n3 – 4 diş sarımsak\r\n10 adet siyah zeytin\r\nSosu için Malzemeler\r\n3 yemek kaşığı zeytinyağı\r\n2 yemek kaşığı az tuzlu soya sosu\r\n1 tatlı kaşığı domates salçası\r\n1 tatlı kaşığı biber salçası\r\nTuz\r\nKarabiber\r\nKuru kekik\r\n1 avuç ceviz – iri dövülmüş",
                          Description = "Antakya Kâğıt Kebabı; dana döş eti, yeşil ve kırmızı biber (acı veya tatlı) maydanoz, sarımsak, tuz ve karabiber karışımından oluşan, disk şekli verilerek yağlı kağıt üzerinde pişirilen, yörede Arapça olarak “lahme la varka” olarak da bilinen bir kebaptır.",
                          ImageUrl = "12.Png",
                          Url = "tavuklu-kagit-kebabi",
                          IsHome = true,
                          IsApproved = true
                      },


                 );

           


        }
    }
}
