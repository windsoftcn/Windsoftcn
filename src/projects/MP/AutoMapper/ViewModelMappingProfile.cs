using AutoMapper;
using MP.Entities;
using MP.Models.WeChatAppsViewModels;
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
            CreateMap<WeChatAppCreateViewModel, WeChatApp>();

            CreateMap<WeChatAppViewModel, WeChatApp>();

            CreateMap<WeChatApp, WeChatAppViewModel>();
        }
    }
}
