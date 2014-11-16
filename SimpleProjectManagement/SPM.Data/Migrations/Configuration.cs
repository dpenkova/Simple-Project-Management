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
        //            Title = "����� ����� ���"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "BTL �������"
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
        //            Title = "���������� ������"
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
        //            Title = "Caravanas roadshow - �������"
        //        });
        //        projects.Add(new Project
        //        {
        //            ClientId = clientsIds[Rand.Next(clientsCount)],
        //            CreatedById = userIds[Rand.Next(usersCount)],
        //            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
        //            StatusId = projectStatusesIds[Rand.Next(projectStatusCount)],
        //            Title = "�������� �� ��� ������� �� ��� ���������"
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
        //            Title = "�������� �����"
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
        //            Name = "������ �� ����� ������ � �������� �� �������.",
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
        //            Name = "������������ �� �������",
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
        //            Name = "�������� - �������� � ������� �� �����",
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
        //            Name = "������������ �� �������",
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
        //            Name = "����� ����",
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
        //            Name = "���������� �� ����",
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
        //            Name = "���������� �� ������� � ���������",
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
        //            Name = "����������� �� �������",
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
        //            Name = "������� �� �������",
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
        //            Name = "��������� �� ������� �� ��������� �������� � ������������",
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
        //            Name = "����������� �� ��������",
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
        //            Name = "���������� �� ���������",
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
        //            Name = "������ �� ������",
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
        //            Name = "��������� �� ���������",
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
        //            Name = "���������� �� �������� � ����������� � ��������",
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
        //            Name = "��������� �� ���������",
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
        //            Name = "������������ �� ������� � ��������",
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
        //            Name = "����� � �������� �� �������",
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
        //            Name = "���������� �� ���������� � ����� � �������",
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
        //            Name = "�������, ��������� �� ��������� ������������ � �������",
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
        //            Name = "����������� �� ���������� �������� �� �������",
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
