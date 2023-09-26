// using System;
// using Microsoft.AspNctCore.Mvc;
// using Microsoft.AspNetCore;

using Microsoft.AspNetCore.Mvc;


namespace RunGroopWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly Data.ApplicationDbContext _context;
        public ClubController(Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() //control stands for C
        {
            var clubs = _context.Clubs.ToList();// Model stands for M
            return View(clubs);//Viewer stands for V 
        }
    }
}