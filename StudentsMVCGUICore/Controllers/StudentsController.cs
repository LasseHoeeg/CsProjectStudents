using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentsMVCGUICore.Controllers
{
    public class StudentsController : Controller
    {
        //Husk at tilføje referencer.
        //Skal skrive Students/Students for at komme siden, da det ikke er default.
        //Man må ikke bruge if-statements, skal bruge switch/case i stedet for. 
        public IActionResult Students(IFormCollection formData)
        {
            //If-check ift. hvis data er null.
                    
               //Skal getStudent være i en get-metode, eller post-metode
            //Skal der tjekkes på 0, eller på null? Tænker null, men hvordan?
            if (formData.Count != 0) { //Giver en fejl her 
             ViewBag.StudentId = formData["StudentId"];
            int studentId = int.Parse(ViewBag.StudentId);


            BusinessLogic.BLL.StudentBLL bll = new BusinessLogic.BLL.StudentBLL();


            DTO.Model.Student student = bll.getStudent(studentId); //Skal det sættes ind i en post-metode i ste
            //Giver muligvis fejl, 
            ViewBag.Student = student;
        }
            else
            {

            }

            return View();
        }



        //List<SelectListItem> countriesList = new List<SelectListItem>();

        //public IActionResult Index(string Countries)
        //{

        //    if (HttpContext.Session.GetString("Countries") == null)
        //    {
        //        countriesList.Add(new SelectListItem { Text = "China", Value = "CN" });
        //        countriesList.Add(new SelectListItem { Text = "Denmark", Value = "DK" });
        //        string json = JsonSerializer.Serialize(countriesList);
        //        HttpContext.Session.SetString("Countries", json);

        //    }
        //    else
        //    {
        //        string json = HttpContext.Session.GetString("Countries");
        //        countriesList = JsonSerializer.Deserialize<List<SelectListItem>>(json);

        //    }
        //    ViewBag.Countries = countriesList;
        //    ViewBag.CountryCode = Countries;

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Index(IFormCollection formData)
        //{

        //    string json = HttpContext.Session.GetString("Countries");
        //    countriesList = JsonSerializer.Deserialize<List<SelectListItem>>(json);

        //    ViewBag.NewCountry = formData["Country"];
        //    ViewBag.NewCode = formData["Code"];
        //    string country = ViewBag.NewCountry;
        //    string code = ViewBag.NewCode;
        //    countriesList.Add(new SelectListItem { Text = country, Value = code });

        //    json = JsonSerializer.Serialize(countriesList);
        //    HttpContext.Session.SetString("Countries", json);

        //    ViewBag.Countries = countriesList;

        //    return View("Index");

        //}















    }
}
