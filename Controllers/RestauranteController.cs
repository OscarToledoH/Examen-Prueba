
using Microsoft.AspNetCore.Mvc;

public class RestauranteController : Controller
{
    public RestauranteController()
    {
    }


    public IActionResult Zonas()
    {
        return View();
    }
}