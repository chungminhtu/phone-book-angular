using System.Threading.Tasks;
using Abp.Application.Services;
using PhoneBookDemo.Configuration.Host.Dto;

namespace PhoneBookDemo.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
