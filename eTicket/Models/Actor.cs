﻿using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor
    {
        [Key]
        public int? Id { get; set; }

        public string? ProfilePicture { get; set; } 
        
        public string? FullName { get; set; }

        public string? Bio { get; set; }

        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
