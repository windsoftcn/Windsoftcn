using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MP.Entities;
using MP.Extensions;
using MP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Api.Apps
{
    [Route("api/[controller]")]
    public class WeChatAppsController : RootController
    {
        private readonly WeChatAppService appService;
        private readonly IMapper mapper;

        public WeChatAppsController(WeChatAppService appService,
            IMapper mapper)
        {
            this.appService = appService ?? throw new ArgumentNullException(nameof(appService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<List<WeChatAppDto>>> GetAll()
        {
            var appList = await appService.GetAllAppsAsync();

            var appDtoList = mapper.Map<List<WeChatApp>, List<WeChatAppDto>>(appList);

            return appDtoList;
        }

        [HttpGet("{appId}")]
        public async Task<ActionResult<WeChatAppDto>> GetAppByAppid(string appId)
        {
            
            appId.CheckNullOrWhitespace();

            var app = await appService.GetAppAsync(appId);
                        
            app.CheckNull();

            var appDto = mapper.Map<WeChatApp, WeChatAppDto>(app);

            return appDto;
        }
    }
}
