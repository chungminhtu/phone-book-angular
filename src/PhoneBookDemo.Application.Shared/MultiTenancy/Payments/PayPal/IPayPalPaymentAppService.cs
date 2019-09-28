using System.Threading.Tasks;
using Abp.Application.Services;
using PhoneBookDemo.MultiTenancy.Payments.PayPal.Dto;

namespace PhoneBookDemo.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
