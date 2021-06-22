using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingControllersSoulinthavong.Controllers
{
    public class ProductController : Controller
    {
        [Route("Product/List/{cat?}/{num?}")] //attribute routing with specific segments
        public IActionResult List(string cat = "All", int num = 1)
        {
            return Content("Product controller, List action, " + "Category " + cat + ", Page " + num);
            //return View();
        }

        [Route("Detail")] //attribute routing
        public IActionResult Detail(int id) //routing with int id segment
        {
            return Content("Product controller, Detail action, id: " + id);
        }
    }
}
