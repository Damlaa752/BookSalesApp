using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookSalesMVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Area("Admin"), Authorize]
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
