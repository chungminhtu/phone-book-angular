using Abp.AspNetCore.Mvc.Authorization;
using PhoneBookDemo.Authorization;
using PhoneBookDemo.Storage;
using Abp.BackgroundJobs;

namespace PhoneBookDemo.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}