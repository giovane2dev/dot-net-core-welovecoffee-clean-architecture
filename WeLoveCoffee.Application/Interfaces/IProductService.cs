using System.Collections.Generic;
using System.Threading.Tasks;
using WeLoveCoffee.Application.DTOs;

namespace WeLoveCoffee.Application.Interfaces
{
    public interface IProductService
    {
        Task CreateAsync(ProductDTO product);
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetByIdAsync(int? id);
        Task UpdateAsync(ProductDTO product);
        Task DeleteAsync(ProductDTO product);
    }
}