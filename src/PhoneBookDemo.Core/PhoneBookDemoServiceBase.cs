using Abp;
using PhoneBookDemo.PhoneBook;

namespace PhoneBookDemo
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="PhoneBookDemoDomainServiceBase"/>.
    /// For application services inherit PhoneBookDemoAppServiceBase.
    /// </summary>
    public abstract class PhoneBookDemoServiceBase : AbpServiceBase
    {
        protected PhoneBookDemoServiceBase()
        {
            LocalizationSourceName = PhoneBookDemoConsts.LocalizationSourceName;
        }
    }
}