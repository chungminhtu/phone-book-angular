using System.Threading.Tasks;
using Abp.Application.Services;
using PhoneBookDemo.Editions.Dto;
using PhoneBookDemo.MultiTenancy.Dto;

namespace PhoneBookDemo.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}