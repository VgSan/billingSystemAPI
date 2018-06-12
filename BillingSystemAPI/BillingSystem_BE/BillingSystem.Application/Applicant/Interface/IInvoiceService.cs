using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Application
{
    public interface IInvoiceService
    {
        Task<InvoiceDto> GetInvoice(int id);
        List<InvoiceDto> GetInvoice();
        Task CreateInvoice(InvoicInput input);
        Task UpdateInvoice(InvoiceDto input);
        Task DeleteInvoice(int id);
    }
}
