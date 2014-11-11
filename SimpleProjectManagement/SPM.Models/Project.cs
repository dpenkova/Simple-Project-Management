using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SPM.Models
{
    public class Project
    {
        private ICollection<ProjectTask> tasks { get; set; }

        public Project()
        {
            this.tasks = new HashSet<ProjectTask>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(150)]
        public string Title { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }

        [Required]
        public int StatusId { get; set; }

        public virtual ProjectStatus Status { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        public string CreatedById { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }

        public virtual ICollection<ProjectTask> Tasks
        {
            get { return this.tasks; }
            set { this.tasks = value; }
        }

    }
}
