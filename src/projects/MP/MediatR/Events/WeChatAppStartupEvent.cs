using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MP.MediatR.Events
{
    public class WeChatAppStartupEvent : INotification 
    {
        public string AppId { get; }
        public string UserId { get; }
        public string ChannelId { get; }

        public WeChatAppStartupEvent(string appId,string userId, string channelId)
        {
            AppId = appId;
            UserId = userId;
            ChannelId = channelId;
        }
        
    }

   
}
