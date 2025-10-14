using Microsoft.AspNetCore.Mvc;

namespace Tattoo_booking_system.Controllers;

public class Booking : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Booking model)
    {
        if (!ModelState.IsValid)
            return View(model);
        
        return RedirectToAction(nameof(Index));
    }
}