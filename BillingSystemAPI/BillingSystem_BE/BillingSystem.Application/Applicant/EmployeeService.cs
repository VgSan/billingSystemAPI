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
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;
        IGenericRepository<Employee> _employeeRepository;

        public EmployeeService(IMapper mapper,
            IGenericRepository<Employee> employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }


        public async Task CreateEmployee(EmployeeInput input)
        {
            Employee result = _mapper.Map<Employee>(input);
            await _employeeRepository.Create(result);
        }

        public List<EmployeeLookUpDto> GetEmployeeLookUp()
        {
            var listOfEmployees = _employeeRepository.GetAll().Select(x => new { x.Id, x.FirstName }).ToList();
            var result = _mapper.Map<List<EmployeeLookUpDto>>(listOfEmployees);
            return result;
        }

        public async Task DeleteEmployee(int id)
        {
            await _employeeRepository.Delete(id);
        }

        public async Task<EmployeeDto> GetEmployee(int id)
        {
            Employee employee = await _employeeRepository.GetByIdAsync(id);
            var result = _mapper.Map<EmployeeDto>(employee);
            return result;
        }

        public List<EmployeeDto> GetEmployees()
        {

            List<Employee> listOfEmployees = _employeeRepository.GetAll().ToList();
            var result = _mapper.Map<List<EmployeeDto>>(listOfEmployees);

            //listOfCompanies = listOfCompanies.Where(x => x.ModifiedDate.ToShortDateString() == input.BillDate
            // && x.IsActive == true && x.AddedDate == input.BillDate).ToList();
            //var result = _mapper.Map<List<BowsersDto>>(listOfExperince);

            return result;
        }


      

        public async Task UpdateEmployee(EmployeeDto input)
        {
            Employee extCom = _employeeRepository.GetAll()
                .Where(c => c.EmployeeNIC == input.EmployeeNIC)
                .FirstOrDefault();
            Employee result = _mapper.Map<EmployeeDto, Employee>(input, extCom);

            await _employeeRepository.Update(extCom.Id, result);
        }
    }
}
