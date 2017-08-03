using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMustache.Models
{
    public class BlogModel
    {
        public List<string> BlogBaslik { get; set; }
        public string BlogSinglePostBaslik { get; set; }
        public List<string> ResimPathBlog { get; set; }
        public string ResimPathBlogSinglePost { get; set; }
        public string LinkKontrolAdi { get; set; }
        public string LinkActionAdi { get; set; }
        public List<string> IcerikBlog { get; set; }
        public List<string> IcerikBlogSinglePost { get; set; }

    }
}