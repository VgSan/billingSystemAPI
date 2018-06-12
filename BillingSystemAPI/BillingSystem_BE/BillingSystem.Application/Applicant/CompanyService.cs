using AutoMapper;
using BillingSystem.Application.Applicant.Dto;
using BillingSystem.Core;
using BillingSystem.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Application
{
    public class CompanyService : ICompanyService
    {
        private readonly IMapper _mapper;
        IGenericRepository<Company> _companyRepository;

        public CompanyService(IMapper mapper,
            IGenericRepository<Company> companyRepository)
        {
            _mapper = mapper;
            _companyRepository = companyRepository;
        }

        public async Task CreateCompany(CompanyInput input)
        {
            Company result = _mapper.Map<Company>(input);
            await _companyRepository.Create(result);
        }

        public List<CompanyLookUpDto> GetCompanyLookUp()
        {
            var listOfCompanies = _companyRepository.GetAll().Select(x => new { x.CompanyId, x.CompanyName }).ToList();
            var result = _mapper.Map<List<CompanyLookUpDto>>(listOfCompanies);
            return result;
        }

        public async Task DeleteCompany(int CompanyID)
        {
            await _companyRepository.Delete(CompanyID);
        }

        public List<CompanyDto> GetCompanies()
        {
           
            List<Company> listOfCompanies = _companyRepository.GetAll().ToList();
            var result = _mapper.Map<List<CompanyDto>>(listOfCompanies);

            //listOfCompanies = listOfCompanies.Where(x => x.ModifiedDate.ToShortDateString() == input.BillDate
            // && x.IsActive == true && x.AddedDate == input.BillDate).ToList();
            //var result = _mapper.Map<List<BowsersDto>>(listOfExperince);

            return result;
        }

   
        public async Task<CompanyDto> GetCompany(int id)
        {
            Company company = await _companyRepository.GetByIdAsync(id);
            var result = _mapper.Map<CompanyDto>(company);
            return result;
        }

        public async Task UpdateCompany(CompanyDto input)
        {
            Company extCom = _companyRepository.GetAll()
                .Where(c => c.CompanyId == input.CompanyId)
                .FirstOrDefault();
            Company result = _mapper.Map<CompanyDto, Company>(input, extCom);

            await _companyRepository.Update(extCom.Id, result);
        }
    }
}
