using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoBlogSite.Models;
using Recaptcha.Web;
using Recaptcha.Web.Mvc;

namespace UmbracoBlogSite.Controllers
{
    public class ContactController : SurfaceController
    {
        public const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/Contact/";

        public ActionResult RenderForm()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Contact.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(Contact model)
        {
            RecaptchaVerificationHelper recaptchaHelper = this.GetRecaptchaVerificationHelper();
            if (string.IsNullOrEmpty(recaptchaHelper.Response))
            {
                ModelState.AddModelError("reCAPTCHA", "Please complete the reCAPTCHA");
                return CurrentUmbracoPage();
            }
            else
            {
                RecaptchaVerificationResult recaptchaResult = recaptchaHelper.VerifyRecaptchaResponse();
                if (recaptchaResult != RecaptchaVerificationResult.Success)
                {
                    ModelState.AddModelError("reCAPTCHA", "The reCAPTCHA is incorrect");
                    return CurrentUmbracoPage();
                }
            }

            if (ModelState.IsValid)
            {
                //Process the valid form
               
                SendEmail(model);
                TempData["ContactSuccess"] = true;
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();

        }

        private void SendEmail(Contact model)
        {
            MailMessage message = new MailMessage(model.EmailAddress, "semere@adulis.se");
            message.Subject = string.Format("Enquiry from {0} - {1}", model.Name, model.EmailAddress);
            message.Body = model.Message;
            SmtpClient client = new SmtpClient("127.0.0.1", 25);
            client.Host = "mail7.inviso.se";
            client.Credentials = new System.Net.NetworkCredential("semere@adulis.se", "Aster92hanna!");


            client.Send(message);
        }
    }
}