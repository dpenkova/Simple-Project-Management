namespace SPM.Web.Areas.Administration.ViewModels.Base
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public abstract class AdministrationViewModel
    {
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Modified On")]
        public DateTime? ModifiedOn { get; set; }
    }
}