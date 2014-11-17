namespace SPM.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using SPM.Data;
    using SPM.Common;
    using SPM.Web.Controllers;

    // TODO: Uncomment in production
    // [Authorize(Roles = GlobalConstants.AdminRole)]
    public abstract class AdminController : BaseController
    {
        public AdminController(IApplicationData data)
            : base(data)
        {

        }
    }
}