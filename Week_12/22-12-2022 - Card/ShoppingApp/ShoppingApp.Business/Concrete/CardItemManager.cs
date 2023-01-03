using ShoppingApp.Business.Abstract;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Business.Concrete
{
    public class CardItemManager : ICardItemService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CardItemManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task ChangeQuantity(int cardItemId, int quantity)
        {
           
        }

        public void Delete(CardItem cardItem)
        {
           _unitOfWork.CardItems.Delete(cardItem);
            _unitOfWork.Save();

        }

        public async Task<CardItem> GetByIdAsync(int id)
        {
            return await _unitOfWork.CardItem.GetByIdAsync(id);
        }
    }
}
