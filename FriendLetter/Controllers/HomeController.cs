using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")]
        public string Hello() { return "Hello Friend!!!!!!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye old friend."; }

        [Route("/")]
        public string Letter()  {return "Our virtual Postcard will go here soon!!!!!"; }
    }
}