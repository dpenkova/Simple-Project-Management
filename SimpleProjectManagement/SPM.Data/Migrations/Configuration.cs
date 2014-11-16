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

        //protected override void Seed(ApplicationDbContext context)
        //{
        //    var seed = new SeedData();

        //    if (!context.ProjectStatuses.Any())
        //    {
        //        var projectStatuses = seed.ProjectStatuses;
        //        context.ProjectStatuses.AddOrUpdate(projectStatuses.ToArray());
        //        context.SaveChanges();
        //    }

        //    if (!context.TaskStatuses.Any())
        //    {
        //        var taskStatuses = seed.TaskStatuses;
        //        context.TaskStatuses.AddOrUpdate(taskStatuses.ToArray());
        //        context.SaveChanges();
        //    }

        //    if (!context.Clients.Any())
        //    {
        //        var clients = seed.Clients;
        //        context.Clients.AddOrUpdate(clients.ToArray());
        //        context.SaveChanges();
        //    }

        //    var clientsIds = context.Clients.Select(c => c.Id).ToList();
        //    var clientsCount = clientsIds.Count();

        //    var projectStatusesIds = context.ProjectStatuses.Select(st => st.Id).ToList();
        //    var projectStatusCount = projectStatusesIds.Count();

        //    var userIds = context.Users.Select(u => u.Id).ToList();
        //    var usersCount = userIds.Count();

        //    //if (!context.Projects.Any())
        //    //{
        //        var projects = new List<Project>();
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "Halloween event"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "Първа помощ БТЛ"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "BTL конкурс"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "Branding magazine"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "Prizes logistics"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "Пловдивски панаир"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "Back to school additional activities"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "Malls contracts"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "Caravanas roadshow - конкурс"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "Семплинг на нов продукт на два фестивала"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "QSA Monthly Report"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "Веселите зъбки"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "Blue Event"
        //        });

        //        context.Projects.AddOrUpdate(projects.ToArray());
        //        context.SaveChanges();
        //    //}

        //    var taskStatusCount = context.TaskStatuses.Count();

        //    var projectIds = context.Projects.Where(pr=> pr.StatusId == 2 ).Select(pr => pr.Id).ToList();
        //    var projectsCount = projectIds.Count();

        //    var tasks = new List<ProjectTask>();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Дизайн на флаер стикер и брандинг на корнера.",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Производство на стикери",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Каталози - корекции и файлове за печат",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Финализиране на дизайни",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Медия план",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Генериране на идеи",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Уточняване на детайли с локацията",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Фактуриране на проекта",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Ревизия на бюджета",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Изготвяне на тайминг за основните елементи и производства",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Предложения за подаръци",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Запитвания за логистика",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Дизайн на банери",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Материали за събитието",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Коригиране на текстове и съгласуване с адвокати",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Транспорт до Велинград",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Производство на дипляни и листовки",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Среща с архитект по проекта",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Изчистване на механиката и среща с клиента",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Бюджети, попълване на конкурсна документация и таблици",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //        tasks.Add(new ProjectTask
        //        {
        //            Name = "Фактуриране на приключили дейности по проекта",
        //            ProjectId = projectIds[Rand.Next(projectsCount)],
        //            Priority = Priority.Medium,
        //            StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
        //            EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            TaskStatusId = Rand.Next(1, taskStatusCount + 1),
        //            ResponsibleId = userIds[Rand.Next(usersCount)],
        //        });
        //    }

        //    context.ProjectTasks.AddOrUpdate(tasks.ToArray());
        //    context.SaveChanges();

        //    //if (!context.Projects.Any())
        //    //{
        //    //    var projects = seed.Projects;
        //    //    context.Projects.AddOrUpdate(projects.ToArray());
        //    //    context.SaveChanges();
        //    //}

        //    //if (!context.ProjectTasks.Any())
        //    //{
        //    //    var projectTasks = seed.ProjectTasks;
        //    //    context.ProjectTasks.AddOrUpdate(projectTasks.ToArray());
        //    //    context.SaveChanges();
        //    //}

        //}
    }
}
