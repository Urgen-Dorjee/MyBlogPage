using Application.Queries.GetAllPosts;
using Application.Queries.Models;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Services
{
    public class MapperService : Profile
    {
        public MapperService()
        {
            CreateMap<Post, PostDto>();
        } 
    }
}
