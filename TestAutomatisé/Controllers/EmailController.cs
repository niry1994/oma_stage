using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAutomatisé.Models;
using System.Net;
using System.Net.Mail;
using System.IO;
//using KP.GmailApi.Models;
//using KP.GmailApi.GmailClient;
//using KP.GmailApi;

namespace TestAutomatisé.Controllers
{
    public class EmailController : Controller
    {
        //const string path = "C:\\Users\\Me\\Documents\\Gmail-Project.json";
        //var initializer = GmailClientInitializer.Initialize(path, scopes);
        // client = new GmailClient(initializer, emailAddress);
        // GET: Email
        public ActionResult Index()
        {
            //Message sentMessage = await client.Messages.SendAsync(emailAddress, "The subject", "Plain text body");
            //Profile profile = await client.GetProfileAsync();
            return View();
        }


        [HttpPost]
        public ActionResult Index(Gmail model)
        {
            //try
            //{

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
     
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential("nirizo1994@gmail.com","andriamanitra");

                MailMessage msg = new MailMessage();
                msg.To.Add(model.To);
                msg.From = new MailAddress("nirizo1994@gmail.com");

                msg.Subject = model.Subject;
                msg.Body = model.Body;
                msg.IsBodyHtml = true;

                smtp.Send(msg);


            ViewBag.Message = "Test Envoyer";
            return View();
            
            //catch (Exception)
            //{
            //    ViewBag.messageErreur = "erreur serveur";
            //    return View();
            //}



        }

    }
}