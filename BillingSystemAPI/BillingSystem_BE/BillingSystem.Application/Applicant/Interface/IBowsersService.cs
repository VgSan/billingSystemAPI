using BillingSystem.Application;
using BillingSystem.Application.Applicant;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Application
{
    public interface IBowsersService
    {
        List<BowsersDto> GetBowsers();
        List<BowserLookUpDto> GetBowserLookUp();

        Task<BowsersDto> GetBowser(int id);
        BowsersDto GetBowserBynoPlate(string noPlate);

        Task CreateBowser(BowsersInput input);
        Task UpdateBowser(BowsersDto input);
        Task DeleteBowser(int id);
    }
}
