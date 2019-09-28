using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PhoneBookDemo
{
    [DependsOn(typeof(PhoneBookDemoClientModule), typeof(AbpAutoMapperModule))]
    public class PhoneBookDemoXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneBookDemoXamarinSharedModule).GetAssembly());
        }
    }
}