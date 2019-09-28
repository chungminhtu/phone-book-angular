using Microsoft.Extensions.Configuration;

namespace PhoneBookDemo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
