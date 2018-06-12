using BillingSystem.Application.Applicant.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Application
{
    public interface ICompanyService
    {
        List<CompanyDto> GetCompanies();

        Task<CompanyDto> GetCompany(int id);
        List<CompanyLookUpDto> GetCompanyLookUp();
        
            Task CreateCompany(CompanyInput input);
        Task UpdateCompany(CompanyDto input);
        Task DeleteCompany(int id);
    }
}
