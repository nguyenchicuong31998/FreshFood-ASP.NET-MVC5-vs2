﻿using System.Web.Mvc;

namespace WebsiteThucPhamSach_VS2.Areas.Dashboard
{
    public class DashboardAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Dashboard";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {


            context.MapRoute(
                "Dashboard_default",
                "Dashboard/{controller}/{action}/{id}",
                new { controller = "Dashboard" , action = "Index", id = UrlParameter.Optional },
                namespaces: new string [] { "WebsiteThucPhamSach_VS2.Areas.Dashboard.Controllers" }
            );
        }
    }
}