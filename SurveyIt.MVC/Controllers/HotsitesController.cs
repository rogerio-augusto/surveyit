using AutoMapper;
using SurveyIt.Domain.Contracts.Services;
using SurveyIt.Domain.Entities;
using SurveyIt.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SurveyIt.MVC.Controllers
{
    public class HotsitesController : Controller
    {
        protected IHotsiteService hotsiteService;

        public HotsitesController(IHotsiteService hotsiteService)
        {
            this.hotsiteService = hotsiteService;
        }

        //
        // GET: /Hotsites/
        public ActionResult Index()
        {
            var hotsiteViewModel = Mapper.Map<IEnumerable<Hotsite>, IEnumerable<HotsiteViewModel>>(this.hotsiteService.FindAll());
            return View(hotsiteViewModel);
        }

        //
        // GET: /Hotsites/Details/5
        public ActionResult Details(int id)
        {
            var hotsite = this.hotsiteService.Find(id);
            var hotsiteViewModel = Mapper.Map<Hotsite, HotsiteViewModel>(hotsite);

            return View(hotsiteViewModel);
        }

        //
        // GET: /Hotsites/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Hotsites/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HotsiteViewModel hotsiteViewModel)
        {
            if(ModelState.IsValid)
            {
                var hotsite = Mapper.Map<HotsiteViewModel, Hotsite>(hotsiteViewModel);
                this.hotsiteService.Create(hotsite);
                return RedirectToAction("Index");
            }
            
            return View(hotsiteViewModel);
        }

        //
        // GET: /Hotsites/Edit/5
        public ActionResult Edit(int id)
        {
            var hotsite = this.hotsiteService.Find(id);
            var hotsiteViewModel = Mapper.Map<Hotsite, HotsiteViewModel>(hotsite);

            return View(hotsiteViewModel);
        }

        //
        // POST: /Hotsites/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(HotsiteViewModel hotsiteViewModel)
        {
            if (ModelState.IsValid)
            {
                var hotsite = Mapper.Map<HotsiteViewModel, Hotsite>(hotsiteViewModel);
                this.hotsiteService.Update(hotsite);
                return RedirectToAction("Index");
            }

            return View(hotsiteViewModel);
        }

        //
        // GET: /Hotsites/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Hotsites/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var hotsite = this.hotsiteService.Find(id);
            hotsiteService.Delete(hotsite);

            return RedirectToAction("Index");
        }
    }
}
