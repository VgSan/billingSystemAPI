using AutoMapper;
using BillingSystem.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillingSystem.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        { 

            CreateMap<Company, CompanyDto>()
                .ReverseMap();
            CreateMap<Company, CompanyInput>()
                .ReverseMap();

            CreateMap<BillInfo, BillInfoDto>()
      .ForMember(d => d.BillDate,
        expression => expression.ResolveUsing(s => s.BillDate.ToString()));
     
            CreateMap<BillInfo, BillInfoInput>()
             .ReverseMap();

            CreateMap<Employee, EmployeeDto>()
                .ReverseMap();
            CreateMap<Employee, EmployeeInput>()
                .ReverseMap();

            CreateMap<Bowsers, BowsersDto>()
             .ReverseMap();
            CreateMap<Bowsers, BowsersInput>()
                .ReverseMap();



            //CreateMap<ApplicantWorkflow, ApplicantWorkflowInput>()
            //    .ReverseMap();
        }
    }
}
