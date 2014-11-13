using SPM.Models;
using SPM.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPM.Web.ViewModels.Home
{
    public class IndexClientViewModel: IMapFrom<Client>
    {
        public string Name { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}