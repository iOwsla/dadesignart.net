using Microsoft.Extensions.Caching.Memory;

namespace dadesignart.net.Application;

 public static class MemoryCacheHelper
    {
        public static string GetCategoryGetAllKey(Guid userId) => $"CategoriesGetAll_{userId}";
        public static string GetCategoryGetByIdKey(Guid id) =>$"CategoryGetById_{id}";

        public static MemoryCacheEntryOptions GetMemoryCacheEntryOptions()
        {
            return new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromHours(12))
                .SetPriority(CacheItemPriority.Normal);
        }
    }
