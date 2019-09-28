using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhoneBookDemo.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookDemo.PhoneBook
{
    public interface IPersonAppService : IApplicationService
    {
        ListResultDto<PersonListDto> GetPeople(GetPeopleInput input);
        Task CreatePerson(CreatePersonInput input);

    }
}
