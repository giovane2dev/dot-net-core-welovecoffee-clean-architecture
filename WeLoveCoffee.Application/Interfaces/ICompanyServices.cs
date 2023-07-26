using System.Collections.Generic;
using System.Threading.Tasks;
using WeLoveCoffee.Application.DTOs;

namespace WeLoveCoffee.Application.Interfaces
{
    public interface ICompanyServices
    {
        Task CreateAsync(CompanyDTO company);
        Task<IEnumerable<CompanyDTO>> GetCompaniesAsync();
        Task<CompanyDTO> GetByIdAsync(int? id);
        Task UpdateAsync(CompanyDTO company);
        Task DeleteAsync(CompanyDTO company);            
    }
}
