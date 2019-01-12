using Application.Commands.Models;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Services
{
    public class CommandMapperService : Profile
    {
        public CommandMapperService()
        {
            CreateMap<CreatePostDto, Post>()
                     .ForMember(p => p.Id, m => m.Ignore())                     
                     .ForMember(p => p.Published, m => m.Ignore())
                     .ForMember(p => p.PublishedDateTime, m => m.Ignore());

            CreateMap<Post, CreatePostDto>();
        }
    }
}
