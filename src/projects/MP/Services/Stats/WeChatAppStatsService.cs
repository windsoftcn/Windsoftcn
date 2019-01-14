using MP.Services.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Services.Stats
{
    public class WeChatAppStatsService
    {
        private readonly IRedisProvider redisProvider;
        private readonly WxAppService appService;

        public WeChatAppStatsService(IRedisProvider redisProvider,
            WxAppService appService)
        {
            this.redisProvider = redisProvider ?? throw new ArgumentNullException(nameof(redisProvider));
            this.appService = appService ?? throw new ArgumentNullException(nameof(appService));
        }


        public async Task<bool> Startup(string appId)
        {
            return false;
        }
    }
}
