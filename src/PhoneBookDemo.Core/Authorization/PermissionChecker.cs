using Abp.Authorization;
using PhoneBookDemo.Authorization.Roles;
using PhoneBookDemo.Authorization.Users;

namespace PhoneBookDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
