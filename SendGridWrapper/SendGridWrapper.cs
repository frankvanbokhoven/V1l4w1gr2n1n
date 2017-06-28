using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;
using SendGrid;
//using Newtonsoft.Json;

namespace SendGridWrapper
{
    public class SendGridWrapper
    {


        /// <summary>
        /// Zend de mail via sendgrid
        /// </summary>
        /// <param name="_to"></param>
        /// <param name="_toName"></param>
        /// <param name="_subject"></param>
        /// <param name="_text"></param>
        /// <param name="_from"></param>
        public static void SendMail(string _to, string _toName, string _subject, string _text, string _from)
        {
            try
            {
                String apiKey = "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"; ////Environment.GetEnvironmentVariable("SENDGRID_APIKEY", EnvironmentVariableTarget.User);
                dynamic sg = new SendGrid.SendGridAPIClient(apiKey, "https://api.sendgrid.com");

                SendGrid.Helpers.Mail.Email from = new SendGrid.Helpers.Mail.Email(_from);
                String subject = _subject;
                SendGrid.Helpers.Mail.Email to = new SendGrid.Helpers.Mail.Email(_to);
                SendGrid.Helpers.Mail.Content content = new SendGrid.Helpers.Mail.Content("text/plain", _text);
                SendGrid.Helpers.Mail.Mail mail = new SendGrid.Helpers.Mail.Mail(from, subject, to, content);
                SendGrid.Helpers.Mail.Email email = new SendGrid.Helpers.Mail.Email("support@activenoise.audio");
              //  mail.Personalization[0].AddTo(email);
                mail.Personalization[0].AddBcc(email);


                sg.client.mail.send.post(requestBody: mail.Get());
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
