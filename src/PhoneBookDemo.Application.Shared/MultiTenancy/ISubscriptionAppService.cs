using System.Threading.Tasks;
using Abp.Application.Services;

namespace PhoneBookDemo.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
