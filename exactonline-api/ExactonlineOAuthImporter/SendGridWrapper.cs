using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactonlineOAuthImporter
{
    public class SendGridWrapper
    {
        private const string cFromEmail = "support@yggdra.nl";
        public SendGridWrapper()
        {

        }


        /// <summary>
        /// Zend de mail via sendgrid
        /// </summary>
        /// <param name="_to"></param>
        /// <param name="_toName"></param>
        /// <param name="_subject"></param>
        /// <param name="_text"></param>
        /// <param name="_from"></param>
        public void SendMail(string _to, string _toName, string _subject, string _body, string _from)
        {
            try
            {
                String apiKey = "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"; ////Environment.GetEnvironmentVariable("SENDGRID_APIKEY", EnvironmentVariableTarget.User);
                dynamic sg = new SendGrid.SendGridAPIClient(apiKey, "https://api.sendgrid.com");

                SendGrid.Helpers.Mail.Email from = new SendGrid.Helpers.Mail.Email(cFromEmail);
                String subject = _subject;
                SendGrid.Helpers.Mail.Email to = new SendGrid.Helpers.Mail.Email(_to);
                SendGrid.Helpers.Mail.Content content = new SendGrid.Helpers.Mail.Content("text/plain", _body + Environment.NewLine +
                    String.Format("{0}{0} Sender info: {0}Name: {1} {0}{3}Mailadress: {2}{0}", Environment.NewLine, _toName, _to, Environment.NewLine));

                SendGrid.Helpers.Mail.Mail mail = new SendGrid.Helpers.Mail.Mail(from, subject, to, content);
                SendGrid.Helpers.Mail.Email email = new SendGrid.Helpers.Mail.Email(cFromEmail);
                mail.Personalization[0].AddTo(email);
                SendGrid.Helpers.Mail.Email email2 = new SendGrid.Helpers.Mail.Email("frankvanbokhoven@yggdra.nl");
                mail.Personalization[0].AddBcc(email2);
     

                sg.client.mail.send.post(requestBody: mail.Get());
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
