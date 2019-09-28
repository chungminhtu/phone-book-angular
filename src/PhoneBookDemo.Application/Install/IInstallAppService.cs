using System.Threading.Tasks;
using Abp.Application.Services;
using PhoneBookDemo.Install.Dto;

namespace PhoneBookDemo.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}