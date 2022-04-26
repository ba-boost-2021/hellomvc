using BilgeAdam.MVCStyla.Managers;
using BilgeAdam.MVCStyla.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BilgeAdam.MVCStyla.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Receipt()
        {
            var manager = new ReceiptManager();
            var receipts = manager.GetReceipts();
            return View(receipts);
        }

        [Route("Home/Receipt-Detail/{id}")]
        public IActionResult ReceiptDetail(int id)
        {
            var manager = new ReceiptManager();
            var receipt = manager.GetReceipts().FirstOrDefault(f => f.Id == id);
            return View("Detail", receipt);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}