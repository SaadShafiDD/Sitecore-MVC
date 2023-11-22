using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.Demo.MVC.Web.Models
{
    public class CarouselVM
    {
        public List<CarouselItem> Items { get; set; }
    }

    public class CarouselItem
    {
        public Item Item { get; set; }
    }
}