﻿using System.Web;
using System.Web.Mvc;

namespace Practical_13_Entity_FrameWork
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
