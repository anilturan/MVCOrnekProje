using MvcMustache.Filters;
using MvcMustache.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMustache.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
      
            [Log]
        public ActionResult Blog()
        {
            BlogModel blog = new BlogModel
            {
                BlogBaslik = new List<string> { "blog", " why i grew a mustache", "in the country", "the mustache brothers" },
                ResimPathBlog = new List<string> { "/images/cutting-mustache.jpg", " /images/in-the-country.jpg", "/images/mustache-brothers.jpg" },
                LinkKontrolAdi = "BlogSinglePost",
                LinkActionAdi = "Blog",
                IcerikBlog = new List<string>
                {
                     "   Our website templates are created with inspiration, checked for quality and originality and meticulously sliced and coded.What’s more, they’re absolutely free!You can do a lot with them.You can modify them.",

                     "  Our website templates are created with inspiration, checked for quality and originality and meticulously sliced and coded. What’s more, they’re absolutely free! You can do a lot with them. You can modify them.",

                       " Our website templates are created with inspiration, checked for quality and originality and meticulously sliced and coded.What’s more, they’re absolutely free!You can do a lot with them.You can modify them."
                }

            };

            return View(blog);
        }
        [Log]
        public ActionResult BlogSinglePost()
        {
            BlogModel blog = new BlogModel
            {
                BlogSinglePostBaslik = "blog single post",
                ResimPathBlogSinglePost = "/images/grew-a-mustache.jpg",
                IcerikBlogSinglePost = new List<string>
                {
                     " Our website templates are created with inspiration, checked for quality and originality and meticulously sliced and coded. What’s more, they’re absolutely free! You can do a lot with them. You can modify them. You can use them to design websites for clients, so long as you agree with the Terms of Use. You can even remove all our links if you want to.",
               " Looking for more templates? Just browse through all our Free Website Templates and find what you’re looking for. But if you don’t find any website template you can use, you can try our Free Web Design service and tell us all about it. Maybe you’re looking for something different, something special. And we love the challenge of doing something different and something special.",
               " If you’re experiencing issues and concerns about this website template, join the discussion on our forum and meet other people in the community who share the same interests with you. Website Template details, discussion and updates for this Mustacchio Template. Website Template design by Free Website Templates."
                }
            };

            return View(blog);
        }
        public ActionResult LogBlog()
        {
            return View(LogVeri.Loglar);
        }


    }
}
