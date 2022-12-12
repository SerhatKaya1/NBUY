using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core
{
    public static class Jobs  //Url oluşturmak istiyoruz.
    {
        public static string InitUrl(string url)
        {
            #region Açıklamalar
            /*Bu metot kendisine gelen url değişkeninin içindeki 
             1) Latin alfabesine çevrilirken problem çıkaran    İ-i , ı-i gibi dönüşümleri yapacak.
             2) Diğer Türkçe karakter yerine latin alfabesindeki karşılıkları koyacak.
            3-) Boşluklar yerine - koyacak.
            4) Nokta(.), slash(/) ifadeler kaldırılacak
             */
            #endregion



            url = url.Replace("I", "i");
            url = url.Replace("İ", "i"); //Bunları kendim çevirdim .
            url = url.Replace("ı", "i");


            url = url.ToLower();
            //ş ye s çevirmesi gerektiğini bilmiyr ben söyleyeceğim.

            url = url.Replace("ö", "o");
            url = url.Replace("ü", "u");
            url = url.Replace("ş", "s");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");

            url = url.Replace("ö", "o");
            url = url.Replace("ö", "o");
            url = url.Replace("ö", "o");
            url = url.Replace("ö", "o");

            url = url.Replace(" ", "-");
            url = url.Replace(".", "");
            url = url.Replace("/", "");
            url = url.Replace("\\", "");
            url = url.Replace("'", "");
            url = url.Replace("(", "");
            url = url.Replace(")", "");
            url = url.Replace("[", "");
            url = url.Replace("]", "");
            url = url.Replace("{", "");
            url = url.Replace("}", "");

            return url;

        }
    }
}
