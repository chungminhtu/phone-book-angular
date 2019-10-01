using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PhoneBookDemo.Configuration;
using PhoneBookDemo.PhoneBook;
using PhoneBookDemo.Web;

namespace PhoneBookDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PhoneBookDemoDbContextFactory : IDesignTimeDbContextFactory<PhoneBookDemoDbContext>
    {
        public PhoneBookDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhoneBookDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            PhoneBookDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PhoneBookDemoConsts.ConnectionStringName));

            return new PhoneBookDemoDbContext(builder.Options);
        }
    }
}