namespace SPM.Web.Areas.Administration.ViewModels.Projects
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    using SPM.Models;
    using SPM.Web.Areas.Administration.ViewModels.Base;
    using SPM.Web.Infrastructure.Mapping;

    public class ProjectViewModel : AdministrationViewModel, IMapFrom<Project>
    {
        [HiddenInput(DisplayValue = false)]
        public int? Id { get; set; }

        [Required]
        [Display(Name = "Project")]
        [StringLength(150, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        public string Title { get; set; }

        [Display(Name = "Description")]
        [StringLength(255, ErrorMessage = "The {0} must be at least {2} characters long.")]
        public string Description { get; set; }

        //[Display(Name = "Client")]
        //public virtual Client Client { get; set; }

        [Display(Name = "Status")]
        public virtual ProjectStatus Status { get; set; }

        //[Display(Name = "Manager")]
        //public virtual ApplicationUser CreatedBy { get; set; }

        public virtual ICollection<ProjectTask> Tasks { get; set; }

        //[Required]
        public int ClientId { get; set; }

        //[Required]
        //public int StatusId { get; set; }

        //[Required]
        //public string CreatedById { get; set; }

        //public bool IsDeleted { get; set; }

        //public DateTime? DeletedOn { get; set; }
    }
}