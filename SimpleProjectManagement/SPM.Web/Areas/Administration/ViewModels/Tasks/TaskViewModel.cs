namespace SPM.Web.Areas.Administration.ViewModels.Tasks
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    using SPM.Models;
    using SPM.Web.Areas.Administration.ViewModels.Base;
    using SPM.Web.Infrastructure.Mapping;

    public class TaskViewModel : AdministrationViewModel, IMapFrom<ProjectTask>
    {
        [HiddenInput(DisplayValue = false)]
        public int? Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(150)]
        [Display(Name = "Task")]
        public string Name { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int ProjectId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public Priority Priority { get; set; }

        [HiddenInput(DisplayValue = false)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Start")]
        public DateTime StartDate { get; set; }

        [HiddenInput(DisplayValue = false)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Deadline")]
        public DateTime EndDate { get; set; }

        [HiddenInput(DisplayValue = false)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Completed On")]
        public DateTime? EndedOn { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string CreatedById { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Required]
        public int TaskStatusId { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Required]
        public string ResponsibleId { get; set; }

        [Display(Name = "Is Deleted")]
        public bool IsDeleted { get; set; }
    }
}