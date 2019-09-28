using Abp.Modules;
using PhoneBookDemo.Test.Base;

namespace PhoneBookDemo.Tests
{
    [DependsOn(typeof(PhoneBookDemoTestBaseModule))]
    public class PhoneBookDemoTestModule : AbpModule
    {
       
    }
}
