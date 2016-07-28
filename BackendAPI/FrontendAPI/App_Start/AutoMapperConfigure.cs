using AutoMapper;
using BackendAPI.Entities;
using FrontendAPI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontendAPI.App_Start
{
    public class AutoMapperConfigure
    {
        public static void AutoMapConfig()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Person, PersonDto>());
        }
    }
}