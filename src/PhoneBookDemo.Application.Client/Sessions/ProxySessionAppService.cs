﻿using System.Threading.Tasks;
using PhoneBookDemo.Sessions.Dto;

namespace PhoneBookDemo.Sessions
{
    public class ProxySessionAppService : ProxyAppServiceBase, ISessionAppService
    {
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            return await ApiClient.GetAsync<GetCurrentLoginInformationsOutput>(GetEndpoint(nameof(GetCurrentLoginInformations)));
        }

        public async Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken()
        {
            return await ApiClient.PutAsync<UpdateUserSignInTokenOutput>(GetEndpoint(nameof(UpdateUserSignInToken)));
        }
    }
}