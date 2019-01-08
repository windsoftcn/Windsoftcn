using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using MP.Data;
using MP.Entities;
using MP.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Services
{
    public class WeChatAppService
    {
        private readonly IMemoryCache cache;
        private readonly AppDbContext dbContext;

        public WeChatAppService(IMemoryCache cache,
            AppDbContext dbContext)
        {
            this.cache = cache ?? throw new ArgumentNullException(nameof(cache));
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public Task<List<WeChatApp>> GetAllAppsAsync()
        {
            return cache.GetOrCreateAsync(Constants.AllWeChatMiniApps, entry => dbContext.WeChatApps.Where(x=>x.IsEnabled).ToListAsync());
        }

        public Task<WeChatApp> GetAppAsync(int id)
        {
            return dbContext.WeChatApps.FindAsync(id);
        }

        public Task<WeChatApp> GetAppAsync(string appId)
        {
            return cache.GetOrCreateAsync(appId, entry => dbContext.WeChatApps.FirstOrDefaultAsync(app => app.AppId == appId));
        }


        public Task<int> CreateAppAsync(WeChatApp app)
        {
            dbContext.WeChatApps.Add(app);
            return dbContext.SaveChangesAsync();            
        }
        

        public Task<int> UpdateAppAsync(WeChatApp app)
        {
            dbContext.WeChatApps.Update(app);
            return dbContext.SaveChangesAsync();
        }
    }
}
