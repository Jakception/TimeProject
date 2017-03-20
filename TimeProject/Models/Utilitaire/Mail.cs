using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Utilitaire
{
    public static class Mail
    {
        public static void CreateTestMessage1(string server, int port)
        {
            string to = "gbeulaygue@gmail.com";
            string from = "gbeulaygue@gmail.com";
            string subject = "Using the new SMTP client.";
            string body = @"Using this new feature, you can send an e-mail message from an application very easily.";

            MailMessage message = new MailMessage(from, to, subject, body);
            SmtpClient client = new SmtpClient(server, port);

            // Credentials are necessary if the server requires the client
            // to authenticate before it will send e-mail on the client's behalf.
            client.Credentials = CredentialCache.DefaultNetworkCredentials;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Exception caught in CreateTestMessage1(): {0}",
                    ex.ToString());
            }
        }

        public static void CreateTestMessage2()
        {
            var fromAddress = new MailAddress("EMAIL@EXEMPLE.COM", "From Name");
            var toAddress = new MailAddress("EMAIL@EXEMPLE.COM", "To Name");
            const string fromPassword = "MDP";
            const string subject = "Subject";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        //SmtpClient client = new SmtpClient(server);
        //client.Credentials = CredentialCache.DefaultNetworkCredentials;
    }
}
