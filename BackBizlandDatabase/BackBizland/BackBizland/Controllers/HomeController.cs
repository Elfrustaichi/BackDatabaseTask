using BackBizland.DataAccess;
using BackBizland.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BackBizland.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
           HomeViewModel hmv = new HomeViewModel()
           {
               Services=_context.Services.ToList(),
               TeamMembers=_context.TeamMembers.ToList(),
           };
            
            return View(hmv);
        }
    }
}
