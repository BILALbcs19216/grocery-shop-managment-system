﻿using System.Web;
using System.Web.Mvc;

namespace grocery_shop_managment_system
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
