﻿namespace FunTextMVC.Controllers;

[Authorize]
public class HistoryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
