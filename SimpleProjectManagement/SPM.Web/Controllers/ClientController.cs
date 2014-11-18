namespace SPM.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;

    using Microsoft.AspNet.Identity;

    using SPM.Data;
    using SPM.Models;
    using SPM.Web.ViewModels.Clients;

    public class ClientController : BaseController
    {
        public ClientController(IApplicationData data)
            : base(data)
        {

        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Read([DataSourceRequest]DataSourceRequest request)
        {
            var clients = this.Data.Clients.All().Project().To<ClientViewModel>();

            return this.Json(clients.AsQueryable().ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Authorize]
        // [ValidateAntiForgeryToken]
        public JsonResult Update([DataSourceRequest] DataSourceRequest request, ClientViewModel clientModel)
        {
            var existingClient = this.Data.Clients.GetById(clientModel.Id);

            if (clientModel != null && ModelState.IsValid)
            {
                existingClient.Name = clientModel.Name;

                this.Data.SaveChanges();
            }

            return Json((new[] { clientModel }.ToDataSourceResult(request, ModelState)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Authorize]
        // [ValidateAntiForgeryToken]
        public JsonResult Create([DataSourceRequest] DataSourceRequest request, ClientViewModel clientModel)
        {
            if (clientModel != null && ModelState.IsValid)
            {
                var userId = this.User.Identity.GetUserId();

                var newClient = new Client
                {
                    Name = clientModel.Name,
                    CreatedById = userId
                };

                this.Data.Clients.Add(newClient);
                this.Data.SaveChanges();

                clientModel.Id = newClient.Id;
                clientModel.CreatedById = userId;
            }

            return Json(new[] { clientModel }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }
    }
}