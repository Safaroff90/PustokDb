using _Pustok.Areas.Manage.ViewModels;
using _Pustok.DAL;
using Microsoft.AspNetCore.Mvc;

namespace _Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AuthorController : Controller
    {
        private readonly PustokContext _context;

        public AuthorController(PustokContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            DashboardViewModel AuthorVM = new DashboardViewModel
            {
                authors = _context.Authors.ToList()
            };
            return View(AuthorVM);
        }
    }
}
