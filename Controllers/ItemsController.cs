using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()             //item/overview
        {
            var item = new Item() { Name = "Item1"};
            return View(item);
        }
    }
}
