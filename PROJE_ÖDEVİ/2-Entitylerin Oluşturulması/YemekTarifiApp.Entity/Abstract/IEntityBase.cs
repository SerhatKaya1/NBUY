using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifiApp.Entity.Abstract
{
    public class IEntityBase
    {
        public int Id { get; set; }
    }
}

/*
 EntityBase sınıfı , genellikle MCV(Model-View-Controller) tabanlı bir uygulamada 
bir tasarım kalııdır. Bu sınıf, veri tabanındaki bir tablonun göstericisini temsil eden bir
bir "entity" sınıfı oluşturmak için kullanılır.Bu sınıftan miras alınmaması, bir entity 
sınıfının tasarımını standartlaştırmak ve bu sınıfın veri tabanındaki bir tablo ile ilişki-
lendirilmesi için gereken bazı özellikleri sağlamak için yapılır . Örneğin; IEntityBase sınıfı
genellikle bir "Id" değişkeni içererek, veri tabanındaki bir tablonun primary key alanını
temsil eden bir değişken sağlar.
 */
