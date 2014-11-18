namespace SPM.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using SPM.Data;

    public class ProjectController : BaseController
    {
        public ProjectController(IApplicationData data)
            : base(data)
        {

        }

        public ActionResult Index()
        {
            return View();
        }
    }
}