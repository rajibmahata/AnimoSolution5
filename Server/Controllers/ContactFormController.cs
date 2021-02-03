using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimoWeb.Server;
using Model.Shared.DTOs;
using Model.Shared;
using System.Net.Mail;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactFormController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ContactFormController(ApplicationDbContext context)
        {
            this.context = context;
        }

               
 
        [HttpPost]
        public async Task<ActionResult<bool>> Post(ContactFormDTO contact) 
        {
            var config = await context.GlobalConfig.FirstOrDefaultAsync();
            bool message;
            var formattedMessage = contact.Message.Replace("\n", "<br />");
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(config.FirmaSmtpUser);
                    mail.To.Add(config.MailDestination);
                    mail.Subject = "Contact FORM - Web Animations and More";
                    mail.Body = $"Hallo Ich bin: <b>{contact.FullName}</b> <br><hr>Meine firma ist: <b>{contact.Firma}</b><br><br> Meine Email ist: " +
                        $"<b>{contact.EmailAddress}</b> <br><br>" +
                        $"<hr>Das Nachricht wurde:<br> {formattedMessage}" +
                        $"<br><br>" +
                        $"Bitte antwork nich wegen das eine Automatichenachritch ist" +
                        $"<br>" +
                        $"<span style='color: red; font-size:12px;'>Animations and More GmbH </span>" +
                        $"<br><br>" +
                        $"<img src='https://angstpfister.animoserver.com/logosm.png'/>";

                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(config.FirmaSmtp, config.FirmaSmtpPort))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential(config.FirmaSmtpUser, config.FirmaSmtpPass);
                        smtp.EnableSsl = false;
                        smtp.Send(mail);
                     
                    }

                }
                message = true;
            }
            catch (Exception error)
            {
                var what = error.Message;
                message = false;
            }
             return message;
        }

        private async Task<ActionResult<GlobalConfig>> GetConfig() 
        {
            var config = await context.GlobalConfig.FirstOrDefaultAsync();
            return config;
        } 
      
    }
}
