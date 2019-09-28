using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhoneBookDemo.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookDemo.PhoneBook
{
    public interface IPersonAppService : IApplicationService
    {
        ListResultDto<PersonListDto> GetPeople(GetPeopleInput input);
    }
}
