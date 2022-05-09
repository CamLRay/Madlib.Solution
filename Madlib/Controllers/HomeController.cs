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

    [Route("/random")]
    public ActionResult MadlibForm(string form)
    {
      if(form == "random")
      {
        MadlibVariable myMadlibVariable = new MadlibVariable();
        Random rand = new Random();
        int randomView = rand.Next(1, 4);
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
      else if (form == "space")
      {
        MadlibVariable myMadlibVariable = new MadlibVariable();
        myMadlibVariable.Random = 3;
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

    [Route("/madlibgametwo")]
    public ActionResult MadlibGameTwo(string noun, string nounTwo, string adjective, string exclamation, string verb, string verbTwo, string verbThree)
    {
      MadlibVariable myMadlibVariable = new MadlibVariable();
      
      myMadlibVariable.Noun = noun;
      myMadlibVariable.Noun2 = nounTwo;
      myMadlibVariable.Adjective = adjective;
      myMadlibVariable.Exclamation = exclamation;
      myMadlibVariable.Verb = verb;
      myMadlibVariable.Verb2 = verbTwo;
      myMadlibVariable.Verb3 = verbThree;
      return View(myMadlibVariable);
    }

    [Route("/madlibgamethree")]
    public ActionResult MadlibGameThree(string noun, string nounTwo, string adjective, string adjectiveTwo, string exclamation, string exclamationTwo, string verb, string verbTwo, string verbThree)
    {
      MadlibVariable myMadlibVariable = new MadlibVariable();
      
      myMadlibVariable.Noun = noun;
      myMadlibVariable.Noun2 = nounTwo;
      myMadlibVariable.Adjective = adjective;
      myMadlibVariable.Adjective2 = adjectiveTwo;
      myMadlibVariable.Exclamation = exclamation;
      myMadlibVariable.Exclamation2 = exclamationTwo;
      myMadlibVariable.Verb = verb;
      myMadlibVariable.Verb2 = verbTwo;
      myMadlibVariable.Verb3 = verbThree;
      return View(myMadlibVariable);
    }

  }

  
}
