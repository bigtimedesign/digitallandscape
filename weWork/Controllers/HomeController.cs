using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeWorkModel;
using weWork.Models;

namespace weWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            using (var ctx = new weWorkEntities())
            {
                var summary = new SummaryModel()
                    {
                        CompanyCount = ctx.Companies.Count(),
                        PeopleCount = ctx.People.Count(),
                        GroupCount = ctx.Groups.Count(),
                        ProjectCount = ctx.Projects.Count(),
                        ResourcesCount = ctx.Resources.Count()
                    };
                return View(summary);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
