using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train.WebAPI.Models
{
    public class Link
    {
        public string Rel { get; set; }
        public Uri Href { get; set; }
        public string Action { get; set; }
    }
}