using System.Threading.Tasks;
using Abp.Application.Services;
using PhoneBookDemo.Sessions.Dto;

namespace PhoneBookDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
