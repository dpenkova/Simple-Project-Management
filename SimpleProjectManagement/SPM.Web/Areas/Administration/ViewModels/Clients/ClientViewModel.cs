namespace SPM.Web.Areas.Administration.ViewModels.Clients
{
    using SPM.Web.Infrastructure.Mapping;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class ClientViewModel : IMapFrom<SPM.Models.Client>
    {
        [HiddenInput(DisplayValue = false)]
        public int? Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Is Deleted")]
        public bool IsDeleted { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string CreatedById { get; set; }
    }
}