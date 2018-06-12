using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BillingSystem.Application;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using BillingSystem.Application.Applicant.Dto;

namespace BillingSystem.Web.Host.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Produces("application/json")]
    [Route("api/Company")]
    public class CompanyContoller : Controller
    {
        private readonly IMapper _mapper;
        ICompanyService _companyService;

        public CompanyContoller(IMapper mapper,
            ICompanyService companyService)
        {
            _mapper = mapper;
            _companyService = companyService;
        }

        [HttpGet("GetCompany")]
        public async Task<CompanyDto> GetCompany(int id)
        {
            CompanyDto company = await _companyService.GetCompany(id);
            return company;
        }


        [HttpGet("GetCompanies")]
        public List<CompanyDto> GetCompanies()
        {
            List<CompanyDto> companyList = _companyService.GetCompanies();
            return companyList;
        }

        [HttpGet("CompanyLookUp")]
        public List<CompanyLookUpDto> GetCompanyLookUp( )
        {
            List<CompanyLookUpDto> companyLookUpList = _companyService.GetCompanyLookUp();
            return companyLookUpList;
        }

        [HttpPost("CreateCompany")]
        public async Task CreateCompany(CompanyInput input)
        {
            await _companyService.CreateCompany(input);
        }

        [HttpPost("UpdateCompany")]
        public async Task UpdateCompany(CompanyDto input)
        {
            await _companyService.UpdateCompany(input);
        }

        [HttpPost("DeleteCompany")]
        public async Task DeleteCompany(int id)
        {
            await _companyService.DeleteCompany(id);
        }
    }
}