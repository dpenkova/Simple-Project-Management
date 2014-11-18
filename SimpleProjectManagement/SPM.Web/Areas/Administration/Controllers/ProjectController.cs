namespace SPM.Web.Areas.Administration.Controllers
{
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;

    using Microsoft.AspNet.Identity;

    using SPM.Data;
    using SPM.Models;
    using SPM.Web.Areas.Administration.ViewModels.Clients;
    using SPM.Web.Areas.Administration.ViewModels.Projects;
    using SPM.Web.Areas.Administration.ViewModels.Statuses;
    using SPM.Web.Areas.Administration.ViewModels.Users;

    public class ProjectController : AdminController
    {
        
        public ProjectController(IApplicationData data)
            : base(data)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        // GET: Administration/Project
        public ActionResult Index()
        {
            PopulateClients();
            PopulateUsers();
            PopulateStatuses();
            return View();
        }

        [HttpPost]
        public JsonResult Read([DataSourceRequest]DataSourceRequest request)
        {

           // var projects = this.dbContext.Projects.Select(ProjectViewModel.FromProject);
            var projects = this.Data.Projects.AllWithDeleted().Select(ProjectViewModel.FromProject);

            return this.Json(projects.AsQueryable().ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        // [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult Update([DataSourceRequest] DataSourceRequest request, ProjectViewModel projectModel)
        {
            var existingProject = this.Data.Projects.AllWithDeleted().FirstOrDefault(pr => pr.Id == projectModel.Id);
            
            if (projectModel != null && ModelState.IsValid)
            {
                existingProject.Title = projectModel.Title;
                existingProject.Description = projectModel.Description;
                existingProject.IsDeleted = projectModel.IsDeleted;
                //existingProject.Client = this.Data.Clients.All().FirstOrDefault(client => client.Name == projectModel.Client);
                //existingProject.Status = this.Data.ProjectStatuses.All().FirstOrDefault(status => status.Text == projectModel.Status);
                       
                this.Data.SaveChanges();
            }

            //projectModel.ModifiedOn = existingProject.ModifiedOn;
            //projectModel.CreatedOn = (DateTime)existingProject.CreatedOn;

            return Json((new[] { projectModel }.ToDataSourceResult(request, ModelState)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Destroy([DataSourceRequest] DataSourceRequest request, ProjectViewModel projectModel)
        {
            var existingProject = this.Data.Projects.All().FirstOrDefault(x => x.Id == projectModel.Id);

            this.Data.Projects.Delete(projectModel.Id.Value);
            this.Data.SaveChanges();

            return Json(new[] { projectModel }, JsonRequestBehavior.AllowGet);
        }

        //[HttpPost]
        //public JsonResult Create([DataSourceRequest] DataSourceRequest request, ProjectViewModel projectModel)
        //{
        //    if (projectModel != null && ModelState.IsValid)
        //    {
        //        var client = this.Data.Clients.All().FirstOrDefault(x => x.Name == projectModel.Client);
        //        var status = this.Data.ProjectStatuses.All().FirstOrDefault(x => x.Text == projectModel.Status);

        //        var userId = this.User.Identity.GetUserId();
        //        var user = this.Data.Users.All().FirstOrDefault(x => x.Id == userId);

        //        var newProject = new Project
        //        {
        //            Title = projectModel.Title,
        //            Description = projectModel.Description,
        //            Client = client,
        //            Status = status,
        //            CreatedById = userId,
        //        };

        //        this.Data.Projects.Add(newProject);
        //        this.Data.SaveChanges();

        //        string author = user.FirstName + " " + user.LastName;
        //        projectModel.Id = newProject.Id;
        //        projectModel.CreatedBy = author;
        //    }

        //    return Json(new[] { projectModel }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        //}

        private void PopulateClients()
        {
            var clients = this.Data.Clients.All().OrderBy(e => e.Name).Project().To<ClientViewModel>();

            ViewData["clients"] = clients;
            ViewData["defaultClient"] = clients.First();
        }

        private void PopulateUsers()
        {
            var users = this.Data.Users.All().Project().To<UserViewModel>().OrderBy(e => e.UserName);

            ViewData["users"] = users;
        }

        private void PopulateStatuses()
        {
            var statuses = this.Data.ProjectStatuses.All().Project().To<StatusViewModel>().OrderBy(st => st.Text);

            ViewData["statuses"] = statuses;
        }
    }
}