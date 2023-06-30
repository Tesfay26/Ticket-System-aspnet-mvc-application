using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ticket_System.Data.Enums;

namespace Ticket_System.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
		[Display(Name = "Description")]
		public string Description { get; set; }
		[Display(Name = "Price")]
		public double Price { get; set; }
		[Display(Name = "Image")]
		public string ImageUrl { get; set; }
		[Display(Name = "Start Date")]
		public DateTime StartDate { get; set; }
		[Display(Name = "End Date")]
		public DateTime EndDate { get; set; }
		[Display(Name = "Categorey")]
		public MovieCategory MovieCategories { get; set; }

        //Relationship
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
        public List<ActorMovie> ActorMovies { get; set; }
    }
}
