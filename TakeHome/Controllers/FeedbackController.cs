using System.Web.Mvc;
using TakeHome.Models;

namespace TakeHome.Controllers
{
    public class FeedbackController : Controller
    {
        /// <summary>Get form view</summary>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>Form submission</summary>
        [HttpPost]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        public ActionResult Submit(FeedbackViewModel form)
        {
            if (ModelState.IsValid) // check form
            {
                // TODO: add persistence or additional action here
                return View("ThankYou", form);
            }

            ViewBag.Message = "Invalid entries, kindly recheck.";
            return View("Index"); // return form view if not valid
        }

    }
}