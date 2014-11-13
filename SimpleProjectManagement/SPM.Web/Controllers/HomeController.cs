using SPM.Data;
using SPM.Data.Contracts.Repository;
using SPM.Data.Repositories;
using SPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using SPM.Web.ViewModels.Home;

namespace SPM.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Client> clients;

        public HomeController(IRepository<Client> clients)
        {
            this.clients = clients;
        }

        public ActionResult Index()
        {
            var clients = this.clients.All().Project().To<IndexClientViewModel>();
            return View(clients);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}