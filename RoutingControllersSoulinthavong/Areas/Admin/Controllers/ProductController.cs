using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingControllersSoulinthavong.Area.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        [Route("[area]/[controller]s/{id?}")] //attribute routing with specific segments
        public IActionResult List(string cat = "All", int num = 1)
        {
            return Content("Product controller, List action, " + "Category " + cat + ", Page " + num);
        }

        [Route("[area]/Detail")] //attribute routing
        public IActionResult Detail(int id) //routing with int id segment
        {
            return Content("Product controller, Detail action, id: " + id);
        }
    }
}
