using Application.Commands.CreatePost;
using Application.Queries.GetAllPosts;
using Application.Queries.GetPost;
using Application.Queries.Models;
using Application.Queries.Topic;
using AutoMapper;
using BlogWeb.UI.ViewModels;
using CommonShared.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWeb.UI.Controllers
{
    public class PostController : BaseController
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public PostController(ILoggerFactory loggerFactory, IMapper mapper)
        {
            _logger = loggerFactory.CreateLogger("Create Page");
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var number = 2;
            return View(await Mediator.Send(new GetAllPostsQuery(number)));

        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> GetPost(string slug)
        {
            return View(await Mediator.Send(new GetPostQuery(slug)));
        }

        public async Task<IActionResult> CreatePost([FromBody] PostDto post)
        {
            var slug = UrlHelpers.URLFriendly(post.Topic);
            if (string.IsNullOrWhiteSpace(slug))
            {
                ModelState.AddModelError("post.Topic", "The topic must contain at atleast one alphanumeric character");
                return View();
            }
            if (!ModelState.IsValid) { return View(); }
            _logger.LogWarning($"Creating page with slug {slug}");

            var isTopicAvailable = new PostTitleExistsQuery { Slug = slug, Id = 0 };
            if(await Mediator.Send(isTopicAvailable))
            {
                ModelState.AddModelError("post.Topic", "This title is already exists");
                return View();
            }
            var cmd = _mapper.Map<CreatePostCommand>(post);

            cmd = _mapper.Map(User,cmd);
            var cmdResult = await Mediator.Send(cmd);


            return Redirect($"/Post/{slug}");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
