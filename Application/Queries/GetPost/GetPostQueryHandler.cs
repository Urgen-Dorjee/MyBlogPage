using Application.Interfaces;
using Application.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries.GetPost
{
    public class GetPostQueryHandler : IRequestHandler<GetPostQuery, PostDto>
    {
        private readonly IPostRepositoryMediator _postMediator;

        public GetPostQueryHandler(IPostRepositoryMediator postMediator)
        {
            _postMediator = postMediator;
        }
        public Task<PostDto> Handle(GetPostQuery request, CancellationToken cancellationToken)
        {
            return _postMediator.GetPostBySlug(request.Slug);
        }
    }
}
