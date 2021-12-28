using eCommerce.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public string ImageUrl { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //Relationship
        public List<Actor_Movie> Actor_Movie { get; set; }

        //Cinema
        [ForeignKey("CinemaId")]
        public int  CinemaId { get; set; }
        public Cinema Cinema { get; set; }

        //Producer
        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }

    }
}
