using System.ComponentModel.DataAnnotations;

namespace PhoneBookDemo.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}