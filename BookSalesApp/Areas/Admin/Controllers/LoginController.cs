using BookSalesCore.Entities;
using BookSalesMVCUI.Models;
using BookSalesService.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BookSalesMVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {

        private readonly IService<AppUser> _service;

        public LoginController(IService<AppUser> service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminLoginViewModel admin)
        {
            return View();
        }
    }
}
