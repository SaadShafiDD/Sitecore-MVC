using Sitecore.Data.Fields;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Demo.MVC.Web.Models;

namespace Sitecore.Demo.MVC.Web.Controllers
{
    public class CarouselController : Controller
    {
        // GET: Carousel
        public ActionResult Index()
        {
            var model = new CarouselVM();
            var listItems = new List<CarouselItem>();
            var data = RenderingContext.Current?.Rendering.Item;
            MultilistField items = data.Fields["Items"];

            var count = RenderingContext.Current?.Rendering.Parameters["SlideCount"];
            int.TryParse(count, out int result);
            var itemsCount = result == 0 ? 3 : result;

            if (items.Count > 0)
            {
                var dataItems = items.GetItems();
                foreach(var item in dataItems.Take(itemsCount))
                {
                    listItems.Add(new CarouselItem
                    {
                        Item = item
                    });
                }
                model.Items = listItems;
            }
            return View(model);
        }
    }
}