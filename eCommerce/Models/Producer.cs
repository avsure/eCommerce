﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //relationship
        public List<Movie> Movies { get; set; }
    }
}
