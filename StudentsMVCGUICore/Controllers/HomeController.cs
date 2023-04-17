using Microsoft.AspNetCore.Mvc;

namespace StudentsMVCGUICore.Controllers
{
    public class HomeController : Controller
    {
        //Husk at tilføje referencer
        //Behøver ikke at skrive noget i til web-navnet, da den som default er sat til Home/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
