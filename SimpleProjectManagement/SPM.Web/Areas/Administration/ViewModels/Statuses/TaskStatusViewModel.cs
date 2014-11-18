namespace SPM.Web.Areas.Administration.ViewModels.Statuses
{
    using SPM.Models;
    using SPM.Web.Infrastructure.Mapping;

    public class TaskStatusViewModel : IMapFrom<TaskStatus>
    {
        public int Id { get; set; }

        public string Text { get; set; }
    }
}