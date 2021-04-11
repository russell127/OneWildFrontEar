using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneWildFrontEar.Models
{
    public class JokeVote
    {
        public Joke joke1 { get; set; }
        public Joke joke2 { get; set; }
        public int choice { get; set; }
    }
}