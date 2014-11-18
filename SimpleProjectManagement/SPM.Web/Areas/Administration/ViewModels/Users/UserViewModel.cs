namespace SPM.Web.Areas.Administration.ViewModels.Users
{
    using SPM.Models;
    using SPM.Web.Infrastructure.Mapping;

    public class UserViewModel : IMapFrom<ApplicationUser>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<ApplicationUser, UserViewModel>()
               .ForMember(m => m.UserName, opt => opt.MapFrom(t => t.FirstName + " " + t.LastName))
               .ReverseMap();
        }
    }
}