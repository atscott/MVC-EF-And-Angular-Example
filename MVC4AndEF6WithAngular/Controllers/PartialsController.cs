using System.Web.Mvc;
using MVC4AndEF6WithAngular.Data.Dtos;

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
            return PartialView("StudentPartial", new StudentDto());
        }

        public ActionResult DetailsPartial()
        {
            return PartialView("DetailsPartial", new StudentDetailsDto());
        }

        public ActionResult CreatePartial()
        {
            return PartialView("CreatePartial",new StudentDto());
        }
    }
}
