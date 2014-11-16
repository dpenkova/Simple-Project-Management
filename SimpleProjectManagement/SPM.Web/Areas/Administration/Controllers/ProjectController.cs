namespace SPM.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;

    using Microsoft.AspNet.Identity;

    using SPM.Data;
    using SPM.Data.Contracts.Repository;
    using SPM.Models;
    using SPM.Web.Areas.Administration.ViewModels.Projects;
    using System.Threading;
    using System.Globalization;
    using System;

    public class ProjectController : AdminController
    {
        private ApplicationDbContext dbContext;
        private IDeletableEntityRepository<Project> projects;
        //private IRepository<Client> clients;


        public ProjectController(ApplicationDbContext context, IDeletableEntityRepository<Project> projects, 
            IRepository<Client> clients)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            this.dbContext = context;
            this.projects = projects;
            //this.clients = clients;

        }

        // GET: Administration/Project
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Read([DataSourceRequest]DataSourceRequest request)
        {

           // var projects = this.dbContext.Projects.Select(ProjectViewModel.FromProject);
            var projects = this.projects.All().Select(ProjectViewModel.FromProject);


            return this.Json(projects.AsQueryable().ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Update([DataSourceRequest] DataSourceRequest request, ProjectViewModel projectModel)
        {
            var existingProject = this.dbContext.Projects.FirstOrDefault(pr => pr.Id == projectModel.Id);
            
            if (projectModel != null && ModelState.IsValid)
            {
                existingProject.Title = projectModel.Title;
                existingProject.Description = projectModel.Description;
                existingProject.Client = this.dbContext.Clients.FirstOrDefault(client => client.Name == projectModel.Client);
                existingProject.Status = this.dbContext.ProjectStatuses.FirstOrDefault(status => status.Text == projectModel.Status);
                       
                this.dbContext.SaveChanges();
            }

            //projectModel.ModifiedOn = existingProject.ModifiedOn;
            //projectModel.CreatedOn = (DateTime)existingProject.CreatedOn;

            return Json((new[] { projectModel }.ToDataSourceResult(request, ModelState)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Destroy([DataSourceRequest] DataSourceRequest request, ProjectViewModel projectModel)
        {
            var existingProject = this.dbContext.Projects.FirstOrDefault(x => x.Id == projectModel.Id);

            this.projects.Delete(projectModel.Id.Value);
            this.projects.SaveChanges();

            return Json(new[] { projectModel }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Create([DataSourceRequest] DataSourceRequest request, ProjectViewModel projectModel)
        {
            if (projectModel != null && ModelState.IsValid)
            {
                var client = this.dbContext.Clients.FirstOrDefault(x => x.Name == projectModel.Client);
                var status = this.dbContext.ProjectStatuses.FirstOrDefault(x => x.Text == projectModel.Status);

                var userId = this.User.Identity.GetUserId();
                var user = this.dbContext.Users.FirstOrDefault(x => x.Id == userId);

                var newProject = new Project
                {
                    Title = projectModel.Title,
                    Description = projectModel.Description,
                    Client = client,
                    Status = status,
                    CreatedById = userId,
                };

                this.dbContext.Projects.Add(newProject);
                this.dbContext.SaveChanges();

                string author = user.FirstName + " " + user.LastName;
                projectModel.Id = newProject.Id;
                projectModel.CreatedBy = author;
            }

            return Json(new[] { projectModel }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }
    }
}