using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Demo.MVC.Web.Models
{
    public class NavigationVM
    {
        public List<Navigation> NavigationItems { get; set; }
    }

    public class Navigation
    {
        public string Title { get; set; }
        public string URL { get; set; }
        public string ActiveClass { get; set; }
    }
}