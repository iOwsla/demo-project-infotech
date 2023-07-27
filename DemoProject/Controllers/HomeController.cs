using DemoProject.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUserService _userService;

    public HomeController(ILogger<HomeController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    public IActionResult Index()
    {
        var users = _userService.GetAllUsers();

        return Ok(Json(users));
    }
}