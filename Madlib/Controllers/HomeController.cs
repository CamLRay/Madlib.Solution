using Microsoft.AspNetCore.Mvc;
using Madlib.Models;
using System;


namespace Madlib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult MadlibLanding()
    {
      return View();
    }

    // [Route("/madlibform")]
    // public ActionResult MadlibForm()
    // {
    //   return View();
    // }

    [Route("/madlibformtwo")]
    public ActionResult MadlibFormTwo()
    {
      return View();
    }

    [Route("/random")]
    public ActionResult MadlibForm(string form)
    {
      if(form == "random")
      {
        MadlibVariable myMadlibVariable = new MadlibVariable();
        Random rand = new Random();
        int randomView = rand.Next(2);
        myMadlibVariable.Random = randomView;
        return View(myMadlibVariable);
      }
      else if(form == "denmark")
      {
        MadlibVariable myMadlibVariable = new MadlibVariable();
        myMadlibVariable.Random = 1;
        return View(myMadlibVariable);
      }
      else if (form == "uzbekistan")
      {
        MadlibVariable myMadlibVariable = new MadlibVariable();
        myMadlibVariable.Random = 2;
        return View(myMadlibVariable);
      }
      else
      {
        return View();
      }
    }
    [Route("/madlibgame")]
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
