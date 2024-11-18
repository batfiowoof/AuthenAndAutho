using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ManageUsers()
    {
        // Логика за управление на потребителите
        return View();
    }

    public IActionResult ManageRoles()
    {
        // Логика за управление на ролите
        return View();
    }
}
