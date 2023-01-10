using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid01_Single_SingleResponsibility.After
{
    public class EmailSender
    {
        void SendEmail(string text)
        {
            EmailSender emailSender= new EmailSender();
            emailSender.SendEmail("Kaydınız başarıyla gerçekleşmiştir..")
        }
    }
}
