using System.ComponentModel.DataAnnotations;

namespace Ticket_System.Models
{
    public class ActorMovie
    {
        [Key]
        public int Id { get; set; }

        //Relationship
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
