using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sala.Models;

namespace sala.Controllers;

public class salaController : Controller
{
    public IActionResult Index(){
        return View();
    }
}
