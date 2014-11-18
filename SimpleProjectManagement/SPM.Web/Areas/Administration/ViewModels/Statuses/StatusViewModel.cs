namespace SPM.Web.Areas.Administration.ViewModels.Statuses
{
    using SPM.Models;
    using SPM.Web.Infrastructure.Mapping;

    public class StatusViewModel : IMapFrom<ProjectStatus>
    {
        public int Id { get; set; }
     
        public string Text { get; set; }
    }
}