using Microsoft.AspNetCore.Mvc;
using PhoneBookDemo.Web.Controllers;

namespace PhoneBookDemo.Web.Public.Controllers
{
    public class HomeController : PhoneBookDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}