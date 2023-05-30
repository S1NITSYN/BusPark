using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;

namespace BusPark
{
    public static class WebInteraction
    {
        private static string _from = "", _password = "";
        private static SmtpClient _smtpServer = new SmtpClient();
        private static MailMessage _message = new MailMessage();
        public static int AcceptCode = 0;
        public static void SetCreneditials(string from, string paswword)
        {
            _from = from;
            _password = paswword;
        }
        private static void InitSMTP(string to)
        {
            _smtpServer = new SmtpClient("smtp.yandex.ru", 587);
            _smtpServer.Credentials = new NetworkCredential(_from, _password);
            _smtpServer.EnableSsl = true;
            _message = new MailMessage(_from, to);
        }
        private static void AddAttachments(List<string> attachments)
        {
            if (attachments != null)
                foreach (string i in attachments)
                    _message.Attachments.Add(new Attachment(i));
        }
        public static void SendMessage(string to, string title, string body, List<string> attachments)
        {
            InitSMTP(to);
            AddAttachments(attachments);
            Send(title, body);
        }
        public static void SendMessage(string to, string title, string body)
        {
            InitSMTP(to);
            Send(title, body);
        }

        private static Exception Send(string title, string body)
        {
            _message.Subject = title;
            _message.Body = body;

            try
            {
                _smtpServer.Send(_message);
                return null;
            }
            catch (SmtpException e)
            {
                return e.InnerException;
            }
        }
    }
}