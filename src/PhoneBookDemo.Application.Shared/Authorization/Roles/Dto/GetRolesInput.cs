using System.Collections.Generic;

namespace PhoneBookDemo.Authorization.Roles.Dto
{
    public class GetRolesInput
    {
        public List<string> Permissions { get; set; }
    }
}
