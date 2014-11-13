namespace SPM.Web.ViewModels.Home
{
    using System.Collections.Generic;

    using SPM.Models;
    using SPM.Web.Infrastructure.Mapping;

    public class IndexClientViewModel : IMapFrom<Client>
    {
        public string Name { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}