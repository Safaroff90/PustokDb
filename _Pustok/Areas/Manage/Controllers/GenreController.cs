using _Pustok.Areas.Manage.ViewModels;
using _Pustok.DAL;
using Microsoft.AspNetCore.Mvc;

namespace _Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class GenreController : Controller
    {
        private readonly PustokContext _context;

        public GenreController(PustokContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DashboardViewModel GenreVM = new DashboardViewModel
            {
                genres = _context.Genres.ToList()
            };
            return View(GenreVM);
        }
    }
}
