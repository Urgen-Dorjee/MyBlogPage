using Application.Commands.Common;
using Application.Commands.Models;
using MediatR;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.CreatePost
{
    public class CreatePostCommand : IRequest<CommandResult>
    {
       
        public string Topic { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }    
        public string AuthorName { get; set; }
    }
}
