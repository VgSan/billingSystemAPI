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
using BillingSystem.Application.Applicant;
using BillingSystem.Core;

namespace BillingSystem.Web.Host.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Produces("application/json")]
    [Route("api/Bowser")]
    public class BowserController : Controller
    {
        private readonly IMapper _mapper;
        IBowsersService _bowserService;

        public BowserController(IMapper mapper,
            IBowsersService bowserService)
        {
            _mapper = mapper;
            _bowserService = bowserService;
        }



        [HttpGet("BowserLookUp")]
        public List<BowserLookUpDto> GetBowserLookUp()
        {
            List<BowserLookUpDto> bowserLookUpList = _bowserService.GetBowserLookUp();
            return bowserLookUpList;
        }

        [HttpGet("GetBowserBynoPlate")]
        public  BowsersDto GetBowserBynoPlate(string noPlate)
        {
            BowsersDto bowser =  _bowserService.GetBowserBynoPlate(noPlate);
            return bowser;
        }


        [HttpGet("GetBowser")]
        public async Task<BowsersDto> GetBowser(int id)
        {
            BowsersDto bowser = await _bowserService.GetBowser(id);
            return bowser;
        }

        [HttpGet("GetBowsers")]
        public List<BowsersDto> GetEmployee()
        {
            List<BowsersDto> bowserList = _bowserService.GetBowsers();
            return bowserList;
        }



        [HttpPut("CreateBowser")]
        public async Task CreateBowser(BowsersInput input)
        {
            await _bowserService.CreateBowser(input);
        }

        [HttpPost("UpdateBowser")]
        public async Task UpdateBowser(BowsersDto input)
        {
            await _bowserService.UpdateBowser(input);
        }


        


        [HttpDelete("DeleteBowser")]
        public async Task DeleteBowser(int id)
        {
            await _bowserService.DeleteBowser(id);
        }
    }
}