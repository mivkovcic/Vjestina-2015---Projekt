using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportEvents.Core;
using SportEvents.Models;

namespace SportEvents.Controllers
{
    public class HomeController : Controller
    {

        private SportEventsService _sportEventsService;

        public HomeController()
        {
            _sportEventsService = new SportEventsService();
        }

        public ActionResult Index()
        {
            using(var db = new SportEventDBEntities())
            {
                var model = new HomeIndexViewModel
                {                 
                    
                    Događaji = _sportEventsService.GetDogađajiN(6),
                    
                };


                return View(model);
            }            
        }

        public ActionResult Events()
        {
            using (var db = new SportEventDBEntities())
            {
                var model = new HomeEventsViewModel
                {

                    Događaji = _sportEventsService.GetDogađaji(),

                };


                return View(model);
            }
        }

        public ActionResult Sports(int pk_sport)
        {
            using (var db = new SportEventDBEntities())
            {
                var model = new HomeSportsViewModel
                {

                    Sportovi = _sportEventsService.GetSportovi(),
                    SportDogađaji = _sportEventsService.GetSportDogađaji(pk_sport),

                };


                return View(model);
            }
        }

        public ActionResult Locations(int pk_grad)
        {
            using (var db = new SportEventDBEntities())
            {
                var model = new HomeLocationsViewModel
                {

                    Gradovi = _sportEventsService.GetGradovi(),

                    MjestaGrad = _sportEventsService.GetMjestaGrad(pk_grad)

                };

                return View(model);
            }
        }

        public ActionResult Event(int pk_događaj)
        {
            using (var db = new SportEventDBEntities())
            {
                var model = new HomeEventViewModel
                {
                    Događaj = _sportEventsService.GetDogađaj(pk_događaj)
                };

                return View(model);
            }
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