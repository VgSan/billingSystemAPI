using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Application
{
    public interface IBillInfoService
    {
        Task<BillInfoDto> GetBillInfo(int id);
        List<BillInfoDto> GetBillsInfo();
        Task CreateUpdate(BillInfoInput input);
       

        Task DeleteBillInfo(int id);
    }
}
