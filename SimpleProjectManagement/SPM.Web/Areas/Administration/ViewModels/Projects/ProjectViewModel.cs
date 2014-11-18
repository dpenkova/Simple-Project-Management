namespace SPM.Web.Areas.Administration.ViewModels.Projects
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    using SPM.Models;
    using SPM.Web.Areas.Administration.ViewModels.Base;
    using SPM.Web.Infrastructure.Mapping;
    using System;
    using System.Linq.Expressions;

    public class ProjectViewModel : AdministrationViewModel, IMapFrom<Project>
    {
        public static Expression<Func<Project, ProjectViewModel>> FromProject
        {
            get
            {
                return pr => new ProjectViewModel
                {
                    Id = pr.Id,
                    Title = pr.Title,
                    CreatedBy = pr.CreatedBy.FirstName + " " + pr.CreatedBy.LastName,
                    Client = pr.Client.Name,
                    Status = pr.Status.Text,
                    Description = pr.Description,
                    CreatedOn = pr.CreatedOn,
                    ModifiedOn = pr.ModifiedOn,
                    IsDeleted = pr.IsDeleted,
                    ClientId = pr.ClientId,
                    UserId = pr.CreatedById,
                    StatusId = pr.StatusId,
                };
            }
        }

        [HiddenInput(DisplayValue = false)]
        public int? Id { get; set; }

        [Required]
        public string Title { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Required]
        public string Client { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Required]
        public string Status { get; set; }

        public string Description { get; set; }
        
        [HiddenInput(DisplayValue = false)]
        public string CreatedBy { get; set; }

        [Display(Name = "Is Deleted")]
        public bool IsDeleted { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int ClientId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string UserId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int StatusId { get; set; }
    }
}