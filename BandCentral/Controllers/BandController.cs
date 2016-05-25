using BandCentral.Model;
using BandCentral.Service;
using BandCentral.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
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
            List<BandViewModel> bandViewModels = new List<BandViewModel>();
            List<Band> bands;

            //Set messages returned from redirects
            if(TempData["ErrorMessage"] != null)
                ViewBag.ErrorMessage = TempData["ErrorMessage"].ToString();
            if (TempData["SuccessMessage"] != null)
                ViewBag.SuccessMessage = TempData["SuccessMessage"].ToString();

            bands = bandService.GetBands().ToList();
            foreach (var band in bands)
            {
                Boolean favoriteStatus = band.Users.Any(u => u.Id == User.Identity.GetUserId());
                bandViewModels.Add(new BandViewModel
                {
                    Id = band.Id,
                    BandName = band.BandName,
                    isFavorited = favoriteStatus
                });
            }

            return View(bandViewModels);
        }

        // GET: Band/Details/5
        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                TempData["ErrorMessage"] = "Band Id was not set";
                return RedirectToAction("Index");
            }
            Band band;
            DetailsBandViewModel detailsBandViewModel;
            band = bandService.GetBand(id.Value);
            detailsBandViewModel = Mapper.Map<Band, DetailsBandViewModel>(band);
            return View(detailsBandViewModel);
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(BandViewModel bandViewModel)
        {
            try
            {
                Band band;
                band = Mapper.Map<BandViewModel, Band>(bandViewModel);
                bandService.CreateBand(band);
                bandService.SaveBand();

                TempData["SuccessMessage"] = bandViewModel.BandName + " was created!";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Band/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                TempData["ErrorMessage"] = "Band Id was not set";
                return RedirectToAction("Index");
            }
            Band band = bandService.GetBand(id.Value);
            BandViewModel bandViewModel = Mapper.Map<Band, BandViewModel>(band);
            return View(bandViewModel);
        }

        // POST: Band/Edit/5
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BandViewModel bandViewModel)
        {
            try
            {
                Band band = Mapper.Map<BandViewModel, Band>(bandViewModel);
                bandService.UpdateBand(band);
                bandService.SaveBand();
                TempData["SuccessMessage"] = bandViewModel.BandName + " was updated!";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Band/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (!id.HasValue)
            {
                TempData["ErrorMessage"] = "Band Id was not set";
                return RedirectToAction("Index");
            }
            Band band = bandService.GetBand(id.Value);
            BandViewModel bandViewModel = Mapper.Map<Band, BandViewModel>(band);
            return View(bandViewModel);
        }

        // POST: Band/Delete/5
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {

            try
            {
                bandService.DeleteBand(id);
                bandService.SaveBand();
                TempData["SuccessMessage"] = "Band was deleted!";
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.ErrorMessage = "Band could not be deleted.";
                return View();
            }
        }

        //GET: Band/AddFavorite/5
        [Authorize]
        public ActionResult AddFavorite(int? id)
        {
            if (!id.HasValue)
            {
                TempData["ErrorMessage"] = "Band Id was not set";
                return RedirectToAction("Index");
            }
            Band band = bandService.GetBand(id.Value);
            BandViewModel bandViewModel = Mapper.Map<Band, BandViewModel>(band);
            return View(bandViewModel);
        }

        //Post: Band/AddFavorite/5
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddFavorite(int id, FormCollection collection)
        {
            try
            {
                Band band = bandService.GetBand(id);
                ApplicationUser user = userService.GetUser(User.Identity.GetUserId());
                bandService.AddUserBand(band,user);
                bandService.SaveBand();

                TempData["SuccessMessage"] = "Band was added to favorites!";
                return RedirectToAction("Index");
            }
            catch
            {

                ViewBag.ErrorMessage = "Band could not be added to favorites.";
                return View();
            }
        }
        //GET: Band/RemoveFavorite/5
        [Authorize]
        public ActionResult RemoveFavorite(int? id)
        {
            if (!id.HasValue)
            {
                TempData["ErrorMessage"] = "Band Id was not set";
                return RedirectToAction("Index");
            }
            Band band = bandService.GetBand(id.Value);
            BandViewModel bandViewModel = Mapper.Map<Band, BandViewModel>(band);
            return View(bandViewModel);
        }

        //POST: Band/RemoveFavorite/5
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RemoveFavorite(int id, FormCollection collection)
        {
            try
            {
                Band band = bandService.GetBand(id);
                ApplicationUser user = userService.GetUser(User.Identity.GetUserId());
                bandService.RemoveUserBand(band, user);
                bandService.SaveBand();

                TempData["SuccessMessage"] = "Band was removed from favorites!";
                return RedirectToAction("Index");
            }
            catch
            {

                ViewBag.ErrorMessage = "Band could not be removed from favorites.";
                return View();
            }
        }
    }
}
