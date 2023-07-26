using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeLoveCoffee.Domain.Entities;
using WeLoveCoffee.Domain.Interfaces;
using WeLoveCoffee.Infra.Data.Context;

namespace WeLoveCoffee.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext categoryContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            categoryContext = applicationDbContext;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            categoryContext.Add(category);
            await categoryContext.SaveChangesAsync();

            return category;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await categoryContext.Categories.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int? id)
        {
            return await categoryContext.Categories.FindAsync(id);
        }        

        public async Task<Category> UpdateAsync(Category category)
        {
            categoryContext.Update(category);
            await categoryContext.SaveChangesAsync();

            return category;
        }

        public async Task<Category> DeleteAsync(Category category)
        {
            categoryContext.Remove(category);
            await categoryContext.SaveChangesAsync();

            return category;
        }
    }
}