using AutoMapper;
using MP.Entities;
using MP.Models.WxAppViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.AutoMapper
{
    public class ViewModelMappingProfile : Profile
    {
        public ViewModelMappingProfile()
        {
            CreateMap<WxAppCreateViewModel, WxApp>();

            CreateMap<WxAppViewModel, WxApp>();

            CreateMap<WxApp, WxAppViewModel>();
        }
    }
}
