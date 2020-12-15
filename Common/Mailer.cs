namespace Common
{
    using System;
    using System.Net;
    using System.Net.Mail;
    using System.Net.Security;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Windows.Forms;

    public static class Mailer
    {
        public static void EnviarMail(StringBuilder CuerpoMail, string mailPara, string Asunto)
        {
            try
            {
                var server = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };

                var credential = new NetworkCredential("mygymproyect@gmail.com", "MyGym0173");

                server.Credentials = credential;

                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(AcceptAllCertifications);

                var correoElectronico = new MailMessage();

                string mailTo = mailPara;
                string mailTo2 = "";

                correoElectronico.Subject = Asunto;
                correoElectronico.SubjectEncoding = Encoding.UTF8;

                correoElectronico.To.Add(new MailAddress(mailTo));

                if (mailTo2 != "")
                    correoElectronico.To.Add(new MailAddress(mailTo2));

                correoElectronico.From = new MailAddress("mygymproyect@gmail.com.ar", "MyGym");

                correoElectronico.Body = CuerpoMail.ToString();

                correoElectronico.Body += "<footer>";
                correoElectronico.Body += "Enviado desde MyGym";
                correoElectronico.Body += "</footer>";

                correoElectronico.BodyEncoding = Encoding.UTF8;
                correoElectronico.IsBodyHtml = true;

                server.Send(correoElectronico);

                MessageBox.Show("El Mail se ha Enviado Correctamente", "Listo!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static bool AcceptAllCertifications(object sender, X509Certificate certification, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
    }
}