using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; }
        public string Message { get; private set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (ModelState.IsValid())
            {
                EmailService.SendEmail(Contact);
                Message = "Your Email has been sent";
            }

        }

        public void OnPostSubscribe(string address)
        {
            EmailService.SendEmail(Contact);
            Message = "Your have been added to the mailing List.";

        }
    }
}
