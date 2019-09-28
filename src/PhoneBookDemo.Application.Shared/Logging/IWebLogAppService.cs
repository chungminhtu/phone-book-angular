using Abp.Application.Services;
using PhoneBookDemo.Dto;
using PhoneBookDemo.Logging.Dto;

namespace PhoneBookDemo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
