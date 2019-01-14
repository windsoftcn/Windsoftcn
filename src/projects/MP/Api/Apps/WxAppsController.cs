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
    public class WxAppsController : ControllerBase
    {
        private readonly WxAppService appService;
        private readonly IMapper mapper;

        public WxAppsController(WxAppService appService,
            IMapper mapper)
        {
            this.appService = appService ?? throw new ArgumentNullException(nameof(appService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<List<WxAppDto>>> GetAll()
        {
            var appList = await appService.GetAllAppsAsync();

            var appDtoList = mapper.Map<List<WxApp>, List<WxAppDto>>(appList);

            return appDtoList;
        }

        [HttpGet("{appId}")]
        public async Task<ActionResult<WxAppDto>> GetAppByAppId(string appId)
        {            
            appId.CheckNullOrWhitespace();

            var app = await appService.GetAppAsync(appId);
                        
            app.CheckNull();

            var appDto = mapper.Map<WxApp, WxAppDto>(app);

            return appDto;
        }
        
     
    }
}
