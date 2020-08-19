using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using CleanUmbraco.Core.Controllers;
using Umbraco.Core.Logging;
using CleanUmbraco.Core.ViewModels;

namespace CleanUmbraco.Core.Services
{
    public class SmtpService : ISmtpService
    {
        private readonly ILogger _logger;
        public SmtpService(ILogger logger)
        {
            _logger = logger;
        }
        public bool SendEmail(ContactViewModel model)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();

                string toAddress = "to@test.com";
                string fromAddress = "from@test.com";
                message.Subject = $"Enquiry from: {model.Name} - {model.Email}";
                message.Body = model.Message;
                message.To.Add(new MailAddress(toAddress, toAddress));
                message.From = new MailAddress(fromAddress, fromAddress);

                client.Send(message);
                return true;
            }
            catch (SmtpException ex)
            {
                _logger.Error(typeof(ContactSurfaceController), ex, "Error sending contact form.");
                return false;
            }
        }
    }
}
