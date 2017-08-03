using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMustache.Models
{
    public class HomeModel
    {
        public string BaslikHome { get; set; }
        public List<string> ResimPathHome { get; set; }
        public List<string> IcerikHome { get; set; }
        public List<string> ResimAdi { get; set; }
        public List<string> IcerikAbout { get; set; }
        public string ResimPathAbout { get; set; }
        public List<string> BaslikAbout { get; set; }
        public string BaslikContact { get; set; }
        public string LinkKontrolAdi { get; set; }
        public string LinkActionAdi { get; set; }

    }
}