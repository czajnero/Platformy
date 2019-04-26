using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace JTTT
{ 
    [Serializable]
    class SendMail : JTTTAction
    {
        Log jtttLog = new Log();

        public string Email { get; set; }

        public string Mail
        {
            get
            {
                try
                {
                    return (string)InputParameters[0];
                }
                catch (Exception e)
                {
                    
                }

                return null;
            }

        }

        public MemoryStream AttachmentImg
        {
            get
            {
                try
                {
                    return (MemoryStream)InputParameters[2];
                }
                catch (Exception e)
                {
                    
                }

                return null;
            }
        }


        public SendMail(string mail)
        {
            Email = mail; 
        }

        public override void Action()
        {
           
            DownloadHTML downloadHTML = new DownloadHTML();

            try
            {
              
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                MailMessage message = new MailMessage();
                MailAddress from = new MailAddress("platformyrkbp@gmail.com", "JTTT");

                message.From = from;
                message.To.Add(Mail);
                message.Subject = "Aplikacja JTTT - news";
                message.Body = "Znaleziono obrazek.";
                message.Attachments.Add(new Attachment(AttachmentImg, "obrazek.jpg"));

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Credentials = new NetworkCredential("platformyrkbp@gmail.com", "platformy123");
                smtpClient.SendAsync(message, Mail);
                jtttLog.log("Wyslano maila");

            }
            catch(Exception ex)
            {
                Console.WriteLine("Blad wysylania maila");
            }
        }

        public override string ToString()
        {
            return string.Format("Adres mailowy={0}", Mail);
        }

    }
}
