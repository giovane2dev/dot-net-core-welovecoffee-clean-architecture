﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeLoveCoffee.Domain.Entities;
using WeLoveCoffee.Domain.Interfaces;
using WeLoveCoffee.Infra.Data.Context;

namespace WeLoveCoffee.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext productContext;

        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            productContext = applicationDbContext;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            productContext.Add(product);
            await productContext.SaveChangesAsync();

            return product;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await productContext.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
            return await productContext.Products.FindAsync(id);
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            productContext.Update(product);
            await productContext.SaveChangesAsync();

            return product;
        }

        public async Task<Product> DeleteAsync(Product product)
        {
            productContext.Remove(product);
            await productContext.SaveChangesAsync();

            return product;
        }
    }
}