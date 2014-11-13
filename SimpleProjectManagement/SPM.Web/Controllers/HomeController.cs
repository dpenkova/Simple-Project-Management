namespace SPM.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using SPM.Data.Contracts.Repository;
    using SPM.Models;
    using SPM.Web.ViewModels.Home;

    public class HomeController : Controller
    {
        private readonly IRepository<Client> clients;
        private readonly IDeletableEntityRepository<Project> projects;


        public HomeController(IRepository<Client> clients, IDeletableEntityRepository<Project> projects)
        {
            this.clients = clients;
            this.projects = projects;

        }

        public ActionResult Index()
        {
            this.projects.Delete(12);
            this.projects.SaveChanges();

            var clients = this.clients.All().OrderBy(c => c.Id).Project().To<IndexClientViewModel>();
            return this.View(clients);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}