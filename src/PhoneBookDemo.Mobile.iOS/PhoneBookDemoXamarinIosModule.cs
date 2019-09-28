using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PhoneBookDemo
{
    [DependsOn(typeof(PhoneBookDemoXamarinSharedModule))]
    public class PhoneBookDemoXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneBookDemoXamarinIosModule).GetAssembly());
        }
    }
}