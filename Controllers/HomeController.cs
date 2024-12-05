using System.Diagnostics;
using devmindfusion.Models;
using Microsoft.AspNetCore.Mvc;

namespace devmindfusion.Controllers;

public class HomeController : Controller
{
    //
    // GET: /Home/
    public IActionResult Index()
    {
        return View();
    }

    public string Welcome()
    {
        return "This is the welcome action method";
    }
}
