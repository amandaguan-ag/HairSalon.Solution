using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            Client starterClient = new Client("Add first client to Hair Salon");
            return View(starterClient);
        }

        [HttpGet("/clients/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/clients")]
        public ActionResult Create(string description)
        {
            Client myClient = new Client(description);
            return View("Index", myClient);
        }

    }
}