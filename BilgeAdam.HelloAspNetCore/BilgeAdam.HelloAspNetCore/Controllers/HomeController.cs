using BilgeAdam.HelloAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BilgeAdam.HelloAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() // Controller'ın dönüş türü olan her türün temel tipidir
        {
            return View(); // Sayfa döner
        }

        public IActionResult People()
        {
            var persons = new List<PersonViewModel>
            {
                new PersonViewModel { Name = "Can Perk", Age = 24 },
                new PersonViewModel { Name = "Tufan Yıldırım", Age = 21 },
                new PersonViewModel { Name = "Esengül Özkul", Age = 22 }
            };
            return View(persons);
        }
    }
}
