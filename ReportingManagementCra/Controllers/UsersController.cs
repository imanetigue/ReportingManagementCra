using Microsoft.AspNetCore.Mvc;

namespace ReportingManagementCra.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
