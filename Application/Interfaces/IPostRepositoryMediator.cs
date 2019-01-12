using Application.Commands.Models;
using Application.Queries.GetAllPosts;
using Application.Queries.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPostRepositoryMediator
    {
        Task<List<PostDto>> ListAllPostMediator(int num);
        Task<PostDto> GetPostBySlug(string slug);
        Task<bool> IsTitleAlreadyExists(string slug, int id);
    }
}
