using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ticket_System.Data;

namespace Ticket_System.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDBContext _dbContext;
        public MoviesController(AppDBContext context)
        {
            _dbContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _dbContext.Movies.ToListAsync();
            return View();
        }
    }
}
