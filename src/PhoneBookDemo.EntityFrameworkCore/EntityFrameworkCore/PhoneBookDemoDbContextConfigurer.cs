using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PhoneBookDemo.EntityFrameworkCore
{
    public static class PhoneBookDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhoneBookDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PhoneBookDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}