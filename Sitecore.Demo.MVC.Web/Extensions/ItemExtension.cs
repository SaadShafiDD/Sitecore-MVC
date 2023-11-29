using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.Links.UrlBuilders;

namespace Sitecore.Demo.MVC.Web.Extensions
{
    public static class ItemExtension
    {
        public static string GetItemUrl(this Item item, ItemUrlBuilderOptions options=null)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(Item));
            else if (options != null)
                return LinkManager.GetItemUrl(item, options);
            else
                return LinkManager.GetItemUrl(item);
        }
    }
}