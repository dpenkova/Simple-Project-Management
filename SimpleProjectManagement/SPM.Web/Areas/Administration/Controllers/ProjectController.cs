using Kendo.Mvc.UI;
using SPM.Data;
using SPM.Data.Contracts.Repository;
using SPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using SPM.Web.Areas.Administration.ViewModels.Projects;


namespace SPM.Web.Areas.Administration.Controllers
{
    public class ProjectController : AdminController
    {
        private ApplicationDbContext dbContext;
        private IDeletableEntityRepository<Project> projects;


        public ProjectController(ApplicationDbContext context, IDeletableEntityRepository<Project> projects)
        {
            this.dbContext = context;
            this.projects = projects;

        }

        // GET: Administration/Project
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Read([DataSourceRequest]DataSourceRequest request)
        {
            var projects = this.projects.All()
                .Project().To<ProjectViewModel>()
                .ToDataSourceResult(request);
             
            return this.Json(projects);

        }
    }
}