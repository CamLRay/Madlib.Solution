using Microsoft.AspNetCore.Mvc;
using Madlib.Models;

namespace Madlib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult MadlibForm()
    {
      return View();
    }

    [Rout("/madlibgame")]
    public ActionResult MadlibGame(string noun, string adjective, string exclamation, string verb)
    {
      MadlibVariable myMadlibVariable = new MadlibVariable();

      myMadlibVariable.Noun = noun;
      myMadlibVariable.Adjective = adjective;
      myMadlibVariable.Exclamation = exclamation;
      myMadlibVariable.Verb = verb;
      return View(myMadlibVariable);
    }
  }
}
