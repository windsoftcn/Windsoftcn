using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Api.Apps
{
    public class WxBoxSettingsDto
    {
        public List<WxAppDto> BannerApps { get; set; }

        public List<WxAppDto> BestApps { get; set; }

        public List<WxAppDto> OtherApps { get; set; }
    }
}
