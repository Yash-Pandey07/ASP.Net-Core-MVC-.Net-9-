using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class ItemsController : Controller
    {
        //Action Result
        public IActionResult Overview()             //item/overview
        {
            var item = new Item() { Name = "Item1"};
            return View(item);
        }
        //Action Parameters
        public IActionResult Edit(int id) {         //http://localhost:7221/items/edit/5
            return Content("id = " +  id);          //http://localhost:7221/items/edit?id=5 
        }
    }
}
