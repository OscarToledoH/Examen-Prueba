using Microsoft.AspNetCore.Mvc;

namespace Ejerciciomvc.Controllers;

public class MenuController: Controller
{
    public MenuController()
    {
    }

    public IActionResult MenuAdd()
    {
        return View();
    }

    public IActionResult MenuSave ()
    {
        return View();
    }

}