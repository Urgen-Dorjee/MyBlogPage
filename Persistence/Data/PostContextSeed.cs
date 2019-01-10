using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.Extensions.Logging;
using NodaTime;

namespace Persistence.Data
{
    public class PostContextSeed
    {
        public static async Task SeedAsync(PostContext context, ILoggerFactory loggerFactory, int? retry=0)
        {
            int retryForAvailablity = retry.Value;

            try
            {
                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(GetPreConfigurePosts());
                    await context.SaveChangesAsync();
                }
            } catch(Exception ex)
            {
                if(retryForAvailablity < 10)
                {
                    retryForAvailablity++;
                    var log = loggerFactory.CreateLogger<PostContextSeed>();
                    log.LogError(ex.Message);
                    await SeedAsync(context, loggerFactory, retryForAvailablity);
                }
            }           
        }
        private static IEnumerable<Post> GetPreConfigurePosts()
        {
            return new List<Post>()
            {
                new Post()
                {
                    Id = 1,
                    Topic = "Ravangla Travel Dairy Year 2019",
                    Slug = "ravangla-travel-dairy-year-2019",
                    Published = Instant.FromDateTimeUtc(new DateTime(2018, 6, 19, 14, 31, 2, 265, DateTimeKind.Utc)),
                    AuthorName = "Urgen Dorjee",
                    Content = "This is the default home page. Please change me!"
                },
                new Post()
                {
                    Id = 2,
                    Topic = "His Holiness Dalai Lama Bodh Gaya Sermon 2019",
                    Slug = "his-holiness-dalai-lama-bodh-gaya-sermon-2019",
                    Published = Instant.FromDateTimeUtc(new DateTime(2018, 6, 19, 14, 31, 2, 265, DateTimeKind.Utc)),
                    AuthorName = "Kalsang Nyima",
                    Content = "This is the default home page. Please change me!"
                }
            };
        }
    }
}
