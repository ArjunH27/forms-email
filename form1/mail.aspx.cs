using System;
using System.Net.Mail;

namespace form1
{
    public partial class mail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add(TextBox1.Text);
                mailMessage.From = new MailAddress(TextBox2.Text);
                mailMessage.Subject = TextBox3.Text;
                mailMessage.Body = TextBox4.Text;
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential("arjunhariharasubramani27@gmail.com", "h7736509721");
                smtpClient.Port = 587;
                smtpClient.Send(mailMessage);
                Response.Write("E-mail sent!");
            }
            catch (Exception ex)
            {
                Response.Write("Could not send the e-mail - error: " + ex.Message);
            }
        }



        
       
    }
}