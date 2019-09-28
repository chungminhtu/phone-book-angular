using Abp.Auditing;
using PhoneBookDemo.Configuration.Dto;

namespace PhoneBookDemo.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}