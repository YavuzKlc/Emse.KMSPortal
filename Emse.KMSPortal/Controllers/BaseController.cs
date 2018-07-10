using Emse.KMSPortal.Data.EF.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emse.KMSPortal.Controllers
{
    public class BaseController : Controller
    {

        protected readonly EFUnitOfWork efUnitOfWork;
        
        public BaseController()
        {
            var context = new Data.EF.Context.KMSPortalContext();
            efUnitOfWork = new EFUnitOfWork(context);
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if(Session.SessionID == String.Empty || Session["UserSession"] == null)
            {
                Response.Redirect("/Login/Login");
            }
            base.OnActionExecuted(filterContext);
        }
    }
}