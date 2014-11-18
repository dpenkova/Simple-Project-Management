namespace SPM.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;

    using SPM.Data;
    using SPM.Web.Areas.Administration.ViewModels.Projects;
    using SPM.Web.Areas.Administration.ViewModels.Statuses;
    using SPM.Web.Areas.Administration.ViewModels.Tasks;
    using SPM.Web.Areas.Administration.ViewModels.Users;

    public class TaskController : AdminController
    {
       public TaskController(IApplicationData data)
            : base(data)
        {
           
        }

        public ActionResult Index()
        {
            PopulateUsers();
            PopulateProjects();
            PopulateStatuses();
            return View();
        }


        [HttpPost]
        public JsonResult Read([DataSourceRequest]DataSourceRequest request)
        {
            var clients = this.Data.ProjectTasks.AllWithDeleted().Project().To<TaskViewModel>();

            return this.Json(clients.AsQueryable().ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Authorize]
        public JsonResult Update([DataSourceRequest] DataSourceRequest request, TaskViewModel model)
        {
            var dbdEntry = this.Data.ProjectTasks.GetById(model.Id);

            if (model != null && ModelState.IsValid)
            {
                dbdEntry.Name = model.Name;
                dbdEntry.IsDeleted = model.IsDeleted;

                this.Data.SaveChanges();
            }

            return Json((new[] { model }.ToDataSourceResult(request, ModelState)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Authorize]
        public JsonResult Destroy([DataSourceRequest] DataSourceRequest request, TaskViewModel model)
        {
            var dbdEntry = this.Data.ProjectTasks.GetById(model.Id.Value);

            this.Data.ProjectTasks.Delete(model.Id.Value);
            this.Data.SaveChanges();

            return Json(new[] { model }, JsonRequestBehavior.AllowGet);
        }

        private void PopulateUsers()
        {
            var users = this.Data.Users.All().Project().To<UserViewModel>().OrderBy(e => e.UserName);

            ViewData["users"] = users;
        }

        private void PopulateProjects()
        {
            var projects = this.Data.Projects.AllWithDeleted().Select(p => new ProjectViewModel {
                            Id = p.Id,
                            Title = p.Title
                        })
                        .OrderBy(p => p.Title);
          
            ViewData["projects"] = projects;
        }

        private void PopulateStatuses()
        {
            var taskStatuses = this.Data.TaskStatuses.All().Project().To<TaskStatusViewModel>().OrderBy(s => s.Text);

            ViewData["taskStatuses"] = taskStatuses;
        }
    }
}