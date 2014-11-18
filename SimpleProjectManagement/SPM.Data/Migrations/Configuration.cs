namespace SPM.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    using SPM.Data;
    using SPM.Models;
    using System.Collections.Generic;
    using SPM.Common;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public static Random Rand = new Random();

        private UserManager<ApplicationUser> userManager;

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;

            // TODO: Remove in production
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            this.userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            this.SeedRoles(context);
            this.SeedUsers(context);

            var seed = new SeedData();

            this.SeedProjectStatuses(context, seed);
            this.SeedTaskStatuses(context, seed);
            this.SeedClients(context);
            this.SeedProjects(context);
            this.SeedTasks(context);
        }

        private void SeedTasks(ApplicationDbContext context)
        {
            if (context.ProjectTasks.Any())
            {
                return;
            }

            var taskStatusCount = context.TaskStatuses.Count();

            var projectIds = context.Projects.Where(pr => pr.StatusId == 2).Select(pr => pr.Id).ToList();
            var projectsCount = projectIds.Count();

            var userIds = context.Users.Select(u => u.Id).ToList();
            var usersCount = userIds.Count();

            var tasks = new List<ProjectTask>();
            for (int i = 0; i < 5; i++)
            {
                tasks.Add(new ProjectTask
                {
                    Name = "Дизайн на флаер стикер и брандинг на корнера.",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Производство на стикери",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Каталози - корекции и файлове за печат",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Финализиране на дизайни",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Медия план",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Генериране на идеи",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Уточняване на детайли с локацията",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Фактуриране на проекта",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Ревизия на бюджета",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Изготвяне на тайминг за основните елементи и производства",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Предложения за подаръци",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Запитвания за логистика",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Дизайн на банери",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Материали за събитието",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Коригиране на текстове и съгласуване с адвокати",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Транспорт до Велинград",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Производство на дипляни и листовки",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Среща с архитект по проекта",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Изчистване на механиката и среща с клиента",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Бюджети, попълване на конкурсна документация и таблици",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
                tasks.Add(new ProjectTask
                {
                    Name = "Фактуриране на приключили дейности по проекта",
                    ProjectId = projectIds[Rand.Next(projectsCount)],
                    Priority = Priority.Medium,
                    StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                    EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                    CreatedById = userIds[Rand.Next(usersCount)],
                    TaskStatusId = Rand.Next(1, taskStatusCount + 1),
                    ResponsibleId = userIds[Rand.Next(usersCount)],
                });
            }

            context.ProjectTasks.AddOrUpdate(tasks.ToArray());
            context.SaveChanges();
        }

        private void SeedProjects(ApplicationDbContext context)
        {
            var clientsIds = context.Clients.Select(c => c.Id).ToList();
            var clientsCount = clientsIds.Count();

            var projectStatusesIds = context.ProjectStatuses.Select(st => st.Id).ToList();
            var projectStatusCount = projectStatusesIds.Count();

            var userIds = context.Users.Select(u => u.Id).ToList();
            var usersCount = userIds.Count();

            if (!context.Projects.Any())
            {
                var projects = new List<Project>();
                projects.Add(new Project
                {
                    ClientId = clientsIds[Rand.Next(clientsCount)],
                    CreatedById = userIds[Rand.Next(usersCount)],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
                    Title = "Halloween event"
                });
                projects.Add(new Project
                {
                    ClientId = clientsIds[Rand.Next(clientsCount)],
                    CreatedById = userIds[Rand.Next(usersCount)],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
                    Title = "Първа помощ БТЛ"
                });
                projects.Add(new Project
                {
                    ClientId = clientsIds[Rand.Next(clientsCount)],
                    CreatedById = userIds[Rand.Next(usersCount)],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
                    Title = "BTL конкурс"
                });
                projects.Add(new Project
                {
                    ClientId = clientsIds[Rand.Next(clientsCount)],
                    CreatedById = userIds[Rand.Next(usersCount)],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
                    Title = "Branding magazine"
                });
                projects.Add(new Project
                {
                    ClientId = clientsIds[Rand.Next(clientsCount)],
                    CreatedById = userIds[Rand.Next(usersCount)],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
                    Title = "Prizes logistics"
                });
                projects.Add(new Project
                {
                    ClientId = clientsIds[Rand.Next(clientsCount)],
                    CreatedById = userIds[Rand.Next(usersCount)],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
                    Title = "Пловдивски панаир"
                });
                projects.Add(new Project
                {
                    ClientId = clientsIds[Rand.Next(clientsCount)],
                    CreatedById = userIds[Rand.Next(usersCount)],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
                    Title = "Back to school additional activities"
                });
                projects.Add(new Project
                {
                    ClientId = clientsIds[Rand.Next(clientsCount)],
                    CreatedById = userIds[Rand.Next(usersCount)],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
                    Title = "Malls contracts"
                });
                projects.Add(new Project
                {
                    ClientId = clientsIds[Rand.Next(clientsCount)],
                    CreatedById = userIds[Rand.Next(usersCount)],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
                    Title = "Caravanas roadshow - конкурс"
                });
                projects.Add(new Project
                {
                    ClientId = clientsIds[Rand.Next(clientsCount)],
                    CreatedById = userIds[Rand.Next(usersCount)],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
                    Title = "Семплинг на нов продукт на два фестивала"
                });
                projects.Add(new Project
                {
                    ClientId = clientsIds[Rand.Next(clientsCount)],
                    CreatedById = userIds[Rand.Next(usersCount)],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
                    Title = "QSA Monthly Report"
                });
                projects.Add(new Project
                {
                    ClientId = clientsIds[Rand.Next(clientsCount)],
                    CreatedById = userIds[Rand.Next(usersCount)],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
                    Title = "Веселите зъбки"
                });
                projects.Add(new Project
                {
                    ClientId = clientsIds[Rand.Next(clientsCount)],
                    CreatedById = userIds[Rand.Next(usersCount)],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
                    Title = "Blue Event"
                });

                context.Projects.AddOrUpdate(projects.ToArray());
                context.SaveChanges();
            }
        }

        private void SeedClients(ApplicationDbContext context)
        {
            if (!context.Clients.Any())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == "testuser");
                var clients = new List<Client>();
                clients.Add(new Client()
                {
                    Name = "Post Bank",
                    CreatedBy = user,
                    CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
                });
                clients.Add(new Client()
                {
                    Name = "MicroSoft",
                    CreatedBy = user,
                    CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
                });
                clients.Add(new Client()
                {
                    Name = "Beiersdorf",
                    CreatedBy = user,
                    CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
                });
                clients.Add(new Client()
                {
                    Name = "L'Oreal",
                    CreatedBy = user,
                    CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
                });
                clients.Add(new Client()
                {
                    Name = "Renault",
                    CreatedBy = user,
                    CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
                });
                clients.Add(new Client()
                {
                    Name = "SOS Детски селища",
                    CreatedBy = user,
                    CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
                });
                clients.Add(new Client()
                {
                    Name = "Subway",
                    CreatedBy = user,
                    CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
                });
                context.Clients.AddOrUpdate(clients.ToArray());
                context.SaveChanges();
            }
        }

        private void SeedTaskStatuses(ApplicationDbContext context, SeedData seed)
        {
            if (!context.TaskStatuses.Any())
            {
                var taskStatuses = seed.TaskStatuses;
                context.TaskStatuses.AddOrUpdate(taskStatuses.ToArray());
                context.SaveChanges();
            }
        }

        private void SeedProjectStatuses(ApplicationDbContext context, SeedData seed)
        {
            if (!context.ProjectStatuses.Any())
            {
                var projectStatuses = seed.ProjectStatuses;
                context.ProjectStatuses.AddOrUpdate(projectStatuses.ToArray());
                context.SaveChanges();
            }
        }

        private void SeedRoles(ApplicationDbContext context)
        {
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole(GlobalConstants.AdminRole));
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole(GlobalConstants.ManagerRole));

            context.SaveChanges();
        }

        private void SeedUsers(ApplicationDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            var testUser = new ApplicationUser
            {
                Email = "test@abv.com",
                UserName = "testuser",
                FirstName = "Пешо",
                LastName = "Гошев"
            };

            this.userManager.Create(testUser, "123456");

            var adminUser = new ApplicationUser
            {
                Email = "admin@abv.com",
                UserName = "admin",
                FirstName = "Мишо",
                LastName = "Георгиев"
            };

            this.userManager.Create(adminUser, "123456");

            this.userManager.AddToRole(adminUser.Id, GlobalConstants.AdminRole);
        }
    }
}
