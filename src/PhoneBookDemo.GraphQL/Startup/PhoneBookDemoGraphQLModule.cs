using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PhoneBookDemo.Startup
{
    [DependsOn(typeof(PhoneBookDemoCoreModule))]
    public class PhoneBookDemoGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneBookDemoGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}