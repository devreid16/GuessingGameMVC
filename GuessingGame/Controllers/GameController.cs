using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuessingGame.Models;

namespace GuessingGame.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            Session["Answer"] = new Random().Next(1, 10);

            return View();
        }

        private bool GuessWasCorrect(int guess)
        {
            return guess == (int )Session["Answer"];
        }

        [HttpPost]  //attribute that decorates index overload
        [ValidateAntiForgeryToken] //extra layer of security, not authentication
        
        public ActionResult Index(GameModel model)
        {           
            if (ModelState.IsValid) 
            {
                ViewBag.Win = GuessWasCorrect(model.Guess);  
            }

            return View(model);
        }
    }
}