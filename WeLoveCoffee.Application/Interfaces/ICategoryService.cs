using System.Collections.Generic;
using System.Threading.Tasks;
using WeLoveCoffee.Application.DTOs;

namespace WeLoveCoffee.Application.Interfaces
{
    public interface ICategoryService
    {
        Task CreateAsync(CategoryDTO category);
        Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();
        Task<CategoryDTO> GetByIdAsync(int? id);
        Task UpdateAsync(CategoryDTO category);
        Task DeleteAsync(CategoryDTO category);
    }
}