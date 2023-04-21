using EternaWithDatabase.DataAccess;
using EternaWithDatabase.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EternaWithDatabase.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel()
            {
                Services = _context.Services.ToList(),
                Features = _context.Features.ToList(),
                Slides = _context.Slider.ToList(),

            };
            return View(hvm);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About() 
        { 
            return View();
        }
    }
}
