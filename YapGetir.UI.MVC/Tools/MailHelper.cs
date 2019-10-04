using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace YapGetir.UI.MVC.Tools
{
    public class MailHelper
    {
        public static bool SendConfirmationMail(string metin, string mail)
        {
            bool result = false;
            MailMessage msg = new MailMessage();
            msg.To.Add(mail);
            msg.Subject = "Hoşgeldinizzzz";
            msg.IsBodyHtml = true;
            msg.Body = metin;
            msg.From = new MailAddress("bilgeinsan1530@gmail.com");
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            NetworkCredential credential = new NetworkCredential("bilgeinsan1530@gmail.com", "Bilge1530insan.");
            smtpClient.Credentials = credential;
            try
            {
                smtpClient.Send(msg);
                result = true;
            }
            catch (Exception)
            {

                result = false;
            }
            return result;
        }
    }
}