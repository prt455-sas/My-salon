using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySalon_Master.Models;

namespace MySalon_Master.Controllers
{
    public class ContactUsController : Controller
    {
        private EmailAddress FromAndToEmailAddress;
        private IEmailService EmailService;
        public ContactUsController(EmailAddress _fromAddress, IEmailService _emailService)
        {
            FromAndToEmailAddress = _fromAddress;
            EmailService = _emailService;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                EmailMessage msgToSend = new EmailMessage
                {
                    FromAddresses = new List<EmailAddress> { FromAndToEmailAddress },
                    ToAddresses = new List<EmailAddress> { FromAndToEmailAddress },
                    Content = $"Message From MySalon" + "\n" + $"Name: {model.Name}, " + "\n" +
                              $"Email: {model.Email}" + "\n" + $" Message: {model.Message}",
                    Subject = "Contact Us - User Message"
                };

                EmailService.Send(msgToSend);
                return RedirectToAction("Index");
            }
            else
            {
                return Index();
            }
        }
    }
}