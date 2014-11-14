namespace SPM.Web.Controllers
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;

    using System.Data.Entity.Migrations;

    using AutoMapper.QueryableExtensions;
    
    using Microsoft.AspNet.Identity;
    
    using SPM.Data;
    using SPM.Data.Contracts.Repository;
    using SPM.Models;
    using SPM.Web.ViewModels.Home;
    using System;

    public class HomeController : Controller
    {
        private readonly IRepository<Client> clients;
        private readonly IRepository<ProjectTask> tasks;

        private readonly IDeletableEntityRepository<Project> projects;
        private ApplicationDbContext dbContext;

        public HomeController(IRepository<ProjectTask> tasks, IRepository<Client> clients, IDeletableEntityRepository<Project> projects, ApplicationDbContext context)
        {
            this.clients = clients;
            this.tasks = tasks;
            this.projects = projects;
            this.dbContext = context;
        }

        public ActionResult Index()
        {
            //this.projects.Delete(12);
            //this.projects.SaveChanges();

            //var newProject = new Project();
            //newProject.ClientId = 5;
            //newProject.CreatedById = this.User.Identity.GetUserId();
            //newProject.Description = "daslkjfjan safnlanfl";
            //newProject.StatusId = 2;
            //newProject.Title = "Project 1";

            //var projects = new List<Project>();

            //projects.Add(new Project { ClientId = 1, CreatedById = this.User.Identity.GetUserId(), Description = "TEst project 1 safnlanfl", StatusId = 1, Title = "Test Project 1" });
            //projects.Add(new Project { ClientId = 2, CreatedById = this.User.Identity.GetUserId(), Description = "TEst project 2 safnlanfl", StatusId = 2, Title = "Test Project 2" });


            //this.dbContext.Projects.AddOrUpdate(projects.ToArray());
            //this.dbContext.SaveChanges();

            var task = new ProjectTask();
            task.CreatedById = this.User.Identity.GetUserId();
            task.EndDate = DateTime.Now;
            task.Name = "Task 1";
            task.Priority = Priority.Medium;
            task.ProjectId = 12;
            task.ResponsibleId = this.User.Identity.GetUserId();
            task.StartDate = DateTime.Now;
            task.TaskStatusId = 1;

            this.tasks.Add(task);
            this.tasks.SaveChanges();

            var clients = this.clients.All().OrderBy(c => c.Id).Project().To<IndexClientViewModel>();
            return this.View(clients);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}