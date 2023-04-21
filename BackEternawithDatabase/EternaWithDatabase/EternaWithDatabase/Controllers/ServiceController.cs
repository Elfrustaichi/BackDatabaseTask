using EternaWithDatabase.DataAccess;
using EternaWithDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EternaWithDatabase.Controllers
{
    public class ServiceController : Controller
    {
        private readonly DataContext _context;
        public ServiceController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();
            return View(services);
        }

        public IActionResult Detail(int id)
        {
            Service service = _context.Services.SingleOrDefault(s => s.Id == id);
            return View(service);
        }
    }
}
