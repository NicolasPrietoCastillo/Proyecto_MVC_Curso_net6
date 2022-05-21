using Microsoft.AspNetCore.Mvc;

namespace MVCPrimerEjemplo.Controllers
{
    public class AdminController : Controller
    {
        [Route("~/Admin/Admin")]
        public IActionResult Admin()
        {
            return View();
        }
    }
}
