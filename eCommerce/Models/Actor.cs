using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relationship

        public List<Actor_Movie> Actor_Movie { get; set; }
    }
}
