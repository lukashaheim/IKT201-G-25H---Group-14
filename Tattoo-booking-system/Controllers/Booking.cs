using Microsoft.AspNetCore.Mvc;
using Tattoo_booking_system.Models;

namespace Tattoo_booking_system.Controllers;

public class BookingController : Controller
{
    private readonly IWebHostEnvironment _env;
    public BookingController(IWebHostEnvironment env) => _env = env;

    [HttpGet]
    public IActionResult Index() => View(new Booking());

    [HttpPost]
    public async Task<IActionResult> Index(Booking model)
    {
        if (!ModelState.IsValid)
            return View(model);

        // TODO: lagre booking til database 

        return View(model); // viser evt. opplastet bilde
    }
}