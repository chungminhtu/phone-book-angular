using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace PhoneBookDemo.Net.Emailing
{
    public class PhoneBookDemoSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public PhoneBookDemoSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}