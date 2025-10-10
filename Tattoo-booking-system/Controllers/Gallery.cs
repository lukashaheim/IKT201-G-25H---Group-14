using Microsoft.AspNetCore.Mvc;

namespace Tattoo_booking_system.Controllers;

public class Gallery : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}