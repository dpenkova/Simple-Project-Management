namespace SPM.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    using SPM.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
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
