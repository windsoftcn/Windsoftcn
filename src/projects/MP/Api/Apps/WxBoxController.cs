using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MP.Entities;
using MP.Enumerations;
using MP.Extensions;
using MP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Api.Apps
{
    [Route("api/[controller]")]
    public class WxBoxController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly WxBoxService boxService;

        public WxBoxController(IMapper mapper,
            WxBoxService boxService)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.boxService = boxService ?? throw new ArgumentNullException(nameof(boxService));
        }


        [HttpGet]        
        [Route("settings")]
        public async Task<ActionResult<WxBoxSettingsDto>> GetBoxSettings(int boxId = 1)
        {
            var wxBox = await boxService.GetBoxDetailsAsync(boxId);

            // banner 推荐
            var bannerApps = wxBox.WxBoxApps
                .Where(x => x.WxApp.BannerUrl.IsNotNullOrWhiteSpace() && x.AppShowType.Equals(AppShowType.横幅))
                .Select(x=>x.WxApp)
                .ToList();

            bannerApps.Shuffle();

            // 获取火爆游戏
            var bestApps = wxBox.WxBoxApps
                .Take(8)
                .Select(x => x.WxApp)
                .ToList();

            bestApps.Shuffle();

            // 精品推荐
            var otherApps = wxBox.WxBoxApps.Select(x => x.WxApp).ToList();            
            otherApps.Shuffle(); // 随机排序

            var settingsDto = new WxBoxSettingsDto
            {
                BannerApps = mapper.Map<List<WxApp>, List<WxAppDto>>(bannerApps),
                BestApps = mapper.Map<List<WxApp>, List<WxAppDto>>(bestApps),
                OtherApps = mapper.Map<List<WxApp>, List<WxAppDto>>(otherApps)
            };

            return settingsDto;
        }
    }
}
