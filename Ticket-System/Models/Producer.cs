﻿using System.ComponentModel.DataAnnotations;

namespace Ticket_System.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; }
		[Display(Name = "Full Name")]

		public string FullName { get; set; }
		[Display(Name = "Biography")]
		public string Biography { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
