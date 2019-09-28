using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using PhoneBookDemo.Configuration;

namespace PhoneBookDemo.Test.Base
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(PhoneBookDemoTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
