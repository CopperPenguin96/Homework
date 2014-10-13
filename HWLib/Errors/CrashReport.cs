using HWLib.Errors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib
{
    public class CrashReport
    {
        private String crashMessage;
        private CrashReports cReport;
        private DateTime dateTime;
        public CrashReport(String message)
        {
            crashMessage = message;
            dateTime = new DateTime();
        }
        public CrashReport(String message, CrashReports c)
        {
            cReport = c;
            crashMessage = message;
            dateTime = new DateTime();
        }
        
        public void send()
        {
            String item = "Crash Message: " + crashMessage + "\n" +
                "Priority: " + cReport.ToString() + "\n" +
                "DateTime: " + dateTime.Date;
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add("alex364981@gmail.com");
            message.Subject = "HomeworkHelper CrashReport " + dateTime.Date + " version " + Version.release();
            message.From = new System.Net.Mail.MailAddress("noreply@homeworkcalendar.edu");
            message.Body = "A Crash Report Has Been Submitted!" + item;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
            smtp.Send(message);
        }
    }
}
