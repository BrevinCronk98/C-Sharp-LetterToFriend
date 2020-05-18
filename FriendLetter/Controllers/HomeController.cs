using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")]
        public string Hello() { return "Hello Friend!!!!!!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye old friend."; }

        [Route("/")]
        public ActionResult Letter()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = "(not)Master Skywalker";
            myLetterVariable.Sender = "Obi-Wan Kenobi";
            return View(myLetterVariable);
        }

        [Route("/form")]
        public ActionResult Form() { return View(); }

        [Route("/postcard")]
        public ActionResult Postcard(string recipient, string sender, string vacationSpot, string souvenir)
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = recipient;
            myLetterVariable.Sender = sender;
            myLetterVariable.VacationSpot = vacationSpot;
            myLetterVariable.Souvenirs = souvenir;
            return View(myLetterVariable);
        }
    }
}