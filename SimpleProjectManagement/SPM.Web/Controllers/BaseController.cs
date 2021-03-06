﻿namespace SPM.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Routing;

    using SPM.Data;
    using SPM.Models;

    [HandleError]
    public class BaseController : Controller
    {
        protected IApplicationData Data { get; private set; }

        protected ApplicationUser UserProfile { get; private set; }

        public BaseController(IApplicationData data)
        {
            this.Data = data;
        }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            this.UserProfile = this.Data.Users.All().Where(u => u.UserName == requestContext.HttpContext.User.Identity.Name).FirstOrDefault();

            return base.BeginExecute(requestContext, callback, state);
        }
    }
}