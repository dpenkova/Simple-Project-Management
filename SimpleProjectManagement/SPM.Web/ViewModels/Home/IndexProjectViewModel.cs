using SPM.Models;
using SPM.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPM.Web.ViewModels.Home
{
    public class IndexProjectViewModel : IMapFrom<Project>
    {
        
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(150)]
        public string Title { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
   
        public virtual ProjectStatus Status { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }

        public ICollection<ProjectTask> Tasks { get; set; }

        public double ProgressPercentage
        {
            get
            {
                var allTasksCount = this.Tasks.Count;
                var completedTasksCount = this.Tasks.Where(t => t.Status.Text == "Completed").Count();

                if (allTasksCount == 0)
                {
                    return 0;
                }

                return Math.Round((double)completedTasksCount / allTasksCount * 100, 2);
            }
        }
    }
}