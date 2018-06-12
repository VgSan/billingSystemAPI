using AutoMapper;
using BillingSystem.Application;
using BillingSystem.Core;
using BillingSystem.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Application
{
    public class BillInfoService : IBillInfoService
    {

        private readonly IMapper _mapper;
        IGenericRepository<BillInfo> _billInfoRepository;
        IGenericRepository<Bowsers> _bowsersRepository;
        IGenericRepository<Employee> _employeeRepository;
        IGenericRepository<Company> _companyRepository;

        public BillInfoService(IMapper mapper,

            IGenericRepository<BillInfo> billInfoRepository,

            IGenericRepository<Bowsers> bowsersRepository)
        {
            _mapper = mapper;
            _billInfoRepository = billInfoRepository;
            _bowsersRepository = bowsersRepository;
        }

        public async Task<BillInfoDto> GetBillInfo(int id)
        {
            BillInfo bill = await _billInfoRepository.GetByIdAsync(id);
            var result = _mapper.Map<BillInfoDto>(bill);
            return result;
        }

        public List<BillInfoDto> GetBillsInfo()
        {

            List<BillInfo> listofBills = _billInfoRepository.GetAll().ToList();
            var result = _mapper.Map<List<BillInfoDto>>(listofBills);

            return result;
        }

        public async Task CreateUpdate(BillInfoInput input)
        {

            BillInfo result = _mapper.Map<BillInfo>(input);


            if (input.Id == null || input.Id.Equals(0))
            {
                //result.Bowser= _bowsersRepository.GetAll().Where(b => b.Id == input.BowserId).FirstOrDefault();
                //result.Company = _companyRepository.GetAll().Where(c=> c.Id == input.CompanyId).FirstOrDefault();
                //result.Employee=_employeeRepository.GetAll().Where(d => d.Id == input.EmployeeId).FirstOrDefault();
                var billInfo = _billInfoRepository.GetAll()
                         .OrderByDescending(x => x.Id)
                         .FirstOrDefault();

                result.BillNo = billInfo.BillNo + 1;

                await _billInfoRepository.Create(result);

            }

            else

            {

                result.Bowser = _bowsersRepository.GetAll().Where(b => b.Id ==input.Id).FirstOrDefault();

                await _billInfoRepository.Update(input.Id, result);
              

                //result.Bowser = _bowsersRepository.GetAll().Where(b => b.BowserNoPlate == input.).FirstOrDefault();
                //await _billInfoRepository.Create(result);
            }


        }

 
        //public async Task UpdateBillInfo(BillInfoDto input)
        //{

        //    BillInfo result = _mapper.Map<BillInfo>(input);
        //    result.Bowser = _bowsersRepository.GetAll().Where(b => b.BowserNoPlate == input.Bowser_Noplate).FirstOrDefault();

        //  await _billInfoRepository.Update(input.BillNo, result);
        //}

        ////public async Task<ApplicantDto> GetApplicant(int id)
        ////{
        ////    Applicant applicant = await _applicantrepository.GetByIdAsync(id);
        ////    var result = _mapper.Map<ApplicantDto>(applicant);
        ////    return result;
        ////}

        public async Task DeleteBillInfo(int id)
        {
            await _billInfoRepository.Delete(id);
        }

      

    }
}
