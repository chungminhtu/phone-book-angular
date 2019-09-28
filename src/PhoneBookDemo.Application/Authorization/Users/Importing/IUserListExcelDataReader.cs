using System.Collections.Generic;
using PhoneBookDemo.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace PhoneBookDemo.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
