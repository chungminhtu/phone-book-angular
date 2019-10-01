using Abp.AspNetCore.Mvc.ViewComponents;
using PhoneBookDemo.PhoneBook;

namespace PhoneBookDemo.Web.Public.Views
{
    public abstract class PhoneBookDemoViewComponent : AbpViewComponent
    {
        protected PhoneBookDemoViewComponent()
        {
            LocalizationSourceName = PhoneBookDemoConsts.LocalizationSourceName;
        }
    }
}