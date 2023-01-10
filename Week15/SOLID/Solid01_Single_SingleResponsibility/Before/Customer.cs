using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid01_Single_SingleResponsibility.Before
{
    public class Customer
    {
        void Login(string username, string password)
        {
            //Login işlemleri ile ilgili kodlar
        }

        void Register(string username, string password)
        {
            //Register İşlemleri
            SendMail("Kaydınız başarıyla gerçekleşmiştir.");
        }

        void SendMail(string text)
        {
            //Mail gönderme ile ilgili kodlar 
        }
    }
}
