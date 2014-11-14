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

            if (!context.Projects.Any())
            {
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
            }

            var taskStatusCount = context.TaskStatuses.Count();
            var projectsCount = context.Projects.Count();
            
            var tasks = new List<ProjectTask>();
            tasks.Add(new ProjectTask
            {
                Name = "Дизайн на флаер стикер и брандинг на корнера.",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Производство на стикери",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Каталози - корекции и файлове за печат",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Финализиране на дизайни",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Медия план",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Генериране на идеи",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Уточняване на детайли с локацията",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Фактуриране на проекта",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Ревизия на бюджета",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Изготвяне на тайминг за основните елементи и производства",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Предложения за подаръци",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Запитвания за логистика",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Дизайн на банери",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Материали за събитието",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Коригиране на текстове и съгласуване с адвокати",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Транспорт до Велинград",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Производство на дипляни и листовки",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Среща с архитект по проекта",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Изчистване на механиката и среща с клиента",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Бюджети, попълване на конкурсна документация и таблици",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });
            tasks.Add(new ProjectTask
            {
                Name = "Фактуриране на приключили дейности по проекта",
                ProjectId = Rand.Next(1, projectsCount + 1),
                Priority = Priority.Medium,
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                CreatedBy = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
                TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                Responsible = context.Users.FirstOrDefault(u => u.UserName == "SomeUser"),
            });

            context.ProjectTasks.AddOrUpdate(tasks.ToArray());
            context.SaveChanges();

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
