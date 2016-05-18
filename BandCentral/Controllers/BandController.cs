using BandCentral.Model;
using BandCentral.Service;
using BandCentral.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace BandCentral.Controllers
{
    public class BandController : Controller
    {
        private readonly IBandService bandService;
        private readonly IUserService userService;

        public BandController(IBandService bandService, IUserService userService)
        {
            this.bandService = bandService;
            this.userService = userService;
        }

        // GET: Band
        public ActionResult Index()
        {
            IEnumerable<BandViewModel> viewModelBands;
            viewModelBands = Mapper.Map<IEnumerable<Band>, IEnumerable<BandViewModel>>(bandService.GetBands().ToList());
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
        public ActionResult Edit(BandViewModel bandViewModel)
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

        //GET: Band/AddFavorite/5
        [Authorize]
        public ActionResult AddFavorite(int? id)
        {
            if (!id.HasValue)
                return View("Index");
            Band band = bandService.GetBand(id.Value);
            BandViewModel bandViewModel = Mapper.Map<Band, BandViewModel>(band);
            return View(bandViewModel);
        }

        //GET: Band/AddFavorite/5
        [Authorize]
        [HttpPost]
        public ActionResult AddFavorite(int id, FormCollection collection)
        {
            try
            {
                Band band = bandService.GetBand(id);
                ApplicationUser user = userService.GetUser(User.Identity.GetUserId());
                bandService.AddUserBand(band,user);
                bandService.SaveBand();
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                return View();
            }
            //catch
            //{

            //    ViewBag.ErrorMessage = "Band could not be added to favorites."
            //    return View();
            //}
        }

    }
}
