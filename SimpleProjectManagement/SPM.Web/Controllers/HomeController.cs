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
        private IRepository<Client> clients;

        public HomeController(IRepository<Client> clients)
        {
            this.clients = clients;
        }

        public ActionResult Index()
        {
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