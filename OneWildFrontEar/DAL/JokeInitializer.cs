using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OneWildFrontEar.Models;

namespace OneWildFrontEar.DAL
{
    public class JokeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WildFrontEarContext>
    {
        protected override void Seed(WildFrontEarContext context)
        {
            var jokes = new List<Joke>
            {
                new Joke {Randomizer = 1, JokeText = "1 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 2, JokeText = "2 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 3, JokeText = "3 - Blah Blah Blay", Votes = 12, Category = "General" },
                new Joke {Randomizer = 4, JokeText = "4 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 5, JokeText = "5 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 6, JokeText = "6 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 7, JokeText = "7 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 8, JokeText = "8 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 9, JokeText = "9 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 10, JokeText = "10 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 11, JokeText = "11 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 12, JokeText = "12 - How many ears does Davy Crockett have? Three. One left ear, one right ear, and one wild front ear! ", Votes = 999, Category = "General" },
                new Joke {Randomizer = 13, JokeText = "13 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 14, JokeText = "14 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 15, JokeText = "15 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 16, JokeText = "16 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 17, JokeText = "17 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 18, JokeText = "18 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 19, JokeText = "19 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 20, JokeText = "20 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 21, JokeText = "21 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 22, JokeText = "22 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 23, JokeText = "23 - Blah Blah Blay", Votes = 0, Category = "General" },
                new Joke {Randomizer = 24, JokeText = "24 - Blah Blah Blay", Votes = 0, Category = "General" }
            };

            jokes.ForEach(j => context.Jokes.Add(j));
            context.SaveChanges();
        }
    }
}