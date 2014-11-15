namespace SPM.Web.Areas.Administration.ViewModels.Base
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public abstract class AdministrationViewModel
    {
        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Modified On")]
        public DateTime? ModifiedOn { get; set; }
    }
}