using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMustache.Models
{
    public class LogVeri
    {
        //Logların listesini tutuyorum, listelemek bunu kullanacağım.
        private static List<LogBilgi> _loglar = new List<LogBilgi>();

        public static List<LogBilgi> Loglar
        {
            get { return _loglar; }
        }
    }
}