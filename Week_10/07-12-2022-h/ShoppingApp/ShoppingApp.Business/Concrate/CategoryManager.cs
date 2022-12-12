using ShoppingApp.Business.Abstract;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Business.Concrate
{
    public class CategoryManager : ICategoryService
    {
        public Task<Category> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(Category category)
        {
          await  _unitOfWork.Categories.CreateAsync(category);
            await _unitOfWork.SaveAsync();
        }

        public void Delete(Category category)
        {
            _unitOfWork.Categories.Delete(category);
            _unitOfWork.Save();
        }

        

        public async Category GetByIdWithProducts()
        {
            return await _unitOfWork.Categories.GetByIdAsync(id);
        }

        public Task<System.Collections.Generic.List> GetByNameAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            _unitOfWork.Categories.Update(category);
            _unitOfWork.Save();
        }
    }
}
