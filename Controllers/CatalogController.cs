
using Microsoft.AspNetCore.Mvc;
using PropertyRental.Models;

namespace PropertyRental.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult Register() 
        {
            return View();
        }


        [HttpPost]
        public IActionResult SaveProperty([FromBody] Property theProperty ) 
        {
            // store theProperty into DB
            System.Console.WriteLine("Saving a property");
            System.Console.WriteLine(theProperty.Title);

            theProperty.Id = 1;
            return Json(theProperty);
        }
    }
}