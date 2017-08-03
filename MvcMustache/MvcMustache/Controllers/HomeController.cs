using MvcMustache.Filters;
using MvcMustache.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMustache.Controllers
{
    public class HomeController : Controller
    {
        private static List<Contact> ContactList = new List<Contact>();
        // GET: Home
        [Log]
        public ActionResult Home()
        {
            HomeModel home = new HomeModel
            {
                ResimPathHome = new List<string> { "/images/the-beacon.jpg", "/images/the-father.jpg", "/images/the-actor.jpg", "/images/the-nerd.jpg" },
                ResimAdi = new List<string> { "the father", "the actor", "the nerd" },
                BaslikHome = "the beacon to all mankind",
                IcerikHome = new List<string>
                {
                    "Our website templates are created with",
                    "inspiration, checked for quality and originality",
                    "and meticulously sliced and coded."
                }

            };
            return View(home);
        }
        [Log]
        public ActionResult About()
        {
            HomeModel about = new HomeModel
            {
                ResimPathAbout = "/images/photographer.jpg",
                BaslikAbout = new List<string> { "mustacchio started", "We Have Free Templates for Everyone", "We Have More Templates for You", "Be Part of Our Community", "Template details" },
                IcerikAbout = new List<string>
                {
                  "  Our website templates are created with inspiration, checked for quality and originality and meticulously sliced and coded. What’s more, they’re absolutely free! You can do a lot with them. You can modify them. You can use them to design websites for clients, so long as you agree with the . You can even remove all our links if you want to.",
                  "   Looking for more templates? Just browse through all our and find what you’re looking for. But if you don’t find any website template you can use, you can try our  service and tell us all about it. Maybe you’re looking for something different, something special. And we love the challenge of doing something different and something special. ",
                  "  If you’re experiencing issues and concerns about this website template, join the discussion and meet other people in the community who share the same interests with you.",
                  " Design version 2. Code version 1. Website Template details, discussion and updates for this. Website Template design by Please feel free to remove some or all the text and links of this page and replace it with your own About content. "
                }
            };
            return View(about);
        }
        [Log]
        [HttpGet]
        public ActionResult Contact()
        {
            
            return View();
        }

        [HttpPost]
        // İnputtaki verileri kayıt ettiğim action (post edilen )
        public ActionResult Contact(string name,string address,string email,string phone,string message)
        {
            Contact model = new Contact
            {
                Name = name,
                Address = address,
                Email = email,
                Phone = phone,
                Message = message
            };
            ContactList.Add(model);
            return View(new Contact());
        }


        public ActionResult LogHome()
        {
            return View(LogVeri.Loglar);
        }

    }
}