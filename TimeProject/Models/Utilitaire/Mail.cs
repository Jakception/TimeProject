using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Collections;

namespace TimeProject.Models.Utilitaire
{
    public static class Mail
    {
        // AppCOnfig avec appSettings
        public static void EnvoiMail(string emailRecepteur, string sujet, string contenuMail)
        {
            var appSettings = ConfigurationManager.AppSettings;

            var fromAddress = new MailAddress(ConfigurationManager.AppSettings["email"].ToString(), "From Timeporject");
            var toAddress = new MailAddress(emailRecepteur, "To Name");
            string fromPassword = ConfigurationManager.AppSettings["mdp"].ToString();
            string subject = sujet;
            string body = contenuMail;

            var smtp = new SmtpClient
            {
                Host = ConfigurationManager.AppSettings["host"].ToString(),
                Port = Convert.ToInt32(ConfigurationManager.AppSettings["port"]),
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
                try
                {
                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Exception caught in EnvoiMail(): {0}",
                        ex.ToString());
                }
            }
        }
        // AppConfig avec les sections
        //public static void EnvoiMail(string sourceName, string emailRecepteur, string sujet, string contenuMail)
        //{
        //    Hashtable section = (Hashtable)ConfigurationManager.GetSection(sourceName);

        //    var fromAddress = new MailAddress(section["email"].ToString(), "From Name");
        //    var toAddress = new MailAddress(emailRecepteur, "To Name");
        //    string fromPassword = section["mdp"].ToString();
        //    string subject = sujet;
        //    string body = contenuMail;

        //    var smtp = new SmtpClient
        //    {
        //        Host = section["host"].ToString(),
        //        Port = Convert.ToInt32(section["port"]),
        //        EnableSsl = true,
        //        DeliveryMethod = SmtpDeliveryMethod.Network,
        //        UseDefaultCredentials = false,
        //        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
        //    };
        //    using (var message = new MailMessage(fromAddress, toAddress)
        //    {
        //        Subject = subject,
        //        Body = body
        //    })
        //    {
        //        try
        //        {
        //            smtp.Send(message);
        //        }
        //        catch (Exception ex)
        //        {
        //            System.Windows.Forms.MessageBox.Show("Exception caught in EnvoiMail(): {0}",
        //                ex.ToString());
        //        }
        //    }
        //}
        // Référence de la méthode
        //public static void EnvoiMail(string source, string emailRecepteur, string sujet, string contenuMail)
        //{
        //    var fromAddress = new MailAddress("EMAIL@EXEMPLE.COM", "From Name");
        //    var toAddress = new MailAddress("EMAIL@EXEMPLE.COM", "To Name");
        //    const string fromPassword = "MDP";
        //    const string subject = "Subject";
        //    const string body = "Body";

        //    var smtp = new SmtpClient
        //    {
        //        Host = "smtp.gmail.com",
        //        Port = 587,
        //        EnableSsl = true,
        //        DeliveryMethod = SmtpDeliveryMethod.Network,
        //        UseDefaultCredentials = false,
        //        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
        //    };
        //    using (var message = new MailMessage(fromAddress, toAddress)
        //    {
        //        Subject = subject,
        //        Body = body
        //    })
        //    {
        //        try
        //        {
        //            smtp.Send(message);
        //        }
        //        catch (Exception ex)
        //        {
        //            System.Windows.Forms.MessageBox.Show("Exception caught in EnvoiMail(): {0}",
        //                ex.ToString());
        //        }
        //    }
        //}
    }
}
