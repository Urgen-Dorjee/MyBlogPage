using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries.Topic
{
    public class PostTitleExistsQueryHanlder : IRequestHandler<PostTitleExistsQuery, bool>
    {
        private readonly IPostRepositoryMediator _repository;

        public PostTitleExistsQueryHanlder(IPostRepositoryMediator repository)
        {
            _repository = repository;
        }
        public Task<bool> Handle(PostTitleExistsQuery request, CancellationToken cancellationToken)
        {
            return _repository.IsTitleAlreadyExists(request.Slug, request.Id);
        }
    }
}
