using BilgeAdam.BootStrap.Context;
using BilgeAdam.BootStrap.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BilgeAdam.BootStrap.Controllers
{
    public class HomeController : Controller
    {
        private readonly NorthwindDbContext dbContext;

        public HomeController(NorthwindDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var categories = dbContext.Categories.ToList();
            return View(categories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}