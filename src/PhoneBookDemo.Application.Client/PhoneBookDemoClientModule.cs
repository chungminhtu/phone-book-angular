using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PhoneBookDemo
{
    public class PhoneBookDemoClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneBookDemoClientModule).GetAssembly());
        }
    }
}
