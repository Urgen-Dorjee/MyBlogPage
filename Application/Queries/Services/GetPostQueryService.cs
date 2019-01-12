using Application.Interfaces;
using Application.Queries.GetAllPosts;
using Application.Queries.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Services
{
    public class GetPostQueryService : IPostRepositoryMediator
    {
        private readonly IPostRepository _postRepo;
        private readonly IMapper _mapper;

        public GetPostQueryService(IPostRepository postRepo, IMapper mapper)
        {
            _postRepo = postRepo;
            _mapper = mapper;
        }

        public async Task<PostDto> GetPostBySlug(string slug)
        {
            return _mapper.Map<PostDto>(await _postRepo.GetPostBySlug(slug));
        }

        public async Task<bool> IsTitleAlreadyExists(string slug, int id)
        {
            return await _postRepo.IsTitleAlreadyExists(slug, id);
        }

        public async Task<List<PostDto>> ListAllPostMediator(int num)
        {
            return _mapper.Map<List<PostDto>>(await _postRepo.GetAllPostQuery(num));
        }
    }
}
