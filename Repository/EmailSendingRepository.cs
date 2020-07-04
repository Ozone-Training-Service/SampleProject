using SampleProject.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SampleProject.Repository
{
    public class EmailSendingRepository: IEmailSendingRepository
    {
       public void SendEmail()
        {
            try
            {
                Random rn = new Random();
                int OTP = rn.Next(9000);
                Console.WriteLine(OTP);
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("vishnukumarps2017@gmail.com");


                mail.To.Add("vivekps561@gmail.com");
                mail.Subject = "Test";
                mail.Body = "Hai  Your OTP= " + OTP;


                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("vishnukumarps2017@gmail.com", "vISHNU@123");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
                

    }
}
