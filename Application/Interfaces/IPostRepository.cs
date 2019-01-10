using Application.Queries.GetAllPosts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPostRepository
    {
       // IEnumerable<T> ListAllPost();
        Task<List<Post>> GetAllPostQuery(int num);
        Task<Post> GetPostBySlug(string slug);
    }
}
