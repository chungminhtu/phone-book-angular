using System.Collections.Generic;
using PhoneBookDemo.Authorization.Users.Dto;
using PhoneBookDemo.Dto;

namespace PhoneBookDemo.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}