using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3.Models;
using Microsoft.Extensions.Caching.Memory;
using Lab3.Data;
using Lab3.ViewModels;

namespace Lab3.Services
{
    public class CreateCache
    {
        private IMemoryCache cache;

        public CreateCache(STOContext context, IMemoryCache memoryCache)
        {
            cache = memoryCache;
        }

        public HomeViewModel GetProduct(string key)
        {
            HomeViewModel homeViewModel = null;

            if (!cache.TryGetValue(key, out homeViewModel))
            {
                homeViewModel = TakeLast.GetHomeViewModel();
                if (homeViewModel != null)
                {
                    cache.Set(key, homeViewModel,
                    new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromSeconds((2 * 6) + 240)));
                }
            }
            return homeViewModel;
        }
    }
}
