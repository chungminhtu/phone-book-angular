using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using PhoneBookDemo.Dto;

namespace PhoneBookDemo.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
