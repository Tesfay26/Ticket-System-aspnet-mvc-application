using System.ComponentModel.DataAnnotations;

namespace Ticket_System.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
