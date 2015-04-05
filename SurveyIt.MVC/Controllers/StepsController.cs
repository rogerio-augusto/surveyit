using AutoMapper;
using SurveyIt.Core.Contracts.Services;
using SurveyIt.Core.DomainEntities;
using SurveyIt.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveyIt.MVC.Controllers
{
    public class StepsController : Controller
    {
        protected IStepService stepService;
        protected IHotsiteService hotsiteService;

        public StepsController(IHotsiteService hotsiteService, IStepService stepService)
        {
            this.stepService = stepService;
            this.hotsiteService = hotsiteService;
        }

        //
        // GET: Hotsite/hotsiteId/Steps/
        public ActionResult Index(int hotsiteId)
        {
            var stepViewModel = Mapper.Map<IEnumerable<Step>, IEnumerable<StepViewModel>>(this.stepService.FindByHotsiteId(hotsiteId));
            
            return View(stepViewModel);
        }

        //
        // GET: Hotsite/hotsiteId/Steps/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: Hotsite/hotsiteId/Steps/Create
        public ActionResult Create(int hotsiteId)
        {
            var hotsite = this.hotsiteService.Find(hotsiteId);
            var hotsiteViewModel = Mapper.Map<Hotsite, HotsiteViewModel>(hotsite);
            var newStep = new StepViewModel { Hotsite = hotsiteViewModel };
            return View(newStep);
        }

        //
        // POST: Hotsite/hotsiteId/Steps/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StepViewModel stepViewModel, int hotsiteId)
        {
            stepViewModel.HotsiteId = hotsiteId;

            if (ModelState.IsValid)
            {
                var step = Mapper.Map<StepViewModel, Step>(stepViewModel);
                this.stepService.Create(step);
                return RedirectToAction("Index");
            }

            return View(stepViewModel);
        }

        //
        // GET: /Steps/Edit/5
        public ActionResult Edit(int id)
        {
            var step = this.stepService.Find(id);
            var stepViewModel = Mapper.Map<Step, StepViewModel>(step);

            return View(stepViewModel);
        }

        //
        // POST: /Steps/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Steps/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Steps/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
