using System.Web.Mvc;

namespace Learun.Application.Web.Areas.LR_Principle
{
    public class LR_PrincipleAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LR_Principle";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LR_Principle_default",
                "LR_Principle/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}