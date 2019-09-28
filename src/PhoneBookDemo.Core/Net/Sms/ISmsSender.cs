using System.Threading.Tasks;

namespace PhoneBookDemo.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}