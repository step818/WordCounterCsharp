using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/wordcounter")]
    public ActionResult Create(string word, string sentence)
    {
      WordCounterClass newCount = new WordCounterClass(word, sentence);
      return View("Index", newCount);
    }
  }
}
