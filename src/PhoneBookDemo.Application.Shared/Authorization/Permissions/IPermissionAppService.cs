using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhoneBookDemo.Authorization.Permissions.Dto;

namespace PhoneBookDemo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
