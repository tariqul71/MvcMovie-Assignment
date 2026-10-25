using Microsoft.AspNetCore.Mvc;
namespace MvcMovie.Controllers;
public class HomeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Privacy() => View();
}
