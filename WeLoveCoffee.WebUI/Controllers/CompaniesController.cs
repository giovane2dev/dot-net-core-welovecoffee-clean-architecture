using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeLoveCoffee.Application.Interfaces;

namespace WeLoveCoffee.WebUI.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ICompanyServices _companyServices;

        public CompaniesController(ICompanyServices companyServices)
        {
            _companyServices = companyServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var companies = await _companyServices.GetCompaniesAsync();

            return View(companies);
        }
    }
}
