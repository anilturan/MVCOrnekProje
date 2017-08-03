using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMustache.Models
{
    public class LogBilgi
    {
        //Loglama işlemi için kullanılan entity
        public string Controller { get; set; }
        public string Action { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string Tip { get; set; }
    }
}