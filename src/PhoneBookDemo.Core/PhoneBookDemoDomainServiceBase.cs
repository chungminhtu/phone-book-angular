using Abp.Domain.Services;
using PhoneBookDemo.PhoneBook;

namespace PhoneBookDemo
{
    public abstract class PhoneBookDemoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected PhoneBookDemoDomainServiceBase()
        {
            LocalizationSourceName = PhoneBookDemoConsts.LocalizationSourceName;
        }
    }
}
