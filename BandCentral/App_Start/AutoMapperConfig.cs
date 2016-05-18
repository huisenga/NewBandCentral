using AutoMapper;
using BandCentral.Model;
using BandCentral.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BandCentral.App_Start
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMissingTypeMaps = true;
                //Band View Models
                cfg.CreateMap<Band, BandViewModel>();
                cfg.CreateMap<BandViewModel, Band>();
                cfg.CreateMap<Band, DetailsBandViewModel>();
                cfg.CreateMap<DetailsBandViewModel, Band>();

                //User View Models
                cfg.CreateMap<ApplicationUser, ProfileViewModel>();
                cfg.CreateMap<ProfileViewModel, ApplicationUser>();

            });
        }
    }

}