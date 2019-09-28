using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using PhoneBookDemo.Configure;
using PhoneBookDemo.Startup;
using PhoneBookDemo.Test.Base;

namespace PhoneBookDemo.GraphQL.Tests
{
    [DependsOn(
        typeof(PhoneBookDemoGraphQLModule),
        typeof(PhoneBookDemoTestBaseModule))]
    public class PhoneBookDemoGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneBookDemoGraphQLTestModule).GetAssembly());
        }
    }
}