using Abp.AspNetCore.Mvc.ViewComponents;

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