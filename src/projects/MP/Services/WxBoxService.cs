using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using MP.Data;
using MP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Services
{
    public class WxBoxService
    {
        private readonly IMemoryCache cache;
        private readonly AppDbContext dbContext;

        public WxBoxService(IMemoryCache cache,
            AppDbContext dbContext)
        {
            this.cache = cache ?? throw new ArgumentNullException(nameof(cache));
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public Task<WxBox> GetBoxDetailsAsync(int boxId)
        {
            return dbContext.WxBoxes.Include(x => x.WxBoxApps)
                 .ThenInclude(x => x.WxApp)
                 .Where(x => x.Id == boxId)
                 .FirstOrDefaultAsync();
        }

        public Task<int> AddBoxAsync(WxBox box)
        {
            dbContext.WxBoxes.Add(box);
            return dbContext.SaveChangesAsync();
        }

        public Task<List<WxBox>> GetAllBoxes(bool fromCache = true)
        {
            return cache.GetOrCreateAsync(Constants.AllWxBoxes, entry =>
            {
                return dbContext.WxBoxes.ToListAsync();
            });
        }
    }
}
