using _Pustok.Models;

namespace _Pustok.Areas.Manage.ViewModels
{
    public class DashboardViewModel
    {
        public List<Author> authors { get; set; }
        public List<Genre> genres { get; set; }
    }
}
