using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.RepositoryService
{
    public class PostRepository: IPostRepository, IDisposable
    {
        private readonly PostContext _context;

        public PostRepository(PostContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<List<Post>> GetAllPostQuery(int no)
        {
            var posts = await _context.Posts.AsTracking()
                                      .OrderByDescending(p => p.Published)  
                                      .Take(no)
                                      .ToListAsync();
                                     
            return posts.ToList();
        }

        public async Task<Post> GetPostBySlug(string slug)
        {
            return await _context.Posts.FirstOrDefaultAsync(p => p.Slug == slug);
        }
    }
}
