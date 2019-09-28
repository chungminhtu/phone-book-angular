using PhoneBookDemo.EntityFrameworkCore;

namespace PhoneBookDemo.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly PhoneBookDemoDbContext _context;

        public InitialHostDbBuilder(PhoneBookDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            new InitialPeopleCreator(_context).Create();


            _context.SaveChanges();
        }
    }
}
