using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalesLead.Models;
using Vonage;
using Vonage.Request;

namespace SalesLead.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(Lead lead)
        {
            string name = lead.Name;
            string phone = lead.Phone;
            string message = lead.Message;

            var credentials = Credentials.FromAppIdAndPrivateKeyPath(
                Domain.Credentials.ApplicationId,
                Domain.Credentials.PrivateKeyPath
            );

            var vonageClient = new VonageClient(credentials);

            var request = new Vonage.Messages.Sms.SmsRequest
            {
                To = "ENTER_YOUR_PHONE_NUMBER",
                From = "ENTER_YOUR_LINKED_PHONE_NUMBER",
                Text = $"New lead acquired!\n\nName: {name}\nPhone: {phone}\nMessage: {message}"
            };

            try
            {
                var response = await vonageClient.MessagesClient.SendAsync(request);
                lead.Result = "Message sent successfully! An agent will contact you shortly.";
            }
            catch (Exception)
            {
                lead.Result = "Message Failure. Please try your request again.";
            }

            return this.View(lead);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
