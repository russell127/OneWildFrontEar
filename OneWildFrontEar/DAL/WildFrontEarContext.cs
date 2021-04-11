using System;
using System.Collections.Generic;
using System.Linq;
using OneWildFrontEar.Models;
using System.Data.Entity;

namespace OneWildFrontEar.DAL
{
    public class WildFrontEarContext : DbContext
    {
        public WildFrontEarContext() : base("WildFrontEarContext")
        {
        }

        public DbSet<Joke> Jokes { get; set; }
    }
}