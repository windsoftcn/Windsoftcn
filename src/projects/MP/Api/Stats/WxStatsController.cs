using MediatR;
using Microsoft.AspNetCore.Mvc;
using MP.Extensions;
using MP.MediatR.Events;
using MP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Api.Stats
{
    [Route("api/[controller]")]
    public class WxStatsController : ControllerBase
    {
        private readonly WxAppService appService;
        private readonly IMediator mediator;

        public WxStatsController(WxAppService appService,
            IMediator mediator)
        {
            this.appService = appService ?? throw new ArgumentNullException(nameof(appService));
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("startup")]
        public async Task<IActionResult> Startup(string appId, string userId, string channelId)
        {
            appId.CheckNull();
            userId.CheckNull();
            
            if (channelId.IsNullOrWhiteSpace())
            {
                channelId = Constants.DefaultChannel;
            }

            if (!(await appService.ContainsAppId(appId)))
            {
                throw new ArgumentNullException(nameof(appId));
            }

            // 通知后台处理
            await mediator.Publish(new WeChatAppStartupEvent(appId, userId, channelId));

            return Ok("success");
        }
         
   
        // 跳转
        [HttpGet("goto")]
        public async Task<IActionResult> GoTo(string fromAppId, string gotoAppId)
        {
            // todo ..
            return Ok("success");
        }


        // 点击 
        [HttpGet("tap")]
        public async Task<IActionResult> Tap(string appId, string item)
        {
            // todo
            return Ok("success");
        }

        
    }
}
