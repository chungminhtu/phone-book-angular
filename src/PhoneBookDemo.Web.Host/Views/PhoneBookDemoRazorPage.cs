using Abp.AspNetCore.Mvc.Views;

namespace PhoneBookDemo.Web.Views
{
    public abstract class PhoneBookDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected PhoneBookDemoRazorPage()
        {
            LocalizationSourceName = PhoneBookDemoConsts.LocalizationSourceName;
        }
    }
}
