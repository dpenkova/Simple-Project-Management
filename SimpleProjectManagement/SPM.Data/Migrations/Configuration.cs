namespace SPM.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using SPM.Data;
    using SPM.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public static Random Rand = new Random();

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;

            // TODO: Remove in production
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var seed = new SeedData();

            if (!context.ProjectStatuses.Any())
            {
                var projectStatuses = seed.ProjectStatuses;
                context.ProjectStatuses.AddOrUpdate(projectStatuses.ToArray());
                context.SaveChanges();
            }

            if (!context.TaskStatuses.Any())
            {
                var taskStatuses = seed.TaskStatuses;
                context.TaskStatuses.AddOrUpdate(taskStatuses.ToArray());
                context.SaveChanges();
            }

            if (!context.Clients.Any())
            {
                var clients = seed.Clients;
                context.Clients.AddOrUpdate(clients.ToArray());
                context.SaveChanges();
            }

            var clientsCount = context.Clients.Count();
            var projectStatusCount = context.ProjectStatuses.Count();
            
            var projects = new List<Project>();
            projects.Add(new Project 
            { 
                ClientId = Rand.Next(1, clientsCount + 1), 
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 
                StatusId = Rand.Next(1, projectStatusCount + 1), 
                Title = "Halloween event" 
            });
            projects.Add(new Project
            {
                ClientId = Rand.Next(1, clientsCount + 1),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                StatusId = Rand.Next(1, projectStatusCount + 1),
                Title = "Първа помощ БТЛ"
            });
            projects.Add(new Project
            {
                ClientId = Rand.Next(1, clientsCount + 1),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                StatusId = Rand.Next(1, projectStatusCount + 1),
                Title = "BTL конкурс"
            }); 
            projects.Add(new Project
            {
                ClientId = Rand.Next(1, clientsCount + 1),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                StatusId = Rand.Next(1, projectStatusCount + 1),
                Title = "Branding magazine"
            });
            projects.Add(new Project
            {
                ClientId = Rand.Next(1, clientsCount + 1),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                StatusId = Rand.Next(1, projectStatusCount + 1),
                Title = "Prizes logistics"
            });
            projects.Add(new Project
            {
                ClientId = Rand.Next(1, clientsCount + 1),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                StatusId = Rand.Next(1, projectStatusCount + 1),
                Title = "Пловдивски панаир"
            });
            projects.Add(new Project
            {
                ClientId = Rand.Next(1, clientsCount + 1),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                StatusId = Rand.Next(1, projectStatusCount + 1),
                Title = "Back to school additional activities"
            });
            projects.Add(new Project
            {
                ClientId = Rand.Next(1, clientsCount + 1),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                StatusId = Rand.Next(1, projectStatusCount + 1),
                Title = "Malls contracts"
            });
            projects.Add(new Project
            {
                ClientId = Rand.Next(1, clientsCount + 1),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                StatusId = Rand.Next(1, projectStatusCount + 1),
                Title = "Caravanas roadshow - конкурс"
            });
            projects.Add(new Project
            {
                ClientId = Rand.Next(1, clientsCount + 1),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                StatusId = Rand.Next(1, projectStatusCount + 1),
                Title = "Семплинг на нов продукт на два фестивала"
            });
            projects.Add(new Project
            {
                ClientId = Rand.Next(1, clientsCount + 1),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                StatusId = Rand.Next(1, projectStatusCount + 1),
                Title = "QSA Monthly Report"
            });
            projects.Add(new Project
            {
                ClientId = Rand.Next(1, clientsCount + 1),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                StatusId = Rand.Next(1, projectStatusCount + 1),
                Title = "Веселите зъбки"
            });
            projects.Add(new Project
            {
                ClientId = Rand.Next(1, clientsCount + 1),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                StatusId = Rand.Next(1, projectStatusCount + 1),
                Title = "Blue Event"
            });
            
            context.Projects.AddOrUpdate(projects.ToArray());
            context.SaveChanges();

            var taskStatusCount = context.TaskStatuses.Count();
            var projectsCount = context.Projects.Count();

            //var tasks = new List<ProjectTask>();
            //tasks.Add(new ProjectTask
            //{
            //    Name = "Task1",
            //    ProjectId = Rand.Next(1, projectsCount + 1),
            //    Priority = Priority.Medium,
            //    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
            //    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
            //    CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            //    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
            //    Responsible = new ApplicationUser() { UserName = "AnotherUser" },
            //});

            //context.ProjectTasks.AddOrUpdate(tasks.ToArray());
            //context.SaveChanges();

            //if (!context.Projects.Any())
            //{
            //    var projects = seed.Projects;
            //    context.Projects.AddOrUpdate(projects.ToArray());
            //    context.SaveChanges();
            //}

            //if (!context.ProjectTasks.Any())
            //{
            //    var projectTasks = seed.ProjectTasks;
            //    context.ProjectTasks.AddOrUpdate(projectTasks.ToArray());
            //    context.SaveChanges();
            //}

        }
    }
}
