using SPM.Data.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPM.Models;

namespace SPM.Data
{
    public interface IApplicationData
    {
        ApplicationDbContext Context { get; }

        IRepository<SPM.Models.TaskStatus> TaskStatuses { get; }

        IRepository<ProjectStatus> ProjectStatuses { get; }

        IDeletableEntityRepository<Project> Projects { get; }

        IDeletableEntityRepository<ApplicationUser> Users { get; }
   
        IDeletableEntityRepository<Client> Clients { get; }
    
        IDeletableEntityRepository<ProjectTask> ProjectTasks { get; }

        int SaveChanges();
    }
}
