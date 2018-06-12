using BillingSystem.Application.Applicant.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Application
{
    public interface IEmployeeService
    {
        Task<EmployeeDto> GetEmployee(int id);
        List<EmployeeDto> GetEmployees();
        Task CreateEmployee(EmployeeInput input);

        List<EmployeeLookUpDto> GetEmployeeLookUp();

        Task UpdateEmployee(EmployeeDto input);
        Task DeleteEmployee(int id);
    }
}
