using AutoMapper;
using BandCentral.Model;
using BandCentral.Service;
using BandCentral.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BandCentral.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IBandService bandService;
        private readonly IUserService userService;

        public ProfileController(IBandService bandService, IUserService userService)
        {
            this.bandService = bandService;
            this.userService = userService;
        }

        // GET: Profile
        public ActionResult Index()
        {
            ProfileViewModel profileViewModel;
            profileViewModel = Mapper.Map<ApplicationUser, ProfileViewModel>(userService.GetUser(User.Identity.GetUserId()));
            return View(profileViewModel);
        }
    }
}