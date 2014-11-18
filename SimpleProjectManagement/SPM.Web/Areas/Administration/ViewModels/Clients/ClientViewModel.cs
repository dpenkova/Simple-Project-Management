namespace SPM.Web.Areas.Administration.ViewModels.Clients
{
    using SPM.Web.Infrastructure.Mapping;

    public class ClientViewModel : IMapFrom<SPM.Models.Client>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}