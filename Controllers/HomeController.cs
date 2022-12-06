using System.Web.Mvc;
using WebApplication2.Managers;

namespace WebApplication2.Controllers
{
    public class HomeController : MyController
    {

        public ActionResult Index()
        {
            ViewBag.Index = "active";
            return View();
        }

        public ActionResult Privacy()
        {
            ViewBag.Privacy = "active";
            return View();
        }


        public ActionResult About()
        {
            ViewBag.About = "active";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Contact = "active";
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Gallery = "active";
            return View();
        }

        public ActionResult Service()
        {
            ViewBag.Service = "active";
            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Location = "active";
            return View();
        }

        public ActionResult ChangeLanguage(string lang)
        {


            new LanguageManager().SetLanguage(lang);
            return RedirectToAction("Index", "Home");
        }
    }
}