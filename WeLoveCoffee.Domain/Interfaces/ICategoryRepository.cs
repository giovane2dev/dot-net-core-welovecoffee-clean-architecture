using System.Collections.Generic;
using System.Threading.Tasks;
using WeLoveCoffee.Domain.Entities;

namespace WeLoveCoffee.Domain.Interfaces
{
    public interface ICategoryRepository
    {       
        Task<Category> CreateAsync(Category category);
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<Category> GetByIdAsync(int? id);
        Task<Category> UpdateAsync(Category category);
        Task<Category> DeleteAsync(Category category);
    }
}