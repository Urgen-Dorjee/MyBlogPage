using Application.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.GetPost
{
    public class GetPostQuery : IRequest<PostDto>
    {
        public string Slug { get; }
        public GetPostQuery(string slug)
        {
            Slug = slug;
        }
    }
}
