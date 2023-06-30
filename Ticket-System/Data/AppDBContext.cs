using Microsoft.EntityFrameworkCore;

namespace Ticket_System.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }
    }
}
