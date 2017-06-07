using Metrics360.Mail.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task.MailDeleter
{
    class Program
    {
        static void Main(string[] args)
        {
            Metrics360.Mail.MetricsMailService mailService = new Metrics360.Mail.MetricsMailService();
            mailService.DeleteMails(m=>m.Sent); 
        }
    }
}
