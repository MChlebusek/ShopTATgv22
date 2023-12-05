using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using Shop.Models;

namespace Shop.Controllers
{
    public class EmailsController : Controller
    {
        private readonly IEmailServices _emailServices;
        public EmailsController(IEmailServices emailServices)
        {
            _emailServices = emailServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(EmailIndexViewModel vm)
        {

            EmailDtos newreq = new();
            newreq.To = vm.To;
            newreq.Subject = vm.Subject;
            newreq.Body = vm.Body;
            _emailServices.SendEmail(newreq);
            return Ok();
        }

    }
}