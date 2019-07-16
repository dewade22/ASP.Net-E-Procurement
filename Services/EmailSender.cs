using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Balimoon_E_Procurement.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        //dependency injection
        /*
        private SendGridOptions _sendGridOptions { get; }
        private IFunctional _functional { get; }
        private SmtpOptions _smtpOptions { get; }
        */
        //tanda dependency injection
        private string host;
        private int port;
        private bool enableSSL;
        private string userName;
        private string password;

        public EmailSender(string host, int port, bool enableSSL, string userName, string password)
        {
            this.host = host;
            this.port = port;
            this.enableSSL = enableSSL;
            this.userName = userName;
            this.password = password;
        }


        public Task SendEmailAsync(string email, string subject, string message)
        {
                var client = new SmtpClient(host, port)
                {
                    Credentials = new NetworkCredential(userName, password),
                    EnableSsl = enableSSL
                };
            return client.SendMailAsync(
                new MailMessage(userName, email, subject, message) { IsBodyHtml = true }
            );
        }
    }
}
