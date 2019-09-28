using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace PhoneBookDemo.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
