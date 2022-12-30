using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public class ICardItemRepository : IRepository<CardItem>
    {
        public Task CreateAsync(CardItem entity)
        {
            
        }

        
    }
}
