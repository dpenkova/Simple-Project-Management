using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SPM.Models;

namespace SPM.Data.Migrations
{
    public class SeedData
    {
        public static Random Rand = new Random();

        public IList<ProjectStatus> ProjectStatuses;

        public IList<SPM.Models.TaskStatus> TaskStatuses;

        public IList<Client> Clients;

        public IList<Project> Projects;

        public IList<ProjectTask> ProjectTasks;



        public SeedData()
        {
            this.ProjectStatuses = new List<ProjectStatus>();
            ProjectStatuses.Add(new ProjectStatus() { Text = "In Planning" });
            ProjectStatuses.Add(new ProjectStatus() { Text = "In Progress" });
            ProjectStatuses.Add(new ProjectStatus() { Text = "Completed" });
            ProjectStatuses.Add(new ProjectStatus() { Text = "Cancelled" });

            this.TaskStatuses = new List<SPM.Models.TaskStatus>();
            TaskStatuses.Add(new SPM.Models.TaskStatus() { Text = "Waiting for approval" });
            TaskStatuses.Add(new SPM.Models.TaskStatus() { Text = "In Progress" });
            TaskStatuses.Add(new SPM.Models.TaskStatus() { Text = "Completed" });

            ApplicationUser user = new ApplicationUser() { UserName = "SomeUser", FirstName = "Pesho", LastName = "Peshov", Email = "pesho@abv.bg" };
            ApplicationUser anotherUser = new ApplicationUser() { UserName = "AnotherUser" };


            this.Clients = new List<Client>();
            this.Clients.Add(new Client()
            {
                Name = "Post Bank",
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
            });
            this.Clients.Add(new Client()
            {
                Name = "MicroSoft",
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
            });
            this.Clients.Add(new Client()
            {
                Name = "Beiersdorf",
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
            });
            this.Clients.Add(new Client()
            {
                Name = "L'Oreal",
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
            });
            this.Clients.Add(new Client()
            {
                Name = "Renault",
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
            });
            this.Clients.Add(new Client()
            {
                Name = "SOS Детски селища",
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
            });
            this.Clients.Add(new Client()
            {
                Name = "Subway",
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5))
            });

            this.Projects = new List<Project>();
            this.Projects.Add(new Project()
            {
                Title = "Halloween event",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",
                ClientId = Rand.Next(1, this.Clients.Count),
                StatusId = Rand.Next(1, this.ProjectStatuses.Count),
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
                IsDeleted = false
            });
            this.Projects.Add(new Project()
            {
                Title = "Първа помощ БТЛ",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",
                ClientId = Rand.Next(1, this.Clients.Count),
                StatusId = Rand.Next(1, this.ProjectStatuses.Count),
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
                IsDeleted = false

            });
            this.Projects.Add(new Project()
            {
                Title = "BTL конкурс",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",
                ClientId = Rand.Next(1, this.Clients.Count),
                StatusId = Rand.Next(1, this.ProjectStatuses.Count),
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
                IsDeleted = false

            });
            this.Projects.Add(new Project()
            {
                Title = "Branding magazine",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",
                ClientId = Rand.Next(1, this.Clients.Count),
                StatusId = Rand.Next(1, this.ProjectStatuses.Count),
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
                IsDeleted = false
            });
            this.Projects.Add(new Project()
            {
                Title = "Prizes logistics",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",
                ClientId = Rand.Next(1, this.Clients.Count),
                StatusId = Rand.Next(1, this.ProjectStatuses.Count),
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
                IsDeleted = false
            });
            this.Projects.Add(new Project()
            {
                Title = "Пловдивски панаир",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",
                ClientId = Rand.Next(1, this.Clients.Count),
                StatusId = Rand.Next(1, this.ProjectStatuses.Count),
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
                IsDeleted = false

            });
            this.Projects.Add(new Project()
            {
                Title = "Back to school additional activities",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",
                ClientId = Rand.Next(1, this.Clients.Count),
                StatusId = Rand.Next(1, this.ProjectStatuses.Count),
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
                IsDeleted = false

            });
            this.Projects.Add(new Project()
            {
                Title = "Malls contracts",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",
                ClientId = Rand.Next(1, this.Clients.Count),
                StatusId = Rand.Next(1, this.ProjectStatuses.Count),
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
                IsDeleted = false

            });
            this.Projects.Add(new Project()
            {
                Title = "Caravanas roadshow - конкурс",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",
                ClientId = Rand.Next(1, this.Clients.Count),
                StatusId = Rand.Next(1, this.ProjectStatuses.Count),
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
                IsDeleted = false

            });
            this.Projects.Add(new Project()
            {
                Title = "Семплинг на нов продукт на два фестивала",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",
                ClientId = Rand.Next(1, this.Clients.Count),
                StatusId = Rand.Next(1, this.ProjectStatuses.Count),
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
                IsDeleted = false

            });
            this.Projects.Add(new Project()
            {
                Title = "QSA Monthly Report",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",
                ClientId = Rand.Next(1, this.Clients.Count),
                StatusId = Rand.Next(1, this.ProjectStatuses.Count),
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
                IsDeleted = false

            });
            this.Projects.Add(new Project()
            {
                Title = "Веселите зъбки",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",
                ClientId = Rand.Next(1, this.Clients.Count),
                StatusId = Rand.Next(1, this.ProjectStatuses.Count),
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
                IsDeleted = false

            });
            this.Projects.Add(new Project()
            {
                Title = "Blue Event",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",
                ClientId = Rand.Next(1, this.Clients.Count),
                StatusId = Rand.Next(1, this.ProjectStatuses.Count),
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
                IsDeleted = false

            });

            this.ProjectTasks = new List<ProjectTask>();
            this.ProjectTasks.Add(new ProjectTask()
            {
                Name = "Дизайн на флаер стикер и брандинг на корнера.",
                ProjectId = Rand.Next(this.Projects.Count),
                Priority = Priority.Medium,
                TaskStatusId = Rand.Next(this.TaskStatuses.Count),
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next( -130, -5)),
                Responsible = anotherUser,
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
            });
            this.ProjectTasks.Add(new ProjectTask()
            {
                Name = "Производство на стикери",
                ProjectId = Rand.Next(this.Projects.Count),
                Priority = Priority.Medium,
                TaskStatusId = Rand.Next(this.TaskStatuses.Count),
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                Responsible = anotherUser,
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
            }); this.ProjectTasks.Add(new ProjectTask()
            {
                Name = "Каталози - корекции и файлове за печат",
                ProjectId = Rand.Next(this.Projects.Count),
                Priority = Priority.Medium,
                TaskStatusId = Rand.Next(this.TaskStatuses.Count),
                StartDate = DateTime.Now.AddDays(Rand.Next(-365, -135)),
                EndDate = DateTime.Now.AddDays(Rand.Next(-130, -5)),
                Responsible = anotherUser,
                CreatedBy = user,
                CreatedOn = DateTime.Now.AddDays(Rand.Next(-365, -5)),
            });
          
        }
    }
}
