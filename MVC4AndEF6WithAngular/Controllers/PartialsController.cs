using System.Web.Mvc;

namespace MVC4AndEF6WithAngular.Controllers
{
    public class PartialsController : Controller
    {
        public ActionResult NavbarPartial()
        {
            return PartialView("NavbarPartial");
        }

        public ActionResult HomePartial()
        {
            return PartialView("HomePartial");
        }

        public ActionResult StudentPartial()
        {
            return PartialView("StudentPartial");
        }
    }
}
