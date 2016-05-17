using BandCentral.Model;
using BandCentral.Service;
using BandCentral.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;

namespace BandCentral.Controllers
{
    public class BandController : Controller
    {
        private readonly IBandService bandService;

        public BandController(IBandService bandService)
        {
            this.bandService = bandService;
        }

        // GET: Band
        public ActionResult Index()
        {
            IEnumerable<BandViewModel> viewModelBands;
            IEnumerable<Band> bands;
            bands = bandService.GetBands().ToList();
            viewModelBands = Mapper.Map<IEnumerable<Band>, IEnumerable<BandViewModel>>(bands);
            return View(viewModelBands);
        }

        // GET: Band/Details/5
        public ActionResult Details(int id)
        {
            Band band;
            BandViewModel bandViewModel;
            band = bandService.GetBand(id);
            bandViewModel = Mapper.Map<Band, BandViewModel>(band);
            return View(bandViewModel);
        }

        // GET: Band/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Band/Create
        [Authorize]
        [HttpPost]
        public ActionResult Create(BandViewModel bandViewModel)
        {
            try
            {
                Band band;
                band = Mapper.Map<BandViewModel, Band>(bandViewModel);
                bandService.CreateBand(band);
                bandService.SaveBand();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Band/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            Band band = bandService.GetBand(id);
            BandViewModel bandViewModel = Mapper.Map<Band, BandViewModel>(band);
            return View(bandViewModel);
        }

        // POST: Band/Edit/5
        [Authorize]
        [HttpPost]
        public ActionResult Edit([Bind(Include="ID,BandName")] BandViewModel bandViewModel)
        {
            try
            {
                Band band = Mapper.Map<BandViewModel, Band>(bandViewModel);
                bandService.UpdateBand(band);
                bandService.SaveBand();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Band/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            Band band = bandService.GetBand(id);
            BandViewModel bandViewModel = Mapper.Map<Band, BandViewModel>(band);
            return View(bandViewModel);
        }

        // POST: Band/Delete/5
        [Authorize]
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                bandService.DeleteBand(id);
                bandService.SaveBand();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
