﻿using Microsoft.AspNetCore.Mvc;
using MP.Extensions;
using MP.Services;
using MP.Services.WeChatAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Api.WeChatAuth
{
    [Route("api/[controller]")]
    public class WeChatAuthController : ControllerBase
    {
        
        
        private readonly WeChatAuthHttpClient weChatAuthHttpClient;
        private readonly WeChatAppService appService;

        public WeChatAuthController(WeChatAuthHttpClient weChatAuthHttpClient,
            WeChatAppService appService)
        {
            this.weChatAuthHttpClient = weChatAuthHttpClient ?? throw new ArgumentNullException(nameof(weChatAuthHttpClient));
            this.appService = appService ?? throw new ArgumentNullException(nameof(appService));
        }

        [HttpGet("mpLogin")]
        public async Task<IActionResult> MiniProgramLogin(string appId, string code)
        {
            // 1. 验证AppId
            appId.CheckNullOrWhitespace();

            var app = await appService.GetAppAsync(appId);

            app.CheckNull();       

            
            var openId = await weChatAuthHttpClient.GetOpenIdAsync(app.AppId, app.Secret, code);
            return Ok(openId);
        }


    }
}
