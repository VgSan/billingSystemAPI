using AutoMapper;
using BillingSystem.Application.Applicant;
using BillingSystem.Core;
using BillingSystem.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Application
{
    public class BowserService : IBowsersService
    {
        private readonly IMapper _mapper;
        IGenericRepository<Bowsers> _bowserRepository;

        public BowserService(IMapper mapper,
            IGenericRepository<Bowsers> bowserRepository)
        {
            _mapper = mapper;
            _bowserRepository = bowserRepository;
        }

     

        public async Task CreateBowser(BowsersInput input)
        {
            Bowsers result = _mapper.Map<Bowsers>(input);
            await _bowserRepository.Create(result);
        }

        public List<BowsersDto> GetBowsers()
        {
            List<Bowsers> listofbowsers = _bowserRepository.GetAll().ToList();
            var result = _mapper.Map<List<BowsersDto>>(listofbowsers);

            return result;
        }

        public async Task<BowsersDto> GetBowser(int id)
        {
            Bowsers bowser = await _bowserRepository.GetByIdAsync(id);
            var result = _mapper.Map<BowsersDto>(bowser);
            return result;
        }


        public  BowsersDto GetBowserBynoPlate(string  noPlate)
        {
            Bowsers bowser =  _bowserRepository.GetAll().Where(b=>b.BowserNoPlate==noPlate).FirstOrDefault();
            var result = _mapper.Map<BowsersDto>(bowser);
            return result;
        }




        public List<BowserLookUpDto> GetBowserLookUp()
        {
            var listOfBowsers = _bowserRepository.GetAll().Select(x => new { x.BowserNoPlate }).ToList();
            var result = _mapper.Map<List<BowserLookUpDto>>(listOfBowsers);
            return result;
        }





        //public Task<BowsersDto> GetBowserLookUp(Bowsers input)
        //{
        //    var Bowsers = _bowserRepository.GetAll().Where(x => x.BowserNoPlate==input.BowserNoPlate ).FirstOrDefault();
        //    var result = _mapper.Map<BowsersDto> (Bowsers);
        //    return result;
        //}


        public async Task UpdateBowser(BowsersDto input)
        {

            Bowsers extCom = _bowserRepository.GetAll()
               .Where(b => b.BowserNoPlate == input.BowserNoPlate)
               .FirstOrDefault();
            Bowsers result = _mapper.Map<BowsersDto, Bowsers>(input, extCom);

            await _bowserRepository.Update(extCom.Id, result);
        }
        public async Task DeleteBowser(int id)
        {
            Bowsers Bowsers = _bowserRepository.GetAll().Where(d => d.Id == id).FirstOrDefault();

            await _bowserRepository.Delete(id);
        }
    }
}
