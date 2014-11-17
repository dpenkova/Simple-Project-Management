namespace SPM.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using SPM.Data.Contracts.Models;
    using System;

    public class Client : AuditInfo, IDeletableEntity
    {
        private ICollection<Project> projects;

        public Client()
        {
            this.projects = new HashSet<Project>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        //[Required]
        public string CreatedById { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }

        public virtual ICollection<Project> Projects 
        { 
            get { return this.projects; }
            set { this.projects = value; }
        }

        [Index]
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
