using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IUnitOfWork : IDisposable ///merkezi yerden işlemlerimizi yönetmek için yapıyoruz.
    {
        ICategoryRepository Categories { get; }
        IProductRepository Products { get; }
        Task SaveAsync();
        
    }
}
