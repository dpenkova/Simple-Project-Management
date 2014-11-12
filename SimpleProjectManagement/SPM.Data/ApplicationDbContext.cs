namespace SPM.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using SPM.Models;
    using System.Data.Entity;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Project> Projects { get; set; }

    }
}
