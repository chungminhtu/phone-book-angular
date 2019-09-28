using System.Collections.Generic;
using MvvmHelpers;
using PhoneBookDemo.Models.NavigationMenu;

namespace PhoneBookDemo.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}