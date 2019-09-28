using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using PhoneBookDemo.MultiTenancy.Accounting.Dto;

namespace PhoneBookDemo.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
