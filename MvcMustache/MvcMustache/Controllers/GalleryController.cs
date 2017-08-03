using MvcMustache.Filters;
using MvcMustache.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMustache.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        [Log]
        public ActionResult Gallery()
        {
            GalleryModel gallery = new GalleryModel
            {
                ResimPathGallery = new List<string> { "/images/mustache1.jpg", "/images/mustache2.jpg", "/images/mustache3.jpg", "/images/mustache4.jpg", "/images/mustache5.jpg", "/images/mustache6.jpg", "/images/mustache7.jpg", "/images/mustache8.jpg", "/images/mustache9.jpg" },
                GalleryBaslik = "gallery",
                LinkKontrolAdi= "GallerySinglePost",
                LinkActionAdi="Gallery"
            };
            return View(gallery);
        }



        [Log]
        public ActionResult GallerySinglePost()
        {
            GalleryModel gallery = new GalleryModel
            {
                ResimPathGallerySinglePost = "/images/prim-and-proper.jpg",
                GallerySinglePostBaslik = "gallery single post"
            };
           
            return View(gallery);
        }
        public ActionResult LogGallery()
        {
            return View(LogVeri.Loglar);
        }
    }
}