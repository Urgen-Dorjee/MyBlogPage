using Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Persistence.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Domain.Entities;
using Application.Queries.Models;

namespace Application.Queries.GetAllPosts
{
    public class GetAllPostsQueryHandler : IRequestHandler<GetAllPostsQuery, List<PostDto>>
    {
        private readonly IPostRepositoryMediator _postMediator;

        public GetAllPostsQueryHandler(IPostRepositoryMediator postMediator)
        {
            _postMediator = postMediator;
        }
        public Task<List<PostDto>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
        {
            return _postMediator.ListAllPostMediator(request.NumPosts);

        }
    }
}
