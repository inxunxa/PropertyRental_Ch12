
using Microsoft.AspNetCore.Mvc;
using PropertyRental.Models;

namespace PropertyRental.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index() 
        {
            return View(); // catalog page
        }

        public IActionResult Register() 
        {
            return View(); // register page
        }


        [HttpPost]
        public IActionResult SaveProperty([FromBody] Property theProperty ) 
        {
            // store theProperty into DB
            System.Console.WriteLine("Saving a property");
            System.Console.WriteLine(theProperty.Title);

    	    // temp
            theProperty.Id = 1;
            return Json(theProperty);
        }

    }
}