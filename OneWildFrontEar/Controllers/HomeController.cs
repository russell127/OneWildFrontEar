using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OneWildFrontEar.DAL;

namespace OneWildFrontEar.Controllers
{
    public class HomeController : Controller
    {
        const int PageSize = 10;

        public ActionResult Index(int? page, int? id)
        {
            if (id != null)
            {
                // We came here on a redirect from voting.  Display the result.
                using (WildFrontEarContext db = new WildFrontEarContext())
                {
                    ViewBag.VoteResult = db.Jokes.Where(j => j.ID == id).Single(); 
                }
            }
            using (WildFrontEarContext db = new WildFrontEarContext())
            {
                int offset = page ?? 0;
                offset *= PageSize;
                return View(db.Jokes.OrderByDescending(j => j.Votes).Skip(offset).Take(PageSize).ToList());
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Vote for the funniest joke from two jokes chosen at random.  See which joke got the most votes.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}