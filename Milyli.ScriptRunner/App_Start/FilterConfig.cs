﻿namespace Milyli.ScriptRunner
{
    using System.Web;
    using System.Web.Mvc;

    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}