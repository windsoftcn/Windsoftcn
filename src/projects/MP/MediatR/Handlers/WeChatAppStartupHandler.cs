using MediatR;
using MP.MediatR.Events;
using MP.Services.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MP.MediatR.Handlers
{
     public class WeChatAppStartupHandler : INotificationHandler<WeChatAppStartupEvent>
    {
        private readonly WeChatAppStatsService appStatsService;

        public WeChatAppStartupHandler(WeChatAppStatsService appStatsService)
        {
            this.appStatsService = appStatsService ?? throw new ArgumentNullException(nameof(appStatsService));
        }

        public Task Handle(WeChatAppStartupEvent notification, CancellationToken cancellationToken)
        {               
            
        }
    }
}
