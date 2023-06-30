using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ticket_System.Data;

namespace Ticket_System.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDBContext _dbContext;
        public ProducersController(AppDBContext context)
        {
            _dbContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _dbContext.Producers.ToListAsync();
            return View(data);
        }
    }
}
