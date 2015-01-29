using System.Web.Mvc;

namespace PghTechFest.Www.Controllers
{
    public class VenueController : Controller
    {
        //
        // GET: /Venue/
        public ActionResult Index()
        {
            return View("Index");
        }
	}
}