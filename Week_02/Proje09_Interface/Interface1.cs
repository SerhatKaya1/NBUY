using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje09_Interface
{
    public interface Interface1
    {
       public int Id { get; set; } 
        public string Name { get; set; }   
        public DateTime CreatedDate { get; set; }

    }
     public interface IGeneral2 : IGeneral
     {
        public string NameToUpper();
     }
    //NameToUpper kulanılacak
    public class Product : IGeneral2
    {
        public
    }
        
}  