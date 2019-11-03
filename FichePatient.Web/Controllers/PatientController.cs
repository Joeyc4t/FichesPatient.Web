using FichePatient.DAL.Entities;
using FichePatient.Web.Models;
using FichePatient.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Tools.Generic;
using PagedList;

namespace FichePatient.Web.Controllers
{
    public class PatientController : BaseController
    {
        private const int PAGE_SIZE = 15;

        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            List<PatientModel> models = new List<PatientModel>();

            foreach (var entity in UOW.PatientRepository.GetEntities().Where(e => e.STATUTENREGISTREMENT))
                models.Add(AutoMapper<PatientEntity, PatientModel>.AutoMap(entity));

            if (!String.IsNullOrEmpty(searchString))
            {
                models = models.Where(s => s.PRENOM.ToLower().Contains(searchString.ToLower())
                                       || s.NOM_FAMILLE.ToLower().Contains(searchString.ToLower())).ToList();
            }
            switch (sortOrder)
            {
                case "name_desc":
                    models = models.OrderByDescending(s => s.NOM_FAMILLE).ToList();
                    break;
                case "Date":
                    models = models.OrderBy(s => s.DATE_NAISSANCE).ToList();
                    break;
                case "date_desc":
                    models = models.OrderByDescending(s => s.DATE_NAISSANCE).ToList();
                    break;
                default: 
                    models = models.OrderBy(s => s.NOM_FAMILLE).ToList();
                    break;
            }

            int pageSize = PAGE_SIZE;
            int pageNumber = (page ?? 1);
            return View(models.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Details(int id)
        {
            PatientViewModel viewModel = MapPatient(id);
            return View(viewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PatientViewModel viewModel)
        {
            try
            {
                viewModel.patient.ETAT_SANTE_ID = UOW.EtatSanteRepository.AddEntity(AutoMapper<EtatSanteModel, EtatSanteEntity>.AutoMap(viewModel.etatSante));
                viewModel.patient.STATUTENREGISTREMENT = true;

                UOW.PatientRepository.AddEntity(AutoMapper<PatientModel, PatientEntity>.AutoMap(viewModel.patient));

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            PatientViewModel viewModel = MapPatient(id);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PatientViewModel viewModel)
        {
            try
            {
                EtatSanteEntity etatSante = AutoMapper<EtatSanteModel, EtatSanteEntity>.AutoMap(viewModel.etatSante);
                PatientEntity patient = AutoMapper<PatientModel, PatientEntity>.AutoMap(viewModel.patient);
                patient.ETAT_SANTE_ID = etatSante.ID;
                patient.STATUTENREGISTREMENT = true;

                bool ok1 = UOW.EtatSanteRepository.UpdateEntity(etatSante);
                bool ok2 = UOW.PatientRepository.UpdateEntity(patient);

                return RedirectToAction("Details", new { id = viewModel.patient.ID });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private PatientViewModel MapPatient(int id)
        {
            PatientViewModel viewModel = new PatientViewModel();
            viewModel.patient = AutoMapper<PatientEntity, PatientModel>.AutoMap(UOW.PatientRepository.GetEntity(id));
            viewModel.etatSante = AutoMapper<EtatSanteEntity, EtatSanteModel>.AutoMap(UOW.EtatSanteRepository.GetEntities()
                                                                                         .FirstOrDefault(e => e.ID.Equals(viewModel.patient.ETAT_SANTE_ID)));            
            viewModel.soins = GetSoinsPatient(id);

            return viewModel;
        }

        private IEnumerable<SoinModel> GetSoinsPatient(int id)
        {
            foreach (var entity in UOW.SoinRepository.GetEntities().Where(e => e.PATIENT_ID.Equals(id)))
                yield return AutoMapper<SoinEntity, SoinModel>.AutoMap(entity);
        }
    }
}
