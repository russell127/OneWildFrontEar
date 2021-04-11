using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Infrastructure;
using OneWildFrontEar.Models;
using OneWildFrontEar.DAL;

namespace OneWildFrontEar.Controllers
{
    public class VoteController : Controller
    {
        public ActionResult Index()
        {
            JokeVote jokeVote = new JokeVote();
            using (WildFrontEarContext db = new WildFrontEarContext())
            {
                int jokeCount = db.Jokes.Max(j => j.ID);

                // Get two random jokes and display them.
                Random rnd = new Random();
                int jokeIndex = rnd.Next(1, jokeCount);

                Joke joke1 = db.Jokes.Where(j => j.Randomizer == jokeIndex).FirstOrDefault();
                jokeIndex = rnd.Next(1, jokeCount);
                Joke joke2 = db.Jokes.Where(j => j.Randomizer == jokeIndex).FirstOrDefault();

                jokeVote.joke1 = joke1;
                jokeVote.joke2 = joke2;
                jokeVote.choice = -1;       
            }
                
            return View(jokeVote);
        }

        public ActionResult Vote(int id)
        {
            using (WildFrontEarContext db = new WildFrontEarContext())
            {
                var joke = db.Jokes.Where(j => j.ID == id).Single();
                joke.Votes++;  
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException e)
                {
                    // TODO: What to do if something else incremented?
                    // Maybe retry with a max number of retries
                }
            }
            return RedirectToAction("Index", "Home", new { page = 0,  id });  
        }
    }
}