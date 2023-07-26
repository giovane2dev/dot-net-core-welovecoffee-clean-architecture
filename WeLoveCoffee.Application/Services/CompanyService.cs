using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using WeLoveCoffee.Application.DTOs;
using WeLoveCoffee.Application.Interfaces;
using WeLoveCoffee.Domain.Entities;
using WeLoveCoffee.Domain.Interfaces;

namespace WeLoveCoffee.Application.Services
{
    public class CompanyService : ICompanyServices
    {
        private ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
                _companyRepository = companyRepository;
                _mapper = mapper;
        }

        public async Task CreateAsync(CompanyDTO company)
        {
            var companyEntity = _mapper.Map<Company>(company);

            await _companyRepository.CreateAsync(companyEntity);
        }

        public async Task<IEnumerable<CompanyDTO>> GetCompaniesAsync()
        {
            var companiesEntity = await _companyRepository.GetCompaniesAsync();

            return _mapper.Map<IEnumerable<CompanyDTO>>(companiesEntity);
        }

        public async Task<CompanyDTO> GetByIdAsync(int? id)
        {
            var companiesEntity = await _companyRepository.GetByAsyncId(id);

            return _mapper.Map<CompanyDTO>(companiesEntity);
        }

        public async Task UpdateAsync(CompanyDTO company)
        {
            var companyEntity = _mapper.Map<Company>(company);

            await _companyRepository.UpdateAsync(companyEntity);
        }

        public async Task DeleteAsync(CompanyDTO company)
        {
            var companyEntity = _mapper.Map<Company>(company);

            await _companyRepository.DeleteAsync(companyEntity);
        }
    }
}
