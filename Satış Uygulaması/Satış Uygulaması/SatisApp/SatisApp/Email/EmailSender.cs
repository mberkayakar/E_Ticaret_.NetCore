using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace SatisApp.Email
{
    public class EmailSender:IEmailSender
    {
     

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(Options.SendGridKey);
            var mesaj = new SendGridMessage()
            {
                From = new EmailAddress("m.berkay.akar@gmail.com", "BerkayAkar"),
                Subject = subject,
                PlainTextContent = htmlMessage,
                HtmlContent = htmlMessage

            };
            mesaj.AddTo(new EmailAddress(email));
            try
            {
                return client.SendEmailAsync(mesaj);
            }
            catch (System.Exception)
            {

                return null;
            }
        }

        public EmailSender(IOptions<EmailOptions> emailOptions)
        {
            Options = emailOptions.Value;
        }

        public EmailOptions Options{ get; set; }
    }
}
