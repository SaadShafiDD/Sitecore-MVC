using Sitecore.Demo.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Demo.MVC.Web.Extensions;
using Sitecore.Mvc.Presentation;
using Sitecore.Data.Items;
using Sitecore.Links.UrlBuilders;

namespace Sitecore.Demo.MVC.Web.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        public ActionResult Index()
        {
            ItemUrlBuilderOptions options = new ItemUrlBuilderOptions();
            options.LanguageEmbedding = Links.LanguageEmbedding.Never;

            var model = new NavigationVM();
            var list = new List<Navigation>();
            var home = Context.Site.HomeItem();

            list.Add(new Navigation()
            {
                Title = home.Fields["Title"]?.Value,
                URL = home.ItemUrl(options),
                ActiveClass = PageContext.Current.Item.ID == home.ID ? "active" : string.Empty
            });

            if(home.HasChildren)
            {
                foreach(Item item in home.Children)
                {
                    list.Add(new Navigation()
                    {
                        Title = item.Fields["Title"]?.Value,
                        URL = item.ItemUrl(options),
                        ActiveClass = PageContext.Current.Item.ID == item.ID ? "active" : string.Empty
                    });
                }
            }

            model.NavigationItems = list;

            return View(model);
        }
    }
}