using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IRepository<T>    //Bunlardan miras alan yerlerin içi doldurulacak
    {
        Task<T> GetByIdAsync(int id); //id ye göre entity getirecek. eğer bir asenkron yapılandırma varsa asenkron olan metotları anlamaya yarıyor.
        Task<List<T>> GetAllAsync(int id);   // ilgili entity ile ilgili tüm kayıtları getirecek.
       Task CreateAsync(T entity); //yeni kayıt yaratacak
       void Update(T entity); //kayıt güncelleme
       void Deete(T entity); //kayıt silinecek


    }
}
