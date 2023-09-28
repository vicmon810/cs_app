// using System;
// using Microsoft.AspNctCore.Mvc;
// using Microsoft.AspNetCore;

using Microsoft.AspNetCore.Mvc;


namespace RunGroopWebApp.Controllers
{
    public class RaceController : Controller
    {
        private readonly Data.ApplicationDbContext _context;
        public RaceController(Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var race = _context.Races.ToList();
            return View(race);
        }
    }
}