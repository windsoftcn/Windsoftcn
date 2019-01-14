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
    public class WxAppService
    {
        private readonly IMemoryCache cache;
        private readonly AppDbContext dbContext;

        public WxAppService(IMemoryCache cache,
            AppDbContext dbContext)
        {
            this.cache = cache ?? throw new ArgumentNullException(nameof(cache));
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public Task<List<WxApp>> GetAllAppsAsync(bool fromCache = true)
        {
            if (fromCache)
            {
                return cache.GetOrCreateAsync(Constants.AllWxApps, entry => dbContext.WxApps.Where(x => x.Enabled).ToListAsync());
            }
            else
            {
                return dbContext.WxApps.Where(x => x.Enabled).ToListAsync();
            }
        }

        public Task<WxApp> GetAppAsync(int id)
        {
            return dbContext.WxApps.FindAsync(id);
        }

        public Task<WxApp> GetAppAsync(string appId)
        {
            return cache.GetOrCreateAsync(appId, entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromMinutes(5);
                return dbContext.WxApps.FirstOrDefaultAsync(app => app.AppId == appId);
            });
        }


        public Task<int> CreateAppAsync(WxApp app)
        {
            dbContext.WxApps.Add(app);
            return dbContext.SaveChangesAsync();                        
        }
        

        public Task<int> UpdateAppAsync(WxApp app)
        {
            dbContext.WxApps.Update(app);
            return dbContext.SaveChangesAsync();
        }


        public Task<HashSet<string>> GetAllAppIdsAsync()
        { 
            return cache.GetOrCreateAsync(Constants.AllWxAppIds, entry=>
            {             
                return Task.FromResult(dbContext.WxApps.Select(x => x.AppId).ToHashSet());
            });
        }
        
        public async Task<bool> ContainsAppId(string appId)
        {
            var appIds = await GetAllAppIdsAsync();
            return appIds.Contains(appId);
        }
                        
    }
}
