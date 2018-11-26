using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult InputWords() { return View(); }

    [Route("/showStory")]
    public ActionResult ShowStory(string noun, string verb, string adjective)
    {
      WordVariable myWordVariable = new WordVariable();
      myWordVariable.SetNoun(noun);
      myWordVariable.SetVerb(verb);
      myWordVariable.SetAdjective(adjective);
      return View(myWordVariable);
    }

  }
}
