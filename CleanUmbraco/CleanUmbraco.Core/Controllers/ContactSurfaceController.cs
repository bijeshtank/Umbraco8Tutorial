using CleanUmbraco.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Umbraco.Core.Logging;
using CleanUmbraco.Core.Services;

namespace CleanUmbraco.Core.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        private readonly ISmtpService _smtpService;
        public ContactSurfaceController(ISmtpService smtpService)
        {
            _smtpService = smtpService;
        }

        [HttpGet]
        public ActionResult RenderForm()
        {
            ContactViewModel model = new ContactViewModel()
            {
                ContactFormId = CurrentPage.Id
            };

            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);
        }

        [HttpPost]
        public ActionResult RenderForm(ContactViewModel model)
        {
           return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);
        }

        public ActionResult SubmitForm(ContactViewModel model)
        {
            bool success = false;

            if (ModelState.IsValid)
            {
                success = _smtpService.SendEmail(model);
            }

            var contactPage = UmbracoContext.Content.GetById(false, model.ContactFormId);

            var successMessage = contactPage.Value<IHtmlString>("successMessage");
            var errorMessage = contactPage.Value<IHtmlString>("errorMessage");

            return PartialView("~/Views/Partials/Contact/result.cshtml", success ? successMessage : errorMessage);
        }

        
    }
}
