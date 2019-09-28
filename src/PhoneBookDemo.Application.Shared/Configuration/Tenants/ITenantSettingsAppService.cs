using System.Threading.Tasks;
using Abp.Application.Services;
using PhoneBookDemo.Configuration.Tenants.Dto;

namespace PhoneBookDemo.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
