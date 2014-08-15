using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//references to send email
using System.Net;
using System.Net.Mail;

namespace lesson10
{
    public class CException
    {
        public static void EmailException(Exception objError)
        {
            MailMessage objMail = new MailMessage();
            objMail.Subject = "Lesson 10 Error";
            objMail.From = new MailAddress("gcstudent@infrontofthenet.com");
            objMail.To.Add("rich.freeman@georgiancollege.ca");

            objMail.Body = "Message: " + objError.Message + "<br />" + "Type: " + objError.GetType().ToString() + "<br />" + "Source: " + objError.Source + "<br />Stack Trace: " + objError.StackTrace;
            objMail.IsBodyHtml = true;

            SmtpClient objSmtp = new SmtpClient();
            //objSmtp.Send(objMail);

            //clear the error
            
        }
    }
}