using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BillingSystem.Application;
using AutoMapper;
using Microsoft.AspNetCore.Cors;

namespace BillingSystem.Web.Host.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Produces("application/json")]
    [Route("api/BillInfo")]
    public class BillController : Controller
    {
        private readonly IMapper _mapper;
        IBillInfoService _billInfoService;

        public BillController(IMapper mapper,
            IBillInfoService billInfoService)
        {
            _mapper = mapper;
            _billInfoService = billInfoService;
        }

        [HttpGet("GetBillInfo")]
        public async Task<BillInfoDto> GetBillInfo(int id)
        {
            BillInfoDto bill = await _billInfoService.GetBillInfo(id);
            return bill;
        }

        [HttpGet("GetBillsInfo")]
        public List<BillInfoDto> GetBillsInfo()
        {
            List<BillInfoDto> billList = _billInfoService.GetBillsInfo();
            return billList;
        }

        //[HttpPut("CreateBillInfo")]
        //public async Task CreateBillInfo(BillInfoInput input)
        //{
        //    await _billInfoService.CreateBillInfo(input);
        //}

        [HttpPost("CreateUpdate")]
        public async Task CreateUpdate(BillInfoInput input)
        {
            await _billInfoService.CreateUpdate(input);
        }

        [HttpDelete("DeleteBillInfo")]
        public async Task DeleteBillInfo(int id)
        {
            await _billInfoService.DeleteBillInfo(id);
        }
    }
}