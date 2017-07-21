using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAPP.Models;

namespace TestAPP.Controllers
{
    public class HomeController : Controller
    {
        private IPatientSchedulesRepository repository = null;
        public HomeController()
        {
            this.repository = new PatientSchedulesRepository();
        }
        public HomeController(IPatientSchedulesRepository repository)
        {
            this.repository = repository;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Schedule(PatientSchedule obj)
        {
            obj.CreatedDate = DateTime.Now;
            repository.Insert(obj);
            repository.Save();

            return Redirect("https://www.gohealthuc.com/about/");
        }
    }
}