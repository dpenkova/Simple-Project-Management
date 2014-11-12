﻿namespace SPM.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ProjectTask
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }

        [Required]
        public Priority Priority { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public DateTime EndedOn { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string CreatedById { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }

        [Required]
        public int TaskStatusId { get; set; }

        public virtual TaskStatus Status { get; set; }

        [Required]
        public string ResponsibleId { get; set; }

        public virtual ApplicationUser Responsible { get; set; }
    }
}
