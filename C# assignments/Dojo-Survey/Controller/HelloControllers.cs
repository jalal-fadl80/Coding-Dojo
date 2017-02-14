using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace FirstCore.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
           return View("index");
        }
        [HttpPostAttribute]
        [RouteAttribute("sur")]
        public IActionResult sur(string name, string location,string language ,string comment ){
            ViewBag.name = name ;
            ViewBag.location= location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View("sur");

        }


    }
}