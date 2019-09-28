using System.Threading.Tasks;
using PhoneBookDemo.Sessions.Dto;

namespace PhoneBookDemo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
