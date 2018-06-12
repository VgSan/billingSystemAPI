using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BillingSystem.Application;
using Microsoft.AspNetCore.Cors;
using BillingSystem.Application.Applicant.Dto;

namespace BillingSystem.Web.Host.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Produces("application/json")]
    [Route("api/Company")]
    public class EmployeeController : Controller
    {
        private readonly IMapper _mapper;
        IEmployeeService _employeService;

        public EmployeeController(IMapper mapper,
            IEmployeeService employeService)
        {
            _mapper = mapper;
            _employeService = employeService;
        }

        [HttpGet("GetEmployee")]
        public async Task<EmployeeDto> GetEmployee(int id)
        {
            EmployeeDto employee = await _employeService.GetEmployee(id);
            return employee;
        }

        [HttpGet("GetEmployees")]
        public List<EmployeeDto> GetEmployee()
        {
            List<EmployeeDto> employeeList = _employeService.GetEmployees();
            return employeeList;
        }


        [HttpGet("EmployeeLookUp")]
        public List<EmployeeLookUpDto> GetEmployeeLookUp()
        {
            List<EmployeeLookUpDto> companyLookUpList = _employeService.GetEmployeeLookUp();
            return companyLookUpList;
        }

        [HttpPut("CreateEmployee")]
        public async Task CreateEmployee(EmployeeInput input)
        {
            await _employeService.CreateEmployee(input);
        }

        [HttpPost("UpdateEmployee")]
        public async Task UpdateEmployee(EmployeeDto input)
        {
            await _employeService.UpdateEmployee(input);
        }


       


        [HttpDelete("DeleteEmployee")]
        public async Task DeleteEmployee(int id)
        {
            await _employeService.DeleteEmployee(id);
        }
    }
}