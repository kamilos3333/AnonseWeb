﻿using AnonseWeb.Model;
using AnonseWeb.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnonseWeb.Mapping
{
    public class AutomapperWebProfile : AutoMapper.Profile
    {
        public AutomapperWebProfile()
        {
            CreateMap<Advertisement, DetailAdvertisementViewModel>()
                .ForMember(d => d.AdvertisementDesc, o => o.MapFrom(s => s.Description))
                .ForMember(d => d.CategoryName, o => o.MapFrom(s => s.categories.CategoryName))
                .ForMember(d => d.CityName, o => o.MapFrom(s => s.cities.CityName))
                .ForMember(d => d.Photo, o => o.MapFrom(s => s.files.First().FileName))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.users.Email))
                .ForMember(d => d.PhoneNumber, o => o.MapFrom(s => s.users.PhoneNumber));

            CreateMap<Advertisement, EditAdvertisementViewModel>();

            CreateMap<EditAdvertisementViewModel, Advertisement>();

        }

        public static void Run()
        {
            AutoMapper.Mapper.Initialize(a =>
            {
                a.AddProfile<AutomapperWebProfile>();
            });
        }
    }
}