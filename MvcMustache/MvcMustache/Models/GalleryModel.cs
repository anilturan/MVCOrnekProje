using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMustache.Models
{
    public class GalleryModel
    {
        public string GalleryBaslik { get; set; }
        public string GallerySinglePostBaslik { get; set; }
        public List<string> ResimPathGallery { get; set; }
        public string ResimPathGallerySinglePost { get; set; }
        public string LinkKontrolAdi { get; set; }
        public string LinkActionAdi { get; set; }


    }
}