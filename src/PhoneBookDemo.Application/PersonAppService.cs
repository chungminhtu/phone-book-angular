using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using PhoneBookDemo.Authorization;
using PhoneBookDemo.Dto;
using PhoneBookDemo.EntityFrameworkCore.PhoneBook;
using PhoneBookDemo.PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookDemo
{
    [AbpAuthorize(AppPermissions.Pages_Tenant_PhoneBook)]
    public class PersonAppService : PhoneBookDemoAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public ListResultDto<PersonListDto> GetPeople(GetPeopleInput input)
        {
            var people = _personRepository
                .GetAll()
                .WhereIf(
                    !input.Filter.IsNullOrEmpty(),
                    p => p.Name.Contains(input.Filter) ||
                         p.Surname.Contains(input.Filter) ||
                         p.EmailAddress.Contains(input.Filter)
                )
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Surname)
                .ToList();

            return new ListResultDto<PersonListDto>(ObjectMapper.Map<List<PersonListDto>>(people));
        }

        [AbpAuthorize(AppPermissions.Pages_Tenant_PhoneBook_CreatePerson)]
        public async Task CreatePerson(CreatePersonInput input)
        {
            var person = ObjectMapper.Map<Person>(input);
            await _personRepository.InsertAsync(person);
        }

        public async Task DeletePerson(EntityDto input)
        {
            await _personRepository.DeleteAsync(input.Id);
        }
    }
}
