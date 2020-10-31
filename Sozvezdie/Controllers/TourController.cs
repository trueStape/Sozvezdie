using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sozvezdie.BLL.Interfaces;
using Sozvezdie.BLL.Models;
using Sozvezdie.DAL.Interfaces;

namespace Sozvezdie.Controllers
{
    public class TourController : Controller
    {
        private readonly ITourServices _tourServices;
       
        public TourController(ITourServices tourServices)
        {
            _tourServices = tourServices;
        }

        //GET: TourController
        [HttpGet("api/tour")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("api/tour/{id}")]
        public async Task<JsonResult> GetTourAsync(int id)
        {
            var tour = await _tourServices.GetTourAsync(id);
            return Json(tour);
        }

        // POST: TourController/Create
        [HttpPost]
        public async Task<IActionResult> CreateAsync(TourModel model)
        {
            await _tourServices.CrateTourAsync(model);
            return Ok();
        }
        
        // PUT: TourController/5
        [HttpPut]
        public async Task<IActionResult> EditAsync(TourModel model)
        {
            await _tourServices.EditTourAsync(model);
            return Ok();
        }
        
        // Delete: TourController/5
        [HttpDelete]
        public ActionResult DeleteAsync(int id)
        {
            var answer = _tourServices.DeleteTour(id);
            return Ok(answer);
        }
    }
}
