using System.Web.Mvc;

namespace GameInventory.Areas.PRGE
{
    public class PRGEAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "PRGE";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name:  "PRGE_default",
                url: "PRGE/{controller}/{action}/{id}",
                //defaults: new { action = "Index", id = UrlParameter.Optional }
                defaults: new { controller = "PRGEHome", action = "Index", id = UrlParameter.Optional }

            );
        }
    }
}