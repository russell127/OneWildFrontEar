using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneWildFrontEar.Models
{
    public class Joke
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string JokeText { get; set; }
        [Required]
        [ConcurrencyCheck]
        public long Votes { get; set; }

        public int Inappropriate { get; set; }

        [Index(IsUnique = true)]
        public int Randomizer { get; set; }

        [MaxLength(50)]
        public string Category { get; set; }

    }

}