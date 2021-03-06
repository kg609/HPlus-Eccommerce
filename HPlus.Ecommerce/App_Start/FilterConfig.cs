﻿using HPlus.Ecommerce.Filters;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogRequestFilter());
        }
    }
}
