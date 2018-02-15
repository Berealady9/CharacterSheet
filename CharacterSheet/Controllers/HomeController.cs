using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CharacterSheet.Models;

namespace CharacterSheet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var name = "Thing";

            return View(Models.Character.GetAll());
        }

        public IActionResult Create(string characterName)
        {
            Models.Character.Create(characterName);
            var model = new CharacterSheet.Models.Character();
            model.Name = characterName;
            return RedirectToAction("Index");
        }

        ///
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
