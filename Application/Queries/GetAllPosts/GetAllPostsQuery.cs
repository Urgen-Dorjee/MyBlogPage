using Application.Queries.Models;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.GetAllPosts
{
    public class GetAllPostsQuery: IRequest<List<PostDto>> 
    {
        public int NumPosts { get; }
        public GetAllPostsQuery(int num)
        {
            NumPosts = num;
        }
    }
}
