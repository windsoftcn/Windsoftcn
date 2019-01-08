using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Windsoftcn.Caching.LazyCache
{
    public class LazyCacheOptions
    {
        public virtual int DefaultCacheDurationSeconds { get; set; } = 60 * 20;

        internal MemoryCacheEntryOptions BuildOptions() => new MemoryCacheEntryOptions { AbsoluteExpiration = DateTimeOffset.UtcNow.AddSeconds(DefaultCacheDurationSeconds) };
    }

    public interface ILazyCache
    {

        void Add<T>(string key, T item, MemoryCacheEntryOptions policy);

        T Get<T>(string key);

        T GetOrAdd<T>(string key, Func<ICacheEntry, T> addItemFactory);

        Task<T> GetAsync<T>(string key);

        Task<T> GetOrAddAsync<T>(string key, Func<ICacheEntry, Task<T>> addItemFactory);

        void Remove(string key);
    }


    public class LazyCache: ILazyCache
    {
        private readonly IMemoryCache memoryCache;

        public LazyCache(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }


        public virtual void Add<T>(string key, T item, MemoryCacheEntryOptions policy)
        {
            ValidateNull(item);

            ValidateKey(key);

            memoryCache.Set(key, item, policy);
        }

        public virtual T Get<T>(string key)
        {
            ValidateKey(key);

            var item = memoryCache.Get<T>(key);

            return item;
        }

        public Task<T> GetAsync<T>(string key)
        {
            memoryCache.GetOrCreateAsync()

            
        }

        public T GetOrAdd<T>(string key, Func<ICacheEntry, T> addItemFactory)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetOrAddAsync<T>(string key, Func<ICacheEntry, Task<T>> addItemFactory)
        {
            throw new NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        protected virtual void ValidateKey(string key)
        {
            ValidateNull(key);

            ValidateWhitespace(key, "Cache key cannot be empty or whitespace");
        }

        protected virtual void ValidateNull<T>(T value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
        }

        protected virtual void ValidateWhitespace(string value, string errorMsg = "value cannot be empty or whitespace")
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentOutOfRangeException(nameof(value), errorMsg);
        }
    }
     
    
}
