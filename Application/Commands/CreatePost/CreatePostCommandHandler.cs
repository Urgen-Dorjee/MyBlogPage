using Application.Commands.Common;
using Application.Commands.Models;
using Application.Exceptions;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, CommandResult>
    {
        private readonly IPostRepositoryMediatorCommand _repo;
        private readonly IMapper _mapper;

        public CreatePostCommandHandler(IPostRepositoryMediatorCommand repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<CommandResult> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var result = new CommandResult() { Successful = true };
            try
            {
                var mapCreate = _mapper.Map<Post>(request);
                await _repo.CreateBlogPostMediator(mapCreate);
            }
            catch(Exception ex){

                result.Successful = false;
                result.Exception = new CreatePostException("There was an error creating a Post", ex);
            }

            return result;
        }
    }
}
