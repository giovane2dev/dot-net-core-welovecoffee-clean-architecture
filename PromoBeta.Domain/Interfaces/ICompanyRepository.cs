using PromoBeta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoBeta.Domain.Interfaces
{
    public interface ICompanyRepository
    {
        Task<Company> CreateAsync(Company company);
        Task<IEnumerable<Company>> GetCompaniesAsync();
        Task<Company> GetByAsyncId(int id);
        Task<Company> UpdateAsync(Company company);
        Task<Company> DeleteAsync(Company company);
    }
}
