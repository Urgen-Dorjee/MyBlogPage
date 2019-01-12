using Application.Commands.Events;
using Application.Commands.Models;
using Application.Interfaces;
using Application.Queries.Models;
using Domain.Entities;
using MediatR;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Services
{
    public class CommandService : IPostRepositoryMediatorCommand
    {
        private readonly IPostRepository _repository;
        private readonly IClock _clock;
        private readonly IMediator _mediator;

        public CommandService(IPostRepository repository, IClock clock, IMediator mediator)
        {
            _repository = repository;
            _clock = clock;
            _mediator = mediator;
        }
        public async Task<Post> CreateBlogPostMediator(Post post)
        {
            post.Published = _clock.GetCurrentInstant();
            var createPost = await _repository.CreatePostRepository(post);
            await _mediator.Publish(new NotifyPostCreation(createPost));
            return createPost;
        }      
    }
}
