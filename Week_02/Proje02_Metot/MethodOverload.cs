using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje02_Metot
{
    internal class MethodOverload
    {
        private int price; //Field
        public int Price //Property
        public int Sayi { get; set; } //Property
        public string Name { get; set; }
        //public void DenemeMetodu()//Method

            
        public int Topla(int s1, int s2, int s3=0)

        {
            return s1 + s2;
        }
        // Gönderilem üç sayı arasında istersem toplama, istersem çarpma yapsın.       
        public void DenemeMetodu()
        {
            Console.WriteLine("Merhaba.Ben MethodOverload classındayım");
            Console.WriteLine(Program.Topla(3, 5));

        }
    }
}
