using FichePatient.DAL.Entities;
using FichePatient.Web.Models;
using System;
using System.Web.Mvc;
using Tools.Generic;

namespace FichePatient.Web.Controllers
{
    public class SoinController : BaseController
    {
        public ActionResult Create(int id)
        {            
            return View(new SoinModel() { PATIENT_ID = id }); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SoinModel model)
        {
            try
            {
                UOW.SoinRepository.AddEntity(AutoMapper<SoinModel, SoinEntity>.AutoMap(model));
                return RedirectToAction("Details", "Patient", new { @id = model.PATIENT_ID });
            }
            catch(Exception ex)
            {
                return View();
            }
        }        
    }
}
