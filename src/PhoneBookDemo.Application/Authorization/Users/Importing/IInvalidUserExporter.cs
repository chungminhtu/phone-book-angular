using System.Collections.Generic;
using PhoneBookDemo.Authorization.Users.Importing.Dto;
using PhoneBookDemo.Dto;

namespace PhoneBookDemo.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
