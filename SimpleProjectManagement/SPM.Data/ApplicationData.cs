using SPM.Data.Contracts.Models;
using SPM.Data.Contracts.Repository;
using SPM.Data.Repositories;
using SPM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM.Data
{
    public class ApplicationData : IApplicationData
    {
        private readonly ApplicationDbContext context;

        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public ApplicationData(ApplicationDbContext context)
        {
            this.context = context;
        }

        public ApplicationDbContext Context
        {
            get
            {
                return this.context;
            }
        }

        public IRepository<SPM.Models.TaskStatus> TaskStatuses
        {
            get { return this.GetRepository<SPM.Models.TaskStatus>(); }
        }

        public IRepository<ProjectStatus> ProjectStatuses
        {
            get { return this.GetRepository<ProjectStatus>(); }
        }

        public IDeletableEntityRepository<Project> Projects
        {
            get { return this.GetDeletableEntityRepository<Project>(); }
        }

        public IDeletableEntityRepository<ApplicationUser> Users
        {
            get { return this.GetDeletableEntityRepository<ApplicationUser>(); }
        }

        public IDeletableEntityRepository<Client> Clients
        {
            get { return this.GetDeletableEntityRepository<Client>(); }
        }

        public IDeletableEntityRepository<ProjectTask> ProjectTasks
        {
            get { return this.GetDeletableEntityRepository<ProjectTask>(); }
        }

        /// <summary>
        /// Saves all changes made in this context to the underlying database.
        /// </summary>
        /// <returns>
        /// The number of objects written to the underlying database.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">Thrown if the context has been disposed.</exception>
        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);
                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }

        private IDeletableEntityRepository<T> GetDeletableEntityRepository<T>() where T : class, IDeletableEntity
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(DeletableEntityRepository<T>);
                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IDeletableEntityRepository<T>)this.repositories[typeof(T)];
        }
    }
    
}
