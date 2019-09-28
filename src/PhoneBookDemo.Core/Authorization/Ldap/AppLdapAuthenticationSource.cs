using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using PhoneBookDemo.Authorization.Users;
using PhoneBookDemo.MultiTenancy;

namespace PhoneBookDemo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}