using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeLoveCoffee.Domain.Entities;
using WeLoveCoffee.Domain.Interfaces;
using WeLoveCoffee.Infra.Data.Context;

namespace WeLoveCoffee.Infra.Data.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private ApplicationDbContext companyContext;

        public CompanyRepository(ApplicationDbContext applicationDbContext)
        {
                companyContext = applicationDbContext;
        }

        public async Task<Company> CreateAsync(Company company)
        {
            companyContext.Add(company);
            await companyContext.SaveChangesAsync();

            return company;
        }

        public async Task<IEnumerable<Company>> GetCompaniesAsync()
        {
            return await companyContext.Companies.ToListAsync();
        }

        public async Task<Company> GetByAsyncId(int? id)
        {
            return await companyContext.Companies.FindAsync(id);
        }        

        public async Task<Company> UpdateAsync(Company company)
        {
            companyContext.Update(company);
            await companyContext.SaveChangesAsync();

            return company;
        }

        public async Task<Company> DeleteAsync(Company company)
        {
            companyContext.Remove(company);
            await companyContext.SaveChangesAsync();

            return company;
        }        
    }
}
