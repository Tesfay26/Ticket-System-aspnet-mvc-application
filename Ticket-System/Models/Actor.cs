using System.ComponentModel.DataAnnotations;

namespace Ticket_System.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePicture { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }

        //Relationship
        public List<ActorMovie> ActorMovies { get; set; }
    }
}
