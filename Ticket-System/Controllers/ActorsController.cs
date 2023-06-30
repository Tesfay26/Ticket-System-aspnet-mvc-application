using Microsoft.AspNetCore.Mvc;
using Ticket_System.Data;

namespace Ticket_System.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDBContext _dbContext;
        public ActorsController(AppDBContext context)
        {
            _dbContext = context;
        }
        public IActionResult Index()
        {
            var data = _dbContext.Actors.ToList();
            return View();
        }
    }
}
