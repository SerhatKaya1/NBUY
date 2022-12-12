﻿using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Context;
using ShoppingApp.Data.Concrete.EfCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopAppContext _context;

        public UnitOfWork(ShopAppContext context)
        {
            _context = context;
        }

        private EfCoreCategoryRepository _categoryRepository;
        private EfCoreCategoryRepository _productRepository;

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new EfCoreCategoryRepository(_context);

        public IProductRepository Products => _productRepository = _productRepository ?? EfCoreProductRepository(_context);

        public void Dispose()
        {
           _context.Dispose();

        }

        public Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
