using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ticket_System.Data;

namespace Ticket_System.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDBContext _dbContext;
        public CinemasController(AppDBContext context)
        {
            _dbContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _dbContext.Cinemas.ToListAsync();
            return View();
        }
    }
}
