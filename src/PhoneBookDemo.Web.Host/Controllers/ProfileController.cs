using Abp.AspNetCore.Mvc.Authorization;
using PhoneBookDemo.Storage;

namespace PhoneBookDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(ITempFileCacheManager tempFileCacheManager) :
            base(tempFileCacheManager)
        {
        }
    }
}