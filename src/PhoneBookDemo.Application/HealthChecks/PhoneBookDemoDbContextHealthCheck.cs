using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using PhoneBookDemo.EntityFrameworkCore;

namespace PhoneBookDemo.HealthChecks
{
    public class PhoneBookDemoDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public PhoneBookDemoDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("PhoneBookDemoDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("PhoneBookDemoDbContext could not connect to database"));
        }
    }
}
