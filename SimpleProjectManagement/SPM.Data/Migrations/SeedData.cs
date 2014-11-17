namespace SPM.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SPM.Models;

    public class SeedData
    {
        public static Random Rand = new Random();

        public IList<ProjectStatus> ProjectStatuses;

        public IList<SPM.Models.TaskStatus> TaskStatuses;

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
        }
    }
}
