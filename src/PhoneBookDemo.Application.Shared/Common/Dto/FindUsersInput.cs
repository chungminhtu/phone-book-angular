using PhoneBookDemo.Dto;

namespace PhoneBookDemo.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}