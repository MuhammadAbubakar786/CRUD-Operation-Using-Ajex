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
                return RedirectToAction("Create");
            }
            catch (Exception)
            {
                ViewBag.hint = "Failed";
                ViewBag.message = airline.Name + " Data Not Saved Error!!!";
                return View();
            }

        } 

        public IActionResult Detail()
        {
            return View(orm.Airline1.ToList());
        }


    }
}