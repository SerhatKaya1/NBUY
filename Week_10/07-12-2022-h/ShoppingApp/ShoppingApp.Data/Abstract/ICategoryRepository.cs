using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        //Categorye özgü memberler burada olacak.
        //örnek aşağıdaki gibidir
        Category GetByIdWithProducts(); 
    }
}
