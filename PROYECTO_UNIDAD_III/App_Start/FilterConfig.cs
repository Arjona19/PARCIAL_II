﻿using System.Web;
using System.Web.Mvc;

namespace PROYECTO_UNIDAD_III
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
