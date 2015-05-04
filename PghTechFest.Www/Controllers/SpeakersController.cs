using System.Web.Mvc;

namespace PghTechFest.Www.Controllers
{
    public class SpeakersController : Controller
    {
        //
        // GET: /Speakers/
        public ActionResult Index()
        {
            return View();
        }
    }
}