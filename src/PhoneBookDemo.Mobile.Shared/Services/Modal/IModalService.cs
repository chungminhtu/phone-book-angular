using System.Threading.Tasks;
using PhoneBookDemo.Views;
using Xamarin.Forms;

namespace PhoneBookDemo.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
