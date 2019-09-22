using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ajex_Crud_Operations_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ajex_Crud_Operations_.Controllers
{
    public class AirlineController : Controller
    {
        private AirlineORMCRUDOperationsContext orm = null;
        public AirlineController(AirlineORMCRUDOperationsContext orm1)
        {
            orm = orm1;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Airline1 airline)
        {
            try
            {
                orm.Airline1.Add(airline);
                orm.SaveChanges();
                ViewBag.hint = "Success";
                ViewBag.message = airline.Name + " Data Saved Sucessfully";
                return View();
            }
            catch (Exception)
            {
                ViewBag.hint = "Failed";
                ViewBag.message = airline.Name + " Data Not Saved Error!!!";
                return View();
            }

        }
        [HttpGet]
        public IActionResult Detail(string value="")
        {
            if(value == "")
                {
                return View(orm.Airline1.ToList());
            }
            return View(orm.Airline1.Where(temp => temp.Name.StartsWith(value) || temp.Status.Contains(value)).ToList());
            
        }

        public string Delete(int id)
        {

            orm.Airline1.Remove(orm.Airline1.Find(id));
            orm.SaveChanges();
            return "1";
        }
        public IActionResult Details(int id)
        {
            return View(orm.Airline1.Find(id));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var E_id = orm.Airline1.Find(id);
            return View(E_id);
        }

        [HttpPost]
        public IActionResult Edit(Airline1 airline)
        {
            orm.Airline1.Update(airline);
            orm.SaveChanges();
            return RedirectToAction("Detail");
        }

        public string uploadImage()
        {
            return "<img src='http://lorempixel.com/300/300/sports' />";
        }
        public string uploadVideo()
        {
            return "<iframe width='500' height='315' src='https://www.youtube.com/embed/yAIALB5VT2c' frameborder='0'" +
                " allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>";
        }
    }
}