using Abp.AspNetCore.Mvc.Views;
using PhoneBookDemo.PhoneBook;

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
