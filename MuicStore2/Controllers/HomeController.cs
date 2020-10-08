using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MuicStore2.Data;
using MuicStore2.Models;

namespace MuicStore2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            
        }
        
        public IActionResult Index()
        {
            return View(_context.Songs.Where(m => m.Feature).ToList());
            
        }
        public IActionResult ActiveSongs()
        {
            
            return View(_context.Songs.Where(m => m.IsActive).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Albums()
        {
            var albums = _context.Songs.ToList().GroupBy(g => g.Album).Select(s => s.FirstOrDefault());
            return View(albums);
        }
       /* public IActionResult Activesongs()
        {
            var activesongs = _context.Songs.ToList().GroupBy(g => g.IsActive).Select(s => s.FirstOrDefault());
            return View(activesongs);
             
        } */

    }
}
